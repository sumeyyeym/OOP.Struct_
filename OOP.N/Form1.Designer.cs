namespace OOP.N
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
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStruck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(12, 12);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(133, 23);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // btnStruck
            // 
            this.btnStruck.Location = new System.Drawing.Point(12, 41);
            this.btnStruck.Name = "btnStruck";
            this.btnStruck.Size = new System.Drawing.Size(133, 23);
            this.btnStruck.TabIndex = 1;
            this.btnStruck.Text = "Struct";
            this.btnStruck.UseVisualStyleBackColor = true;
            this.btnStruck.Click += new System.EventHandler(this.BtnStruck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 74);
            this.Controls.Add(this.btnStruck);
            this.Controls.Add(this.btnClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStruck;
    }
}

