using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float leftBounds = 15;


    // Update is called once per frame
    void Update()
    {
        
         {
            Destroy(this.gameObject);
         }
    }
}
