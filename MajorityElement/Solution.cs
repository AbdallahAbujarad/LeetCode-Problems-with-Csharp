public class Solution {
    public int MajorityElement(int[] nums) 
    {
       Dictionary<int,int> dict = new Dictionary<int,int>();
        int returnValue = 0;
       for(int i = 0 ; i < nums.Length ; i++)
       {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],1);
            }
            else
            {
                dict[nums[i]]++;
            }
       }
        foreach(var item in dict)
        {
            if(item.Value > nums.Length/2)
            {
                returnValue = item.Key;
            }
        }
            return returnValue;                
    }
}