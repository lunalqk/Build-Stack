using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class HighscoreText : MonoBehaviour
{
    private int highScore;
    private TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        //GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;

        string path = "Assets/highscore.txt";
        StreamReader reader = new StreamReader(path);

        highScore = int.Parse(reader.ReadLine());
        reader.Close();

        text.text = "HighScore: " + highScore;
    }

    private void OnDestroy()
    {
        string[] lines = { ""+highScore };
        System.IO.File.WriteAllLines(@"Assets/highscore.txt", lines );
        text.SetText("HighScore: " + highScore);
    }

    private void Update()
    {
        if (GameManager.score > highScore)
        {
            highScore = GameManager.score-1; 
            text.SetText("HighScore: " + highScore);
           
        }
    }
}
