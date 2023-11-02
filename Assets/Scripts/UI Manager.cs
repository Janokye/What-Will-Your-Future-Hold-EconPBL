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

    public void StartButton() //Start Button - loads lvl.1 
    {
          StartCoroutine(FlashTextColor(startButtonText));
          SceneManager.LoadScene("Level One");
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


    IEnumerator FlashTextColor(TMP_Text buttonTextName) //change the text color to green for 2.5 seconds then switch scene
    {
         buttonTextName.color = Color.green;
         yield return new WaitForSeconds(2.5f); //wait 1 second       
    }
}

