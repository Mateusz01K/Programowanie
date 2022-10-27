namespace lab2.nowy.lab2
{
    public class calculate
    {
        public calculate(int value)
        {
            Value = value;
        }

        private int Value { get; set; }

        public void Increase(int value)
        {
            Value += value;
        }

        public void Decrease(int value)
        {
            Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
