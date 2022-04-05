using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Example1.Awake was called");
    }

    // Update is called once per frame
    void Start()
    {
        Debug.Log("Start1 was called");
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            Debug.Log("B1 was pressed");
        }
    }
}
