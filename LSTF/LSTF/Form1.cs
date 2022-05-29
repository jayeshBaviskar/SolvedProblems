using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<CustomTask> tasks = new List<CustomTask>();
        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"D:\DS_Algo_Design\SolvedProblems\LSTF\LSTF\Input.txt";
            String[] contents = File.ReadAllLines(filename);
            for(int i=1; i< contents.Length; i++)
            {
                String record = contents[i];
                string[] parts =  record.Split(',');
                CustomTask task = new CustomTask();
                task.TaskID = parts[0];
                task.Arrival = Convert.ToDouble(parts[1]);
                task.Duration = Convert.ToDouble(parts[2]);
                task.Deadline = Convert.ToDouble(parts[3]);
                tasks.Add(task);
            }

            MessageBox.Show(tasks.Count + " records available");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double startTime = getStartTime();
            double endTime = getEndTime();
            double step = 0.0001;
            string exeData = "";
            string csv = "TaskID,StartTime,EndTime,RemainingExecution,Deadline\n";
            StringBuilder builder = new StringBuilder();
            builder.Append(csv);

            MessageBox.Show(startTime + " Starttime \n" + endTime + " endtime");
            ////String op = "";
            
            int batch = 10000;
            int batch_counter = 0;
            for(double i = startTime ; i<=endTime; i = Math.Round(i+step,4))
            {
                ++batch_counter;

                ////  op += "Time: " + i + "\n";
                exeData += "Time: " + i + "\n";

                double slackTime = Int32.MaxValue;
                CustomTask lowestSlackTime = null;

                foreach (var item in tasks)
                {
                    if(item.Duration == 0)
                    {
                        continue;
                    }
                    if(item.Arrival == i)
                    {
                        //// op += item.TaskID + " Arrived \n";
                    }

                    if (item.Arrival <= i) // Calculte Slack Time
                    {
                        double newslackTime = (item.Deadline - i - item.Duration);
                        newslackTime = Math.Round(newslackTime, 4);
                        ////  op +=  item.TaskID +  " SlackTime: " + newslackTime + "  (" + item.Deadline + "-" + 
                        //// i + "-" +  item.Duration+ ")\n";
                        if (newslackTime < slackTime)
                        {
                            slackTime = newslackTime;
                            lowestSlackTime = item;
                        }
                    }
                }

                if(lowestSlackTime == null)
                {
                    break;
                }
                ////  op += lowestSlackTime.TaskID + " has lowest SlackTime of " + slackTime + "\n";
                lowestSlackTime.Duration = lowestSlackTime.Duration - step;
                lowestSlackTime.Duration = Math.Round(lowestSlackTime.Duration, 4);
                //// op += lowestSlackTime.TaskID + " Executing\n";

                if (lowestSlackTime.Duration == 0)
                {
                    ////    op += lowestSlackTime.TaskID + " Completed\n";
                }

                
                csv = lowestSlackTime.TaskID + "," + (i) + "," + (i+step) + "," + (lowestSlackTime.Duration) + "," +
                    lowestSlackTime.Deadline + "\n";

                //builder.Append(csv);
                

                //if( (batch_counter%batch) == 0)
                //{
                //    File.AppendAllText(@"D:\temp\output.csv", builder.ToString());
                //    builder.Clear();
                //    batch_counter = 0;
                //}
            }

            File.AppendAllText(@"D:\temp\output.csv", builder.ToString());


            //File.WriteAllText(@"D:\temp\exe.txt", exeData);
            ////  File.WriteAllText(@"D:\temp\op.txt", op);
            MessageBox.Show("File Written successfully");
            
        }
        private double getEndTime()
        {
            double endTime = tasks[0].Deadline;
            for(int i=1; i<tasks.Count; i++)
            {
                if(tasks[i].Deadline > endTime)
                {
                    endTime = tasks[i].Deadline;
                }
            }
            return endTime;
        }
        private double getStartTime()
        {
            double startTime = tasks[0].Arrival;

            for(int i=1; i<tasks.Count; i++)
            {
                if(tasks[i].Arrival < startTime)
                {
                    startTime = tasks[i].Arrival;
                }
            }

            return startTime;
        }
    }
}
