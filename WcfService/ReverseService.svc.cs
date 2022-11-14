using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReverseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ReverseService.svc or ReverseService.svc.cs at the Solution Explorer and start debugging.
    public class ReverseService : IReverseService
    {
        public string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
