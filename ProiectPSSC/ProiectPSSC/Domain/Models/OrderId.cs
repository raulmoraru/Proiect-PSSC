using System;

  namespace ProiectPSSC.Domain.Models
{
    public class OrderId
    {
        public static readonly Regex validCode= new validCode("^[0-6]{5}$");
        public string Value { get; }

        private OrderId(string value)
        {
            if(IsValid(value))
            {
                Value= value;
            }
            else
            {
                throw new InvalidOrderRegistrationNumberException("");
            }
        }
       
        private static bool IsValid(string stringValue)=> validCode.IsMatch(stringValue);

        public override string ToString()
        {
            return Value;
        }
    }
}
