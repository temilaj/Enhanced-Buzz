using System;

namespace FizzBuzzLibrary
{
    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; set; }

        public T Maximum { get; set; }

        public override string ToString() { return String.Format("[{0} - {1}]", Minimum, Maximum); }

        public Boolean IsValid() { return Minimum.CompareTo(Maximum) <= 0; }

        public Boolean ContainsValue(T value)
        {
            return (Minimum.CompareTo(value) <= 0) && (value.CompareTo(Maximum) <= 0);
        }

        public Boolean IsInsideRange(Range<T> Range)
        {
            return this.IsValid() && Range.IsValid() && Range.ContainsValue(this.Minimum) && Range.ContainsValue(this.Maximum);
        }

        public Boolean ContainsRange(Range<T> Range)
        {
            return this.IsValid() && Range.IsValid() && this.ContainsValue(Range.Minimum) && this.ContainsValue(Range.Maximum);
        }
    }
}