namespace GameNumber.UI
{
    partial class SettingsDlg
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
            this.lbGuessCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edGuessCount = new System.Windows.Forms.TextBox();
            this.edMin = new System.Windows.Forms.TextBox();
            this.edMax = new System.Windows.Forms.TextBox();
            this.edSave = new System.Windows.Forms.Button();
            this.edCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGuessCount
            // 
            this.lbGuessCount.AutoSize = true;
            this.lbGuessCount.Location = new System.Drawing.Point(101, 43);
            this.lbGuessCount.Name = "lbGuessCount";
            this.lbGuessCount.Size = new System.Drawing.Size(90, 13);
            this.lbGuessCount.TabIndex = 0;
            this.lbGuessCount.Text = "Кол-во попыток:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мин. число:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Макс. число:";
            // 
            // edGuessCount
            // 
            this.edGuessCount.Location = new System.Drawing.Point(197, 40);
            this.edGuessCount.Name = "edGuessCount";
            this.edGuessCount.Size = new System.Drawing.Size(100, 20);
            this.edGuessCount.TabIndex = 3;
            this.edGuessCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edGuessCount_KeyPress);
            // 
            // edMin
            // 
            this.edMin.Location = new System.Drawing.Point(197, 74);
            this.edMin.Name = "edMin";
            this.edMin.Size = new System.Drawing.Size(100, 20);
            this.edMin.TabIndex = 4;
            this.edMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edGuessCount_KeyPress);
            // 
            // edMax
            // 
            this.edMax.Location = new System.Drawing.Point(197, 111);
            this.edMax.Name = "edMax";
            this.edMax.Size = new System.Drawing.Size(100, 20);
            this.edMax.TabIndex = 5;
            this.edMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edGuessCount_KeyPress);
            // 
            // edSave
            // 
            this.edSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.edSave.Location = new System.Drawing.Point(151, 167);
            this.edSave.Name = "edSave";
            this.edSave.Size = new System.Drawing.Size(75, 23);
            this.edSave.TabIndex = 6;
            this.edSave.Text = "Сохранить";
            this.edSave.UseVisualStyleBackColor = true;
            this.edSave.Click += new System.EventHandler(this.edSave_Click);
            // 
            // edCancel
            // 
            this.edCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.edCancel.Location = new System.Drawing.Point(232, 167);
            this.edCancel.Name = "edCancel";
            this.edCancel.Size = new System.Drawing.Size(75, 23);
            this.edCancel.TabIndex = 7;
            this.edCancel.Text = "Отмена";
            this.edCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 202);
            this.Controls.Add(this.edCancel);
            this.Controls.Add(this.edSave);
            this.Controls.Add(this.edMax);
            this.Controls.Add(this.edMin);
            this.Controls.Add(this.edGuessCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGuessCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGuessCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edGuessCount;
        private System.Windows.Forms.TextBox edMin;
        private System.Windows.Forms.TextBox edMax;
        private System.Windows.Forms.Button edSave;
        private System.Windows.Forms.Button edCancel;
    }
}