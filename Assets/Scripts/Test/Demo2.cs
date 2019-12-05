using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo2 : MonoBehaviour
{
    private List<Demo2Item> _itemList;
    private Demo2Item _demoItem;
    // Start is called before the first frame update
    void Start()
    {
        _itemList = new List<Demo2Item>();
        for (int index = 0; index < 500; index++)
        {
            GameObject  objectItem = new GameObject();
            objectItem.name = "item_" + index;
            _demoItem = objectItem.AddComponent<Demo2Item>();
            _demoItem.index = index;
            _itemList.Add(_demoItem);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
