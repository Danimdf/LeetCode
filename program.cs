class Program
{
    static void Main(string[] args)
    {
        HashMap hash = new HashMap();
        int[] nums = {3,2,3};
        int target = 6;
        int[] solution = hash.TwoSum(nums, target);
        foreach(var sol in solution)
        {
            Console.WriteLine(sol);
        }
    }
}