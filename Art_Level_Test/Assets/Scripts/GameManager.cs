using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour //this script was going to be for a lot of things but now it's only purpose is to not delete the background music everytime the scene changes. 
{
    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        { //if instance isn't set
            instance = this; //set it to this instance
            DontDestroyOnLoad(gameObject); //Don't destory this gameObject
        }
        else
        { //otherwise, if we have a singleton already
            Destroy(gameObject); //Destroy this instance
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}