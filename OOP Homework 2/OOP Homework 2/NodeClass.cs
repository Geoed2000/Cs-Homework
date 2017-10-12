using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework_2
{
    class NodeClass
    {
        private string data;
        public string Data
        {
            set { data = value; }
            get { return data; }
        }

        public NodeClass(string inData)
        {
            data = inData;
        }
    }
}
