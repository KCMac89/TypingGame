using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameManager : MonoBehaviour
{
    public int score; //=0
    public static bool isLoaded = false; //added

    [SerializeField]
    private Text scoreText;
 
    [SerializeField]
    private GameObject menu;

    private bool isPaused = false;

   


    private void Awake()
    {
        // Pause();
      
    }

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        menu.SetActive(false);
    }

    public void Pause()
    {
        menu.SetActive(true);
        //Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Unpause()
    {
       
        menu.SetActive(false);
        // Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
       
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();


        save.score = Score.score;
       

        return save;
    }

    public void SaveGame()
    {
        // 1
        Save save = CreateSaveGameObject();

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

       // scoreText.text = Score.score.ToString();
       // scoreText.text = save.score.ToString();

        
        PlayerPrefs.SetString("savedScore", save.score.ToString()); //added
       


        Debug.Log("Game Saved");
        Debug.Log("Saved score = " + save.score.ToString());

    }

    public void LoadGame()
    {

        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {


            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();




           
         
            scoreText.text = save.score.ToString();

            isLoaded = true; //added

            Debug.Log("Game Loaded");
            Debug.Log("Loaded Score = " + save.score.ToString());
           
            Unpause();
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void NewGame()
    {
        Score.score = 0; // added
        Unpause();
        SceneManager.LoadScene("Menu");
    }
 

}
