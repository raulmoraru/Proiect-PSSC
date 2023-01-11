using System;

namespace ProiectPSSC.Domain.Models
{
    public class CustomerName
    {
        public static readonly Regex validCode = new validCode("^[a-zA-Z]");
        public string CustomerName { get; }
        public CustomerName(string name)
        {
            if(IsValid(name))
            {
                CustomerName= name;
            }
            else
            {
                throw new InvalidatedCustomerOrder("");
            }
           
        }

        private static bool IsValid(string stringValue)=> validCode.IsMatch(stringValue);

        public override string ToString()
        {
            return $"Customer name : {CustomerName}";
        }
    }
}