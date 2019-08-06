using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T4Upgrade3 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T4UPUpgrade3Bought == true)
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

        if (Gamecontroller.T4UPUpgrade3Bought == false)
        {

            if (Gamecontroller.T3UPUpgrade3Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 19)
                {

                    Gamecontroller.T4UPUpgrade3Bought = true;

                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 20;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }
        }

    }
}
