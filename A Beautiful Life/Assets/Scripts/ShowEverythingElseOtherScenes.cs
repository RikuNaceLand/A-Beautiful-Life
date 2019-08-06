using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEverythingElseOtherScenes : MonoBehaviour
{

    public Text HappinessPerSecondText;
    private GameControl gameController = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameController.Upgrade7Bought == false)
        {
            if (gameController.TotalHappinessPerSecond < 1000000f)
            {
                HappinessPerSecondText.text = "HP/s: " + gameController.TotalHappinessPerSecond.ToString("#,0.0");
            }
            else
            {
                HappinessPerSecondText.text = "HP/s: " + gameController.TotalHappinessPerSecond.ToString("0.000e0");
            }
        }

        else
        {
            if (gameController.TotalTotalHappinessPerSecond < 1000000f)
            {
                HappinessPerSecondText.text = "HP/s: " + gameController.TotalTotalHappinessPerSecond.ToString("#,0.0");
            }
            else
            {
                HappinessPerSecondText.text = "HP/s: " + gameController.TotalTotalHappinessPerSecond.ToString("0.000e0");
            }
        }
       
        
    }
}
