using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int score; // =0
   

    void Update()
    {
        if (GameManager.isLoaded == false)
        {
            scoreText.text = score.ToString();
        }
        else
        {
            scoreText.text = PlayerPrefs.GetString("savedScore");
            
          
           // scoreText.text = score.ToString();
        }
       
    }
  
   

   
}
