using System;
namespace Lab1
{
	public class Result
	{
		int total_value;
		int total_weight { get; set; }
		List<int> items;

		public Result()
		{
			total_value = 0;
			total_weight = 0;
			items = new List<int>();

		}

		public void Add(Item item)
		{
			items.Add(item.GetId());
			total_value += item.GetValue();
			total_weight += item.GetWeight();
		}

		public List<int> GetItems() { return items; }
		public int GetTotalVal() { return total_value; }
		public int GetTotalWeight() { return total_weight; }

		public void PrintResultList()
		{
			Console.Write("IDs:");
			items.ForEach(Console.Write);
			Console.Write("\n");

			Console.WriteLine($"total_weight: {total_weight}");
			Console.WriteLine($"total_value: {total_value}");
		}

        public override string ToString()
        {
			String temp = new String("");
			foreach (int i in items) { temp += (i.ToString() + "\r\n"); };
			return temp;
        }
    }
}

