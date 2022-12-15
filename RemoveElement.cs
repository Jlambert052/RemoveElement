namespace LeetCode {
    public class RemoveElement {
        public int  EmptyElement(int[] nums, int val) {
            var resnums= nums.ToList().Where(x => x != val).ToArray();
            Array.Clear(nums, 0, nums.Length);
            Array.Copy(resnums, nums, resnums.Length);
            foreach(int n in resnums) {
            System.Console.Write($" {n} ");
            }
            return resnums.Length;
        }
    }
}