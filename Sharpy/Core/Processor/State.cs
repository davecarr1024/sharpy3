namespace Sharpy.Core.Processor
{
    public record class State<StateValue>
    {
        public Processor<StateValue> Processor { get; init; }

        public StateValue Value { get; init; }

        public State(Processor<StateValue> processor, StateValue value)
        {
            Processor = processor;
            Value = value;
        }
    }
}