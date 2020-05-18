using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryList : MonoBehaviour
{
    public bool active = false;

    public Text inventory;
    public GameObject Player;
    

    public GameObject inventoryWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             
        if (Input.GetKeyDown(KeyCode.E) && active == false)
        {
            active = true;

            if (active == true)
            {
                ToggleInventoryOn();
            }
        }

        if (Input.GetKeyUp(KeyCode.E) && active == true)
        {
            active = false;

            if (active == false)
            {
                ToggleInventoryOff();
            }
        }

        void ToggleInventoryOn()
        {
            inventoryWindow.SetActive(true);
        }

        void ToggleInventoryOff()
        {
            inventoryWindow.SetActive(false);
        }
    }
}
