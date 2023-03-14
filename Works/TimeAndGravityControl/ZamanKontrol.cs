using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZamanKontrol : MonoBehaviour
{

    public float timeSpeed;
    public GameObject gObject;

    
    void Update()
    {
        Time.timeScale += (1f / 2f) * Time.deltaTime;

        Time.timeScale = timeSpeed;
        Time.fixedDeltaTime = Time.timeScale*0.2f;
    }
}
