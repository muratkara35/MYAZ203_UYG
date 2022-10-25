using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAf_5
{
    public class Result
    {
        public Result(bool statu, string message)
        {
            Statu = statu;
            Message = message;
        }
        public  Result()
        {

        }

        public bool Statu { get; set; }
        public string Message { get; set; }
    }
}
