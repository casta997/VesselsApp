using System.Data.Entity.Core.Common.CommandTrees;

namespace VesselsApp
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            idBox = new TextBox();
            nameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 43);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 0;
            button1.Text = "Get Vessel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(381, 392);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 105);
            button2.Name = "button2";
            button2.Size = new Size(137, 43);
            button2.TabIndex = 2;
            button2.Text = "Add Vessel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 167);
            button3.Name = "button3";
            button3.Size = new Size(137, 43);
            button3.TabIndex = 3;
            button3.Text = "Delete Vessel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 228);
            button4.Name = "button4";
            button4.Size = new Size(137, 43);
            button4.TabIndex = 4;
            button4.Text = "Update Vessel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(200, 63);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(200, 105);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox idBox;
        private TextBox nameBox;
    }
}
