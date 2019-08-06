using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1Upgrade3 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T1UPUpgrade3Bought == true)
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
        if (Gamecontroller.T1UPUpgrade3Bought == false)
        {

            if (Gamecontroller.UltimatePoints > 0)
            {

                Gamecontroller.T1UPUpgrade3Bought = true;
                Gamecontroller.AgingLevel = Gamecontroller.AgingLevel + 19;
                Gamecontroller.BreathingLevel = Gamecontroller.BreathingLevel + 19;
                Gamecontroller.PeeingLevel = Gamecontroller.PeeingLevel + 19;


                Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 1;
                GetComponent<Renderer>().material = Bought;
                transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
            }
        }


    }
}
