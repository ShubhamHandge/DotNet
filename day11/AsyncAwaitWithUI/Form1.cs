using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitWithUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long j=LongRunningCode();  //blocking call - blocks main thread
            label1.Text = "Done " + j.ToString();
        }
        long LongRunningCode()
        {
            long j = 0;
            for (long i = 0; i < 9999999999; i++)
            {
                j = i;
            }
            return j;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            long j = await LongRunningCode2(); //non blocking call
            label1.Text = "Done " + j.ToString();
        }
        async Task<long> LongRunningCode2()
        {
            return await Task.Run(
                delegate ()
                {
                    long j = 0; 
                    for (long i = 0; i < 9999999999; i++)
                    {
                        j = i;
                    }
                    return j;
                }
                );
        }
    }
}
