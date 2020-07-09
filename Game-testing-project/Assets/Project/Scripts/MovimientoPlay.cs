using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlay : MonoBehaviour
{
    // Start is called before the first frame update

    RigidBody2D Personaje;

    [SerializeField]
    public float caminar=2;
    public float saltar=3;
    public bool MejorSalto = false;
    public float fallMultiplayer = 0.5f;
    public float lowmultiplayer = 1f;
    
    void Start()
    {
        Personaje = GetComponent<RigidBody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Personaje.velocity = new Vector2(caminar, Personaje.velocity.y);
        }
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            Personaje.velocity = new Vector2(-caminar, Personaje.velocity.y);
        }
        else
        {
            Personaje.velocity = new Vector2(0, Personaje.velocity.y);
        }
        //falta incluirla condicion de salto
        if (Input.GetKey("space"))
        {
            Personaje.velocity = new Vector2(Personaje.velocity.x, saltar);
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