namespace _2026offerTest.习题集;

public class Q2CarPooling
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        if(trips.Length == 0)return true;
        int[] contain = new int[10001];

        foreach (var members in trips)
        {
            int membersCount = members[0];
            int from = members[1];
            int to = members[2];
            
            contain[from]+= membersCount;
            contain[to]-= membersCount;
        }

        int count = 0;
        for (int i = 0; i < 10001; i++)
        {
            count+=contain[i];
            if (count > capacity) return false;
        }
        return true;
    }
}