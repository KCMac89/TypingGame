﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   
  void OnTriggerEnter2D(Collider2D col)
    {
        
        Debug.Log("Game Over");
        SceneManager.LoadScene("Credits");
    }
}
