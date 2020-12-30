using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.Model
{
    public class ResultStatus<T>
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public T Object { get; set; }
    }
}
