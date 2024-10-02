using System;
using System.Collections;
using System.Collections.Generic;
using Minigames;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SkillCheckController : Minigame
{
    [SerializeField] private float needleSpeed = 200f;
    [SerializeField] private float skillCheckToWin = 5f;

    [SerializeField] private SkillCheck skillCheck;

    private float _skillcheckCounter = 0f;

    private readonly float _maxZone = 140.0f;
    private readonly float _minZone = -140.0f;

    protected override void WinGame()
    {
        ResetGame();
        OnWin?.Invoke();
    }

    protected override void LoseGame()
    {
        ResetGame();
        OnLose?.Invoke();
    }

    private void Update()
    {
        OnTick();
    }

    private void OnTick()
    {
        if (_isActive)
        {
            MoveNeedle();
            CheckSkillCheck();
        }
    }

    protected override void ResetGame()
    {
        _skillcheckCounter = 0f;
        _isActive = false;
        skillCheck.gameObject.SetActive(false);
    }

    public override void StartGame()
    {
        OnStart?.Invoke();
        _isActive = true;
        UpdateProgressPointsBar();
        RandomizeSafeZone();
        skillCheck.gameObject.SetActive(true);
    }

    private void MoveNeedle()
    {
        var transformLocalPosition = skillCheck.needle.transform.localPosition;

        if (transformLocalPosition.x > _maxZone || transformLocalPosition.x < _minZone)
        {
            needleSpeed = -needleSpeed;
        }

        transformLocalPosition.x += needleSpeed * Time.deltaTime;

        skillCheck.needle.transform.localPosition = transformLocalPosition;
    }

    private void CheckSkillCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RectTransform needleRect = skillCheck.needle;
            RectTransform safeZoneRect = skillCheck.safeZone;

            if (IsOverlapping(needleRect, safeZoneRect))
            {
                RandomizeSafeZone();
                _skillcheckCounter++;
                UpdateProgressPointsBar();

                if (_skillcheckCounter >= skillCheckToWin)
                {
                    WinGame();
                }

                Debug.Log("acertado");
            }
            else
            {
                if (_skillcheckCounter != 0)
                {
                    _skillcheckCounter--;
                    UpdateProgressPointsBar();
                }

                // LoseGame();
                Debug.Log("mal");
            }
        }
    }

    private void RandomizeSafeZone()
    {
        float newX = Random.Range(_minZone, _maxZone);
        skillCheck.safeZone.transform.localPosition = new Vector2(newX, skillCheck.safeZone.transform.localPosition.y);
    }

    private bool IsOverlapping(RectTransform rectA, RectTransform rectB)
    {
        Vector3[] cornersA = new Vector3[4];
        Vector3[] cornersB = new Vector3[4];

        rectA.GetWorldCorners(cornersA);
        rectB.GetWorldCorners(cornersB);

        Rect rect1 = new Rect(cornersA[0], cornersA[2] - cornersA[0]);
        Rect rect2 = new Rect(cornersB[0], cornersB[2] - cornersB[0]);

        return rect1.Overlaps(rect2);
    }

    public override void StopGame()
    {
        if (_isActive)
        {
            OnStop?.Invoke();
            ResetGame();
        }
    }

    private void UpdateProgressPointsBar()
    {
        skillCheck.progressPointsBar.fillAmount = _skillcheckCounter / skillCheckToWin;
    }
}