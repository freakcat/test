#if UNITY_5_3_OR_NEWER
#define DEBUG
#endif

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;
 
using  TestAttribute;
public class CSharpTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//        Message(new []{"ni","hao","ma"});
//        Message("gun");
// 

        #region 反射 特性

        #region 遍历类的方法名

        foreach (var m in typeof(CSharpTest).GetMethods())
        {
            //
            // print(m.Name);
        }

        #endregion

        #region 遍历 Rectangle 类的特性

        foreach (var attribute in typeof(Rectangle).GetCustomAttributes(false))
        {
            DeBugInfo dbi = (DeBugInfo) attribute;
            print(dbi.Developer);
        }

        #endregion

        #region 遍历方法的特性

        foreach (var method in typeof(Rectangle).GetMethods())
        {
            foreach (var attribute in method.GetCustomAttributes())
            {
                DeBugInfo deBugInfo = (DeBugInfo) attribute;
                print(deBugInfo.BugNo);
            }
        }

        #endregion
        
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
    }


    [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
    public static void Message(string msg)
    {
        print(string.Format("what:{0}", msg));
    }

    [Conditional("DEBUG")]
    public static void Message(string[] msg)
    {
        File.WriteAllLines(Application.dataPath + "/test.txt", msg);

        foreach (var m in msg)
        {
            print(string.Format("what:{0}{1}", m, "\n"));
        }
    }
}