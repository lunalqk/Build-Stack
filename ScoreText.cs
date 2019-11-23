using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;


    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;
    }

    private void OnDestroy()
    {
        GameManager.OnCubeSpawned -= GameManager_OnCubeSpawned;
    }


    private void GameManager_OnCubeSpawned()
    { 
        text.text = "Score: " + score;
        score++;
    }

}
