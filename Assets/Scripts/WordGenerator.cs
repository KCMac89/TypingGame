using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList =
    {
        "sidewalk",
        "robin", "three",
        "protect",
        "periodic",
        "dispersal", 
        "indicate",
        "hurried",
        "financier",
        "vent",
        "all-time",
        "satisfying",
        "sewer",
        "speed",
        "sense",
        "sobering",
        "struggle",
        "malleable",
        "mountainside",
        "cooling",
        "no-fly",
        "hospital",
        "raiser",
        "centimeter",
        "vested",
        "mire",
        "taunt",
        "chime",
        "specify",
        "console",
        "inverted",
        "throne",
        "spoonful",
        "entrance",
        "telephone",
        "document",
        "dues",
        "exemplify",
        "geographical",
        "kit",
        "smashing",
        "tantrum",
        "responsible",
        "accompanying",
        "magnetism",
        "proven",
        "confrontation",
        "unnecessary",
        "trailer",
        "top-rated"
  };


  public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
