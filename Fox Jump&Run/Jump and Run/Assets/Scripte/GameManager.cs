using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player = null;
    [SerializeField] GameObject gameOverLayer = null;
    [SerializeField] GameObject menueOverLayer = null;
    private bool gameOver = false;
    private bool gamePaused = false;
    private bool menue = false;
    [SerializeField] AudioClip[] backgroundMusikClip = null;

    // Start is called before the first frame update
    void Start()
    {
        
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = backgroundMusikClip[Random.Range(0, backgroundMusikClip.Length)];
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null && !gameOver)
        {
            gameOver = true;
            gameOverLayer.SetActive(true);
           
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menue = !menue;
            if (menue)
            {
                menueOverLayer.SetActive(true);
            }
            else
            {
                menueOverLayer.SetActive(false);
            }
          
        }
       
       

        if (Input.GetKeyDown(KeyCode.P))
        {

            gamePaused = !gamePaused;

            if (gamePaused)
            {
                Time.timeScale = 0.0f;
            }
            else
            {
               
                Time.timeScale = 1.0f;
            }

        }
      
    }
}