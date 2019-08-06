using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Upgrade3 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T2UPUpgrade3Bought == true)
        {
            GetComponent<Renderer>().material = Bought;
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.T2UPUpgrade3Bought == false)
        {

            if (Gamecontroller.T1UPUpgrade3Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 5)
                {

                    Gamecontroller.T2UPUpgrade3Bought = true;
                    Gamecontroller.AgingLevel = Gamecontroller.AgingLevel + 99;
                    Gamecontroller.BreathingLevel = Gamecontroller.BreathingLevel + 99;
                    Gamecontroller.PeeingLevel = Gamecontroller.PeeingLevel + 99;


                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 6;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }
        }

    }
}
