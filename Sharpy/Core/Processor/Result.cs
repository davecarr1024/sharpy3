namespace Sharpy.Core.Processor
{
    public interface Result<ValueType>
    {
        ValueType Evaluate();
    }
}