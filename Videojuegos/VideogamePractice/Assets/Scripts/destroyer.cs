using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    //destroys the object 
    void OnCollisionEnter2D(Collision2D col) {
        Destroy(col.gameObject);
    }
}

