namespace BankAutomation
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            buttonSil = new Button();
            button1 = new Button();
            buttonAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxCity = new TextBox();
            textBoxMaas = new TextBox();
            textBoxAvaible = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxMusteriId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 396);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1017, 396);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(buttonSil);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxCity);
            panel2.Controls.Add(textBoxMaas);
            panel2.Controls.Add(textBoxAvaible);
            panel2.Controls.Add(textBoxSurname);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(textBoxMusteriId);
            panel2.Location = new Point(13, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 177);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(735, 95);
            button5.Name = "button5";
            button5.Size = new Size(278, 29);
            button5.TabIndex = 18;
            button5.Text = "Tüm verileri getir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(735, 53);
            button4.Name = "button4";
            button4.Size = new Size(278, 29);
            button4.TabIndex = 17;
            button4.Text = "Aylık Gelire Göre Arama";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(735, 19);
            button3.Name = "button3";
            button3.Size = new Size(278, 29);
            button3.TabIndex = 16;
            button3.Text = "Ad , Soyad Veya Sehre Göre Sorgulama";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(541, 135);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(541, 100);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 29);
            buttonSil.TabIndex = 14;
            buttonSil.Text = "Müşteri sil ";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // button1
            // 
            button1.Location = new Point(541, 58);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 13;
            button1.Text = "Kutuları temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(541, 18);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 107);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 11;
            label6.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 69);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 10;
            label5.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 22);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Muster ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 104);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Sehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 62);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 7;
            label2.Text = "Krediye Uygun MU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Aylik gelir:";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(387, 101);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 5;
            // 
            // textBoxMaas
            // 
            textBoxMaas.Location = new Point(387, 16);
            textBoxMaas.Name = "textBoxMaas";
            textBoxMaas.Size = new Size(125, 27);
            textBoxMaas.TabIndex = 4;
            // 
            // textBoxAvaible
            // 
            textBoxAvaible.Enabled = false;
            textBoxAvaible.Location = new Point(387, 59);
            textBoxAvaible.Name = "textBoxAvaible";
            textBoxAvaible.Size = new Size(125, 27);
            textBoxAvaible.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(101, 104);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(125, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxMusteriId
            // 
            textBoxMusteriId.Enabled = false;
            textBoxMusteriId.Location = new Point(101, 19);
            textBoxMusteriId.Name = "textBoxMusteriId";
            textBoxMusteriId.Size = new Size(125, 27);
            textBoxMusteriId.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1041, 571);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Müşteri Otomasyon Projesi";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxCity;
        private TextBox textBoxMaas;
        private TextBox textBoxAvaible;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxMusteriId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAdd;
        private Button button1;
        private Button buttonSil;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
