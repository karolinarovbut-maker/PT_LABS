using System;
using System.Linq;

namespace RangeTask
{
    public class Range
    {
        private int start;
        private int end;

        public int Start
        {
            get { return start; }
            set
            {
                if (value <= end)
                {
                    start = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Начало отрезка не может быть больше конца.");
                }
            }
        }

        public int End
        {
            get { return end; }
            set
            {
                if (value >= start)
                {
                    end = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Конец отрезка не может быть меньше начала.");
                }
            }
        }

        public Range(int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine("Предупреждение! Начало больше конца. Меняем местами.");
                this.start = end;
                this.end = start;
            }
            else
            {
                this.start = start;
                this.end = end;
            }
        }

        private static bool DoIntersect(Range a, Range b)
        {
            return !(a.end < b.start || b.end < a.start);
        }

        public static Range operator +(Range a, Range b)
        {
            if (!DoIntersect(a, b)) //если не пересекаются
            {
                throw new InvalidOperationException("Отрезки не пересекаются, объединение невозможно.");
            }

            int newStart = Math.Min(a.start, b.start);
            int newEnd = Math.Max(a.end, b.end);
            return new Range(newStart, newEnd);
        }

        public static Range operator -(Range a, Range b)
        {
            if (!DoIntersect(a, b)) //если не пересекаются
            {
                return new Range(0, 0); //возвращ пустой отрезок
            }

            int newStart = Math.Max(a.start, b.start);
            int newEnd = Math.Min(a.end, b.end);
            return new Range(newStart, newEnd);
        }

        public string ToString()
        {
            int[] numbers = Enumerable.Range(start, end - start + 1).ToArray();
            string numbersString = string.Join(", ", numbers);
            return $"Range ({start}, {end}), [{numbersString}]"; //возвращ строки
        }

        public bool Equals(object obj)
        {
            if (obj is Range other) //является ли объектом
            {
                return this.Length == other.Length; //сравнение 
            }
            return false;
        }

        public int GetHashCode()
        {
            return Length.GetHashCode();
        }

        public int Length
        {
            get { return end - start; }
        }
    }
}