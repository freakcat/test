using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Demo : MonoBehaviour
{
    private List<DemoItem> itemList;

    void Awake()
    {
        this.itemList = new List<DemoItem>();

        GameObject objectItem = null;


        DemoItem demoItem = null;


        for (int index = 0; index < 500; index++)
        {
            objectItem = new GameObject();
            objectItem.name = "item_" + index;
            demoItem = objectItem.AddComponent<DemoItem>();
            demoItem.index = index;

            this.itemList.Add(demoItem);
        }

        this.StartCoroutine(this.AwakeEnumerator());
    }


    private IEnumerator AwakeEnumerator()
    {
        yield return new WaitForSeconds(1f);

        int length = this.itemList.Count;
        for (int index = 0; index < length; index++)
        {
            this.itemList[index].Init();
        }

        StringBuilder a = new StringBuilder();
        a.Append("aaa");
        a.Append("b");
        a.Append("x");
        a.Insert(2, "22");
         
        print(a.ToString());

    }
    void Update()
    {
       // FrameMgr.Run();
    }
}

