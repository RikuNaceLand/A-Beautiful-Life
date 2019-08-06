using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade6 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.Upgrade6Bought == true)
        {
            transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.Upgrade6Bought == false)
        {

            if (Gamecontroller.HappinessAmount > 59999)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.Upgrade6Bought = true;
                Gamecontroller.FriendsWorth = Gamecontroller.FriendsWorth * 2;
                Gamecontroller.TotalHappinessPerSecond = (Gamecontroller.BaseHappinessPerSecond + Gamecontroller.FriendsWorth * Gamecontroller.FriendsAmount * Gamecontroller.T1Upgrade2MultiToFriendsWorth) * Gamecontroller.MedalMultToHPs * Gamecontroller.RubyBoost * (Gamecontroller.AmountUltimated + 1);

                Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 60000f;
            }



        }


    }
}