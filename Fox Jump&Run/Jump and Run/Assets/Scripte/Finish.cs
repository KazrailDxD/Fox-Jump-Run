using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
   [SerializeField] GameObject GameFinishOverLayer = null;
   [SerializeField] PlayerMove gem_Playermove =null;
   [SerializeField] GameObject GemcheckOverLayer = null;  
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {

            if (gem_Playermove.gemAmount >=8)
            {
                GameFinishOverLayer.SetActive(true);
                AudioSource finishsound = GetComponent<AudioSource>();
                finishsound.Play();
                Time.timeScale = 0.0f;
            }
            else
            {
                GemcheckOverLayer.SetActive(true);
                Time.timeScale = 1.0f;
            }

           

        }
        
       
    }

}
