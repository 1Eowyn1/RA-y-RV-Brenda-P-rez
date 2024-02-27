using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrusel : MonoBehaviour
{
    public float yAngle;
    public float time = 0.0f;
    public GameObject Carruseles;

        // Update is called once per frame
    void Update()
    {
        Carruseles.transform.Rotate(0f, yAngle, 0f);
        time += Time.deltaTime;
        if (time >= 0f && time <= 20f)
        {
            Carruseles.transform.Translate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        }
        else if (time >= 20f && time <= 30f)
        {
            Carruseles.transform.Translate(new Vector3(0f, -2.5f, 0f) * Time.deltaTime);
        }
        else if (time >= 30f && time <= 50f)
        {
            Carruseles.transform.Translate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        }
        else if (time >= 50f && time <= 60f)
        {
            Carruseles.transform.Translate(new Vector3(0f, 5f, 0f) * Time.deltaTime);
        }
        else if (time >= 60f && time <= 80f) 
        {
            Carruseles.transform.Translate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        }
        else if (time >= 80f && time <= 90f)
        {
            Carruseles.transform.Translate(new Vector3(0f, -2.5f, 0f) * Time.deltaTime);
        }

        if (time >= 90f)
        {
            time = 0f;
        }
    }

}
