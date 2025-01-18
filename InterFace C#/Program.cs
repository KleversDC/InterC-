namespace InterFace_C_
{
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    class Arrayqq : ICalc2
    {
        private int[] data;

        public Arrayqq(int[] data)
        {
            this.data = data;
        }

        public int CountDistinct()
        {
            return data.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return data.Count(x => x == valueToCompare);
        }

        public void Display()
        {
            Console.WriteLine("Array: " + string.Join(", ", data));
        }
    }


    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    class CustomArray : IOutput2
    {
        private int[] data;

        public CustomArray(int[] data)
        {
            this.data = data;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even values: " + string.Join(", ", Array.FindAll(data, x => x % 2 == 0)));
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd values: " + string.Join(", ", Array.FindAll(data, x => x % 2 != 0)));
        }

        public void Display()
        {
            Console.WriteLine("Array: " + string.Join(", ", data));
        }
    }



    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    class Arraycv : ICalc
    {
        private int[] data;

        public Arraycv(int[] data)
        {
            this.data = data;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int value in data)
            {
                if (value < valueToCompare)
                    count++;
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int value in data)
            {
                if (value > valueToCompare)
                    count++;
            }
            return count;
        }

        public void Display()
        {
            Console.WriteLine("Array: " + string.Join(", ", data));
        }
    }
    class Arrayop : ICalc, IOutput2, ICalc2
    {
        private int[] data;

        public Arrayop(int[] data)
        {
            this.data = data;
        }
        public int Less(int valueToCompare)
        {
            return data.Count(x => x < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return data.Count(x => x > valueToCompare);
        }
        public void ShowEven()
        {
            Console.WriteLine("Even values: " + string.Join(", ", data.Where(x => x % 2 == 0)));
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd values: " + string.Join(", ", data.Where(x => x % 2 != 0)));
        }
        public int CountDistinct()
        {
            return data.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return data.Count(x => x == valueToCompare);
        }

        public void Display()
        {
            Console.WriteLine("Array: " + string.Join(", ", data));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 3, 7, 9, 2, 2, 6, 8, 8 };
            Arrayop array = new Arrayop(numbers);

            array.Display();
            Console.WriteLine("Less than 5: " + array.Less(5));
            Console.WriteLine("Greater than 5: " + array.Greater(5));
            array.ShowEven();
            array.ShowOdd();
            Console.WriteLine("Count of distinct values: " + array.CountDistinct());
            Console.WriteLine("Count of values equal to 3: " + array.EqualToValue(3));
        }
    }

}
