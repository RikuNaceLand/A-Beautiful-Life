using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMoreStats : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text UltimatedStat;
    public Text TotalHappiness;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        UltimatedStat.text = "You went Ultimate " + Gamecontroller.AmountUltimated.ToString("#,0.##") + " times so far";

        TotalHappiness.text = "Since you last went Ultimate, you earned a total of " + Gamecontroller.TotalHappiness.ToString("0.000e0") + " HP";



    }
}
