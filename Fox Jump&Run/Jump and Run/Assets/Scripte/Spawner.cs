using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Enemiesspawn = null;
    [SerializeField] float spawnTimer = 3f;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
       if(time <= 0.0f)
       {
            time = spawnTimer;
                                   
            Instantiate(Enemiesspawn,transform.position,transform.rotation);
       }
    }
}
