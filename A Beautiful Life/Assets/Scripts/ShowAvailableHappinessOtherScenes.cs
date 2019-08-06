using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAvailableHappinessOtherScenes : MonoBehaviour
{

    public Text AvailableHappiness;
    private GameControl gameController = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gameController.HappinessAmount < 1000000f)
        {
            AvailableHappiness.text = "Available Happiness: " + gameController.HappinessAmount.ToString("#,0.00") + " HP";
        }
        else
        {
            AvailableHappiness.text = "Available Happiness: " + gameController.HappinessAmount.ToString("0.000e0") + " HP";
        }

    }
}
