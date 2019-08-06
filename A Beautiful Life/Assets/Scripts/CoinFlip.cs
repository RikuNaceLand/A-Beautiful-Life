using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinFlip : MonoBehaviour
{
    public float baseLuck;
    public float HpOnClick;

    private GameControl gameController = GameControl.Instance;

    public Text AvailableHappiness;

    public Text SuccessText;

    public Text DayCounter;

    public Text ClickerText;

    public Text NaceBucks;


    private void Awake()
    {
        if (gameController.EverWentUltimate == true)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }

        if (gameController.DisplayMainInstructions == true)
        {
            if (gameController.TotalHappiness > 100 || gameController.UltimatePoints > 0)
            {
                gameController.DisplayMainInstructions = false;
            }
        }

        if (gameController.Achieve1Unlocked == false)
        {
            gameController.TotalHappinessPerSecond = gameController.BaseHappinessPerSecond;
        }

        if (gameController.Achieve1Unlocked == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }

        if (gameController.Achieve2Unlocked == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }

        if (gameController.FinalMedalUpgrBought == true)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }


        if (gameController.Upgrade5Bought == true)
        {
            ClickerText.text = "Sleep for a week";
        }
        


    }

    // Start is called before the first frame update
    void Start()
    {
        if (gameController.NaceBucks > 0)
        {

            NaceBucks.text = "NaceBucks: " + gameController.NaceBucks;

        }

        if (gameController.Achieve7Unlocked == false)
        {
            if (gameController.EverWentUltimate == true)
            {
                gameController.Achieve7Unlocked = true;
                StartCoroutine(AchievementUnlocked());
            }


        }

    }

    // Update is called once per frame
    void Update()
    {
        // Achieve5Unlock

        if (gameController.Achieve5Unlocked == false)
        {
            if (gameController.MedalCountBreathing > 9 && gameController.MedalCountAging > 9 && gameController.MedalCountPeeing > 9)
            {
                gameController.Achieve5Unlocked = true;
                StartCoroutine(AchievementUnlocked());
            }
        }


        //Mit Upgrade 7 Boost
        if (gameController.Upgrade7Bought == true)
        {
            gameController.HappinessAmount = gameController.HappinessAmount + gameController.TotalTotalHappinessPerSecond * Time.deltaTime;
            gameController.TotalHappiness = gameController.TotalHappiness + gameController.TotalTotalHappinessPerSecond * Time.deltaTime;
        }

        //Ohne Upgrade 7 Boost
        else
        {
            gameController.HappinessAmount = gameController.HappinessAmount + gameController.TotalHappinessPerSecond * Time.deltaTime;
            gameController.TotalHappiness = gameController.TotalHappiness + gameController.TotalHappinessPerSecond * Time.deltaTime;
        }



        if (gameController.HappinessAmount < 1000000f)
        {
            AvailableHappiness.text = "Available Happiness: " + gameController.HappinessAmount.ToString("#,0.00") + " HP";
        }
        else
        {
            AvailableHappiness.text = "Available Happiness: " + gameController.HappinessAmount.ToString("0.000e0") + " HP";
        }



        DayCounter.text = "Days counted " + gameController.Day.ToString("#,0.##");



        if  (gameController.Achieve1Unlocked == false)
        {
            if (gameController.TotalHappiness > 9.99f)
            {
                gameController.Achieve1Unlocked = true;
                transform.GetChild(0).gameObject.SetActive(true);
                StartCoroutine(AchievementUnlocked());
            }
        }
        
        if (gameController.Achieve2Unlocked == false)
        {
            if (gameController.TotalHappiness > 19.99f)
            {
                gameController.Achieve2Unlocked = true;
                transform.GetChild(1).gameObject.SetActive(true);
                StartCoroutine(AchievementUnlocked());
            }
        }

        if (gameController.AmountUltimated == 1 && gameController.Day == 0)
        {
            transform.GetChild(4).gameObject.SetActive(true);
        }
        

    }

    private void OnMouseDown ()
    {

        gameController.Upgrade7Boost = 10 / (2 * Mathf.Exp(-0.002f * (gameController.Day - 100)) + 1);

        if (gameController.Upgrade5Bought == true)
        {
            gameController.Day = gameController.Day + 7;
        }
        else
        {
            gameController.Day = gameController.Day + 1;
        }

        // Ohne Upgrade 5, also 1 Tag pro Klick
        if (gameController.Upgrade5Bought == false)
        {


            if (gameController.Upgrade1Bought == false)
            {
                baseLuck = Random.Range(0f, 1f);
            }
            else if (gameController.Upgrade1Bought == true)
            {
                baseLuck = Random.Range(0f, 5f);
            }



            if (gameController.Upgrade2Bought == false)
            {
                HpOnClick = baseLuck;
            }
            else if (gameController.Upgrade2Bought == true)
            {
                HpOnClick = baseLuck * 5f;
            }




            if (baseLuck < 0.5 && baseLuck > 0)
            {
                SuccessText.text = "This day was average [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }

            else if (baseLuck < 2)
            {
                SuccessText.text = "A beautiful day [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }

            else if (baseLuck < 5.1)
            {
                SuccessText.text = "You saw a beautiful butterfly today [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }



            //failext
            else
            {
                SuccessText.text = "You rolled a 'bug' amount of HP and thus get +" + HpOnClick.ToString("#,0.0#") + " HP";
            }

            gameController.HappinessAmount = gameController.HappinessAmount + HpOnClick;

            gameController.TotalHappiness = gameController.TotalHappiness + HpOnClick;

        }

        // MIT Upgrade 5, also 7 Tage pro Klick

        else if (gameController.Upgrade5Bought == true)
        {
            if (gameController.Upgrade1Bought == false)
            {
                baseLuck = Random.Range(0f, 1f);
            }
            else if (gameController.Upgrade1Bought == true)
            {
                baseLuck = Random.Range(0f, 5f);
            }



            if (gameController.Upgrade2Bought == false)
            {
                HpOnClick = baseLuck * 7f;
            }
            else if (gameController.Upgrade2Bought == true)
            {
                HpOnClick = baseLuck * 5f * 7f;
            }




            if (baseLuck < 0.5 && baseLuck > 0)
            {
                SuccessText.text = "This week was average [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }

            else if (baseLuck < 2)
            {
                SuccessText.text = "A beautiful week [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }

            else if (baseLuck < 5)
            {
                SuccessText.text = "You saw some beautiful butterflies this week [+" + HpOnClick.ToString("#,0.0#") + " HP]";
            }



            //failext
            else
            {
                SuccessText.text = "You rolled a 'bug' amount of HP and thus get +" + HpOnClick.ToString("#,0.0#") + " HP";
            }

            gameController.HappinessAmount = gameController.HappinessAmount + HpOnClick;

            gameController.TotalHappiness = gameController.TotalHappiness + HpOnClick;

        }


    }


    IEnumerator AchievementUnlocked()
    {

        transform.GetChild(2).gameObject.SetActive(true);

        yield return new WaitForSeconds(5);
    
        transform.GetChild(2).gameObject.SetActive(false);
        
    }
   

    
}
