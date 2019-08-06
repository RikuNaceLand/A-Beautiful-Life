using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnusedVariablesUpdater : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Gamecontroller.MedalCountTotal = Gamecontroller.MedalCountAging + Gamecontroller.MedalCountBreathing + Gamecontroller.MedalCountPeeing;

        //MedalMultToIP-Updater:
        if (Gamecontroller.BreathingUpgr2Bought == true)
        {

            if (Gamecontroller.MedalCountTotal < 1)
            {
                Gamecontroller.MedalMultToHPs = 1;
            }
            else if (Gamecontroller.MedalCountTotal < 101)
            {
                Gamecontroller.MedalMultToHPs = Gamecontroller.MedalCountTotal;
            }
            else
            {
                Gamecontroller.MedalMultToHPs = 100;
            }
        } 



        //Upgrade 7 Bought
        if (Gamecontroller.Upgrade7Bought == true)
        {
            Gamecontroller.TotalTotalHappinessPerSecond = Gamecontroller.TotalHappinessPerSecond * Gamecontroller.Upgrade7Boost;
            
        }

        if (Gamecontroller.TPAmount < 10 && Gamecontroller.TPTimer > 0)
        {
            Gamecontroller.TPTimer -= Time.deltaTime;

        }

        else if (Gamecontroller.TPAmount < 10)
        {
            //Both Peeing Upgr bought
            if (Gamecontroller.PeeingUpgr1Bought == true && Gamecontroller.PeeingUpgr2Bought == true)
            {
                Gamecontroller.TPTimer = 300f;
            }
            //Peeing Upgr1 bought only
            else if (Gamecontroller.PeeingUpgr1Bought == true)
            {
                Gamecontroller.TPTimer = 540f;
            }
            //Peeing Upgr 2 bought only (idiot Kappa)
            else if (Gamecontroller.PeeingUpgr2Bought == true)
            {
                Gamecontroller.TPTimer = 360f;
            }
            else
            {
                Gamecontroller.TPTimer = 600f;
            }

            Gamecontroller.TPAmount = Gamecontroller.TPAmount + 1 * Gamecontroller.AgingUpgr2Mult;

        }

        else

        {
            Gamecontroller.TPTimer = 600f;
        }


    }
}
