using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }


    private void OnTriggerStay2D(Collider2D collision)
     {
         if (collision.tag == "Grounded")
         {
             Player.GetComponent<PlayerMove>().isGrounded = true;
         }
     }


     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision/*.collider*/.tag == "Grounded")
         {
             Player.GetComponent<PlayerMove>().isGrounded = true;
         }
     }

     private void OnTriggerExit2D(Collider2D collision)
     {
         if (collision./*collider.*/tag == "Grounded")
         {
             Player.GetComponent<PlayerMove>().isGrounded = false;
         }
     }
  
    
}
