using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReverseService" in both code and config file together.
    [ServiceContract]
    public interface IReverseService
    {
        [OperationContract]
        string ReverseWord(string word);
    }
}
