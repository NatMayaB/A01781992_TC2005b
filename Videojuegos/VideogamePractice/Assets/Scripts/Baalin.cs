using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baalin : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        scoreObj.AddPoints(1);
    }
}