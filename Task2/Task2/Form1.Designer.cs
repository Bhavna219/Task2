namespace Task2
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Group = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            colmn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 40);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(673, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Men", "Women" });
            comboBox1.Location = new Point(318, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jeans", "T-Shirt", "Shirt" });
            comboBox2.Location = new Point(784, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 119);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 4;
            label3.Text = "Enter Qty";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(253, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 142);
            panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 58);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 2;
            label6.Text = "XXL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 57);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 1;
            label5.Text = "M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 57);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 0;
            label4.Text = "S";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(784, 492);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(70, 27);
            textBox4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(690, 492);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 7;
            label7.Text = "Total Qty";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(434, 571);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Group, Item, colmn3, Column4 });
            dataGridView1.Location = new Point(307, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(537, 115);
            dataGridView1.TabIndex = 9;
            // 
            // Group
            // 
            Group.HeaderText = "Group";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.Width = 125;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // colmn3
            // 
            colmn3.HeaderText = "Size";
            colmn3.MinimumWidth = 6;
            colmn3.Name = "colmn3";
            colmn3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Qty";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(556, 569);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(673, 568);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 607);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Qty;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn colmn3;
        private DataGridViewTextBoxColumn Column4;
    }
}
