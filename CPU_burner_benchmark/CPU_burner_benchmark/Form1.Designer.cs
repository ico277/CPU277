
namespace CPU_burner_benchmark
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_Benchmark = new System.Windows.Forms.Button();
            this.ThreadsListBox = new System.Windows.Forms.ListBox();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.TypeListBox = new System.Windows.Forms.ListBox();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.SystemInfoLabel = new System.Windows.Forms.Label();
            this.TestSettingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Benchmark
            // 
            this.Start_Benchmark.AutoSize = true;
            this.Start_Benchmark.Location = new System.Drawing.Point(128, 130);
            this.Start_Benchmark.Name = "Start_Benchmark";
            this.Start_Benchmark.Size = new System.Drawing.Size(80, 23);
            this.Start_Benchmark.TabIndex = 0;
            this.Start_Benchmark.Text = "Start";
            this.Start_Benchmark.UseVisualStyleBackColor = true;
            this.Start_Benchmark.Click += new System.EventHandler(this.start_Click);
            // 
            // ThreadsListBox
            // 
            this.ThreadsListBox.FormattingEnabled = true;
            this.ThreadsListBox.Items.AddRange(new object[] {
            "1 Thread"});
            this.ThreadsListBox.Location = new System.Drawing.Point(13, 13);
            this.ThreadsListBox.Name = "ThreadsListBox";
            this.ThreadsListBox.Size = new System.Drawing.Size(120, 95);
            this.ThreadsListBox.TabIndex = 1;
            this.ThreadsListBox.SelectedIndexChanged += new System.EventHandler(this.ThreadsListBox_SelectedIndexChanged);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(203, 389);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(119, 13);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "This is a Debug Version";
            this.DebugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeListBox
            // 
            this.TypeListBox.FormattingEnabled = true;
            this.TypeListBox.Items.AddRange(new object[] {
            "Benchmark",
            "Stresstest"});
            this.TypeListBox.Location = new System.Drawing.Point(202, 12);
            this.TypeListBox.Name = "TypeListBox";
            this.TypeListBox.Size = new System.Drawing.Size(120, 95);
            this.TypeListBox.TabIndex = 3;
            this.TypeListBox.SelectedIndexChanged += new System.EventHandler(this.TypeListBox_SelectedIndexChanged);
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.Location = new System.Drawing.Point(10, 172);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(78, 13);
            this.ThreadsLabel.TabIndex = 4;
            this.ThreadsLabel.Text = "Threads: None";
            this.ThreadsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(10, 185);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(87, 13);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Test Type: None";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 198);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CpuLabel
            // 
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.Location = new System.Drawing.Point(13, 251);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(55, 13);
            this.CpuLabel.TabIndex = 7;
            this.CpuLabel.Text = "CPU: N/A";
            // 
            // SystemInfoLabel
            // 
            this.SystemInfoLabel.AutoSize = true;
            this.SystemInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemInfoLabel.Location = new System.Drawing.Point(125, 228);
            this.SystemInfoLabel.Name = "SystemInfoLabel";
            this.SystemInfoLabel.Size = new System.Drawing.Size(62, 13);
            this.SystemInfoLabel.TabIndex = 8;
            this.SystemInfoLabel.Text = "System Info";
            // 
            // TestSettingsLabel
            // 
            this.TestSettingsLabel.AutoSize = true;
            this.TestSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestSettingsLabel.Location = new System.Drawing.Point(125, 156);
            this.TestSettingsLabel.Name = "TestSettingsLabel";
            this.TestSettingsLabel.Size = new System.Drawing.Size(69, 13);
            this.TestSettingsLabel.TabIndex = 9;
            this.TestSettingsLabel.Text = "Test Settings";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.TestSettingsLabel);
            this.Controls.Add(this.SystemInfoLabel);
            this.Controls.Add(this.CpuLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.TypeListBox);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.ThreadsListBox);
            this.Controls.Add(this.Start_Benchmark);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "Menu";
            this.Text = "CPU Benchmark Stresstest Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Benchmark;
        private System.Windows.Forms.ListBox ThreadsListBox;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.Label SystemInfoLabel;
        private System.Windows.Forms.Label TestSettingsLabel;
    }
}

