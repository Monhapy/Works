using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CamMove : MonoBehaviour
{

    // 3D PUZZLE OYUNU ÝÇÝN ÝLK KAMERA KODU DENEMESÝ //  

   
    
    public Transform player;
    public Vector3 position;
    public float speed = 50f;
    int kontrol;
    public Rigidbody rb;


    void Start()
    {
        position = transform.position;

    }

    void Update()
    {
        //KAMERA KARAKTER TAKÝP
        transform.LookAt(player);
        

        
        //KAMERA NEREDE KONTROL
        position = transform.position;

        if (position.z == -10f && position.x == 10f)
        {
            kontrol = 1;
            rb.velocity = Vector3.zero;

        }
        else if (position.z == 10f && position.x == 10f)
        {
            kontrol = 2;
            rb.velocity = Vector3.zero;
        }
        else if (position.z == 10f && position.x == -10f)
        {
            kontrol = 3;
            rb.velocity = Vector3.zero;
        }
        else if (position.z == -10f && position.x == -10f)
        {
            kontrol = 4;
            rb.velocity = Vector3.zero;
        }
        //SAÐA DOÐRU KUVVET UYGULAMA
        if (Input.GetKey(KeyCode.L))
        {
            
            switch (kontrol)
            {       
                case 1:

                    rb.velocity = new Vector3(0f, 0f, speed);                    
                    break;

                case 2:

                    rb.velocity = new Vector3(-speed, 0f, 0f);                    
                    break;
                
                case 3:

                    rb.velocity = new Vector3(0f, 0f, -speed);                    
                    break;
                
                case 4:

                    rb.velocity = new Vector3(speed, 0f, 0f);                    
                    break;

            }
        }
        //KAMERA DURDURMA
        if (position.z >= 10f)
        {
            position.z = 10f;
            transform.position = position;
            

        }
        if (position.x <= -10f)
        {
            position.x = -10f;
            transform.position = position;
            
        }
        if (position.z <= -10f)
        {
            position.z = -10f;
            transform.position = position;
           
        }
        if (position.x >= 10f)
        {
            position.x = 10f;
            transform.position = position;
            
        }
        

        //SOLA DOÐRU KUVVET UYGULAMA 
        if (Input.GetKey(KeyCode.K))
        {
            switch (kontrol)
            {
                case 1:

                    rb.velocity = new Vector3(-speed, 0f, 0f);
                    break;

                case 2:

                    rb.velocity = new Vector3(0f, 0f, -speed);                
                    break;

                case 3:

                    rb.velocity = new Vector3(speed, 0f, 0f);
                    break;

                case 4:

                    rb.velocity = new Vector3(0f, 0f, speed);

                    break;

            }
        }
        //KAMERA DURDURMA
        if (position.x <= -10f)
        {
            position.x = -10f;
            transform.position = position;
        }
        if (position.z <= -10f)
        {
            position.z = -10f;
            transform.position = position;
        }
        if (position.x >= 10f)
        {
            position.x = 10f;
            transform.position = position;

        }
        if (position.z >= 10f)
        {
            position.z = 10f;
            transform.position = position;
        }





    }
   
}
