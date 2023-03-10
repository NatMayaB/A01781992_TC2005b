using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    // Class variable to be changed from the Unity interface
    [SerializeField] GameObject ball; // Serialize Field hace que se pueda ver desde la interfaz de Unity
    [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        // Call the "DropBall" function after 0.5 seconds
        // and then keep calling it every set time
        InvokeRepeating("DropBall", 0.5f, delay);
    }

    void DropBall() 
    {
        //Generate a new  random position
        Vector3 pos = new Vector3(Random.Range(-8.0f, 8.0f),6,0);
        // Create a copy of the prefab
        GameObject obj = Instantiate(ball, pos, Quaternion.identity);
        //Doom the object to die in 5 seconds
        Destroy(obj, 5);
    }

    public void StopBalls() {
        CancelInvoke("DropBall");
    }
}
