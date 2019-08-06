using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDownToNextIP : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text Timer;

    public Text TPAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

                //UP-Upgrade for auto-maxing?
                if (Gamecontroller.T2UPUpgrade2Bought == true)
                {
                    Gamecontroller.TPAmount = 10;
                }
                else
                {
                    Gamecontroller.TPAmount = Gamecontroller.TPAmount + 1 * Gamecontroller.AgingUpgr2Mult;
                }
            }

            else

            {
                Gamecontroller.TPTimer = 600f;
            }
        

        

        Timer.text = "Next TP in " + Gamecontroller.TPTimer.ToString("0") + " seconds";
        TPAmount.text = "Available Training-Points (TP): " + Gamecontroller.TPAmount.ToString() + "/10";



    }
}
