class Problem()
{
	static void Main()
	{
		Random random = new Random();
		List<bool> all = new List<bool>();

		int classroom_size = 23; // Size of each classrooms
		double iteration = 10000; // Classroom amount that will be produced for calculation.

		for (int i = 0; i < iteration; i++)
		{
			all.Add(get_probability(classroom_size));
		}

		double percup = all.Count(x => x == true);
		double perdown = all.Count(x => x == false);
		double perc = percup / iteration;
		Console.WriteLine(perc*100 + "%");

		bool get_probability(int x)
		{
			List<int> classroom = new List<int>();
			bool checkd = false;
			for (int i = 0; i != x; i++)
			{
				int no = random.Next(1, 366);
				classroom.Add(no);
			}
			foreach (int i in classroom)
			{
				if (classroom.Count(x => x == i) > 1 && checkd == false)
				{
					return true;
				}
			}
			return checkd;
		}
	}
}