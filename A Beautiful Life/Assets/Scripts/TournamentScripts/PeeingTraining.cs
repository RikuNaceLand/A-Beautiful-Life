using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PeeingTraining : MonoBehaviour
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
        Level.text = "Peeing Level " + Gamecontroller.PeeingLevel.ToString();


    }

    private void OnMouseDown()
    {
        if (Gamecontroller.PeeingLevel < 100)
        {
            if (Gamecontroller.TPAmount > 0)
            {
                Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;
                Gamecontroller.PeeingLevel = Gamecontroller.PeeingLevel + 1;

            }
        }

    }
}
