using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource theme;
    Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        if(scene.name == "Menu")
        {
            theme.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
