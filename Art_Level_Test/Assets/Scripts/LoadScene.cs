using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private bool EnterTrigger = false;
    

    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && EnterTrigger == true)
        {
            print("My trigger has been activated");
            if (scene.buildIndex == 0)
            {
                SceneManager.LoadScene("Room2");
            }

            if(scene.buildIndex ==1)
            {
                SceneManager.LoadScene("Room3");
            }
            if(scene.buildIndex ==2)
            {
                SceneManager.LoadScene("Room1");
            }
            
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        EnterTrigger = true;
    }
}
