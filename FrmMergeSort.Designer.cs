namespace cSharp_MergeSort
{
    partial class FrmMergeSort
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
            this.BtnMergeSort = new System.Windows.Forms.Button();
            this.LbxInput = new System.Windows.Forms.ListBox();
            this.LblInput = new System.Windows.Forms.Label();
            this.LbxOutput = new System.Windows.Forms.ListBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMergeSort
            // 
            this.BtnMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMergeSort.Location = new System.Drawing.Point(191, 25);
            this.BtnMergeSort.Name = "BtnMergeSort";
            this.BtnMergeSort.Size = new System.Drawing.Size(166, 58);
            this.BtnMergeSort.TabIndex = 0;
            this.BtnMergeSort.Text = "Merge Sort";
            this.BtnMergeSort.UseVisualStyleBackColor = true;
            this.BtnMergeSort.Click += new System.EventHandler(this.BtnMergeSort_Click);
            // 
            // LbxInput
            // 
            this.LbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxInput.FormattingEnabled = true;
            this.LbxInput.ItemHeight = 24;
            this.LbxInput.Items.AddRange(new object[] {
            "W",
            "A",
            "Y",
            "N",
            "C",
            "L",
            "S",
            "P",
            "B",
            "R"});
            this.LbxInput.Location = new System.Drawing.Point(76, 141);
            this.LbxInput.Name = "LbxInput";
            this.LbxInput.Size = new System.Drawing.Size(105, 244);
            this.LbxInput.TabIndex = 1;
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput.Location = new System.Drawing.Point(74, 106);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(109, 24);
            this.LblInput.TabIndex = 2;
            this.LblInput.Text = "Input to Sort";
            // 
            // LbxOutput
            // 
            this.LbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxOutput.FormattingEnabled = true;
            this.LbxOutput.ItemHeight = 24;
            this.LbxOutput.Location = new System.Drawing.Point(367, 141);
            this.LbxOutput.Name = "LbxOutput";
            this.LbxOutput.Size = new System.Drawing.Size(105, 244);
            this.LbxOutput.TabIndex = 3;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(357, 106);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(124, 24);
            this.LblOutput.TabIndex = 4;
            this.LblOutput.Text = "Output of Sort";
            // 
            // FrmMergeSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 409);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LbxOutput);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.LbxInput);
            this.Controls.Add(this.BtnMergeSort);
            this.Name = "FrmMergeSort";
            this.Text = "Merge Sort";
            this.Load += new System.EventHandler(this.FrmMergeSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMergeSort;
        private System.Windows.Forms.ListBox LbxInput;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.ListBox LbxOutput;
        private System.Windows.Forms.Label LblOutput;
    }
}

