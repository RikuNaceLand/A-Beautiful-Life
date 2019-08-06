using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUP : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Text UP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        UP.text = "You have " + Gamecontroller.UltimatePoints.ToString("#,0.##") + " Ultimate Points (UP)";



    }
}
