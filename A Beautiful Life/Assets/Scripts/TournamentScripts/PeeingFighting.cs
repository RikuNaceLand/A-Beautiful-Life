﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PeeingFighting : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Text WinChance;

    public Text PeeingMedals;

    public float Result;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WinChance.text = Gamecontroller.PeeingLevel.ToString() + "% Chance to win";

        PeeingMedals.text = "You currently have " + Gamecontroller.MedalCountPeeing + " Peeing-Medals";

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.TPAmount > 0)
        {
            Gamecontroller.TPAmount = Gamecontroller.TPAmount - 1;

            Result = Random.Range(0f, 99f);

            if (Gamecontroller.PeeingLevel > Result)
            {
                Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing + 1 * Gamecontroller.Upgrade9Boost;
                StartCoroutine(Won());

            }
            else
            {
                StartCoroutine(Lost());
            }

        }



    }


    IEnumerator Won()
    {


        transform.GetChild(0).GetChild(5).gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        transform.GetChild(0).GetChild(5).gameObject.SetActive(false);

    }


    IEnumerator Lost()
    {


        transform.GetChild(0).GetChild(6).gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        transform.GetChild(0).GetChild(6).gameObject.SetActive(false);

    }
}
