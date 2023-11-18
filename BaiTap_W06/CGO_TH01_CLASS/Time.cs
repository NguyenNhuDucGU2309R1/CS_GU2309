using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TH01_CLASS
{
    public class Time
    {
        private DateTime startTime, endTime;

        public Time()
        {
            this.startTime = DateTime.Now;
        }
        public void Start() { this.startTime = DateTime.Now; }
        public void Stop() { this.endTime = DateTime.Now; }
        public DateTime StartTime { get => startTime; }
        public DateTime EndTime { get => endTime; }

        public void GetElapsedTime()
        {
            Console.WriteLine("Time run: {0}", endTime - startTime);
        }
    }
}
