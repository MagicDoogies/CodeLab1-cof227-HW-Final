using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPickup : MonoBehaviour
{
    public bool TriggerArea = false;

    public bool RedGem = false;
    public bool GreenGem = false;
    public bool PurpleGem = false;
    Scene scene;

    public static ItemPickup itemInstance;
    // Start is called before the first frame update
    void Start()
    {
       /* scene = SceneManager.GetActiveScene();

        //set up the singleton
        if (itemInstance == null)
        { //if instance isn't set
            itemInstance = this; //set it to this instance
            DontDestroyOnLoad(gameObject); //Don't destory this gameObject
        }
        else
        { //otherwise, if we have a singleton already
            Destroy(gameObject); //Destroy this instance
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerArea == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (scene.buildIndex == 0)
            {
                PurpleGem = true;
                print("Purple gem is picked up");
            }
            if (scene.buildIndex == 1)
            {
                GreenGem = true;
                print("Green gem is picked up");
            }
            if (scene.buildIndex == 2)
            {
                RedGem = true;
                print("Red gem is picked up");
            }
            print("I've been picked up");

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("You are in my radius");
        TriggerArea = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        print("You are out of my radius");
        TriggerArea = false;
    }
}
