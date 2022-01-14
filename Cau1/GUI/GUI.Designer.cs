namespace Cau1.GUI
{
    partial class GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDateBirth = new System.Windows.Forms.DateTimePicker();
            this.tbGender = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaceBirth = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(65, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị";
            // 
            // tbNameDepartment
            // 
            this.tbNameDepartment.FormattingEnabled = true;
            this.tbNameDepartment.Location = new System.Drawing.Point(65, 36);
            this.tbNameDepartment.Name = "tbNameDepartment";
            this.tbNameDepartment.Size = new System.Drawing.Size(121, 21);
            this.tbNameDepartment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(258, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // tbDateBirth
            // 
            this.tbDateBirth.Location = new System.Drawing.Point(469, 6);
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.Size = new System.Drawing.Size(200, 20);
            this.tbDateBirth.TabIndex = 7;
            // 
            // tbGender
            // 
            this.tbGender.AutoSize = true;
            this.tbGender.Location = new System.Drawing.Point(697, 8);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(91, 17);
            this.tbGender.TabIndex = 8;
            this.tbGender.Text = "Giới tính Nam";
            this.tbGender.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nơi sinh";
            // 
            // tbPlaceBirth
            // 
            this.tbPlaceBirth.Location = new System.Drawing.Point(255, 37);
            this.tbPlaceBirth.Name = "tbPlaceBirth";
            this.tbPlaceBirth.Size = new System.Drawing.Size(533, 20);
            this.tbPlaceBirth.TabIndex = 10;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmployee.Location = new System.Drawing.Point(15, 75);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(773, 296);
            this.dgvEmployee.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datebirth";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gender";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NameDepartment";
            this.Column5.HeaderText = "Đơn vị";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PlaceBirth";
            this.Column6.HeaderText = "Nơi sinh";
            this.Column6.Name = "Column6";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(713, 389);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(623, 389);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 29);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(531, 389);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 29);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(438, 389);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 29);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tbPlaceBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbDateBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNameDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbNameDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tbDateBirth;
        private System.Windows.Forms.CheckBox tbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaceBirth;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
    }
}