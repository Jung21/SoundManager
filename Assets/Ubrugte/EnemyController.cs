using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void Start()
    {
        MainGameManager.instance.AdjustScore(-1000);
    }

    private void Update()
    {
        
    }

}
