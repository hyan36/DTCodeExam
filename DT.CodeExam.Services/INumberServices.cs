using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Services
{
    [ServiceContract]
    public interface INumberServices
    {
        [OperationContract]
        bool Ping();

        [OperationContract]
        Response Spell(Request request);
    }

    [DataContract]
    public class Request
    {
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public decimal Number { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Number { get; set; }
    }
}
