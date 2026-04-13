namespace _2026offerTest.习题集;

public class Q1MoveZero 
{
    public void MoveZeroes(int[] nums) 
    {
        for(int i=0;i<=nums.Length-1;i++)
        {
            if(nums[i]==0)
            {
                int notZero=0;
                int firstNum=0;
                int firstIndex=0;
                for(int j = i+1;j<=nums.Length-1;j++)
                {
                    if(nums[j]!=0)
                    {
                        notZero++;
                        firstNum=nums[j];
                        firstIndex=j;
                        break;
                    }
                }
                if(notZero==0)break;
                int temp = nums[i];
                nums[i] = firstNum;
                nums[firstIndex] = temp;
            }
        }
    }
}