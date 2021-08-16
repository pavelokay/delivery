using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Models.Account
{
    public class RegisterResultModel
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
