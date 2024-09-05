class Birthday_Problem()
{
	static void Main()
	{
		Random random = new Random();
		List<bool> classrooms_status = new List<bool>();

		int classroom_size = 23; // Size of each classroom
		double iteration = 100000; // Classroom amount that will be produced for calculation.

		for (int i = 0; i < iteration; i++)
		{
			classrooms_status.Add(get_probability(classroom_size));
		}

		double percup = classrooms_status.Count(x => x == true);
		double perdown = classrooms_status.Count(x => x == false);
		double perc = percup / iteration;
		Console.WriteLine("Percentage:" + perc*100 + "%");

		bool get_probability(int size)
		{
			List<int> classroom = new List<int>();
			bool isduplicate = false;
			for (int person = 0; person != size; person++)
			{
				int dayof_birth = random.Next(1, 366);
				classroom.Add(dayof_birth);
			}
			foreach (int persons_birthday in classroom)
			{
				if (classroom.Count(x => x == persons_birthday) > 1 && isduplicate == false)
				{
					return true;
				}
			}
			return isduplicate;
		}
	}
}