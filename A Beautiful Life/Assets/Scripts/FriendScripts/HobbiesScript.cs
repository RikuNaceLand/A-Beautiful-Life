using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HobbiesScript : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text price;
    public Text amount;
    public Text FriendsPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Gamecontroller.HobbiesPrice < Gamecontroller.HappinessAmount)
        {
            price.color = Color.white;
        }
        else
        {
            price.color = Color.red;
        }

        if (Gamecontroller.HobbiesPrice < 1000000f)
        {
            price.text = Gamecontroller.HobbiesPrice.ToString("#,0.##") + " HP";
        }
        else
        {
            price.text = Gamecontroller.HobbiesPrice.ToString("0.000e0") + " HP";
        }
        
        amount.text = "You have: " + Gamecontroller.HobbiesAmount.ToString("#,0.##");

        if ( Gamecontroller.FriendsAmount < Gamecontroller.FriendsLevelCap)
        {
            Gamecontroller.FriendsAmount = Gamecontroller.FriendsAmount + Gamecontroller.HobbiesWorth * Gamecontroller.HobbiesAmount * Time.deltaTime * Gamecontroller.T3Upgrade3BoostToHobbies * Gamecontroller.T4Upgrade2BoostToHobbies;

        }

        

        FriendsPerSecond.text = "Base: 0.1 Friends/s each";


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.HobbiesPrice < Gamecontroller.HappinessAmount)
        {
            Gamecontroller.HobbiesAmount = Gamecontroller.HobbiesAmount + 1f;
            Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - Gamecontroller.HobbiesPrice;
            Gamecontroller.HobbiesPrice = Gamecontroller.HobbiesPrice * 1.3f;


            if (Gamecontroller.HobbiesPrice < 1000000f)
            {
                price.text = Gamecontroller.HobbiesPrice.ToString("#,0.##") + " HP";
            }
            else
            {
                price.text = Gamecontroller.HobbiesPrice.ToString("0.000e0") + " HP";
            }

            amount.text = "You have:" + Gamecontroller.HobbiesAmount.ToString("#,0.##");

        }




    }


}