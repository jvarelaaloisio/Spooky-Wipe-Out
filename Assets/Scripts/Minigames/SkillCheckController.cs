using System;
using System.Collections;
using System.Collections.Generic;
using Minigames;
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

    private bool _isGameActive = false;


    // private void Start()
    // {
    //     StartGame();
    // }

    protected override void WinGame()
    {
        ResetGame();
    }

    protected override void LoseGame()
    {
        ResetGame();
    }

    private void Update()
    {
        OnTick();
    }

    private void OnTick()
    {
        if (_isGameActive)
        {
            MoveNeedle();
            CheckSkillCheck();
        }
    }

    protected override void ResetGame()
    {
        _skillcheckCounter = 0f;
        _isGameActive = false;
        skillCheck.gameObject.SetActive(false);
    }

    public override void StartGame()
    {
        RandomizeSafeZone();
        skillCheck.gameObject.SetActive(true);
        _isGameActive = true;
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

                if (_skillcheckCounter >= skillCheckToWin)
                {
                    OnWin?.Invoke();
                }

                Debug.Log("acertado");
            }
            else
            {
                LoseGame();
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
}

