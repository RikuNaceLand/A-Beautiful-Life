using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltimateHPProgressBar : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public float PercentageToUltimateHP;
    public float MakeItToActualPercentageForDisplay;

    public Slider ProgressbarUltimateHP;

    public Text PercentageToUltimateHPText;
    

    // Start is called before the first frame update
    void Start()
    {
        ProgressbarUltimateHP.value = 0;

    }

    // Update is called once per frame
    void Update()
    {

        PercentageToUltimateHP = Mathf.Log(Gamecontroller.HappinessAmount) / Mathf.Log (10000000000000000f);


        ProgressbarUltimateHP.value = PercentageToUltimateHP;

        MakeItToActualPercentageForDisplay = PercentageToUltimateHP * 100;

        if (PercentageToUltimateHP < 1)
        {
            PercentageToUltimateHPText.text = MakeItToActualPercentageForDisplay.ToString("#,0.00") + "% until ultimate Happiness (1e16 HP) [logarithmic]";
        }
        else
        {
            PercentageToUltimateHPText.text = "100% until Ultimate Happiness (1e16 HP) [logarithmic]";
        }
    }
}
