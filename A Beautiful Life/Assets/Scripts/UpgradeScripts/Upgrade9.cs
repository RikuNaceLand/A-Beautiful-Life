using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade9 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.Upgrade9Bought == true)
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
        if (Gamecontroller.Upgrade9Bought == false)
        {

            if (Gamecontroller.HappinessAmount > 300000000000)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.Upgrade9Bought = true;
                Gamecontroller.Upgrade9Boost = 2;

                Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 300000000000f;
            }



        }


    }
}