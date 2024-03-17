using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Lab1_Test"),
	InternalsVisibleTo("Lab1_GUI"),
	InternalsVisibleTo("TestProject1")]

namespace Lab1
{
	internal class KnapsackProblem
	{
		public int n;
		public int seed;
		public List<Item> items { get; set; }

		public KnapsackProblem(int n, int seed)
		{
			if(n == 0)
			{
				throw new ArgumentException("Value cannot be 0");
			}
			this.n = n;
			this.seed = seed;
			items = new List<Item>();

			Random random = new Random(seed);
			for(int i = 0; i < n; i++)
			{
				Item item = new Item(i, random.Next(1,11), random.Next(1,11));
				items.Add(item);
			}
        }

		public Result Solve(int capacity)
		{
			Result res = new Result();
			items.Sort(
				(item1, item2) =>
				item2.GetRatio().CompareTo(item1.GetRatio())
				);

			for(int i = 0; i < n; i++)
			{
				if (items[i].GetWeight() <= capacity)
				{
					res.Add(items[i]);
					capacity -= items[i].GetWeight();
				}
			}
			return res;
		}

		public void PrintItems()
		{
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine($"[ id: {items[i].GetId()}, v: {items[i].GetValue()}, w: {items[i].GetWeight()}, ratio: {items[i].GetRatio()} ]");
			}
		}

		public override String ToString()
		{
			String temp = new String("");
			
            for (int i = 0; i < n; i++)
            {
				temp += ("|id: " + items[i].GetId() + "|v: " + items[i].GetValue() + "|w: " + items[i].GetWeight() + "|ratio: " + items[i].GetRatio() + "|\r\n");
                
            }
            return temp;
		}
    }
}

