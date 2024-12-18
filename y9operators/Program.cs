namespace y9operators
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 20;
			int y = 19;
			int z = 3;
			if (x <= y || z > y) {
				Console.WriteLine("hello :3");
			}
			else {
				Console.WriteLine("world (bug bug)");
			}
			Console.WriteLine("how tall are you,,,");
			int height = Console.ReadLine();
			Console.WriteLine("mkay, but how OLD are u ??");
			int age = Console.ReadLine();
			if (age < 11 || height < 140)
			{
				Console.WriteLine("sowwy, you can't come on :c");
			}
			else if (age > 11 && height < 140)
			{
				Console.WriteLine("old enough, bu ur too tiny :p");
			}
			else if (age < 11 && height > 140)
			{
				Console.WriteLine("awfully tall, but you can't come on :p");
			}
			else {
				Console.WriteLine("you may enter :3");
			}
		}
	}
}