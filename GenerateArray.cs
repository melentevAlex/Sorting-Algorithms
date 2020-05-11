using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public class GenerateArray
    {
        private int[] arr = new int[1000];
        public int[] Arr { get => arr; }
        public TimeSpan Tt { get => tt; set => tt = value; }

        private TimeSpan tt;


        public GenerateArray()
        {
            Generate();
        }

        async private void Generate()
        {
            await Task.Run(() =>
            {
                Stopwatch tm = new Stopwatch();
                tm.Start();
                Random rand = new Random();
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = i + 1;
                }
                for (int i = 0; i < Arr.Length; i++)
                {
                    int tempIndex = rand.Next(0, Arr.Length);
                    int temp = Arr[tempIndex];
                    Arr[tempIndex] = Arr[i];
                    Arr[i] = temp;
                }
                tm.Stop();
                TimeSpan t = tm.Elapsed;
            });
        }
    }
}
