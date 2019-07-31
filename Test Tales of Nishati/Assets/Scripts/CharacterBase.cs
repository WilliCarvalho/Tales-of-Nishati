using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasicStats
{
    //Basics atributes
    public float startLife;
    public float startMana;
    public int strength;
    public int magic;
    public int agility;
    public int baseDefence;
    public int baseAttack;
}

public abstract class CharacterBase : MonoBehaviour
{
    public int currentLevel;
    public BasicStats basicStats;

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
