using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
     void Start()
    {
        
    }

     void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {

            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position - this.transform.right, Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.D))
        {

            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + this.transform.right, Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.W))
        {

            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + this.transform.forward, Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {

            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position - this.transform.forward, Time.deltaTime * speed);

        }



    }
}
