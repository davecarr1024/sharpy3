namespace Sharpy.Core.Errors
{
    public class Error : Exception
    {
        public Error(string message) : base(message) { }

        protected Error() : base() { }

        public override bool Equals(object? obj)
        {
            return obj is Error error && Message == error.Message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Message);
        }
    }
}