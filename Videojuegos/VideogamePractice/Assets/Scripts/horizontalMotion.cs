/*  Move a GameObject horizontally using the arrow keys or AD

Natalia Maya Bolaños
2023-03-01  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMotion : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x = 1;
        move.x = Input.GetAxis("Horizontal");

        //Debug.Log("X motion: " + move.x);

        //Limit the motion to a specific range of motion
        if (transform.position.x < -limit && move.x < 0) {
            move.x = 0;
        } else if (transform.position.x > limit && move.x > 0) {
            move.x = 0;
        }

        transform.Translate(move * speed  * Time.deltaTime);

    }
}
