using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameMgr
{
  public static Dictionary<object, FrameUpdate> frameList = new Dictionary<object, FrameUpdate>();

  /// <summary>
  /// 调用函数1 @$ @" v4 g! `$ U! a, a
  /// </summary>2 ^' N& q" x8 [# t
  public static void Run()
  {
    FrameUpdate[] objectList = new FrameUpdate[frameList.Values.Count];
    frameList.Values.CopyTo(objectList, 0);

    // 锁定
    foreach (FrameUpdate frameItem in objectList)
    {
      if (frameItem != null) frameItem.Update();
    }
  }
  /// <summary>
  /// 注册帧管理器) M/ n0 {7 G. o8 ?( ^6 g0 p
  /// </summary>6 r- _1 s9 a, C# f/ e- Y" E
  /// <param name="objectItem">Object item.</param>
  /// <param name="callback">Callback.</param>* }+ r! K1 I3 b8 l. g& m6 R+ N2 r
  public static void Register(object objectItem, Action callback = null)
  {
    if (!frameList.ContainsKey(objectItem))
    {
      FrameUpdate frameItem = new FrameUpdate(callback);
      frameList.Add(objectItem, frameItem);
    }
  }

  /// <summary>  A% u% o( r3 A! }  J% b6 }! P( u
  /// 取消注册帧管理器1 y  m9 @3 y3 }3 K
  /// </summary>" y6 G1 w* R( E- `% z- k- j) k& a
  /// <param name="objectItem">Object item.</param>0 X. p, k; n7 J
  public static void UnRegister(object objectItem)
  {
    if (frameList.ContainsKey(objectItem)) frameList.Remove(objectItem);
  }

}
