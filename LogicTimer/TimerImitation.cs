using System;
using System.Threading;
namespace LogicTimer
{
	public class TimerImitation
	{
		public event EventHandler<TimerEventArgs> Timer = delegate { };
		/// <summary>
		/// New timer.
		/// </summary>
		/// <param name="time">Time.</param>
		/// <param name="message">Message.</param>
		public void NewTimer(int time, string message)
		{
			NewTimer(new TimerEventArgs(time, message));
		}
		private void NewTimer(TimerEventArgs timerEvent)
		{
			if (!ReferenceEquals(Timer, null))
			{
				Thread.Sleep(timerEvent.Time);
				Timer.Invoke(this, timerEvent);
			}
		}
	}

	public class TimerEventArgs : EventArgs
	{
		public int Time { get; }
		public string Message { get; }
		/// <summary>
		/// Initializes a new instance of the <see cref="T:LogicTimer.TimerEventArgs"/> class.
		/// </summary>
		/// <param name="time">Time.</param>
		/// <param name="message">Message.</param>
		public TimerEventArgs(int time, string message)
		{
			if (ValidInput(time, message))
			{
				Time = time;
				Message = message;
			}
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		/// <param name="time">Time.</param>
		/// <param name="message">Message.</param>
		private bool ValidInput(int time, string message)
		{
			if (time < 0) throw new ArgumentException($"{nameof(time)} is invalid.");
			if (ReferenceEquals(message, null)) throw new ArgumentNullException($"{nameof(message)} is null.");
			if (message.Length == 0) throw new ArgumentNullException($"{nameof(message)} is empty.");
			return true;
		}
	}
}
