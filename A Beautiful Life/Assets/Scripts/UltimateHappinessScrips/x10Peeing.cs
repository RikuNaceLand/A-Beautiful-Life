using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x10Peeing : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.TPAmount > 9)
        {
            Gamecontroller.TPAmount = Gamecontroller.TPAmount - 10;

            Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing + 10 * Gamecontroller.Upgrade9Boost;
            StartCoroutine(Won());
        }
    }

    IEnumerator Won()
    {
        transform.GetChild(0).GetChild(1).gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
    }
}
