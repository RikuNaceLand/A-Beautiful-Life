using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AgingTraining : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text Level;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Level.text = "Getting Older Level " + Gamecontroller.AgingLevel.ToString();


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.AgingLevel < 100)
        {

            if (Gamecontroller.TPAmount > 0)
            {
                if (Gamecontroller.AgingUpgr1Bought == true)
                {
                    Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;
                    Gamecontroller.AgingLevel = Gamecontroller.AgingLevel + 2;
                }

                else
                {
                    Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;
                    Gamecontroller.AgingLevel = Gamecontroller.AgingLevel + 1;
                }

            }
        }



    }
}
