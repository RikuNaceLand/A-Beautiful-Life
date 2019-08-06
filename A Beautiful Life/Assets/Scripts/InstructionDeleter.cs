using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionDeleter : MonoBehaviour
{

    private GameControl gameController = GameControl.Instance;

    private void Awake()
    {
        gameObject.GetComponent<Renderer>().enabled = false;


    }


    // Start is called before the first frame update
    void Start()
    {

        if (gameController.DisplayMainInstructions == true)
        {
            StartCoroutine(WaitForGameLoad());

            gameObject.GetComponent<Renderer>().enabled = true;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForGameLoad()
    {

        yield return new WaitForSeconds(3);

    }
}
