using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlay : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D Personaje;

    public float caminar=2;
    public float saltar=3;
    public bool MejorSalto = false;
    public float fallMultiplayer = 0.5f;
    public float lowMultiplayer = 1f;
    
    public SpriteRenderer spriterenderer;
    public Animator anima;
    void Start()
    {
        Personaje = GetComponent<Rigidbody2D>(); 
          
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Personaje.velocity = new Vector2(caminar, Personaje.velocity.y);
            spriterenderer.flipX = false; 
            anima.SetBool("Correr",true);
        }
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            Personaje.velocity = new Vector2(-caminar, Personaje.velocity.y);
            spriterenderer.flipX = true; 
            anima.SetBool("Correr",true);
        }
        else
        {
            Personaje.velocity = new Vector2(0, Personaje.velocity.y);
            anima.SetBool("Correr",false);
            anima.SetBool("Saltar",false);
        }
        //falta incluirla condicion de salto
        if (Input.GetKey("space") && Colided.suelover)
        {
            Personaje.velocity = new Vector2(Personaje.velocity.x, saltar);
            anima.SetBool("Saltar",true);
        }
        
        if (MejorSalto)
        {
            if (Personaje.velocity.y<0)
            {
                Personaje.velocity += Vector2.up * Physics.gravity.y * (fallMultiplayer)* Time.deltaTime;
            }
            if (Personaje.velocity.y>0 && !Input.GetKey("space"))
            {
                Personaje.velocity += Vector2.up * Physics.gravity.y * (lowMultiplayer)* Time.deltaTime;
            }
        }
    }
}