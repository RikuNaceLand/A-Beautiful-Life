using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionCaller : MonoBehaviour
{

    private GameControl gameController = GameControl.Instance;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForGameLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForGameLoad()
    {

        
        if (gameController.DisplayMainInstructions == true)
        {
            yield return new WaitForSeconds(5);

            transform.GetChild(0).gameObject.SetActive(true);

            yield return new WaitForSeconds(3);

            transform.GetChild(1).gameObject.SetActive(true);

            yield return new WaitForSeconds(5);

            transform.GetChild(2).gameObject.SetActive(true);

        }
    }
}
