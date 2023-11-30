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
    public TMP_Text gross;
    public int threeSelections = 0;

    public List <string> listOfExpenses = new List <string> (); //list of expenses
   
    public TMP_Text Output;
    public TMP_Text expenseText;
    public string outputTxt;

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
    }




    //=======================================================Jobs=======================================================
    public void OnClickJobNurse()
    {
        job = "Pediatric Nurse";
        AddToMoney(77600.00f);
        NextButton(); //load next scene
        Debug.Log(5 + -1);
        
    }
    public void OnClickJobElectrician()
    {
        job = "Electrician";
        AddToMoney(49000.00f);
        NextButton(); //load next scene

    }
    public void OnClickJobStylist()
    {
        job = "Hair Stylist";
        AddToMoney(41000.00f);
        NextButton(); //load next scene

    }
    public void OnClickJobGameArtist()
    {
        job = "Game Artist";
        AddToMoney(60000.00f);
        NextButton(); //load next scene

    }
    public void OnClickJobWelder()
    {
        job = "Pipe Welder";
        AddToMoney(33000.00f);
        NextButton(); //load next scene

    }
    public void OnClickJobPharm()
    {
        job = "Pharmaceutical Scientist";
        AddToMoney(110000.00f);
        NextButton(); //load next scene

    }
    //=======================================================Jobs=======================================================

    //=======================================================States=======================================================
    public void OnClickNC()
    {
        stateTax = startingMoney * 0.058f;
        insurance = 120 * 12;
        float total = (stateTax + insurance);
        AddToMoney(-total);
        

        

        NextButton(); //load next scene
    }
    public void OnClickFL()
    {
        stateTax = 0;
        insurance = 98 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

       

        NextButton(); //load next scene
    }
    public void OnClickCA()
    {
        stateTax = startingMoney * 0.123f;
        startingMoney -= stateTax;
        insurance = 188 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        

        NextButton(); //load next scene
    }
    public void OnClickNY()
    {
        stateTax = startingMoney * 0.109f;
        startingMoney -= stateTax;
        insurance = 187 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        

        NextButton(); //load next scene
    }
    public void OnClickGA()
    {
        stateTax = startingMoney * 0.0575f;
        startingMoney -= stateTax;
        insurance = 255 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        

        NextButton(); //load next scene
    }
    public void OnClickPA()
    {
        stateTax = startingMoney * 0.037f;
        startingMoney -= stateTax;
        insurance = 151 * 12;
        float total = stateTax + insurance;
        AddToMoney(-total);

        

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
            AddToMoney(-1900 * 12); //subtract the price of the house per month from their current amount of money

            

            SceneManager.LoadScene("Food"); //Load the food scene
        }
    }
    public void OnClick2bd3baHOUSE()
    {
        {
            AddToMoney(-5000 * 12); //subtract the price of the house per month from their current amount of money

            

            SceneManager.LoadScene("Food"); //Load the food scene
        }
    }
    public void OnClick5bd6baHOUSE()
    {
        {
            AddToMoney(-10000 * 12); //subtract the price of the house per month from their current amount of money

            

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
    IEnumerator errorEnum()
    {
        noCollegeError.text = "Your profession requires you to go to college!";
        yield return new WaitForSeconds(2.5f);
        noCollegeError.text = "";
    }

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
        threeSelections += 1;

        AddExpensesToList("Phone Bill");
    }

    public void OnClickCleaningService()
    {
       
        int cleaningBill = 100 * 12;
        AddToMoney(-cleaningBill);
        threeSelections += 1;
        AddExpensesToList("Cleaning Service");
    }

    public void OnClickGym()
    {
        
        int gymBill = 10 * 12;
        AddToMoney(-gymBill);
        threeSelections += 1;
        AddExpensesToList("Gym Membership");
    }

    public void OnClickCableBill()
    {
        
        int cableBill = 75 * 12;
        AddToMoney(-cableBill);
        threeSelections += 1;
        AddExpensesToList("Cable");
    }

    public void OnClickPet()
    {
        
        int petBill = 50 * 12;
        AddToMoney(-petBill);
        threeSelections += 1;
        AddExpensesToList("Pet");
    }

    public void OnClickStreaming()
    {
        
        int streamBill = 15 * 12;
        AddToMoney(-streamBill);
        threeSelections += 1;
        AddExpensesToList("Streaming Services");
    }

    public void OnClickInternet()
    {
        
        int intBill = 150 * 12;
        AddToMoney(-intBill);
        threeSelections += 1;
        AddExpensesToList("Internet");
    }

    public void OnClickLawn()
    {
        
        int lawnBill = 200 * 12;
        AddToMoney(-lawnBill);
        threeSelections += 1;
        AddExpensesToList("Lawn Service");
    }

    public void OnClickInvestment()
    {
        
        int invBill = 50 * 12;
        AddToMoney(-invBill);
        threeSelections += 1;
        AddExpensesToList("Retirement Investment");
    }

    


    //=======================================================Discretionary Expenses=========================================================================================




    // Update is called once per frame
    void Update()
    {
       if(threeSelections == 3)
       {
            threeSelections = 0;
            NextButton();
       }
    }

    public void QuitButton() //Quit Button
    {
        
        Debug.Log("Quit button was clicked"); 
        Application.Quit(); //quit game
    }

    public void StartButton() //Start Button - Job Selection Menu
    {
          PlayerPrefs.DeleteAll(); //delete all previous money aquired
          SceneManager.LoadScene("Pick a Job");
    }
    public void NextButton() //Go to next scene
    {
          PlayerPrefs.Save(); // save money balance before switching to next scene
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); //switch to next scene in build setting list
    }
    public void RestartButton() //Restart Button
    {
        Scene currentScene = SceneManager.GetActiveScene(); //get current scene 
        string currentSceneName = currentScene.name; //get the name of the current scene as a string

        SceneManager.LoadScene(currentSceneName); //load the current scene
    }

    public void HelpButton() //Help Button
    {
        
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
        if(threeSelections <= 3) 
        {
              if (expenseName != "")
              {
                 listOfExpenses.Add(expenseName);
                 listOfExpenses.Add("                   ");
                 outputTxt = " ";
              }

              for (int index = 0; index < listOfExpenses.Count; index++)
 
              {
                outputTxt += listOfExpenses[index].ToString();
                outputTxt += " ";
              }
 
              expenseText.text = outputTxt;
              Output.text = outputTxt;
        } 
        
    }   
}

