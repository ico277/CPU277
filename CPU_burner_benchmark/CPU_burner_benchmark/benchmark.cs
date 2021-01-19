using System;
using System.Threading;
using System.Numerics;
using System.Diagnostics;
using System.Windows.Forms;

namespace CPU_burner_benchmark
{
    public partial class benchmark : Form
    {
        private int Threads = -1;
        private Type type = Type.None;
        private bool IsBenchmark = false;

        public benchmark(int Threads, Type type)
        {
            this.Threads = Threads; this.type = type; this.IsBenchmark = true;
            InitializeComponent();
            Show();
            Start_Benchmark();
        }

        public void Start_Benchmark()
        {
            if (Threads <= 0 || type == Type.None)
            {
                throw new Exception("Not all parameters provided");
            }
            else if (type == Type.Stresstest)
            {
                for (int i = 0; i < Threads; i++)
                {
                    new Thread(() =>
                    {
                        BigInteger num = 100000000;
                        while (IsBenchmark)
                        {
                            if (!IsBenchmark)
                                break;
                            else
                            {
                                Factorial(num);
                            }
                        }
                    }).Start();
                }
            }
            else if (type == Type.Benchmark) 
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                BigInteger result = BigInteger.Zero;
                for (int i = 0; i < Threads; i++)
                {
                    new Thread(() =>
                    {
                        BigInteger num = 5;
                        while (IsBenchmark)
                        {
                            if (!IsBenchmark)
                            {
                                //stopWatch.Stop();
                                //this.IsBenchmark = false;
                                break;
                            }
                            else
                            {
                                result += Factorial(num);
                            }
                        }
                    }).Start();
                }
                new Thread(() =>
                {
                    while (stopWatch.ElapsedMilliseconds < 30001)
                    {
                        //if (stopWatch.ElapsedMilliseconds != 30000)
                        Thread.Sleep(1);
                        continue;
                    }
                    this.IsBenchmark = false;
                    //Hide();
                    
                    MessageBox.Show($"Points: {(result > 10000 ? Convert.ToString(result / 10000) : result + " (Very low!)")}");
                }).Start();
            }
            else
            {
                this.IsBenchmark = false;
                Close();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.IsBenchmark = false;
            Close();
        }

        private BigInteger Factorial(BigInteger number)
        {
            if (!IsBenchmark)
            {
                return 0;
            } else
            {
                BigInteger fact = 1;
                for (BigInteger i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }
}
