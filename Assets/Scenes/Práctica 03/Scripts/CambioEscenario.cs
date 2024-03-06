using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscenario : MonoBehaviour
{
    public GameObject esfera, cilindro;
    public float time = 0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >=0f && time <= 15f)
        {
            esfera.SetActive(true);
            cilindro.SetActive(false);
        }

        if (time >= 15f && time <= 30f)
        {
            esfera.SetActive(false);
            cilindro.SetActive(true);
        }
        if (time >= 30f && time <= 45f)
        {
            esfera.SetActive(false);
            cilindro.SetActive(false);
        }
        
        if(time >= 45f)
        {
            time = 0f;
        }
    }
}
