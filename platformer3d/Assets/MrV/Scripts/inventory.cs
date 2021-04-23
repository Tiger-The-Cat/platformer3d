using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public class item
    {
        string name;
        int number;
        bool stackable;
    }
    public List<itemPickupable> inventoryList;
    public Transform inventoryUIArea;
    public GameObject basicInventoryItem;

    // Start is called before the first frame update
    void Start()
    {
        basicInventoryItem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(itemPickupable item) {
        inventoryList.Add(item);
        GameObject inv = Instantiate(basicInventoryItem);
        inventoryItemUserInterface itemUI = inv.GetComponent<inventoryItemUserInterface>();
        itemUI.label.text = item.name;
        itemUI.transform.SetParent(inventoryUIArea);
        itemUI.onClick = () => {
            item.gameObject.SetActive(true);
            item.transform.SetParent(null);
            Destroy(itemUI.gameObject);
        };
        itemUI.gameObject.SetActive(true);
    }
}
