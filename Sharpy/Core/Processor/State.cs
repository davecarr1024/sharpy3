namespace Sharpy.Core.Processor
{
    public record class State<StateValue, ResultValue>
    {
        public Processor<StateValue, ResultValue> Processor { get; init; }

        public StateValue Value { get; init; }

        public State(Processor<StateValue, ResultValue> processor, StateValue value)
        {
            Processor = processor;
            Value = value;
        }
    }
}