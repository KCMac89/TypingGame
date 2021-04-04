using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider_wordSpeed : MonoBehaviour
{
    public Slider slider;
    public Text wordSpeedText;


    void Update()
    {
        wordSpeedText.text = slider.value.ToString("f1");
        
    }

    public void ChangeSpeed()
    {
        WordDisplay.fallSpeed = (slider.value);
    }
}
