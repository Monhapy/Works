using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YerÇekimiKontrol : MonoBehaviour
{
    public Rigidbody2D rbGravity;

    private void Start()
    {
        rbGravity.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            rbGravity.gravityScale = 0f;
                                
        }
        else
        {
            rbGravity.gravityScale = 5f;
        }
    }
}
