using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
