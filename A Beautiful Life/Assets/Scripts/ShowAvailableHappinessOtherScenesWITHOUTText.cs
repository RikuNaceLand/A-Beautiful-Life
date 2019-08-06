using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAvailableHappinessOtherScenesWITHOUTText : MonoBehaviour
{

    private GameControl gameController = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Mit Upgrade 7 Boost:
        if (gameController.Upgrade7Bought == true)
        {
            gameController.HappinessAmount = gameController.HappinessAmount + gameController.TotalTotalHappinessPerSecond * Time.deltaTime;
            gameController.TotalHappiness = gameController.TotalHappiness + gameController.TotalTotalHappinessPerSecond * Time.deltaTime;
        }

        //Ohne Upgrade 7 Boost:
        else
        {
            gameController.HappinessAmount = gameController.HappinessAmount + gameController.TotalHappinessPerSecond * Time.deltaTime;
            gameController.TotalHappiness = gameController.TotalHappiness + gameController.TotalHappinessPerSecond * Time.deltaTime;
        }


        //HP/s-Updater:

        gameController.TotalHappinessPerSecond = (gameController.BaseHappinessPerSecond + gameController.FriendsWorth * gameController.FriendsAmount * gameController.T1Upgrade2MultiToFriendsWorth) * gameController.MedalMultToHPs * gameController.RubyBoost * (gameController.AmountUltimated + 1);

        //HP/s with Upgrade 7 Boost:

        if (gameController.Upgrade7Bought == true)
        {
            gameController.TotalTotalHappinessPerSecond = gameController.TotalHappinessPerSecond * gameController.Upgrade7Boost;

        }

        //Friends-Updater to actually increase friends/"HP/s":

        if (gameController.FriendsAmount < gameController.FriendsLevelCap)
        {
            gameController.FriendsAmount = gameController.FriendsAmount + gameController.HobbiesWorth * gameController.HobbiesAmount * Time.deltaTime * gameController.T3Upgrade3BoostToHobbies * gameController.T4Upgrade2BoostToHobbies;

        }

    }
}
