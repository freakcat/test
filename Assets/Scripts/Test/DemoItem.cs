using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoItem : MonoBehaviour
{
    public int index;

    public void Init()
    {
        FrameMgr.Register(this, this.UpdateCallback);
    }

    private void UpdateCallback()
    {
        print("this is my name:"+name);
        // 处理一些事情等同于 Update! 
    }
    
    
}