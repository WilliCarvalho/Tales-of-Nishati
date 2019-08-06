using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationStates
{
    WALKING,
    RUNNING,
    IDLE,
}

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation(AnimationStates stateAnimation)
    {
        switch (stateAnimation)
        {
            case AnimationStates.IDLE:
                {
                    StopAnimations();
                    animator.SetBool("inIdle", true);
                }
                break;
            case AnimationStates.WALKING:
                {
                    StopAnimations();
                    animator.SetBool("inWalk", true);
                }
                break;
            case AnimationStates.RUNNING:
                {
                    StopAnimations();
                    animator.SetBool("inRun", true);
                }
                break;
        }

        void StopAnimations()
        {
            animator.SetBool("inWalk", false);
            animator.SetBool("inRun", false);
            animator.SetBool("inIdle", false);
        }
    }
}
