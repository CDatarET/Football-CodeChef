using System;

public class Test
{
	public static void Main()
	{
	    int cases = int.Parse(Console.ReadLine());
	    for(int c = 0; c < cases; c++){
	        int l = int.Parse(Console.ReadLine());
	        string[] inputs = Console.ReadLine().Split();
	        int[] goals = Array.ConvertAll(inputs, int.Parse);
	        string[] inputs2 = Console.ReadLine().Split();
	        int[] fouls = Array.ConvertAll(inputs2, int.Parse);
	        
	        int[] scores = new int[l];
	        for(int i = 0; i < l; i++){
	            scores[i] = goals[i] * 20;
	            scores[i] = scores[i] - (fouls[i] * 10);
	            if(scores[i] < 0){
	                scores[i] = 0;
	            }
	        }
	        
	        int max = 0;
	        for(int i = 0; i < l; i++){
	            if(max <= scores[i]){
	                max = scores[i];
	            }
	        }
	        Console.WriteLine(max);
	    }
	}
}
