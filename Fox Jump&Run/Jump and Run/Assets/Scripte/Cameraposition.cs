using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cameraposition : MonoBehaviour
{
    [SerializeField] Vector3 offset = Vector3.zero; 
    [SerializeField] Transform player =null;
    Vector3 cameraposition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
       
       
        
    }

    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {
            cameraposition = player.position;
            cameraposition.y = 0f;
            cameraposition.z = -10f;
            transform.position = cameraposition + offset;
        }
       
    }
   
}
