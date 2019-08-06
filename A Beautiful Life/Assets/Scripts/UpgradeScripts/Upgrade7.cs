using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade7 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Text BoostAmount;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.Upgrade7Bought == true)
        {
            transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
            

        }

        Gamecontroller.Upgrade7Boost = 10/(2*Mathf.Exp(-0.002f*(Gamecontroller.Day-100))+1);

        
        BoostAmount.text = "Currently: x" + Gamecontroller.Upgrade7Boost.ToString("f2") + " to HP/s";

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.Upgrade7Bought == false)
        {

            if (Gamecontroller.HappinessAmount > 10e5)
            {

                transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

                Gamecontroller.Upgrade7Bought = true;

                Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 10e5f;
            }



        }


    }
}