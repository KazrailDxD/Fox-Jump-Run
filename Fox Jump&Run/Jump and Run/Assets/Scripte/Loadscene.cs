using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void LoadScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
        Time.timeScale =1.0f;
    }
}
