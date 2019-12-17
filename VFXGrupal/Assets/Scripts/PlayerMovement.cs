using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Camera cam;
    public static Ray ray;
    private RaycastHit hit;
    public float rotSpeed;
 
     void Start()
    {
        cam = Camera.main;
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
      
        if (Input.mousePosition.x < Screen.width * 1/3)
        {

            cam.transform.Rotate(-cam.transform.up * Time.deltaTime * rotSpeed);

        }
        else if (Input.mousePosition.x > Screen.width * 2 / 3)
        {

            cam.transform.Rotate( cam.transform.up * Time.deltaTime * rotSpeed);

        }
        if (Input.mousePosition.y < Screen.width * 1 / 3)
        {

            cam.transform.Rotate(-cam.transform.x * Time.deltaTime * rotSpeed);

        }
        else if (Input.mousePosition.y > Screen.width * 2 / 3)
        {

            cam.transform.Rotate(cam.transform.right * Time.deltaTime * rotSpeed);

        }
    }
}
