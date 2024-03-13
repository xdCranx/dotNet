using System;
namespace Lab1
{
	public class Item
	{
		int id;
		int weight;
		int value;
		float ratio;

		public Item(int i, int w, int v)
		{
			id = i;
			weight = w;
			value = v;
			ratio = (float)value/(float)weight;
		}
		public int GetId() { return id < 0 ? throw new Exception(): id; }
		public int GetValue() { return value; }
		public float GetRatio() { return ratio; }
		public int GetWeight() { return weight; }
	}
}

