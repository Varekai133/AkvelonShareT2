using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    public class Timer
    {
        Stopwatch timer;

        public Timer()
        {

        }

        public Timer (Stopwatch timer)
        {
            this.timer = timer;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Reset()
        {
            timer.Reset();
        }

        public long GetTime()
        {
            return timer.ElapsedMilliseconds;
        }
        
    }
}
