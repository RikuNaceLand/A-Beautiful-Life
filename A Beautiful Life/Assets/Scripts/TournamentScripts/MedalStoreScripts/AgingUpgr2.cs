using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgingUpgr2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.AgingUpgr2Bought == true)
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
        if (Gamecontroller.AgingUpgr2Bought == false)
        {

            if (Gamecontroller.MedalCountAging > 19)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.AgingUpgr2Bought = true;
                Gamecontroller.AgingUpgr2Mult = 2;

                Gamecontroller.MedalCountAging = Gamecontroller.MedalCountAging - 20;
            }



        }


    }
}