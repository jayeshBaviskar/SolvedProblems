using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSTF
{
    class CustomTask
    {
        string taskID;
        double arrival;
        double duration;
        double deadline;

        public string TaskID { get => taskID; set => taskID = value; }
        public double Arrival { get => arrival; set => arrival = value; }
        public double Duration { get => duration; set => duration = value; }
        public double Deadline { get => deadline; set => deadline = value; }
    }
}
