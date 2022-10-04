namespace Sharpy.Core.Processor
{
    public interface Rule<StateValue, ResultValue>
    {
        public ResultAndState<StateValue, ResultValue> Apply(State<StateValue, ResultValue> state);
    }
}
