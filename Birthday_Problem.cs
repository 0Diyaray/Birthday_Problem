class Birthday_Problem
{
	static void Main()
	{
		Random random = new Random();
		List<bool> classrooms_status = new List<bool>();

		int classroom_size = 23; // Size of each classroom
		double iteration = 100000; // Classroom amount that will be produced for calculation.
		int howmany = 2; // How many person must be the same age

		for (int i = 0; i < iteration; i++)
		{
			classrooms_status.Add(Create_Check(classroom_size,howmany));
		}

		double classes_howmany = classrooms_status.Count(x => x == true);
		double perc_howmany = classes_howmany / iteration;
		Console.WriteLine("Percentage:" + perc_howmany * 100+ "%");
		bool Create_Check(int size,int howmany)
		{
			List<int> classroom = new List<int>();
			bool isproper = false;
			for (int person = 0; person != size; person++)
			{
				int dayof_birth = random.Next(1, 366);
				classroom.Add(dayof_birth);
			}
			foreach (int persons_birthday in classroom)
			{
				if (classroom.Count(x => x == persons_birthday) > howmany-1 && isproper == false)
				{
					return true;
				}
			}
			return isproper;
		}
	}
}