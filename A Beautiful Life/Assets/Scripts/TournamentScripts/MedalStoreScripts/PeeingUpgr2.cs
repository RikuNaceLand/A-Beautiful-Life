using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeeingUpgr2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.PeeingUpgr2Bought == true)
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
        if (Gamecontroller.PeeingUpgr2Bought == false)
        {

            if (Gamecontroller.MedalCountPeeing > 19)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.PeeingUpgr2Bought = true;

                Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing - 20;
            }



        }


    }
}