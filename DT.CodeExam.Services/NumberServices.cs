using DT.CodeExam.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Services
{
    public class NumberServices : INumberServices
    {
        public bool Ping()
        {
            return true;
        }

        public Response Spell(Request request)
        {
            var response = new Response();
            var number = new Number(request.Number);
            response.Name = request.Name;
            response.Number = number.Spell();
            return response;
        }
    }
}
