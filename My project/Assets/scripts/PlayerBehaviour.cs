using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{ 
    float velocidade=5.5f;  
    Rigidbody2D rb;
    void Start() 
    {
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movePlayer();    
    }
    void movePlayer()
    {    
    var horizontalinput=Input.GetAxisRaw("Horizontal");
    rb.velocity=new Vector2(horizontalinput*velocidade, rb.velocity.y);
     
    }
}
