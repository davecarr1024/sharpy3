namespace Sharpy.Core.Processor
{
    public record class ResultAndState<StateValue, ResultValue>
    {
        public Result<ResultValue> Result { get; init; }

        public State<StateValue, ResultValue> State { get; init; }

        public ResultAndState(Result<ResultValue> result, State<StateValue, ResultValue> state)
        {
            Result = result;
            State = state;
        }
    }
}