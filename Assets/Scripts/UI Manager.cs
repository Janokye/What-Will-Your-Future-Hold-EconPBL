using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public float startingMoney = 0f; //Changed it to 2 separate variables for the meantime
    
    float stateTax;
    float insurance;

    Scene scene;

    //UI Buttons shown in Inspector//
    public TMP_Text startButtonText;
    public TMP_Text quitButtonText;
    public TMP_Text helpButtonText;

    //UI Buttons shown in Inspector//
    public TMP_Text lifeHappensTitleText; 
    public TMP_Text problemText; //found in Life Happens Scene

    public TMP_Text displayBalanceText;
    public TMP_Text noCollegeError;
    public static string job = "Job";
    public static string gross;
    public static float grossNum;
    public static TMP_Text grossPay;

    public static string net;
    public static float netNum;
    public static TMP_Text netPay;


    public List <string> listOfExpenses = new List <string> (); //list of expenses
   
    public TMP_Text Output;
    public TMP_Text expenseText;
    public string outputTxt;

    public TMP_Text MaxSelectionsNotificationText;
    public TMP_Text currentTotalText;
    int discretionarySelections = 0;
    int totalDiscretionaryCost = 0; 

    //TIMER
    public float timeRemaining = 10f;
    public bool timerRunning = false;

    //AUDIO
    public AudioSource animeWowSFX;
    public AudioSource amoungUsSFX;
    public AudioSource buttonClickSFX;

    // Start is called before the first frame update
    void Start()
    {

      Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
      string currentSceneName = currentScene.name; //get the name of the current scene as a string

      if (currentSceneName != "Main Menu")
      {
        if (currentSceneName != "HELP")
        {    
          startingMoney = PlayerPrefs.GetFloat("startingMoney",0f); //player balance starts out on 0
          
        }
      }

      UpdateBalance();              // update amount
      

      if (currentSceneName == "Life Happens" ) //if the current scene is Life Happens...
      {
                
        int randomNum = Random.Range(1,11); //generate a random number btwn 1 and 11

        switch(randomNum)
        {
                        case(1):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "Your phone breaks and now have to buy a new one. This will cost you $399.00 ";
                        startingMoney -= 399;
                        break;

                        case(2):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "Your fridge breaks and you need to replace it along with all the food stored inside. This will cost you $2,500.00 ";
                        startingMoney -= 2500;
                        break;

                        case(3):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "Your crazy ex breaks down your door and you need to replace it. This will cost you $1,378.00 ";
                        startingMoney -= 1378;
                        break;

                        case(4):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "Little Timmy hits a baseball and you need to replace it. This will cost you $258.00 ";
                        startingMoney -= 258;
                        break;

                        case(5):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "Your cousin needs a place to stay, your mom is making you pay for their needs. This will cost you $300.00 ";
                        startingMoney -= 300;
                        break;

                        case(6):
                        lifeHappensTitleText.text = "It's Your Lucky Day!";
                        problemText.text = "Your mom gave you $150 dollars for your Birthday. ";
                        startingMoney += 100 ;
                        break;

                        case(7):
                        lifeHappensTitleText.text = "It's Your Lucky Day!";
                        problemText.text = "You got a $500 bonus at your job.";
                        startingMoney += 500;

                        break;

                        case(8):
                        lifeHappensTitleText.text = "Oh No!";
                        problemText.text = "You got mugged on the street. They stole your shoes and $50 dollars ($150 dollar loss)";
                        startingMoney -= 150; 

                        break;

                        case(9):
                        lifeHappensTitleText.text = "It's Your Lucky Day!'";
                        problemText.text = "YOU MET MR.BEAST!! He gave you $10,000";
                        startingMoney += 10000;

                        break;

                        case(10):
                        lifeHappensTitleText.text = "It's Your Lucky Day!'";
                        problemText.text = "You found $5 dollars on the floor";
                        startingMoney += 5;

                        break;
        }
      }

      if (currentSceneName == "Game Over")
      {
          if(startingMoney > 0)
          {
              animeWowSFX.Play();
          }
          else
          {
              amoungUsSFX.Play();
          }
      }

    }


    //=======================================================Jobs=======================================================
    public void OnClickJobNurse()
    {
        job = "Pediatric Nurse";
        gross = "$77,600";
        grossNum = 77600.00f;
        grossPay.text = gross;
        AddToMoney(77600.00f);
        NextButton(); //load next scene
        Debug.Log(5 + -1);
        buttonClickSFX.Play(); 
    }
    public void OnClickJobElectrician()
    {
        job = "Electrician";
        gross = "$49,000";
        grossNum = 49000.00f;
        grossPay.text = gross;
        AddToMoney(49000.00f);
        NextButton(); //load next scene
        buttonClickSFX.Play();
    }
    public void OnClickJobStylist()
    {
        job = "Hair Stylist";
        gross = "$41,000";
        grossNum = 41000.00f;
        grossPay.text = gross;
        AddToMoney(41000.00f);
        NextButton(); //load next scene
        buttonClickSFX.Play();
    }
    public void OnClickJobGameArtist()
    {
        job = "Game Artist";
        gross = "$60,000";
        grossNum = 60000.00f;
        grossPay.text = gross;
        AddToMoney(60000.00f);
        NextButton(); //load next scene
        buttonClickSFX.Play();
    }
    public void OnClickJobWelder()
    {
        job = "Pipe Welder";
        gross = "$33,000";
        grossNum = 33000.00f;
        grossPay.text = gross;
        AddToMoney(33000.00f);
        NextButton(); //load next scene
        buttonClickSFX.Play();
    }
    public void OnClickJobPharm()
    {
        job = "Pharmaceutical Scientist";
        gross = "$110,000";
        grossNum = 110000.00f;
        grossPay.text = gross;
        AddToMoney(110000.00f);
        NextButton(); //load next scene
        buttonClickSFX.Play();
    }
    //=======================================================Jobs=======================================================

    //=======================================================States=======================================================
    public void OnClickNC()
    {
        stateTax = startingMoney * 0.058f;
        insurance = 120 * 12;
        float total = (stateTax + insurance);
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$"+netNum;
        netPay.text = net;

        buttonClickSFX.Play();
        

        NextButton(); //load next scene
    }
    public void OnClickFL()
    {
        stateTax = 0;
        insurance = 98 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$" + netNum;
        netPay.text = net;

        buttonClickSFX.Play();

        NextButton(); //load next scene
    }
    public void OnClickCA()
    {
        stateTax = startingMoney * 0.123f;
        startingMoney -= stateTax;
        insurance = 188 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$" + netNum;
        netPay.text = net;

        buttonClickSFX.Play();

        NextButton(); //load next scene
    }
    public void OnClickNY()
    {
        stateTax = startingMoney * 0.109f;
        startingMoney -= stateTax;
        insurance = 187 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$" + netNum;
        netPay.text = net;

        buttonClickSFX.Play();

        NextButton(); //load next scene
    }
    public void OnClickGA()
    {
        stateTax = startingMoney * 0.0575f;
        startingMoney -= stateTax;
        insurance = 255 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$" + netNum;
        netPay.text = net;

        buttonClickSFX.Play();

        NextButton(); //load next scene
    }
    public void OnClickPA()
    {
        stateTax = startingMoney * 0.037f;
        startingMoney -= stateTax;
        insurance = 151 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        netNum = grossNum - total;
        net = "$" + netNum;
        netPay.text = net;

        buttonClickSFX.Play();

        NextButton(); //load next scene
    }
    //=======================================================States=======================================================

    //=======================================================Choose Housing=======================================================
    public void OnClickBuy()
    {
        buttonClickSFX.Play();
        SceneManager.LoadScene("Buying");
    }
    public void OnClickRent()
    {
        buttonClickSFX.Play();
        SceneManager.LoadScene("Renting");
    }
   
    //=======================================================Choose Housing=======================================================

    //=======================================================Buying=========================================================================================
    public void OnClick1bd1baHOUSE()
    {
        {
            AddToMoney(-1900 * 12); //subtract the price of the house per month from their current amount of money

            buttonClickSFX.Play();

            SceneManager.LoadScene("Food"); //Load the food scene
        }
    }
    public void OnClick2bd3baHOUSE()
    {
        {
            AddToMoney(-5000 * 12); //subtract the price of the house per month from their current amount of money

            buttonClickSFX.Play();

            SceneManager.LoadScene("Food"); //Load the food scene
        }
    }
    public void OnClick5bd6baHOUSE()
    {
        {
            AddToMoney(-10000 * 12); //subtract the price of the house per month from their current amount of money

            buttonClickSFX.Play();

            SceneManager.LoadScene("Food"); //Load the food scene
        }
    }
    //=======================================================Buying=========================================================================================

    //=======================================================Renting=========================================================================================

    public void OnClick1bd1baRENTAL()
    {
        {
            AddToMoney(-1702 * 12); //subtract the price of the house per month from their current amount of money
           
            

            NextButton(); //load next scene
        }
    }

    public void OnClick2bd2baRENTAL()
    {
        {
            AddToMoney(-2000 * 12); //subtract the price of the house per month from their current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClick5bd6baRENTAL()
    {
        {
            AddToMoney(-7517 * 12); //subtract the price of the house per month from their current amount of money

            
             
            NextButton(); //load next scene
        }
    }

    //=======================================================Renting=========================================================================================

    //=======================================================Food=========================================================================================

    public void OnClickNeverEatOutButton()
    {
        {
            AddToMoney(-331.44f * 12f); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickEatOutTwiceButton()
    {
        {
            AddToMoney(-520 * 12); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickEatOutEverydayButton()
    {
        {
            AddToMoney(-1400 * 12); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    //=======================================================Food=========================================================================================

    //=======================================================Student Loans=========================================================================================
    

    public void OnClickNCStateButton()
    {
        {
            AddToMoney(-267.69f * 12f); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickPennStateButton()
    {
        {
            AddToMoney(-584.08f * 12f); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickNYUButton()
    {
        {
            AddToMoney(-1001.65f * 12f); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickWakeTechButton()
    {
        {
            AddToMoney(-175.01f * 12f); //subtract expense from current amount of money

            

            NextButton(); //load next scene
        }
    }

    public void OnClickNoCollegeButton()
    {
        if (job == "Pediatric Nurse" || job == "Pharmaceutical Scientist")
        {
            StartCoroutine(errorEnum());
        }
        else
        {

           Debug.Log(job);
           AddToMoney(-0); //subtract expense from current amount of money

           NextButton(); //load next scene
        }
            
    }





    //=======================================================Student Loans=========================================================================================

    //=======================================================Transportation=========================================================================================

    public void OnClickPublicTransit()
    {
        AddToMoney(-75 * 12);
       
        NextButton();
    }

    public void OnClickPrius()
    {
        AddToMoney(-523 * 12);
       
        NextButton();
    }

    public void OnClickMercedes()
    {
        AddToMoney(-94.17f * 12f);
        
        NextButton();
    }

    public void OnClickBugatti()
    {
        AddToMoney(-45000 * 12);
       
        NextButton();
    }

    //=======================================================Transportation=========================================================================================

   

    //=======================================================Discretionary Expenses=========================================================================================

    public void OnClickPhoneBill()
    {
        
        int phoneBill = 75 * 12;
        AddToMoney(-phoneBill);
        discretionarySelections += 1;

        AddExpensesToList("Phone Bill - $900");
        CaculateTotalDiscretionaryCosts(phoneBill);
    }

    public void OnClickCleaningService()
    {
       
        int cleaningBill = 100 * 12;
        AddToMoney(-cleaningBill);
        discretionarySelections += 1;

        AddExpensesToList("Cleaning Service - $1,200");
        CaculateTotalDiscretionaryCosts(cleaningBill);
    }

    public void OnClickGym()
    {
        
        int gymBill = 10 * 12;
        AddToMoney(-gymBill);
        discretionarySelections += 1;
        
        AddExpensesToList("Gym Membership - $120");
        CaculateTotalDiscretionaryCosts(gymBill);
    }

    public void OnClickCableBill()
    {
        
        int cableBill = 75 * 12;
        AddToMoney(-cableBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(cableBill);
        AddExpensesToList("Cable - $900");
    }

    public void OnClickPet()
    {
        
        int petBill = 50 * 12;
        AddToMoney(-petBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(petBill);
        AddExpensesToList("Pet - $600");
    }

    public void OnClickStreaming()
    {
        
        int streamBill = 15 * 12;
        AddToMoney(-streamBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(streamBill);
        AddExpensesToList("Streaming Services - $180");
    }

    public void OnClickInternet()
    {
        
        int intBill = 150 * 12;
        AddToMoney(-intBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(intBill);
        AddExpensesToList("Internet -  $1,800");
    }

    public void OnClickLawn()
    {
        
        int lawnBill = 200 * 12;
        AddToMoney(-lawnBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(lawnBill);
        AddExpensesToList("Lawn Service - $2,400");
    }

    public void OnClickInvestment()
    {
        
        int invBill = 50 * 12;
        AddToMoney(-invBill);
        discretionarySelections += 1;
        CaculateTotalDiscretionaryCosts(invBill);
        AddExpensesToList("Retirement Investment - $600" );
    }

    


    //=======================================================Discretionary Expenses=========================================================================================

   
    

    // Update is called once per frame
    void Update()
    {
      Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
      string currentSceneName = currentScene.name; //get the name of the current scene as a string

      if (currentSceneName == "Discretionary Expenses")
      {
          MaxSelectionsNotificationText.text = "Choose Up to 5 Discretionary Expenses";
      }
       
      if (discretionarySelections == 5)
      {
        timerRunning = true; //enable timer

        if (timerRunning) //if the timer is enabled
        {
            if (timeRemaining > 0) //if the time left is more than 0
            {
                timeRemaining -= Time.deltaTime; // decrement time by 1
                int timeRemainingInt = Mathf.FloorToInt(timeRemaining); // convert time remaining float to int
                MaxSelectionsNotificationText.text = "You have reached 5 Selections...next scene in " + timeRemainingInt + "second(s)"; //update scene title text
            }
            else
            {
                timerRunning = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); //switch to next scene in build setting list

            }
        }
      }
    }

    public void QuitButton() //Quit Button
    {
        buttonClickSFX.Play();
        Debug.Log("Quit button was clicked"); 
        Application.Quit(); //quit game
    }

    public void StartButton() //Start Button - Job Selection Menu
    {
          buttonClickSFX.Play();
          PlayerPrefs.DeleteAll(); //delete all previous money aquired
          SceneManager.LoadScene("Pick a Job");
    }
    public void NextButton() //Go to next scene
    {
          buttonClickSFX.Play();
          PlayerPrefs.Save(); // save money balance before switching to next scene
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); //switch to next scene in build setting list
    }
    public void RestartButton() //Restart Button
    {
        buttonClickSFX.Play();
        Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
        string currentSceneName = currentScene.name; //get the name of the current scene as a string

        SceneManager.LoadScene(currentSceneName); //load the current scene
    }

    public void HelpButton() //Help Button
    {
        buttonClickSFX.Play();
        SceneManager.LoadScene("HELP");
    }

  

    public void AddToMoney(float amount)
    {

        float currentAmount = PlayerPrefs.GetFloat("startingMoney",0f); //current amount of money set to 0
        float newAmount = currentAmount + amount; //add amount to current amount to update

        PlayerPrefs.SetFloat("startingMoney", newAmount); //save the most updated balance to player prefs

        if (newAmount <= 0)
        {
            SceneManager.LoadScene("Game Over"); //...load game over scene
        }
         

        PlayerPrefs.Save();
    }



    void UpdateBalance()
    {
      Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
      string currentSceneName = currentScene.name; //get the name of the current scene as a string
      if (currentSceneName != "Main Menu")
      {
        if (currentSceneName != "HELP")
        {    
         displayBalanceText.text = "Your Current Balance is: $" + startingMoney.ToString();
          
        }
      }
        
    }

    void AddExpensesToList(string expenseName)
    {
        
              if (expenseName != "")
              {
                 listOfExpenses.Add(expenseName);
                 listOfExpenses.Add("                                ");
                 outputTxt = " ";
              }

              for (int index = 0; index < listOfExpenses.Count; index++)
 
              {
                outputTxt += listOfExpenses[index].ToString();
                outputTxt += " ";
              }
 
              expenseText.text = outputTxt + "";
              Output.text = outputTxt; 
    }   

    IEnumerator errorEnum()
    {
        noCollegeError.text = "Your profession requires you to go to college!";
        yield return new WaitForSeconds(2.5f);
        noCollegeError.text = "";
    }

    void CaculateTotalDiscretionaryCosts(int amount)
    {
        totalDiscretionaryCost += amount;
        currentTotalText.text = "Total: $" + totalDiscretionaryCost.ToString();
    }
}

