using System;
using System.Collections;
using System.Collections.Generic;
using Minigames;
using Player.FSM;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

enum SkillCheckState
{
    CanLose,
    CantLose
}

public class SkillCheckController : Minigame
{
    [SerializeField] private InputReader inputReader;
    
    [SerializeField] private Canvas canvas;
    
    [SerializeField] private float needleSpeed = 100f;
    [SerializeField] private float decreaseRate = 0.1f;
    [SerializeField] private float increaseAmount = 0.35f;
    
    [SerializeField] private float maxProgress = 1f;
    [SerializeField] private float minProgress = 0f;
    
    [SerializeField] private float maxWidthSafeZone;
    [SerializeField] private float minWidthSafeZone;
    
    [SerializeField] private float barOffset;
    [SerializeField] private float barAnchor;

    [SerializeField] private SkillCheck skillCheck;
    [SerializeField] private SkillCheckState skillCheckState;

    [SerializeField] private AnimationCurve decreaseCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    
    private float progress { get; set; } = 0.0f;

    private bool HasPlayerWon => progress >= maxProgress;
    private bool HasPlayerLost => progress <= minProgress;

    private void Start()
    {
        // RectTransform canvasRect = canvas.GetComponent<RectTransform>();
        //
        // float maxOffset = (canvasRect.rect.width / 2) - (skillCheck.bar.rect.width / 2);
        //
        // barOffset = Mathf.Clamp(barOffset, -maxOffset, maxOffset);
        //
        // skillCheck.bar.anchorMin = new Vector2(barAnchor, skillCheck.bar.anchorMin.y);
        // skillCheck.bar.anchorMax = new Vector2(barAnchor, skillCheck.bar.anchorMax.y);
        //
        // skillCheck.bar.offsetMin = new Vector2(-barOffset, skillCheck.bar.offsetMin.y); 
        // skillCheck.bar.offsetMax = new Vector2(barOffset, skillCheck.bar.offsetMax.y);  
    }

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

    private void UpdateProgress(float value)
    {
        progress = value;
        if (HasPlayerWon)
            WinGame();
        // else if (HasPlayerLost && maxAfkTime <= _lastSuccessfulInputTime - Time.time)
        //     LoseGame();

        skillCheck.SetProgressBarFill(progress);
    }

    protected override void ResetGame()
    {
        progress = minProgress;
        skillCheck.gameObject.SetActive(false);
        
        StopCoroutine(DecreaseProgressOverTime());
        StopCoroutine(MoveNeedleOverTime());
    }

    public override void StartGame()
    {
        OnStart?.Invoke();
        
        inputReader.OnSpaceInputStart += HandleInput;
        skillCheck.gameObject.SetActive(true);
        RandomizeSafeZoneWidth();
        
        StartCoroutine(DecreaseProgressOverTime());
        StartCoroutine(MoveNeedleOverTime());
    }

    private void MoveNeedle()
    {
        var transformLocalPosition = skillCheck.needle.transform.localPosition;

        if (transformLocalPosition.x >= skillCheck.bar.offsetMax.x || transformLocalPosition.x <= skillCheck.bar.offsetMin.x)
        {
            needleSpeed = -needleSpeed;
        }

        transformLocalPosition.x += needleSpeed * Time.deltaTime;

        skillCheck.needle.transform.localPosition = transformLocalPosition;
    }
    
    private void HandleInput()
    {
        RectTransform needleRect = skillCheck.needle;
        RectTransform safeZoneRect = skillCheck.safeZone;
        
        if (IsColliding(needleRect, safeZoneRect))
        {
            RandomizeSafeZoneWidth();
            UpdateProgress(progress + increaseAmount);
        }
    }

    private void RandomizeSafeZoneWidth()
    {
        float randomWidth = Random.Range(minWidthSafeZone, maxWidthSafeZone);
        skillCheck.safeZone.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, randomWidth);
    }
    
    private Rect GetScreenRect(RectTransform rectTransform)
    {
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);

        float xMin = corners[0].x;
        float xMax = corners[2].x;
        float yMin = corners[0].y;
        float yMax = corners[2].y;

        return new Rect(xMin, yMin, xMax - xMin, yMax - yMin);
    }

    public bool IsColliding(RectTransform rectA, RectTransform rectB)
    {
        if (rectA == null || rectB == null)
        {
            Debug.LogWarning("RectTransform no asignado");
            return false;
        }
        
        Rect rect1 = GetScreenRect(rectA);
        Rect rect2 = GetScreenRect(rectB);
        
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
    
    private IEnumerator DecreaseProgressOverTime()
    {
        while (skillCheck.gameObject.activeInHierarchy)
        {
            DecreaseProgress();
            yield return null;
        }
    }

    private IEnumerator MoveNeedleOverTime()
    {
        while (skillCheck.gameObject.activeInHierarchy)
        {
            MoveNeedle();
            yield return null;
        }
    }
    
    private void DecreaseProgress()
    {
        float curveValue = decreaseCurve.Evaluate(progress);
            
        var decreaseAmount = Mathf.Clamp(
            progress - decreaseRate * Time.deltaTime * curveValue,
            minProgress, maxProgress);

        UpdateProgress(decreaseAmount);
    }
}