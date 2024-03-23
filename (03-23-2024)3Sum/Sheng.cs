public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
           if (nums == null || nums.Length <3)
    {
        return [];
    }

    List<int[]> temp = new List<int[]>();
   
    int zeros = 0;
    Dictionary<int,int> lessThanZero = new Dictionary<int,int>();
    Dictionary<int,int> largerThanZero= new Dictionary<int,int>();
  
   
    List<int> lessThanZeroArray= new ();
    List<int> largerThanZeroArray= new ();


    for (int i = 0; i < nums.Length; i++)
    {
      
        if (nums[i] == 0)
        {
            zeros++;
        }
        if (nums[i] > 0)
        {

            if (!largerThanZero.ContainsKey(nums[i]))
            {
                largerThanZero[nums[i]] = 1;
                largerThanZeroArray.Add(nums[i]);
            }
            else if (largerThanZero[nums[i]] == 1)
            {
                largerThanZero[nums[i]]++;
                largerThanZeroArray.Add(nums[i]);
            }
            //We do not need to care about more than 2 situation.
            
        }
        if (nums[i] < 0)
        {
            if (!lessThanZero.ContainsKey(nums[i]))
            {
                lessThanZero[nums[i]] = 1;
                lessThanZeroArray.Add(nums[i]);
            }
            else if (lessThanZero[nums[i]] == 1)
            {
                lessThanZero[nums[i]]++;
                lessThanZeroArray.Add(nums[i]);
            }
        }
        
    }

    if (zeros>=3 ) {
        var temporaryTriplet = new int[] { 0, 0, 0 };
        temp.Add(temporaryTriplet);
    }
    //if there are 2 zeros, we consider it as 1 zero, the others shoud be one is less than 0, one is bigger than 0
    if(zeros>0 )
    {
        foreach (var key in lessThanZero.Keys)
        {
            if (largerThanZero.ContainsKey(0 - key))
                {
                var temporary = new int[] { key,0,0-key };
                temp.Add(temporary);
            }
        }
    }
    //if no zero in the nums
  
        //two from right,one from left
        if (largerThanZeroArray.Count >= 2)
        {
        //get two of the right
        List<int> largeKeys = []; 
        //if there are duplicate number is it
        foreach (var key in largerThanZero.Keys)
        {
            if (largerThanZero[key] == 2)
            {
                if (lessThanZero.ContainsKey(0 - key - key))
                {
                    var temporary = new int[] { 0 - key - key, key, key };
                    temp.Add(temporary);
                }
            }
            
            largeKeys.Add(key);
            
        }

        // no duplicat key


            for(int i = 0;i < largeKeys.Count - 1;i++)
            {
                for (int j = i+1;j< largeKeys.Count; j++)
                {
                    if (lessThanZero.ContainsKey(0 - largeKeys[j] - largeKeys[i]))
                    {
                        var temporary = new int[]
                        {
                            largeKeys [j],largeKeys[i],0 - largeKeys[j] - largeKeys[i]
                        };
                        temp.Add(temporary);
                    }
                    
                }
            }
        }


        //find two from left, one from right
       
        if (lessThanZeroArray.Count >= 2)
        {
        //get two of the right
        //get two of the right
        List<int> lessKeys = [];
        //if there are duplicate number is it
        foreach (var key in lessThanZero.Keys)
        {
            if (lessThanZero[key] == 2)
            {
                if (largerThanZero.ContainsKey(0 - key - key))
                {
                    var temporary = new int[] { key, key , 0 - key - key};
                    temp.Add(temporary);
                }
            }

            lessKeys.Add(key);

        }

        // no duplicate key


        for (int i = 0; i < lessKeys.Count - 1; i++)
        {
            for (int j = i + 1; j < lessKeys.Count; j++)
            {
                if (largerThanZero.ContainsKey(0 - lessKeys[j] - lessKeys[i]))
                {
                    var temporary = new int[]
                    {
                            lessKeys [j],lessKeys[i],0 - lessKeys[j] - lessKeys[i]
                    };
                    temp.Add(temporary);
                }

            }
        }
    
}


    return temp.ToArray();
        
    }
}