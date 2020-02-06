namespace Hello_Loops
{
    partial class Form1
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.numDialogBoxes = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfDialogBoxes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDialogBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(101, 171);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While Loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(254, 171);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 1;
            this.btnDoWhile.Text = "Do While Loop";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(455, 171);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For Loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // numDialogBoxes
            // 
            this.numDialogBoxes.Location = new System.Drawing.Point(530, 242);
            this.numDialogBoxes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDialogBoxes.Name = "numDialogBoxes";
            this.numDialogBoxes.Size = new System.Drawing.Size(120, 20);
            this.numDialogBoxes.TabIndex = 3;
            // 
            // lblNumberOfDialogBoxes
            // 
            this.lblNumberOfDialogBoxes.AutoSize = true;
            this.lblNumberOfDialogBoxes.Location = new System.Drawing.Point(388, 244);
            this.lblNumberOfDialogBoxes.Name = "lblNumberOfDialogBoxes";
            this.lblNumberOfDialogBoxes.Size = new System.Drawing.Size(124, 13);
            this.lblNumberOfDialogBoxes.TabIndex = 4;
            this.lblNumberOfDialogBoxes.Text = "Number of dialoge boxes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberOfDialogBoxes);
            this.Controls.Add(this.numDialogBoxes);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numDialogBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.NumericUpDown numDialogBoxes;
        private System.Windows.Forms.Label lblNumberOfDialogBoxes;
    }
}

