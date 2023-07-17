namespace Project_ADT_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            cmb_items = new ComboBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            txt_price = new TextBox();
            label2 = new Label();
            txt_qty = new TextBox();
            label3 = new Label();
            txt_total = new TextBox();
            label4 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label5 = new Label();
            txt_subtotal = new TextBox();
            label6 = new Label();
            txt_discount = new TextBox();
            label7 = new Label();
            txt_paid = new TextBox();
            label8 = new Label();
            txt_balance = new TextBox();
            label9 = new Label();
            txt_net = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmb_items
            // 
            cmb_items.FormattingEnabled = true;
            cmb_items.Location = new Point(208, 179);
            cmb_items.Name = "cmb_items";
            cmb_items.Size = new Size(404, 28);
            cmb_items.TabIndex = 1;
            cmb_items.SelectedIndexChanged += cmb_items_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 179);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Game";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(102, 139);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tabletop Games";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(285, 139);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(142, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Miniature Games";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(475, 139);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Card Games";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(60, 270);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 247);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(238, 270);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(125, 27);
            txt_qty.TabIndex = 4;
            txt_qty.TextChanged += txt_qty_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 247);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "Qty";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(428, 270);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(125, 27);
            txt_total.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 247);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Total";
            // 
            // button1
            // 
            button1.Location = new Point(586, 268);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add Game";
            button1.TextAlign = ContentAlignment.BottomLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(23, 332);
            listView1.Name = "listView1";
            listView1.Size = new Size(657, 174);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item Name";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Qty";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 534);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Sub Total";
            // 
            // txt_subtotal
            // 
            txt_subtotal.Location = new Point(102, 532);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(125, 27);
            txt_subtotal.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 535);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 8;
            label6.Text = "Discount";
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(311, 535);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(125, 27);
            txt_discount.TabIndex = 9;
            txt_discount.TextChanged += txt_discount_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 567);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 8;
            label7.Text = "Paid";
            // 
            // txt_paid
            // 
            txt_paid.Location = new Point(542, 564);
            txt_paid.Name = "txt_paid";
            txt_paid.Size = new Size(125, 27);
            txt_paid.TabIndex = 9;
            txt_paid.TextChanged += txt_paid_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 600);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 8;
            label8.Text = "Balance";
            // 
            // txt_balance
            // 
            txt_balance.Location = new Point(542, 597);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(125, 27);
            txt_balance.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(479, 534);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 8;
            label9.Text = "Net";
            // 
            // txt_net
            // 
            txt_net.Location = new Point(542, 531);
            txt_net.Name = "txt_net";
            txt_net.Size = new Size(125, 27);
            txt_net.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(586, 303);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 591);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(164, 591);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 662);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_net);
            Controls.Add(label9);
            Controls.Add(txt_balance);
            Controls.Add(label8);
            Controls.Add(txt_paid);
            Controls.Add(label7);
            Controls.Add(txt_discount);
            Controls.Add(label6);
            Controls.Add(txt_subtotal);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_total);
            Controls.Add(txt_qty);
            Controls.Add(txt_price);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(cmb_items);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Center";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmb_items;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox txt_price;
        private Label label2;
        private TextBox txt_qty;
        private Label label3;
        private TextBox txt_total;
        private Label label4;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label5;
        private TextBox txt_subtotal;
        private Label label6;
        private TextBox txt_discount;
        private Label label7;
        private TextBox txt_paid;
        private Label label8;
        private TextBox txt_balance;
        private Label label9;
        private TextBox txt_net;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}