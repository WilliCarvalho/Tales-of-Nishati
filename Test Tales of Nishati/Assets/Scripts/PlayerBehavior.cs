using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCharacter
{
    Warrior = 0,
    Warlock = 1,
    Archer = 2
}

public class PlayerBehavior : CharacterBase
{
    private TypeCharacter type;

    private AnimationController animationController;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        type = PlayerStatsController.GetTypeCharacter();

        basicStats = PlayerStatsController.instance.GetBasicsStats(type);

        animationController = GetComponent<AnimationController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animationController.PlayAnimation(AnimationStates.WALKING);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            animationController.PlayAnimation(AnimationStates.RUNNING);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animationController.PlayAnimation(AnimationStates.IDLE);
        }
    }
}
