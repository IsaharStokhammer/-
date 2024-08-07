using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace דיקשנרי
{
    public class Dict
    {
        private Dictionary<string, string> MyDict = new Dictionary<string, string>();

        public void Add(string key, string value) => MyDict.Add(key, value); 
        public void Remove(string key) => MyDict.Remove(key); 
        public void Update(string key, string Value) => MyDict[key] = Value;
        public string Get(string key) => MyDict[key];
    }
}

