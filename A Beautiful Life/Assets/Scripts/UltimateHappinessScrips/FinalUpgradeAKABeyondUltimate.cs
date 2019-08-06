using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalUpgradeAKABeyondUltimate : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.BeyondUltimateUpgrBought == true)
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

        if (Gamecontroller.BeyondUltimateUpgrBought == false)
        {

            if (Gamecontroller.T4UPUpgrade1Bought == true && Gamecontroller.T4UPUpgrade2Bought == true && Gamecontroller.T4UPUpgrade3Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 99)
                {

                    Gamecontroller.BeyondUltimateUpgrBought = true;

                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 100;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }
        }

    }
}