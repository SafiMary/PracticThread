namespace PracticThread
{
    partial class DirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryForm));
            this.pictureBoxFrom = new System.Windows.Forms.PictureBox();
            this.pictureBoxTo = new System.Windows.Forms.PictureBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.numericUpCount = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonSuspend = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFrom
            // 
            this.pictureBoxFrom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrom.Image")));
            this.pictureBoxFrom.Location = new System.Drawing.Point(58, 101);
            this.pictureBoxFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxFrom.Name = "pictureBoxFrom";
            this.pictureBoxFrom.Size = new System.Drawing.Size(88, 94);
            this.pictureBoxFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrom.TabIndex = 0;
            this.pictureBoxFrom.TabStop = false;
            this.pictureBoxFrom.Click += new System.EventHandler(this.pictureBoxFrom_Click);
            // 
            // pictureBoxTo
            // 
            this.pictureBoxTo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTo.Image")));
            this.pictureBoxTo.Location = new System.Drawing.Point(254, 101);
            this.pictureBoxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxTo.Name = "pictureBoxTo";
            this.pictureBoxTo.Size = new System.Drawing.Size(88, 94);
            this.pictureBoxTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTo.TabIndex = 1;
            this.pictureBoxTo.TabStop = false;
            this.pictureBoxTo.Click += new System.EventHandler(this.pictureBoxTo_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(92, 40);
            this.labelPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(248, 20);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "выберите путь копирования";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(83, 80);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(28, 20);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "из";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(289, 80);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 20);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "в";
            // 
            // numericUpCount
            // 
            this.numericUpCount.Location = new System.Drawing.Point(146, 231);
            this.numericUpCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpCount.Name = "numericUpCount";
            this.numericUpCount.Size = new System.Drawing.Size(122, 21);
            this.numericUpCount.TabIndex = 5;
            this.numericUpCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpCount.ValueChanged += new System.EventHandler(this.numericUpCount_ValueChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(126, 208);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(181, 20);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "количество потоков";
            // 
            // progressBarProcess
            // 
            this.progressBarProcess.Location = new System.Drawing.Point(58, 327);
            this.progressBarProcess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(311, 47);
            this.progressBarProcess.TabIndex = 7;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopy.Location = new System.Drawing.Point(130, 268);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(146, 39);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSuspend
            // 
            this.buttonSuspend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSuspend.Location = new System.Drawing.Point(459, 61);
            this.buttonSuspend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSuspend.Name = "buttonSuspend";
            this.buttonSuspend.Size = new System.Drawing.Size(146, 39);
            this.buttonSuspend.TabIndex = 9;
            this.buttonSuspend.Text = "приостановить";
            this.buttonSuspend.UseVisualStyleBackColor = true;
            this.buttonSuspend.Click += new System.EventHandler(this.buttonSuspend_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResume.Location = new System.Drawing.Point(459, 113);
            this.buttonResume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(146, 40);
            this.buttonResume.TabIndex = 10;
            this.buttonResume.Text = "возобновить";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbort.Location = new System.Drawing.Point(459, 170);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(146, 39);
            this.buttonAbort.TabIndex = 11;
            this.buttonAbort.Text = "завершить";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonSuspend);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.progressBarProcess);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.numericUpCount);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.pictureBoxTo);
            this.Controls.Add(this.pictureBoxFrom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(683, 469);
            this.MinimumSize = new System.Drawing.Size(683, 469);
            this.Name = "DirectoryForm";
            this.Text = "DirectoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFrom;
        private System.Windows.Forms.PictureBox pictureBoxTo;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.NumericUpDown numericUpCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ProgressBar progressBarProcess;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonSuspend;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}