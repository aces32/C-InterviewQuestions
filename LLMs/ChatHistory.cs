using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs
{
    public class ChatHistory<T> where T : struct
    {
        private readonly T _value;

        public ChatHistory(T value)
        {
            _value = value;
        }

        //public bool HasValue()
        //{

        //}
    }
}
