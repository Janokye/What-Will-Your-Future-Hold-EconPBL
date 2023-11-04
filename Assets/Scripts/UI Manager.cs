using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    Scene scene;
    public TMP_Text startButtonText;
    public TMP_Text quitButtonText;
    public TMP_Text helpButtonText;

    //Pick a Job

   
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitButton() //Quit Button
    {
        StartCoroutine(FlashTextColor(quitButtonText));
        Debug.Log("Quit button was clicked"); 
        Application.Quit(); //quit game
    }

    public void StartButton() //Start Button - Job Selection Menu
    {
          StartCoroutine(FlashTextColor(startButtonText));
          SceneManager.LoadScene("Pick a Job");
    }
    public void NextButton() //Go to next scene
    {
          StartCoroutine(FlashTextColor(startButtonText));
          
          for (int i = 2; i <= 3; i++) //increment the scene number by 1 each time the button is clicked
          {
              int currentSceneNum = i;
              SceneManager.LoadScene(currentSceneNum); //load corresponding scene
          }    
    }
    public void RestartButton() //Restart Button
    {
        Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
        string currentSceneName = currentScene.name; //get the name of the current scene as a string

        //StartCoroutine(FlashTextColor(startButtonText));
        SceneManager.LoadScene(currentSceneName); //load the current scene
    }

    public void HelpButton() //Help Button
    {
        StartCoroutine(FlashTextColor(helpButtonText));
        SceneManager.LoadScene("HELP");
    }

    //void PlayerChoices()

    IEnumerator FlashTextColor(TMP_Text buttonTextName) //change the text color to green for 2.5 seconds then switch scene
    {
         buttonTextName.color = Color.green;
         yield return new WaitForSeconds(2.5f); //wait 1 second       
    }
}

