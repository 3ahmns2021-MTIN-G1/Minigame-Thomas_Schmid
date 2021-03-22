using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string PlayerRight;
    public string PlayerLeft;
    public string PlayerUp;
    public string PlayerDown;

    public Vector2 forceR;
    public Vector2 forceL;
    public Vector2 forceU;
    public Vector2 forceD;

    private Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
       if (Input.GetKeyDown(PlayerRight))
        {
            rb2d.AddForce(forceR);
            print("P_Right");
        }

       if (Input.GetKeyDown(PlayerLeft))
        {
            rb2d.AddForce(forceL);
            print("P_Left");
        }

       if (Input.GetKeyDown(PlayerUp))
        {
            rb2d.AddForce(forceU);
            print("P_Up");
        }

       if (Input.GetKeyDown(PlayerDown))
        {
            rb2d.AddForce(forceD);
            print("P_Down");
        }
    }
}
