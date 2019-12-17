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
      if (Input.GetMouseButton(0))
        {


        if (Input.mousePosition.x < Screen.width * 1/4)
        {

            cam.transform.Rotate(-Vector3.up * Time.deltaTime * rotSpeed);

        }
        else if (Input.mousePosition.x > Screen.width *   3/ 4)
        {

            cam.transform.Rotate( Vector3.up * Time.deltaTime * rotSpeed);

        }
        if (Input.mousePosition.y < Screen.height * 1 / 4)
        {

            cam.transform.Rotate( Vector3.right * Time.deltaTime * rotSpeed);

        }
        else if (Input.mousePosition.y > Screen.height * 3/ 4)
        {

            cam.transform.Rotate( -Vector3.right * Time.deltaTime * rotSpeed);

        }
        }
    }
}
