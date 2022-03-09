using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMainMenue : MonoBehaviour
{
    [SerializeField] AudioClip[] backgroundMusikClip = null;


    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioMainMenue = GetComponent<AudioSource>();
        audioMainMenue.clip = backgroundMusikClip[Random.Range(0, backgroundMusikClip.Length)];
        audioMainMenue.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
