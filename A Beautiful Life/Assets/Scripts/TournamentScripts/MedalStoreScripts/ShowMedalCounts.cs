using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMedalCounts : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Text BreathingMedals;
    public Text AgingMedals;
    public Text PeeingMedals;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BreathingMedals.text = "You currently have " + Gamecontroller.MedalCountBreathing + " Breathing-Medals";
        AgingMedals.text = "You currently have " + Gamecontroller.MedalCountAging + " Getting-Older-Medals";
        PeeingMedals.text = "You currently have " + Gamecontroller.MedalCountPeeing + " Peeing-Medals";


    }
}
