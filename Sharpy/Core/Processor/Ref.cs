namespace Sharpy.Core.Processor
{
    public class Ref<StateValue, ResultValue> : Rule<StateValue, ResultValue>
    {
        public string Name { get; init; }

        public Ref(string name) => Name = name;

        public ResultAndState<StateValue, ResultValue> Apply(State<StateValue, ResultValue> state) => state.Processor.Apply(Name, state);

        public override bool Equals(object? obj) => obj is Ref<StateValue, ResultValue> @ref && Name == @ref.Name;

        public override int GetHashCode() => HashCode.Combine(Name);
    }
}