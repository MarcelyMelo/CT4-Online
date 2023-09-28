using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
   Rigidbody2D rb;
   public float velocidade=5f; 
   BoxCollider2D verfim;
    void Start()
    {
    rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.velocity= new Vector2(velocidade, 0);
    }
    private void OnTriggerExit2D(Collider2D outroobjeto) {
        transform.localScale=new Vector2(-Mathf.Sign(rb.velocity.x), transform.localScale.y);

    if(outroobjeto.gameObject.CompareTag("Ground")){

    }
        }
}
