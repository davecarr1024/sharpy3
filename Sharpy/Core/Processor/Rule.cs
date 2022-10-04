namespace Sharpy.Core.Processor
{
    public interface Rule<StateValue>
    {
        public ResultAndState<StateValue> Apply(State<StateValue> state);
    }
}
