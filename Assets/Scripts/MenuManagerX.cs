using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManagerX : MonoBehaviour
{
    public static string playerName = "";
    public static SaveData highScoreData = new SaveData("no high score", 0);

    [System.Serializable]
    public class SaveData
    {
        public string name;
        public int highScore;

        public SaveData(string playerName, int score)
        {
            name = playerName;
            highScore = score;
        }
    }

    public static void SetHighScore(string name, int score)
    {
        if (highScoreData.highScore < score)
        {
            highScoreData.name = name;
            highScoreData.highScore = score;
        }
    }

    public static void SaveScoreToJson()
    {
        //Here we are saving our highScore to Json
        string json;
        json = JsonUtility.ToJson(highScoreData);
        File.WriteAllText(Application.persistentDataPath + "/highscore.json",json);
        Debug.Log("Data saved to hard drive");
    }

    public static void LoadScoreFromJson()
    {
        //here we are loading score from file 
        if (File.Exists(Application.persistentDataPath + "/highscore.json"))
        {
            Debug.Log("savedata found");
            string json;
            json = File.ReadAllText(Application.persistentDataPath + "/highscore.json");
            highScoreData = JsonUtility.FromJson<SaveData>(json);
        }
        else
        {
            Debug.Log("no save data");
        }
    }

}
