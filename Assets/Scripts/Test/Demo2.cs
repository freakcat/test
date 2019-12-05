using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo2 : MonoBehaviour
{
    private List<Demo2Item> itemList;
    private Demo2Item demoItem;
    // Start is called before the first frame update
    void Start()
    {
        itemList = new List<Demo2Item>();
        for (int index = 0; index < 500; index++)
        {
            GameObject  objectItem = new GameObject();
            objectItem.name = "item_" + index;
            demoItem = objectItem.AddComponent<Demo2Item>();
            demoItem.index = index;
            itemList.Add(demoItem);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
