
namespace GraphVisualization
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rndBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.rstColorsBtn = new System.Windows.Forms.Button();
            this.spanTreeBtn = new System.Windows.Forms.Button();
            this.transBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-177, -58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-122, -38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1076, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.rndBtn);
            this.panel1.Controls.Add(this.predictBtn);
            this.panel1.Controls.Add(this.rstColorsBtn);
            this.panel1.Controls.Add(this.spanTreeBtn);
            this.panel1.Controls.Add(this.transBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(877, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(220, 684);
            this.panel1.TabIndex = 5;
            // 
            // rndBtn
            // 
            this.rndBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rndBtn.FlatAppearance.BorderSize = 0;
            this.rndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rndBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.rndBtn.Location = new System.Drawing.Point(0, 450);
            this.rndBtn.Name = "rndBtn";
            this.rndBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rndBtn.Size = new System.Drawing.Size(220, 60);
            this.rndBtn.TabIndex = 14;
            this.rndBtn.Text = "Randomize positions";
            this.rndBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rndBtn.UseVisualStyleBackColor = true;
            this.rndBtn.Click += new System.EventHandler(this.rndBtn_Click);
            // 
            // predictBtn
            // 
            this.predictBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.predictBtn.FlatAppearance.BorderSize = 0;
            this.predictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.predictBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.predictBtn.Location = new System.Drawing.Point(0, 390);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.predictBtn.Size = new System.Drawing.Size(220, 60);
            this.predictBtn.TabIndex = 13;
            this.predictBtn.Text = "Predict positions";
            this.predictBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // rstColorsBtn
            // 
            this.rstColorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rstColorsBtn.FlatAppearance.BorderSize = 0;
            this.rstColorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rstColorsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rstColorsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.rstColorsBtn.Location = new System.Drawing.Point(0, 330);
            this.rstColorsBtn.Name = "rstColorsBtn";
            this.rstColorsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rstColorsBtn.Size = new System.Drawing.Size(220, 60);
            this.rstColorsBtn.TabIndex = 12;
            this.rstColorsBtn.Text = "Reset colors";
            this.rstColorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rstColorsBtn.UseVisualStyleBackColor = true;
            this.rstColorsBtn.Click += new System.EventHandler(this.rstColorsBtn_Click);
            // 
            // spanTreeBtn
            // 
            this.spanTreeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.spanTreeBtn.FlatAppearance.BorderSize = 0;
            this.spanTreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spanTreeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spanTreeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.spanTreeBtn.Location = new System.Drawing.Point(0, 270);
            this.spanTreeBtn.Name = "spanTreeBtn";
            this.spanTreeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.spanTreeBtn.Size = new System.Drawing.Size(220, 60);
            this.spanTreeBtn.TabIndex = 11;
            this.spanTreeBtn.Text = "Min spanning tree";
            this.spanTreeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spanTreeBtn.UseVisualStyleBackColor = true;
            this.spanTreeBtn.Click += new System.EventHandler(this.spanTreeBtn_Click);
            // 
            // transBtn
            // 
            this.transBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transBtn.FlatAppearance.BorderSize = 0;
            this.transBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.transBtn.Location = new System.Drawing.Point(0, 210);
            this.transBtn.Name = "transBtn";
            this.transBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.transBtn.Size = new System.Drawing.Size(220, 60);
            this.transBtn.TabIndex = 10;
            this.transBtn.Text = "Transitive closure";
            this.transBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transBtn.UseVisualStyleBackColor = true;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 150);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Component labeling";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.componLabBtn_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Springy";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.springyBtn_Click);
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(877, 684);
            this.canvas.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1097, 684);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button rstColorsBtn;
        private System.Windows.Forms.Button spanTreeBtn;
        private System.Windows.Forms.Button transBtn;
        private System.Windows.Forms.Button rndBtn;
        private System.Windows.Forms.Button predictBtn;
    }
}

