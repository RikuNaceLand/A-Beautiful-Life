using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnusedVariablesInMedalStore : MonoBehaviour
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
    }
}
