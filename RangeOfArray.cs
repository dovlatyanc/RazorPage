namespace RazorPage
{
    public class RangeOfArray
    {
        private int[] array;
        public int LowerBound { get; }
        public int UpperBound { get; }

        public RangeOfArray(int lower, int upper)
        {
            if (lower > upper) throw new ArgumentException("Нижняя граница должна быть меньше верхней.");
            LowerBound = lower;
            UpperBound = upper;
            array = new int[upper - lower + 1];
        }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return array[index - LowerBound];
            }
            set
            {
                ValidateIndex(index);
                array[index - LowerBound] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < LowerBound || index > UpperBound)
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
        }
    }
}
