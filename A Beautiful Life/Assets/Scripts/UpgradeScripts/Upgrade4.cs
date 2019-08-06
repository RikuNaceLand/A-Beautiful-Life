using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade4 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.Upgrade4Bought == true)
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
        if (Gamecontroller.Upgrade4Bought == false)
        {

            if (Gamecontroller.HappinessAmount > 99999)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.Upgrade4Bought = true;

                Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 100000f;
            }



        }


    }
}