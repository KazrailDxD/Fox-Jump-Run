using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMove : MonoBehaviour
{

    [SerializeField] float moveSpeed = 3.5f;    //Geschwindigkeit vom Spieler festlegen
    [SerializeField] float jumphigh = 10f;      //die Sprungkraft/höhe bestimmen 
    private Rigidbody2D p_Rigidbody2D;
    public bool isGrounded = true;              //Untergrund überprüfung 
    SpriteRenderer face = null;                 //Gesichtsrichtung ändern
    public int gemAmount;
    public Text scoreText;
    Animator animator = null;
    
    // Start is called before the first frame update
    void Start()
    {
        gemAmount = 0;
        p_Rigidbody2D = GetComponent<Rigidbody2D>();
        face = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
                
        transform.position += moveDirection *moveSpeed * Time.deltaTime;
        
        //Die Gesichtsrichtung ändern vom Spielercharakter 
        if (moveDirection.x < 0)
        {
            face.flipX = true;
        }
        else
        {
            face.flipX = false;
        }

        animator.SetFloat("Run", Mathf.Abs(moveDirection.x));
       
    }
    

    void Jump()
    {
        if (Input.GetButtonDown("Jump")&&  isGrounded == true)
        {
            
            p_Rigidbody2D.AddForce(new Vector2(0f, jumphigh),ForceMode2D.Impulse);
            AudioSource jumpaudio = GetComponent<AudioSource>();
            jumpaudio.Play();
        }

            animator.SetBool("IsJumping", !isGrounded);
        
    }

  void OnCollisionEnter2D(Collision2D other)
    {
        

            if (other.collider.tag == "Gem")
            {
                // Den Sprit Renderer und BoxColider Ausschalten
                other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                other.gameObject.GetComponent<BoxCollider2D>().enabled = false;

                //Sound der Kristalle
                AudioSource gemAudio = other.gameObject.GetComponent<AudioSource>();
                gemAudio.Play();

                gemAmount += 1;
                Destroy(other.gameObject, gemAudio.clip.length);
                scoreText.text = "" + gemAmount.ToString();

            }
      
    }
   
}
