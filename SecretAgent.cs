using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace secretAgent
{
    public class SecretAgent
    {
        // instance variables
        private int ID;
        private string name;
        private string codename;
        private string lang1;
        private string lang2;

        //Constructor
        public SecretAgent(int ID, string name, string codename, string lang1, string lang2)
        {
            this.ID = ID;
            this.name = name;
            this.codename = codename;
            this.lang1 = lang1;
            this.lang2 = lang2;
        }


        // Get & set for ID
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        // Get & set for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Get & set for codename
        public string Codename
        {
            get { return codename; }
            set { codename = value; }
        }

        // Get & set for language
        public string Lang1
        {
            get { return lang1; }
            set { lang1 = value; }
        }
        // Get & set for language nummer 2
        public string Lang2
        {
            get { return lang2; }
            set { lang2 = value; }
        }

        //ToString
        public override string ToString()
        {
            return "Agent " + ID + "'s name is " + name + " codename is " + codename + " and speaks " + lang1 + " and " + lang2;
        }

    }
}