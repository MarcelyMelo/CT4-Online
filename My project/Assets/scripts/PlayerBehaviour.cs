using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{ 
    float velocidade=5.5f;  
    Rigidbody2D rb;
    float velocidadedopulo=5.5f;
    int quantidadedepulos=3;
    bool podepular;
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movePlayer();   
     if(Input.GetKeyDown(KeyCode.Space))
     {
     if(podepular==true && quantidadedepulos>0) 
        pulo();
     }    
    }
    void movePlayer()
    {    
    var horizontalinput=Input.GetAxisRaw("Horizontal");
    rb.velocity=new Vector2(horizontalinput*velocidade, rb.velocity.y);
     
    }
    void pulo()
    {
     quantidadedepulos=quantidadedepulos-1;   
     rb.velocity=new Vector2(0, velocidadedopulo); 
    }
    void OnCollisionEnter2D(Collision2D outroobjeto)
    {
            if(outroobjeto.gameObject.CompareTag("Ground"))
            {
                quantidadedepulos=3;
                podepular=true;
            } 
    } 
    void onCollisionExit2D(Collision2D outroobjeto)
    {
        if(outroobjeto.gameObject.CompareTag("Ground"))
        {
        if(quantidadedepulos==0)
        {
        podepular=false;
        }
        }
    }

private void OnTriggerEnter2D(Collider2D outroobjeto) 
{
    if(outroobjeto.gameObject.tag=="Coin")
    {
        Destroy(outroobjeto.gameObject);

    }
}


}
