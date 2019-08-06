using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T4Upgrade2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T4UPUpgrade2Bought == true)
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
        if (Gamecontroller.T4UPUpgrade2Bought == false)
        {

            if (Gamecontroller.T3UPUpgrade2Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 19)
                {

                    Gamecontroller.T4UPUpgrade2Bought = true;
                    Gamecontroller.T4Upgrade2BoostToHobbies = 10;


                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 20;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }

        }


    }
}
