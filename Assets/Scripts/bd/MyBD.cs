using System.Collections.Generic;
using System;
namespace Sufferinfo
{ 
    [Serializable]
    public class MyBD : BaseBD
    {
    
        private string pw;
        private string hospital;
        private bool sex;
        private int age;
        private int sicktype;

        public string Pw
        {
            get => pw;
            set => pw = value;
        }

        public string Hospital
        {
            get => hospital;
            set => hospital = value;
        }

        public bool Sex
        {
            get => sex;
            set => sex = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int Sicktype
        {
            get => sicktype;
            set => sicktype = value;
        }

        public List<Train> Trains = new List<Train>();
        public List<Estimate> Estimates = new List<Estimate>();
    }
    [Serializable]
    public class Train : BaseBD
    {
        private int level;
        private float scores;
        private float elapsedTime;
        private string anyDirection;
        private string partofbody;

        public int Level
        {
            get => level;
            set => level = value;
        }

        public float Scores
        {
            get => scores;
            set => scores = value;
        }

        public float ElapsedTime
        {
            get => elapsedTime;
            set => elapsedTime = value;
        }

        public string AnyDirection
        {
            get => anyDirection;
            set => anyDirection = value;
        }

        public string Partofbody
        {
            get => partofbody;
            set => partofbody = value;
        }
    }
    [Serializable]
    public class Estimate : BaseBD
    {
        private float scores;
        private string anyDirection;
        private string partofbody;

        public float Scores
        {
            get => scores;
            set => scores = value;
        }

        public string AnyDirection
        {
            get => anyDirection;
            set => anyDirection = value;
        }

        public string Partofbody
        {
            get => partofbody;
            set => partofbody = value;
        }
    }
 
  
    public abstract class BaseBD
    {
        private string uuid;
        private int number;
        private int id;
        private string name;
        private string date;
        private string doctor;
        private string describe;

        public string Uuid
        {
            get => uuid;
            set => uuid = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public string Doctor
        {
            get => doctor;
            set => doctor = value;
        }

        public string Describe
        {
            get => describe;
            set => describe = value;
        }
    }
}