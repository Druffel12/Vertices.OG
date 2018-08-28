using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator anim;
    Vector3 Vel;
    Rigidbody RB;

	// Use this for initialization
	void Start ()
    {
        Vel = RB.velocity;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Animate();
    }

    void Animate()
    {
        
        if (Input.GetKeyDown("space"))
        {
            anim.SetTrigger("isJumping");
        }

        //if (Vel > Vel.magnitude)
        //{
        //    anim.SetBool("isRunning", true);
        //}
    }
}
