using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achieve4 : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Material Earned;

    private Material Unearned;

    // Start is called before the first frame update
    void Start()
    {
        Unearned = GetComponent<Renderer>().material;

        if (Unearned == Earned)
        {
            //nothing
        }
        else if (Gamecontroller.Achieve4Unlocked == true)
        {
            GetComponent<Renderer>().material = Earned;
        }


    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnMouseDown()
    {
        if (Gamecontroller.Achieve4NaceBucksGotten == false)
        {

            if (Gamecontroller.Achieve4Unlocked == true)
            {
                Gamecontroller.Achieve4NaceBucksGotten = true;
                Gamecontroller.NaceBucks = Gamecontroller.NaceBucks + 10;
                StartCoroutine(NaceBucksEarned());
            }

        }

    }

    IEnumerator NaceBucksEarned()
    {


        transform.GetChild(0).GetChild(3).gameObject.SetActive(true);

        yield return new WaitForSeconds(3);

        transform.GetChild(0).GetChild(3).gameObject.SetActive(false);

    }

}
