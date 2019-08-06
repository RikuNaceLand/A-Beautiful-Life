using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgingUpgr1 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.AgingUpgr1Bought == true)
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
        if (Gamecontroller.AgingUpgr1Bought == false)
        {

            if (Gamecontroller.MedalCountAging > 0)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.AgingUpgr1Bought = true;

                Gamecontroller.MedalCountAging = Gamecontroller.MedalCountAging - 1;
            }



        }


    }
}