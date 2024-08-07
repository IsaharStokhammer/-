using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace דיקשנרי
{
    public class QueueData
    {
        private Queue<string> MyQ = new Queue<string>();

        public void Dequeue() => MyQ.Dequeue();
        public void Enqueue(string Value) => MyQ.Enqueue(Value);
        public string peek() => MyQ.Peek();
    }
}
