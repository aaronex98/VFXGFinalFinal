using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzParpadeatne : MonoBehaviour
{
    public Light foco;
    public MeshRenderer luz;
    public Color colorOn;
    public Color colorOff;

    public float minTimeOn;
    public float maxTimeOn;

    public float minTimeOff;
    public float maxTimeOff;
    void Start()
    {
        StartCoroutine(FocoParpadeando(minTimeOn, maxTimeOn, minTimeOff, maxTimeOff));
    }

 

    public IEnumerator FocoParpadeando(float minOn, float maxOn, float minOff, float maxOff)
    {
        foco.enabled = !foco.enabled;
        //if (foco.enabled)
        //{
        //    Debug.Log("4");
        //    luz.sharedMaterial.SetFloat("_Intensidad", 1);
        //}
        //else
        //{
        //    luz.GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_Intensidad", 0);

        //}
        if (foco.enabled)
        yield return new WaitForSeconds(Random.Range(minOn, maxOn));
        else
        {
            yield return new WaitForSeconds(Random.Range(minOff, maxOff));


        }
        StartCoroutine(FocoParpadeando(minOn, maxOn, minOff, maxOff));

        yield return null;
    }
}
