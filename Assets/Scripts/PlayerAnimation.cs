using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsCleaning = Animator.StringToHash("IsCleaning");
    
    [SerializeField] private Animator animator;
    
    public void SetWalkState(bool isWalking)
    {
        animator.SetBool(IsWalking, isWalking);
    }
    
    public void SetCleaning(bool isCleaning)
    {
        animator.SetBool(IsCleaning, isCleaning);
    }
}