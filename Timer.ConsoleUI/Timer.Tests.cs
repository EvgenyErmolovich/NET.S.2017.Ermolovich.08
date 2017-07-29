using System;
namespace LogicTimer.ConsoleUI
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Customer1 one = new Customer1();
			Customer2 two = new Customer2();
			TimerImitation timer = new TimerImitation();
			one.Register(timer);
            timer.NewTimer(100, "first");
            two.Register(timer);
			timer.NewTimer(500, "second");
            one.Unregister(timer);
		}
	}
}
