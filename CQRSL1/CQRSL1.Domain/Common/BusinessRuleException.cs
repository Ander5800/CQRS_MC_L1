using System;

namespace CQRSL1
{
    public sealed class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message)
        {
        }
    }
}
