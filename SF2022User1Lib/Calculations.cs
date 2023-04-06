using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User1Lib
{
    public class Calculations
    {

        public List<string> AvaliablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingtime, int consultationTime)
        {
            List<string> result = new List<string>();
            Dictionary<TimeSpan, TimeSpan> data = new Dictionary<TimeSpan, TimeSpan>();

            TimeSpan consultation = new TimeSpan(0, consultationTime, 0);
            TimeSpan time = beginWorkingTime;
            var j = 0;


            
            while(time < endWorkingtime)
            {
                TimeSpan end = time + consultation;
                TimeSpan duration = new(0, durations[j], 0);

               
                if (end > startTimes[j])
                {
                    time = startTimes[j] + duration;
                    j++;
                    continue;
                }


               
                result.Add(time.ToString() + "-" + end.ToString());

            }

            return result;
        }
    }
}
