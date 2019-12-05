using System.Collections.Generic;
using System;

namespace Sufferinfo
{
    [Serializable]
    public class MyBD : BaseBD
    {
        public string uuid;
        public string pw;
        public string hospital;
        public bool sex;
        public int age;
        public int sicktype;

        public List<Train> Trains = new List<Train>();
        public List<Estimate> Estimates = new List<Estimate>();
    }

    [Serializable]
    public class Train : BaseBD
    {
        public int level;
        public float scores;
        public float elapsedTime;
        public string anyDirection;
        public string partofbody;
    }

    [Serializable]
    public class Estimate : BaseBD
    {
        public float scores;
        public string anyDirection;
        public string partofbody;
    }
 
    public abstract class BaseBD
    {
        public int number;
        public int id;
        public string name;
        public string date;
        public string doctor;
        public string describe;
    }
}