using System;

namespace ProiectPSSC.Domain.Models
{
    public class ItemName
    {
        public static readonly Regex validCode = new validCode("^[a-zA-Z]");
        public string ItemName { get; }
        public ItemName(string name)
        {
            if(IsValid(name))
            {
                ItemName= name;
            }
            else
            {
                throw new InvalidatedCustomerOrder("");
            }
           
        }

        private static bool IsValid(string stringValue)=> validCode.IsMatch(stringValue);

        public override string ToString()
        {
            return $"Item : {ItemName}";
        }
    }
}