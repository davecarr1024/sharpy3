namespace Sharpy.Core.Processor
{
    public record class ResultAndState<StateValue>
    {
        public Result Result { get; init; }

        public State<StateValue> State { get; init; }

        public ResultAndState(Result result, State<StateValue> state)
        {
            Result = result;
            State = state;
        }
    }
}