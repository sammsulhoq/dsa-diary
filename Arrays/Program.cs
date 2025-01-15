namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            twoSum.Calculate();

            ThreeSum threeSum = new ThreeSum();
            threeSum.Calculate();

            SmallestNumberProductVariation1 smallestNumberProductVariation1 = new SmallestNumberProductVariation1();
            smallestNumberProductVariation1.Calculate();

            MajorityElement majorityElement = new MajorityElement();
            Console.WriteLine($"Majority element: {majorityElement.Find()}");
        }
    }
}
