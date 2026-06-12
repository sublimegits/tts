namespace TTSToVCable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            SpeakButton = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            waveViewer1 = new NAudio.Gui.WaveViewer();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "Text Input Box";
            textBox1.AccessibleRole = AccessibleRole.Dialog;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Input your speech here.";
            textBox1.Size = new Size(174, 235);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(SpeakButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(360, 241);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // SpeakButton
            // 
            SpeakButton.AccessibleName = "Speak button";
            SpeakButton.AccessibleRole = AccessibleRole.OutlineButton;
            SpeakButton.Cursor = Cursors.Hand;
            SpeakButton.Font = new Font("Tahoma", 8F);
            SpeakButton.Location = new Point(183, 3);
            SpeakButton.Name = "SpeakButton";
            SpeakButton.Size = new Size(174, 31);
            SpeakButton.TabIndex = 1;
            SpeakButton.Text = "Speak";
            SpeakButton.UseVisualStyleBackColor = true;
            SpeakButton.Click += SpeakButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(688, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(102, 22);
            toolStripDropDownButton1.Text = "Change Output";
            toolStripDropDownButton1.ToolTipText = "Changes the output of the TextToSpeech.";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(92, 22);
            toolStripDropDownButton2.Text = "Change Voice";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 347);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(688, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(148, 17);
            toolStripStatusLabel1.Text = "Everything's fine right now";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(15, 296);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(174, 45);
            trackBar1.TabIndex = 3;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(195, 296);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(174, 45);
            trackBar2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 279);
            label1.Name = "label1";
            label1.Size = new Size(48, 14);
            label1.TabIndex = 5;
            label1.Text = "Volume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 279);
            label2.Name = "label2";
            label2.Size = new Size(32, 14);
            label2.TabIndex = 6;
            label2.Text = "Rate";
            // 
            // waveViewer1
            // 
            waveViewer1.AccessibleName = "Waveform";
            waveViewer1.AccessibleRole = AccessibleRole.Chart;
            waveViewer1.BackColor = Color.White;
            waveViewer1.BorderStyle = BorderStyle.Fixed3D;
            waveViewer1.ForeColor = Color.Black;
            waveViewer1.Location = new Point(378, 34);
            waveViewer1.Name = "waveViewer1";
            waveViewer1.SamplesPerPixel = 128;
            waveViewer1.Size = new Size(300, 300);
            waveViewer1.StartPosition = 0L;
            waveViewer1.TabIndex = 7;
            waveViewer1.WaveStream = null;
            waveViewer1.Load += waveViewer1_Load;
            // 
            // Form1
            // 
            AcceptButton = SpeakButton;
            AccessibleRole = AccessibleRole.TitleBar;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 369);
            Controls.Add(waveViewer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TTSToOutput";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SpeakButton;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label1;
        private Label label2;
        private NAudio.Gui.WaveViewer waveViewer1;
    }
}
