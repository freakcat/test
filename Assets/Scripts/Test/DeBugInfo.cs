using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestAttribute
{
    public class DeBugInfo : System.Attribute
    {
        private int _bugNo;
        private string _developer;
        private string _lastReview;
        private string message;

        public DeBugInfo(int bg, string dev, string d)
        {
            this._bugNo = bg;
            this._developer = dev;
            this._lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return _bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return _developer;
            }
        }
        public string LastReview
        {
            get
            {
                return _lastReview;
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
        protected double Length;
        protected double Width;
        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }
        [DeBugInfo(55, "Zara Ali", "19/10/2012",
            Message = "Return type mismatch")]
        public double GetArea()
        {
            return Length * Width;
        }
        [DeBugInfo(56, "Zara Ali", "19/10/2012")]
        public void Display()
        {  
            Debug.Log("Length: {0}"+Length);
            Debug.Log("Width: {0}"+Width);
            Debug.Log("Area: {0}"+GetArea());
        }
    }

}
