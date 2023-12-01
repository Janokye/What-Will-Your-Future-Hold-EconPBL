using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic instance;

    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
      if (instance != null)
      {
          Destroy(gameObject);
      }
      else
      {
          instance = this;
          DontDestroyOnLoad(this.gameObject);
      }

      Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
      string currentSceneName = currentScene.name; //get the name of the current scene as a string

      if (currentSceneName == "Game Over") //Pause music on game over scene
      {
          BackgroundMusic.instance.GetComponent<AudioSource>().Pause();
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
