using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTimer;
        private DateTime _stopTimer;
        private TimeSpan _duration;
        private bool _isStarted = false;

        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public void Start()
        {
            if (!_isStarted)
            {
                _startTimer = DateTime.UtcNow;
                Duration = _startTimer.TimeOfDay;
                _isStarted = true;
            } else
            {
                throw new InvalidOperationException("You must stop before starting the timer again.\n");
            }
        }

        public TimeSpan Stop()
        {
            if (_isStarted)
            {
                _stopTimer = DateTime.UtcNow;
                _isStarted = false;
            } else
            {
                throw new InvalidOperationException("Timer isn't started.\n");
            }
            return Duration = _stopTimer.Subtract(_startTimer);
        }
    }
}
