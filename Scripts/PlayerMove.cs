using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;
    public Animator animator;

    public AudioSource audioSource;  // Asigna tu AudioSource en el Inspector
    
   
    private float x, y;


    public Rigidbody rb;
    public float jump = 3;

    public Transform groundcheck;
    public float groundDistance = 0.1f;
    public LayerMask grounfMask;

    bool isGrounded;

    void Update()
    {
        // Obtener las entradas del jugador

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        // Movimiento y rotación

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);

        //  parámetros de movimiento en el Animator


        animator.SetFloat("VeX", x);
        animator.SetFloat("VeY", y);

        // Activar animación de baile 
        if (Input.GetKey("b"))
        {   
            animator.SetBool("baile",false);
            animator.Play("dance");  
              
        }

         //activar animacion de golpe

          if (Input.GetKey("m"))
        {   
            animator.SetBool("golpe",false);
            animator.Play("punch");  
              
        }


        

        if (x>0 || x<0 || y>0 || y<0)
        {

            animator.SetBool("baile",true);
            animator.SetBool("golpe",true);
            animator.SetBool("salto",true);
            
        }

        isGrounded = Physics.CheckSphere(groundcheck.position,groundDistance,grounfMask);
        // activar animacion de salto
        if (Input.GetKey("space") && isGrounded)
        {
            animator.Play("Jump up");
            rb.AddForce(Vector3.up*jump,ForceMode.Impulse);
        }
       
    }
}