using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public float startingMoney; //Changed it to 2 separate variables for the meantime
    public float money;
    float stateTax;
    float insurance;

    Scene scene;

    //UI Buttons shown in Inspector//
    public TMP_Text startButtonText;
    public TMP_Text quitButtonText;
    public TMP_Text helpButtonText;

    //UI Buttons shown in Inspector//

    //=======================================================Jobs=======================================================
    public void OnClickJobNurse()
    {
        startingMoney = 77600.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    public void OnClickJobElectrician()
    {
        startingMoney = 49000.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    public void OnClickJobStylist()
    {
        startingMoney = 41000.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    public void OnClickJobGameArtist()
    {
        startingMoney = 60000.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    public void OnClickJobWelder()
    {
        startingMoney = 33000.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    public void OnClickJobPharm()
    {
        startingMoney = 110000.00f;
        money = startingMoney;

        Debug.Log(money);

        StartCoroutine(FlashTextColor(startButtonText));

        NextButton(); //load next scene

    }
    //=======================================================Jobs=======================================================

    //=======================================================States=======================================================
    public void OnClickNC()
    {
        stateTax = startingMoney * 0.058f;
        insurance = 120 * 12;
        money = money - stateTax;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    public void OnClickFL()
    {
        stateTax = 0;
        insurance = 98 * 12;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    public void OnClickCA()
    {
        stateTax = startingMoney * 0.123f;
        money = money - stateTax;
        insurance = 188 * 12;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    public void OnClickNY()
    {
        stateTax = startingMoney * 0.109f;
        money = money - stateTax;
        insurance = 187 * 12;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    public void OnClickGA()
    {
        stateTax = startingMoney * 0.0575f;
        money = money - stateTax;
        insurance = 255 * 12;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    public void OnClickPA()
    {
        stateTax = startingMoney * 0.037f;
        money = money - stateTax;
        insurance = 151 * 12;
        money = money - insurance;

        if (startingMoney <= 0) // if player reaches $0...
        {
           SceneManager.LoadScene("Game Over"); //...load game over scene
        }

        NextButton(); //load next scene
    }
    //=======================================================States=======================================================

    //=======================================================Choose Housing=======================================================
    public void OnClickBuy()
    {
        SceneManager.LoadScene("Buying");
    }
    public void OnClickRent()
    {
        SceneManager.LoadScene("Renting");
    }
   
    //=======================================================Choose Housing=======================================================

    //=======================================================Buying=========================================================================================
    public void OnClick1bd1baHOUSE()
    {
        {
            startingMoney -= 1900; //subtract the price of the house per month from their current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }
    public void OnClick2bd3baHOUSE()
    {
        {
            startingMoney -= 5000; //subtract the price of the house per month from their current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }
    public void OnClick5bd6baHOUSE()
    {
        {
            startingMoney -= 10000; //subtract the price of the house per month from their current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }
    //=======================================================Buying=========================================================================================

    //=======================================================Renting=========================================================================================

    public void OnClick1bd1baRENTAL()
    {
        {
            startingMoney -= 1702; //subtract the price of the house per month from their current amount of money
           
            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClick2bd2baRENTAL()
    {
        {
            startingMoney -= 2000; //subtract the price of the house per month from their current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClick5bd6baRENTAL()
    {
        {
            startingMoney -= 7517; //subtract the price of the house per month from their current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }
             
            NextButton(); //load next scene
        }
    }

    //=======================================================Renting=========================================================================================

    //=======================================================Food=========================================================================================

    public void OnClickNeverEatOutButton()
    {
        {
            startingMoney -= 331.44f; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickEatOutTwiceButton()
    {
        {
            startingMoney -= 520; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickEatOutEverydayButton()
    {
        {
            startingMoney -= 1400; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    //=======================================================Food=========================================================================================

    //=======================================================Student Loans=========================================================================================
    public void OnClickNCStateButton()
    {
        {
            startingMoney -= 267.69; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickPennStateButton()
    {
        {
            startingMoney -= 584.08f; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickNYUButton()
    {
        {
            startingMoney -= 1001.65f; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickWakeTechButton()
    {
        {
            startingMoney -= 175.01f; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }

    public void OnClickNoCollegeButton()
    {
        {
            startingMoney -= 0; //subtract expense from current amount of money

            if (startingMoney <= 0) // if player reaches $0...
            {
                SceneManager.LoadScene("Game Over"); //...load game over scene
            }

            NextButton(); //load next scene
        }
    }



    //=======================================================Student Loans=========================================================================================

    //=======================================================Transportation=========================================================================================



    //=======================================================Transportation=========================================================================================

    //=======================================================Health Insurance=========================================================================================



    //=======================================================Health Insurance=========================================================================================

    //=======================================================Life Happens=========================================================================================



    //=======================================================Life Happens=========================================================================================

    //=======================================================Discretionary Expenses=========================================================================================



    //=======================================================Discretionary Expenses=========================================================================================
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
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); //switch to next scene in build setting list
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

