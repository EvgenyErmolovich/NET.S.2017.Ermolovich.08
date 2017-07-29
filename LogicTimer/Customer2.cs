using System;
namespace LogicTimer
{
	public class Customer2
	{
		/// <summary>
		/// Register the specified timer.
		/// </summary>
		/// <returns>The register.</returns>
		/// <param name="timer">Timer.</param>
		public void Register(TimerImitation timer) => timer.Timer += Customer2Timer;
		/// <summary>
		/// Unregister the specified timer.
		/// </summary>
		/// <returns>The unregister.</returns>
		/// <param name="timer">Timer.</param>
		public void Unregister(TimerImitation timer) => timer.Timer -= Customer2Timer;
		/// <summary>
		/// Customers timer.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void Customer2Timer(object sender, TimerEventArgs e)
		{
			Console.WriteLine($"time: {e.Time}, message: {e.Message}");
		}
	}
}
