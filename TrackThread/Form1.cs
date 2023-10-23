using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Threads()
        {

            lblThreadStarts.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");

            MyThreadClass threadClass = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(threadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(threadClass.Thread2));
            Thread threadC = new Thread(new ThreadStart(threadClass.Thread1));
            Thread threadD = new Thread(new ThreadStart(threadClass.Thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblThreadStarts.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");

        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Threads();

        }
    }
}
