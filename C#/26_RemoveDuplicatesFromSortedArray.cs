public class Solution {
     public int RemoveDuplicates(int[] arr){
        if (arr.Length == 0)
            return 0;
        
        int j=0;
 
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i] != arr[i + 1]) arr[j++] = arr[i];
            
        arr[j++] = arr[arr.Length-1] ;

        
        return j;
     
        }
}

