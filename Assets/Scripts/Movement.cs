using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class Movement : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    private int currentIndex = 0;
    private void Start()
    {
        
        transform.position = spawnPoints[currentIndex].position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = 0;
            }
            UpdatePosition();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= spawnPoints.Length)
            {
                currentIndex = spawnPoints.Length - 1;
            }
            UpdatePosition();
        }
        
    }

   
    void UpdatePosition()
    {
        transform.position = spawnPoints[currentIndex].position;
    }
   
}
