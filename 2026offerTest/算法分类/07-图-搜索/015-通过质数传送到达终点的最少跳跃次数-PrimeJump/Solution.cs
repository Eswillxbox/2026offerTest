namespace _2026offerTest.算法分类._07_图_搜索;

public class PrimeNumJump
{
    private const int MAX_VAL = 1000001;
    
    public int MinJumps(int[] nums)
    {
        int n = nums.Length;
        if (n <= 1) return 0;
        
        bool[] isPrimeSieve = SieveOfEratosthenes(MAX_VAL);
        
        Dictionary<int, List<int>> primeToIndices = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            int val = nums[i];
            List<int> primeFactors = GetPrimeFactors(val, isPrimeSieve);
            
            foreach (int p in primeFactors)
            {
                if (!primeToIndices.ContainsKey(p))
                    primeToIndices[p] = new List<int>();
                primeToIndices[p].Add(i);
            }
        }
        
        bool[] visited = new bool[n];
        HashSet<int> usedPrimes = new HashSet<int>();
        Queue<int> q = new Queue<int>();
        
        q.Enqueue(0);
        visited[0] = true;
        int step = 0;
        
        while(q.Count > 0)
        { 
            int size = q.Count;
            for(int i=0; i<size; i++)
            {
                int pos = q.Dequeue();

                if (pos == n - 1) return step;

                if (pos - 1 >= 0 && !visited[pos - 1])
                {
                    visited[pos - 1] = true;
                    q.Enqueue(pos - 1);
                }
                if (pos + 1 < n && !visited[pos + 1])
                {
                    visited[pos + 1] = true;
                    q.Enqueue(pos + 1);
                }
                
                int currentVal = nums[pos];
                if (isPrimeSieve[currentVal])
                {
                    int p = currentVal;
                    if (!usedPrimes.Contains(p) && primeToIndices.ContainsKey(p))
                    {
                        foreach(int nextPos in primeToIndices[p])
                        {
                            if (!visited[nextPos])
                            {
                                visited[nextPos] = true;
                                q.Enqueue(nextPos);
                            }
                        }
                        usedPrimes.Add(p);
                    } 
                }
            }
            step++;
        }
        
        return -1;
    }
    
    private bool[] SieveOfEratosthenes(int max)
    {
        bool[] isPrime = new bool[max];
        for (int i = 2; i < max; i++)
            isPrime[i] = true;
        
        for (int i = 2; (long)i * i < max; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < max; j += i)
                    isPrime[j] = false;
            }
        }
        return isPrime;
    }
    // 获取一个数的质因数
    private List<int> GetPrimeFactors(int num, bool[] isPrime)
    {
        List<int> factors = new List<int>();
        if (num <= 1) return factors;
        
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0 && isPrime[i])
            {
                factors.Add(i);
                // 根据算术基本定理，任何大于1的整数都可以唯一分解为质因数的幂次乘积
                while (num % i == 0)
                    num /= i;
            }
        }
        if (num > 1 && isPrime[num])
            factors.Add(num);
        
        return factors;
    }
    
    public bool IsPrime(int num) 
    {
        if(num <= 1) return false;
        if(num == 2) return true;
        if(num % 2 == 0) return false;
        int limit= (int)Math.Sqrt(num);
        for(int i=3; i<= limit; i+=2)
            if(num % i == 0) return false;
        return true;
    }
}
