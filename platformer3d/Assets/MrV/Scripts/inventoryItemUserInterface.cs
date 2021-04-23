using System;
using UnityEngine;
using UnityEngine.UI;

public class inventoryItemUserInterface : MonoBehaviour
{
    public Image icon;
    public Text label;
    public Action onClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void doTheThing()
    {
        onClick.Invoke();
    }
}