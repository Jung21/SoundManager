using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour
{


    public GameObject GO;

    private void Awake()
    {
        Debug.Log("Awake2 awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start2 awake");
    }

    private bool activateGO = true;
    // Update is called once per frame
    void Update()
    {
        if ( activateGO == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space pressed");

                GO.SetActive(true);

                activateGO = false;



            }


        }
    }
}
