
namespace lab4._2
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
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelmin2 = new System.Windows.Forms.Label();
            this.labelmin1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(92, 283);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownA.TabIndex = 0;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(347, 283);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownB.TabIndex = 1;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(580, 283);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownC.TabIndex = 2;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(92, 254);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 23);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(347, 254);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 23);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(580, 254);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(120, 23);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // trackBarA
            // 
            this.trackBarA.LargeChange = 1;
            this.trackBarA.Location = new System.Drawing.Point(92, 313);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(120, 37);
            this.trackBarA.TabIndex = 6;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(347, 313);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(120, 37);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(580, 313);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(120, 37);
            this.trackBarC.TabIndex = 8;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(110, 99);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(76, 73);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(364, 99);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(76, 73);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelC.Location = new System.Drawing.Point(605, 99);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(79, 73);
            this.labelC.TabIndex = 11;
            this.labelC.Text = "C";
            // 
            // labelmin2
            // 
            this.labelmin2.AutoSize = true;
            this.labelmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmin2.Location = new System.Drawing.Point(466, 99);
            this.labelmin2.Name = "labelmin2";
            this.labelmin2.Size = new System.Drawing.Size(108, 73);
            this.labelmin2.TabIndex = 12;
            this.labelmin2.Text = "<=";
            // 
            // labelmin1
            // 
            this.labelmin1.AutoSize = true;
            this.labelmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmin1.Location = new System.Drawing.Point(210, 99);
            this.labelmin1.Name = "labelmin1";
            this.labelmin1.Size = new System.Drawing.Size(108, 73);
            this.labelmin1.TabIndex = 13;
            this.labelmin1.Text = "<=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.labelmin1);
            this.Controls.Add(this.labelmin2);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelmin2;
        private System.Windows.Forms.Label labelmin1;
    }
}

