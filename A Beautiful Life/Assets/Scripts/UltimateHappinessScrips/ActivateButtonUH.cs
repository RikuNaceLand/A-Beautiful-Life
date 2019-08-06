using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButtonUH : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public float PercentageToUltimateHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PercentageToUltimateHP = Mathf.Log(Gamecontroller.HappinessAmount) / Mathf.Log(10000000000000000f);

        if (PercentageToUltimateHP >= 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        


    }
}
