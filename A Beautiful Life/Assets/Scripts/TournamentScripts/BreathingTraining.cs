using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreathingTraining : MonoBehaviour
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
        Level.text = "Breathing Level " + Gamecontroller.BreathingLevel.ToString();


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.BreathingLevel < 100)
        {

            if (Gamecontroller.TPAmount > 0)
            {
                if (Gamecontroller.BreathingUpgr1Bought == true)
                {
                    Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;
                    Gamecontroller.BreathingLevel = Gamecontroller.BreathingLevel + 2;
                }

                else
                {
                    Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;
                    Gamecontroller.BreathingLevel = Gamecontroller.BreathingLevel + 1;
                }

            }
        }



    }
}
