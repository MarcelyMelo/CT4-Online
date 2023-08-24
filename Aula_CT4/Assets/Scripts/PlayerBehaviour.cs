using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    float velocidade = 5.5f;
    Rigidbody2D rb;
    float velocidadePulo = 5.5f;
    int quantidadeDePulos = 2;

    bool podePular;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        movePlayer();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(podePular == true && quantidadeDePulos > 0)
            pulo();
        }
        
    }

    void movePlayer()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalInput * velocidade, rb.velocity.y);
    }

    void pulo()
    {
        quantidadeDePulos = quantidadeDePulos -1;
        rb.velocity = new Vector2(0, velocidadePulo);
    }
    void OnCollisionEnter2D(Collision2D outroObjeto)
    {
        if(outroObjeto.gameObject.CompareTag("Ground"))
        {
            quantidadeDePulos = 2;
            podePular = true;
        }
    }
    void OnCollisionExit2D(Collision2D outroObjeto)
    {
        if(outroObjeto.gameObject.CompareTag("Ground"))
        {
            if(quantidadeDePulos == 0)
            {
                podePular = false;
                }
        }
    }
}
