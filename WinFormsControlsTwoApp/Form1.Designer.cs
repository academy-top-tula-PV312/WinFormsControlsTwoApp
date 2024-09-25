namespace WinFormsControlsTwoApp
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            listCities = new ListBox();
            txtCity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnView = new Button();
            lblCities = new Label();
            cmbBoxCities = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Font = new Font("Segoe UI", 20F);
            checkBox1.Location = new Point(39, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 41);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Indeterminate;
            checkBox2.Font = new Font("Segoe UI", 20F);
            checkBox2.Location = new Point(39, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(160, 41);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 20F);
            checkBox3.Location = new Point(39, 129);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(160, 41);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(30, 112);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(39, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listCities
            // 
            listCities.Font = new Font("Segoe UI", 14F);
            listCities.FormattingEnabled = true;
            listCities.ItemHeight = 25;
            listCities.Items.AddRange(new object[] { "Москва", "Тула", "Орел", "Калуга", "Брянск" });
            listCities.Location = new Point(255, 35);
            listCities.Name = "listCities";
            listCities.SelectionMode = SelectionMode.MultiExtended;
            listCities.Size = new Size(192, 204);
            listCities.TabIndex = 7;
            listCities.SelectedIndexChanged += listCities_SelectedIndexChanged;
            listCities.DoubleClick += listCities_DoubleClick;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 14F);
            txtCity.Location = new Point(494, 35);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(229, 32);
            txtCity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(494, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 39);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add City";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.Location = new Point(599, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 39);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete City";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 14F);
            btnView.Location = new Point(494, 198);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 41);
            btnView.TabIndex = 10;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lblCities
            // 
            lblCities.AutoSize = true;
            lblCities.Font = new Font("Segoe UI", 14F);
            lblCities.Location = new Point(255, 337);
            lblCities.Name = "lblCities";
            lblCities.Size = new Size(0, 25);
            lblCities.TabIndex = 11;
            // 
            // cmbBoxCities
            // 
            cmbBoxCities.Font = new Font("Segoe UI", 14F);
            cmbBoxCities.FormattingEnabled = true;
            cmbBoxCities.Location = new Point(255, 269);
            cmbBoxCities.Name = "cmbBoxCities";
            cmbBoxCities.Size = new Size(192, 33);
            cmbBoxCities.TabIndex = 12;
            cmbBoxCities.SelectedIndexChanged += cmbBoxCities_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBoxCities);
            Controls.Add(lblCities);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCity);
            Controls.Add(listCities);
            Controls.Add(groupBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private ListBox listCities;
        private TextBox txtCity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnView;
        private Label lblCities;
        private ComboBox cmbBoxCities;
    }
}
