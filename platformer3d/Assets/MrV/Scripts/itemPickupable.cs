using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickupable : MonoBehaviour
{
    void pickUp(GameObject player)
    {
        inventory playerInventory = player.GetComponent<inventory>();
        //playerInventory.inventoryList.Add();
        //Destroy(transform.gameObject);
        gameObject.SetActive(false);
        transform.SetParent(player.transform);
        playerInventory.addItem(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            pickUp(other.gameObject);
        }

    }
}
