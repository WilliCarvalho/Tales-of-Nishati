using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public static PlayerStatsController instance;

    public int xpMultiply = 1;
    public float xpFirstLevel = 100;
    public float difficultFactor = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        Application.LoadLevel("Gameplay");



       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            AddXp(100);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
        
    }

    public static void AddXp(float xpAdd)
    {
        float newXp = (GetCurrentXp()+ xpAdd) * PlayerStatsController.instance.xpMultiply;
        while(newXp >= GetNextXp())
        {
            newXp -= GetNextXp();
            AddLevel();
        }
        PlayerPrefs.SetFloat("currentXp", newXp);
    }

    public static float GetCurrentXp()
    {
        return PlayerPrefs.GetFloat("currentXp");
    }

    public static int GetCurrentLevel()
    {
        return PlayerPrefs.GetInt("currentLevel");
    }

    public static void AddLevel()
    {
        int newLevel = GetCurrentLevel() + 1;
        PlayerPrefs.SetInt("currentLevel", newLevel);
    }

    public static float GetNextXp()
    {
        return PlayerStatsController.instance.xpFirstLevel * (GetCurrentLevel() + 1) * PlayerStatsController.instance.difficultFactor;
    }

    public static TypeCharacter GetTypeCharacter()
    {
        int typeId = PlayerPrefs.GetInt("TypeCharacter");

        if(typeId == 0)
        {
            return TypeCharacter.Warrior;
        }
        else if (typeId == 1)
        {
            return TypeCharacter.Warlock;
        }
        else if (typeId == 2)
        {
            return TypeCharacter.Archer;
        }

        return TypeCharacter.Warrior;
    }

    public static void SetTyperCharacter (TypeCharacter newType)
    {
        PlayerPrefs.SetInt("TypeCharacter", (int)newType);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 150, 50), "Current Xp = " + GetCurrentXp());
        GUI.Label(new Rect(0, 15, 150, 50), "Current Level = " + GetCurrentLevel());
        GUI.Label(new Rect(0, 30, 150, 50), "Current Next Xp = " + GetNextXp());
    }
}
