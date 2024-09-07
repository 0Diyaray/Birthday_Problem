class Birthday_Problem
{
	static void Main()
	{
		Random random = new Random();
		List<(bool,bool)> classrooms_status = new List<(bool, bool)>();

		int classroom_size = 23; // Size of each classroom
		double iteration = 100000; // Classroom amount that will be produced for calculation.

		for (int i = 0; i < iteration; i++)
		{
			classrooms_status.Add(get_probability(classroom_size));
		}

		double classes_duplicate = classrooms_status.Count(x => x.Item1 == true);
		double classes_triplicate = classrooms_status.Count(x => x.Item2 == true);
		double perc_duplicate = classes_duplicate / iteration;
		double perc_triplicate = classes_triplicate / iteration;
		Console.WriteLine("Duplicate Percentage:" + perc_duplicate*100 + "%");
		Console.WriteLine("Triplicate Percentage:" + perc_triplicate * 100 + "%");
		(bool,bool) get_probability(int size)
		{
			List<int> classroom = new List<int>();
			bool isduplicate = false;
			bool istriplicate = false;
			for (int person = 0; person != size; person++)
			{
				int dayof_birth = random.Next(1, 366);
				classroom.Add(dayof_birth);
			}
			foreach (int persons_birthday in classroom)
			{
				if (classroom.Count(x => x == persons_birthday) > 1 && isduplicate == false)
				{
					isduplicate=true;
				}
				if (classroom.Count(x => x == persons_birthday) > 2 && istriplicate == false)
				{
					istriplicate=true;
				}
			}
			return (isduplicate,istriplicate);
		}
	}
}