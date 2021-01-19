using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace CPU_burner_benchmark
{
    public partial class Menu : Form
    {
        private int Threads = -1;
        private Type TypeOfTest = Type.None;
        public static benchmark BenchmarkWindow = null;

        public Menu()
        {
            InitializeComponent();
            ThreadsListBox.Items.Clear();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                ThreadsListBox.Items.Add(i + 1 + " Threads");
            }
            RegistryKey key = Registry.LocalMachine.OpenSubKey("HARDWARE").OpenSubKey("DESCRIPTION").OpenSubKey("System").OpenSubKey("CentralProcessor").OpenSubKey("0");
            CpuLabel.Text = "CPU: " + key.GetValue(@"ProcessorNameString").ToString() == null ? "N/A" : key.GetValue(@"ProcessorNameString").ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (Threads <= 0)
            {
                ErrorLabel.Text = "Error: No amount of threads is provided";
                if (TypeOfTest == Type.None)
                {
                    ErrorLabel.Text += "\nError: No Test Type is provided";
                }
                return;
            } else if (TypeOfTest == Type.None)
            {
                ErrorLabel.Text = "Error: No Test Type is provided";
                if (Threads <= 0)
                {
                    ErrorLabel.Text += "\nError: No amount of threads is provided";
                }
                return;
            } else if (BenchmarkWindow != null)
            {
                ErrorLabel.Text = "Error: A benchmark/stresstest is currently running";
                return;
            }
            else
            {
                ErrorLabel.Text = string.Empty;
            }

            BenchmarkWindow = new benchmark(Threads, TypeOfTest);
            new Thread(() => {
                while (BenchmarkWindow.Visible)
                {
                    Thread.Sleep(500);
                }
                BenchmarkWindow = null;
            }).Start();
        }

        private void ThreadsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = ThreadsListBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            string selectedStr = selected.ToString();
            try {
                int amount = Convert.ToInt32(selectedStr.Split(' ')[0]);
                ThreadsLabel.Text = "Threads: " + amount;
                Threads = amount;
            } catch (Exception ex)
            {
                MessageBox.Show(this, "An unexpected error occured:\n" + ex);
                Close();
            }
        }

        private void TypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object selected = TypeListBox.SelectedItem;
                if (selected == null)
                {
                    return;
                }
                string selectedStr = TypeListBox.SelectedItem.ToString();
                switch (selectedStr)
                {
                    case "Benchmark":
                        TypeOfTest = Type.Benchmark;
                        TypeLabel.Text = "Test Type: " + "Benchmark";
                        break;
                    case "Stresstest":
                        TypeOfTest = Type.Stresstest;
                        TypeLabel.Text = "Test Type: " + "Stresstest";
                        break;
                    default:
                        MessageBox.Show(this, "An unexpected error occured:\n" + $"'{selected}' is not a known selectable??");
                        TypeOfTest = Type.None;
                        TypeLabel.Text = "Test Type: " + "err";
                        Close();
                        break;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(this, "An unexpected error occured:\n" + ex);
                Close();
            }
        }
    }
}
