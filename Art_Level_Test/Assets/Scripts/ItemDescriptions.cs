using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptions : MonoBehaviour
{
    public Text changingText;

    public GameObject Item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(ItemPickup.itemInstance.PurpleGem == true)
        {
            changingText.text = "This gem is Purple!";
        }
    }


}
