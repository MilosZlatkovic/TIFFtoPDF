namespace TIFFtoPDF
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.select_button = new System.Windows.Forms.Button();
            this.convert_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.up_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(484, 212);
            this.listBox1.TabIndex = 0;
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(12, 11);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(70, 30);
            this.select_button.TabIndex = 1;
            this.select_button.Text = "SELECT";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // convert_button
            // 
            this.convert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.convert_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.convert_button.FlatAppearance.BorderSize = 0;
            this.convert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.ForeColor = System.Drawing.Color.White;
            this.convert_button.Location = new System.Drawing.Point(502, 227);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(70, 30);
            this.convert_button.TabIndex = 2;
            this.convert_button.Text = "CONVERT";
            this.convert_button.UseVisualStyleBackColor = false;
            this.convert_button.Visible = false;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(502, 47);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(70, 30);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(502, 83);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(70, 30);
            this.remove_button.TabIndex = 4;
            this.remove_button.Text = "REMOVE";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(135, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 16);
            this.label.TabIndex = 5;
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(502, 119);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(70, 30);
            this.up_button.TabIndex = 6;
            this.up_button.Text = "˄";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(502, 155);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(70, 30);
            this.down_button.TabIndex = 7;
            this.down_button.Text = "˅";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(502, 191);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(70, 30);
            this.sort_button.TabIndex = 9;
            this.sort_button.Text = "SORT";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 268);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIFF 2 PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button sort_button;
    }
}

