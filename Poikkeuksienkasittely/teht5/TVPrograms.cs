using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class TVPrograms
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Info { get; set; }

        public TVPrograms (string name, string channel, string startTime, string endTime, string info)
        {
            Name = name;
            Channel = channel;
            StartTime = startTime;
            EndTime = endTime;
            Info = info;
        }
    }

}
