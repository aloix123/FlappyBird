using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    
    void Start()
    {
        Debug.Log("działa");
    }
    public void LoadNextScene()
    {
        Debug.Log("hihih");
        // Get the current active scene
        SceneManager.LoadScene(1);

    }
}