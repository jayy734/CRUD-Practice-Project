namespace CRUD_Practice_Project
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
            this.components = new System.ComponentModel.Container();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbMajor = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cRUD_Practice_ProjectDataSet = new CRUD_Practice_Project.CRUD_Practice_ProjectDataSet();
            this.cRUDPracticeProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_Practice_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDPracticeProjectDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(190, 338);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 36);
            this.btn_update.TabIndex = 57;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 346);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(528, 35);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(394, 30);
            this.tbSearch.TabIndex = 55;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Search:";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Silver;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(49, 338);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(118, 36);
            this.btn_insert.TabIndex = 53;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(190, 281);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(205, 30);
            this.tbAge.TabIndex = 52;
            // 
            // tbMajor
            // 
            this.tbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMajor.Location = new System.Drawing.Point(190, 224);
            this.tbMajor.Name = "tbMajor";
            this.tbMajor.Size = new System.Drawing.Size(205, 30);
            this.tbMajor.TabIndex = 51;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(190, 165);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(205, 30);
            this.tbLastName.TabIndex = 50;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(190, 100);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(205, 30);
            this.tbFirstName.TabIndex = 49;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(190, 40);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(205, 30);
            this.tbID.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Major:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "First Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Student ID:";
            // 
            // cRUD_Practice_ProjectDataSet
            // 
            this.cRUD_Practice_ProjectDataSet.DataSetName = "CRUD_Practice_ProjectDataSet";
            this.cRUD_Practice_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDPracticeProjectDataSetBindingSource
            // 
            this.cRUDPracticeProjectDataSetBindingSource.DataSource = this.cRUD_Practice_ProjectDataSet;
            this.cRUDPracticeProjectDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 58;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(190, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 59;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbMajor);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_Practice_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDPracticeProjectDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbMajor;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource cRUDPracticeProjectDataSetBindingSource;
        private CRUD_Practice_ProjectDataSet cRUD_Practice_ProjectDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

