﻿using System.Collections;
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

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        type = PlayerStatsController.GetTypeCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
