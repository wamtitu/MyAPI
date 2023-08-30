using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Responses
{
    public class MessageSucces
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public MessageSucces(int c , string m)
        {
            this.Code = c;
            this.Message = m;
        }
    }
}