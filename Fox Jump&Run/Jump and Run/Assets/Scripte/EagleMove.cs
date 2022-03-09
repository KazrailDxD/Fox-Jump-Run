using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMove : MonoBehaviour
{
    
    Rigidbody2D rb = null;
    Vector2 egalemove = new Vector2(-1f, 0f);
    [SerializeField] float Egale_speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(egalemove.normalized * Egale_speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        
        if(collision.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}

   
    