using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{

    public static HighScoreManager Instance;
    public string playerName;
    public string highScorePlayerName;
    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string savedPlayerName;
        public int savedHighScore;
    }

    public void SaveHighScore(int score)
    {
        SaveData data = new SaveData();
        data.savedPlayerName = playerName;
        data.savedHighScore = score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.savedHighScore;
            highScorePlayerName = data.savedPlayerName;
        }
    }
}
