using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingUpgr2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.BreathingUpgr2Bought == true)
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
        if (Gamecontroller.BreathingUpgr2Bought == false)
        {

            if (Gamecontroller.MedalCountBreathing > 9)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.BreathingUpgr2Bought = true;

                Gamecontroller.MedalCountBreathing = Gamecontroller.MedalCountBreathing - 10;
            }



        }


    }
}