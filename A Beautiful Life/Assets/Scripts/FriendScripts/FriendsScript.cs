using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendsScript : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text price;
    public Text amount;
    public Text HPs;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Gamecontroller.FriendsPrice < Gamecontroller.HappinessAmount)
        {
            price.color = Color.white;
        }
        else
        {
            price.color = Color.red;
        }

        if (Gamecontroller.FriendsPrice < 1000000f)
        {
            price.text = Gamecontroller.FriendsPrice.ToString("#,0.##") + " HP";
        }
        else
        {
            price.text = Gamecontroller.FriendsPrice.ToString("0.000e0") + " HP";
        }
        

        amount.text = "You have: " + Gamecontroller.FriendsAmount.ToString("#,0.0");

        HPs.text = "Base: 5 HP/s each";

        Gamecontroller.TotalHappinessPerSecond = (Gamecontroller.BaseHappinessPerSecond + Gamecontroller.FriendsWorth * Gamecontroller.FriendsAmount * Gamecontroller.T1Upgrade2MultiToFriendsWorth) * Gamecontroller.MedalMultToHPs * Gamecontroller.RubyBoost * (Gamecontroller.AmountUltimated + 1);

        if (Gamecontroller.Achieve4Unlocked == false)
        {

            if (Gamecontroller.FriendsAmount > 99999)
            {
                Gamecontroller.Achieve4Unlocked = true;
                StartCoroutine(AchievementUnlocked());
            }

        }

        if (Gamecontroller.Achieve3Unlocked == false)
        {
            if (Gamecontroller.FriendsAmount > 11f)
            {
                Gamecontroller.Achieve3Unlocked = true;

                Gamecontroller.FriendsWorth = Gamecontroller.FriendsWorth * 5f;
                
                StartCoroutine(AchievementUnlocked());
            }
        }


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.FriendsAmount < Gamecontroller.FriendsLevelCap)
        {

        if (Gamecontroller.FriendsPrice < Gamecontroller.HappinessAmount)
        {
            Gamecontroller.FriendsAmount = Gamecontroller.FriendsAmount + 1f;
            Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - Gamecontroller.FriendsPrice;
            Gamecontroller.FriendsPrice = Gamecontroller.FriendsPrice * 1.2f;


                if (Gamecontroller.FriendsPrice < 1000000f)
                {
                    price.text = Gamecontroller.FriendsPrice.ToString("#,0.##") + " HP";
                }
                else
                {
                    price.text = Gamecontroller.FriendsPrice.ToString("0.000e0") + " HP";
                }



                amount.text = Gamecontroller.FriendsAmount.ToString("#,0.##");
            
        }
        
        }




    }

    IEnumerator AchievementUnlocked()
    {


        transform.GetChild(1).gameObject.SetActive(true);

        yield return new WaitForSeconds(3);

        transform.GetChild(1).gameObject.SetActive(false);

    }

}
