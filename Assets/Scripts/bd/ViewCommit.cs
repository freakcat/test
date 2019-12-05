using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewCommit : MonoBehaviour
{

    public static ViewCommit Vc;
    
    public delegate string MyClick(string name);

    public event MyClick Cclick;
 
    public InputField iputName;

    public Button createBtn;

    public Text showName;

    private void Awake()
    {
        if (Vc == null) Vc = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        iputName = transform.Find("iputName").GetComponent<InputField>();
        createBtn = transform.Find("createBtn").GetComponent<Button>();
        showName = transform.Find("showName").GetComponent<Text>();
        createBtn.onClick.AddListener(Click);
    }

    private void Click()
    {
        showName.text = Cclick?.Invoke(iputName.text);
    }
}
