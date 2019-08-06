using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoUltimate : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       
        Gamecontroller.Day = 0;
        
        if (Gamecontroller.Achieve6Unlocked == true)
        {
            Gamecontroller.HappinessAmount = 5000f;

            Gamecontroller.TotalHappiness = 5000f;
        }
        else
        {
            Gamecontroller.HappinessAmount = 1f;

            Gamecontroller.TotalHappiness = 1f;
        }
       

        Gamecontroller.PercentageToUltimate = 0f;

        Gamecontroller.BaseHappinessPerSecond = 0.1f;
        Gamecontroller.TotalHappinessPerSecond = 0.1f;
        Gamecontroller.TotalTotalHappinessPerSecond = 0.1f;

        Gamecontroller.Upgrade1Bought = false;
        Gamecontroller.Upgrade2Bought = false;
        Gamecontroller.Upgrade3Bought = false;
        Gamecontroller.Upgrade4Bought = false;
        Gamecontroller.Upgrade5Bought = false;
        Gamecontroller.Upgrade6Bought = false;
        Gamecontroller.Upgrade7Bought = false;

        Gamecontroller.Upgrade8Bought = false;
        Gamecontroller.Upgrade9Bought = false;
        Gamecontroller.Upgrade9Boost = 1;

        Gamecontroller.FriendsPrice = 1000f;
        Gamecontroller.FriendsAmount = 0f;
        if (Gamecontroller.Achieve3Unlocked == true)
        {
            Gamecontroller.FriendsWorth = 25f;
        }
        else
        {
            Gamecontroller.FriendsWorth = 5f;
        }
        
        Gamecontroller.FriendsLevelCap = 100000f;

        Gamecontroller.HobbiesPrice = 100000f;
        Gamecontroller.HobbiesAmount = 0f;
        Gamecontroller.HobbiesWorth = 0.1f;

        Gamecontroller.TPTimer = 600f;
        Gamecontroller.TPAmount = 10;

        if (Gamecontroller.T2UPUpgrade3Bought == true)
        {
            Gamecontroller.BreathingLevel = 100;
            Gamecontroller.AgingLevel = 100;
            Gamecontroller.PeeingLevel = 100;
        }

        else if (Gamecontroller.T1UPUpgrade3Bought == true)
        {
            Gamecontroller.BreathingLevel = 20;
            Gamecontroller.AgingLevel = 20;
            Gamecontroller.PeeingLevel = 20;
        }
        else
        {
            Gamecontroller.BreathingLevel = 1;
            Gamecontroller.AgingLevel = 1;
            Gamecontroller.PeeingLevel = 1;
        }

        
        

        Gamecontroller.MedalCountBreathing = 0;
        Gamecontroller.MedalCountAging = 0;
        Gamecontroller.MedalCountPeeing = 0;

        Gamecontroller.BreathingUpgr1Bought = false;
        Gamecontroller.AgingUpgr1Bought = false;
        Gamecontroller.PeeingUpgr1Bought = false;
        Gamecontroller.BreathingUpgr2Bought = false;
        Gamecontroller.AgingUpgr2Bought = false;
        Gamecontroller.PeeingUpgr2Bought = false;
        Gamecontroller.AgingUpgr2Mult = 1;
        Gamecontroller.FinalMedalUpgrBought = false;

        Gamecontroller.MedalMultToHPs = 1;
        Gamecontroller.MedalCountTotal = 0;

        Gamecontroller.Ruby1Amount = 0;
        Gamecontroller.Ruby2Amount = 0;
        Gamecontroller.Ruby3Amount = 0;
        Gamecontroller.Emerald1Amount = 0;
        Gamecontroller.Emerald2Amount = 0;
        Gamecontroller.Emerald3Amount = 0;
        Gamecontroller.Sapphire1Amount = 0;
        Gamecontroller.Sapphire2Amount = 0;
        Gamecontroller.Sapphire3Amount = 0;

        Gamecontroller.RubyBoost = 1f;
        Gamecontroller.EmeraldBoost = 0;
        Gamecontroller.SapphireBoost = 0;


        
        Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints + 1 * Gamecontroller.T1Upgrade1MultiToUP * Gamecontroller.T2Upgrade1MultiToUP * Gamecontroller.T3Upgrade1MultiToUP;
        Gamecontroller.EverWentUltimate = true;
        Gamecontroller.AmountUltimated = Gamecontroller.AmountUltimated + 1;
        
        
       





        //deactivate Button itself
        gameObject.SetActive(false);

        //reload scene
        SceneManager.LoadScene(1);



    }
}
