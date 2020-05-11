using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Sort st = new Sort();

        private void originalBbutton_Click(object sender, EventArgs e)
        {
           
            Stopwatch orstp = new Stopwatch();
            orstp.Start();
            GenerateArray f = new GenerateArray();
            foreach (var item in f.Arr)
            {
                listBox1.Items.Add(item);
            }
            orstp.Stop();
            gen2.Text = orstp.Elapsed.ToString();
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Stopwatch clst = new Stopwatch();
            clst.Start();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox8.Items.Clear();
            clst.Stop();
            cl.Text = clst.Elapsed.ToString();
        }

        private void bubbleButton_Click(object sender, EventArgs e)
        {
            
            st.Buble(st.Ga.Arr);
            
            Stopwatch bubbst = new Stopwatch();
            bubbst.Start();

            foreach (var item in st.Ga.Arr)
            {
                listBox2.Items.Add(item);

            }
            bubbst.Stop();
            bu.Text = bubbst.Elapsed.ToString();
        }
        //Stopwatch stw = new Stopwatch();
        private void shakerButton_Click(object sender, EventArgs e)
        {
            
            Stopwatch shst = new Stopwatch();
            shst.Start();
            st.ShakeSort(st.Ga.Arr);
            foreach (var item in st.Ga.Arr)
            {
                listBox4.Items.Add(item);
            }
            shst.Stop();
            timeOfShaker.Text = shst.Elapsed.ToString();
            
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            Stopwatch swst = new Stopwatch();
            swst.Start();
            st.SwitchSort(st.Ga.Arr);
            foreach (var item in st.Ga.Arr)
            {
                listBox3.Items.Add(item);
            }
            swst.Stop();
            sw.Text = swst.Elapsed.ToString();

        }

        private void countButton_Click(object sender, EventArgs e)
        {
            Stopwatch couSt = new Stopwatch();
            couSt.Start();
            st.CountSort(st.Ga.Arr);
            foreach (var item in st.CountArr1)
            {
                listBox5.Items.Add(item);
            }
            couSt.Stop();
            countLabel.Text = couSt.Elapsed.ToString();
        }

        private void extractButton3_Click(object sender, EventArgs e)
        {
            Stopwatch exst = new Stopwatch();
            exst.Start();
            st.Extract3(st.Ga.Arr);
            foreach (var item in st.Ga.Arr)
            {
                listBox8.Items.Add(item);
            }
            exst.Stop();
            ExLable.Text = exst.Elapsed.ToString();
        }
    }
}
