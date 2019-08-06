using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMedalUpgr : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.FinalMedalUpgrBought == true)
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
        if (Gamecontroller.FinalMedalUpgrBought == false)
        {

            if (Gamecontroller.MedalCountPeeing > 49 && Gamecontroller.MedalCountAging > 49 && Gamecontroller.MedalCountBreathing > 49)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.FinalMedalUpgrBought = true;

                Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing - 50;
                Gamecontroller.MedalCountAging = Gamecontroller.MedalCountAging - 50;
                Gamecontroller.MedalCountBreathing = Gamecontroller.MedalCountBreathing - 50;
            }



        }


    }
}