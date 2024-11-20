namespace GameNumber.UI
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            toolStrip1 = new ToolStrip();
            btnStart = new ToolStripButton();
            btnStop = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btSettings = new ToolStripButton();
            mLog = new TextBox();
            pnBottom = new Panel();
            btnSend = new Button();
            edDigit = new TextBox();
            lbGuessDigit = new Label();
            toolStrip1.SuspendLayout();
            pnBottom.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnStart, btnStop, toolStripSeparator1, btSettings });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(933, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            btnStart.Image = (Image)resources.GetObject("btnStart.Image");
            btnStart.ImageTransparentColor = Color.Transparent;
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(51, 22);
            btnStart.Text = "Start";
            btnStart.ToolTipText = "Start Game";
            btnStart.Click += btStart_Click;
            // 
            // btnStop
            // 
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.ImageTransparentColor = Color.Magenta;
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(51, 22);
            btnStop.Text = "Stop";
            btnStop.Click += btnStop_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btSettings
            // 
            btSettings.Image = (Image)resources.GetObject("btSettings.Image");
            btSettings.ImageTransparentColor = Color.Magenta;
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(69, 22);
            btSettings.Text = "Settings";
            btSettings.Click += btSettings_Click;
            // 
            // mLog
            // 
            mLog.Dock = DockStyle.Fill;
            mLog.Location = new Point(0, 25);
            mLog.Margin = new Padding(4, 3, 4, 3);
            mLog.Multiline = true;
            mLog.Name = "mLog";
            mLog.ReadOnly = true;
            mLog.Size = new Size(933, 494);
            mLog.TabIndex = 1;
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnSend);
            pnBottom.Controls.Add(edDigit);
            pnBottom.Controls.Add(lbGuessDigit);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 442);
            pnBottom.Margin = new Padding(4, 3, 4, 3);
            pnBottom.Name = "pnBottom";
            pnBottom.Size = new Size(933, 77);
            pnBottom.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(245, 25);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(88, 27);
            btnSend.TabIndex = 3;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // edDigit
            // 
            edDigit.Location = new Point(142, 28);
            edDigit.Margin = new Padding(4, 3, 4, 3);
            edDigit.Name = "edDigit";
            edDigit.Size = new Size(95, 23);
            edDigit.TabIndex = 2;
            edDigit.KeyDown += edDigit_KeyDown;
            // 
            // lbGuessDigit
            // 
            lbGuessDigit.AutoSize = true;
            lbGuessDigit.Location = new Point(37, 31);
            lbGuessDigit.Margin = new Padding(4, 0, 4, 0);
            lbGuessDigit.Name = "lbGuessDigit";
            lbGuessDigit.Size = new Size(90, 15);
            lbGuessDigit.TabIndex = 0;
            lbGuessDigit.Text = "Введите число:";
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pnBottom);
            Controls.Add(mLog);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frMain";
            Text = "Угадай число";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnBottom.ResumeLayout(false);
            pnBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btSettings;
        private System.Windows.Forms.TextBox mLog;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.TextBox edDigit;
        private System.Windows.Forms.Label lbGuessDigit;
        private System.Windows.Forms.Button btnSend;
    }
}

