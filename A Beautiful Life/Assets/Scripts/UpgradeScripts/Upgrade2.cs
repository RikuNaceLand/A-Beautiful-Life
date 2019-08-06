using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.Upgrade2Bought == true)
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
        if (Gamecontroller.Upgrade2Bought == false)
        {

            if (Gamecontroller.HappinessAmount > 200)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.Upgrade2Bought = true;

                Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 200f;
            }



        }


    }
}