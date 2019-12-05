using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostionTest : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - transform.position.z > 0)
        {
            if (Mathf.Abs(player.position.z - transform.position.z) > 9)
                print("player is on the right of obj");
        }

        if (player.position.z - transform.position.z < 0)
        {
            if (Mathf.Abs(player.position.z - transform.position.z) > 15)
                print("player is on the left of obj");
        }
    }

    private void OnGUI()
    {
        GUIStyle g = new GUIStyle();
            g.fontSize = 100;

        GUI.Button(new Rect(0f, 0f, 300f, 150f), "Z距离：" + Mathf.Abs(player.position.z - transform.position.z),
            g);
    }
}