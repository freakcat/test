using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameUpdate 
{
    private Action callback;
        
    /// <summary>
    /// 构造函数，必须实例化
    /// </summary>
    /// <param name="callback">Callback.</param>! Q2 V, S  s* _6 f
    public FrameUpdate(Action callback) 
    {
        this.callback = callback; 
    }
 
    /// <summary># ?- `$ ~2 [( _, ]! N
    /// 帧管理器- P* M8 l, B! s. n$ {
    /// </summary>0 n$ A& d9 R1 t' x7 Y& o! m
    /// <param name="callback">Callback.</param>
    public virtual void Update()
    {
        this.callback();
    } 
}
