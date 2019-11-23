using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static event Action OnCubeSpawned = delegate { };

    public static int score;


    private SpawnerCube[] spawners;
    private int spawnerIndex;
    private SpawnerCube currentSpawner;

    private void Awake()
    {
        score = 0;
        spawners = FindObjectsOfType<SpawnerCube>();
    }



    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (MovingCube.CurrentCube != null)
                MovingCube.CurrentCube.Stop();


            spawnerIndex = spawnerIndex == 0 ? 1 : 0;
            currentSpawner = spawners[spawnerIndex];

            currentSpawner.SpawnCube();

            OnCubeSpawned();

            score++;

        }
    }
}
