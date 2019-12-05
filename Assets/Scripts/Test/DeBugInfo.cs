using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DeBugInfo(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developer = dev;
        this.lastReview = d;
    }

    public int BugNo
    {
        get
        {
            return bugNo;
        }
    }
    public string Developer
    {
        get
        {
            return developer;
        }
    }
    public string LastReview
    {
        get
        {
            return lastReview;
        }
    }
    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}




[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
class Rectangle
{
    // 成员变量
    protected double length;
    protected double width;
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    [DeBugInfo(55, "Zara Ali", "19/10/2012",
        Message = "Return type mismatch")]
    public double GetArea()
    {
        return length * width;
    }
    [DeBugInfo(56, "Zara Ali", "19/10/2012")]
    public void Display()
    {  
        Debug.Log("Length: {0}"+length);
        Debug.Log("Width: {0}"+width);
        Debug.Log("Area: {0}"+GetArea());
    }
}