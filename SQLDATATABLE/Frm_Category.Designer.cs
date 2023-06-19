namespace SQLDATATABLE
{
    partial class Frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Category));
            this.Table_Category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Category_Name = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Btn_CategorySave = new System.Windows.Forms.Button();
            this.Btn_CategoryList = new System.Windows.Forms.Button();
            this.Btn_CategoryClear = new System.Windows.Forms.Button();
            this.Btn_CategoryUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_Category
            // 
            this.Table_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Category.Location = new System.Drawing.Point(18, 295);
            this.Table_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Table_Category.Name = "Table_Category";
            this.Table_Category.Size = new System.Drawing.Size(790, 383);
            this.Table_Category.TabIndex = 0;
            this.Table_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Category_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category ID";
            // 
            // Category_ID
            // 
            this.Category_ID.Location = new System.Drawing.Point(172, 82);
            this.Category_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.Size = new System.Drawing.Size(242, 26);
            this.Category_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // Category_Name
            // 
            this.Category_Name.Location = new System.Drawing.Point(172, 122);
            this.Category_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(242, 26);
            this.Category_Name.TabIndex = 2;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(497, 87);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(82, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(495, 24);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // Btn_CategorySave
            // 
            this.Btn_CategorySave.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CategorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CategorySave.ForeColor = System.Drawing.Color.White;
            this.Btn_CategorySave.Location = new System.Drawing.Point(594, 87);
            this.Btn_CategorySave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Btn_CategorySave.Name = "Btn_CategorySave";
            this.Btn_CategorySave.Size = new System.Drawing.Size(214, 52);
            this.Btn_CategorySave.TabIndex = 3;
            this.Btn_CategorySave.Text = "Save";
            this.Btn_CategorySave.UseVisualStyleBackColor = false;
            this.Btn_CategorySave.Click += new System.EventHandler(this.button8_Click);
            // 
            // Btn_CategoryList
            // 
            this.Btn_CategoryList.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CategoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CategoryList.ForeColor = System.Drawing.Color.White;
            this.Btn_CategoryList.Location = new System.Drawing.Point(594, 24);
            this.Btn_CategoryList.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Btn_CategoryList.Name = "Btn_CategoryList";
            this.Btn_CategoryList.Size = new System.Drawing.Size(214, 52);
            this.Btn_CategoryList.TabIndex = 4;
            this.Btn_CategoryList.Text = "List";
            this.Btn_CategoryList.UseVisualStyleBackColor = false;
            this.Btn_CategoryList.Click += new System.EventHandler(this.button7_Click);
            // 
            // Btn_CategoryClear
            // 
            this.Btn_CategoryClear.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CategoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CategoryClear.ForeColor = System.Drawing.Color.White;
            this.Btn_CategoryClear.Location = new System.Drawing.Point(594, 149);
            this.Btn_CategoryClear.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Btn_CategoryClear.Name = "Btn_CategoryClear";
            this.Btn_CategoryClear.Size = new System.Drawing.Size(214, 52);
            this.Btn_CategoryClear.TabIndex = 4;
            this.Btn_CategoryClear.Text = "Clear";
            this.Btn_CategoryClear.UseVisualStyleBackColor = false;
            this.Btn_CategoryClear.Click += new System.EventHandler(this.Btn_CategoryClear_Click);
            // 
            // Btn_CategoryUpdate
            // 
            this.Btn_CategoryUpdate.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CategoryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CategoryUpdate.ForeColor = System.Drawing.Color.White;
            this.Btn_CategoryUpdate.Location = new System.Drawing.Point(594, 212);
            this.Btn_CategoryUpdate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Btn_CategoryUpdate.Name = "Btn_CategoryUpdate";
            this.Btn_CategoryUpdate.Size = new System.Drawing.Size(214, 52);
            this.Btn_CategoryUpdate.TabIndex = 3;
            this.Btn_CategoryUpdate.Text = "Update";
            this.Btn_CategoryUpdate.UseVisualStyleBackColor = false;
            this.Btn_CategoryUpdate.Click += new System.EventHandler(this.Btn_CategoryUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(497, 212);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(826, 692);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_CategoryUpdate);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Btn_CategoryClear);
            this.Controls.Add(this.Btn_CategorySave);
            this.Controls.Add(this.Btn_CategoryList);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.Category_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table_Category);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Category";
            this.Text = "Frm_Category";
            this.Load += new System.EventHandler(this.Frm_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Category_Name;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button Btn_CategorySave;
        private System.Windows.Forms.Button Btn_CategoryList;
        private System.Windows.Forms.Button Btn_CategoryClear;
        private System.Windows.Forms.Button Btn_CategoryUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}