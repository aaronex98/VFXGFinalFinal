using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLookAt : MonoBehaviour
{
    public GameObject cam;
    public float timer = 2;
     void Start()
    {
        StartCoroutine(TimerToLook());
    }

     void Update()
    {
        
    }
    public IEnumerator TimerToLook()
    {




        yield return new WaitForSeconds(timer);
        transform.LookAt(cam.transform);
        yield return StartCoroutine(TimerToLook());
    }
}
