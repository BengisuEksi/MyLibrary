namespace MyLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.list_bttn = new System.Windows.Forms.Button();
            this.add_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(809, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 4;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(140, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Author: ";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_txtbox.Location = new System.Drawing.Point(267, 96);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(190, 30);
            this.name_txtbox.TabIndex = 0;
            // 
            // author_txtbox
            // 
            this.author_txtbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.author_txtbox.Location = new System.Drawing.Point(267, 132);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(190, 30);
            this.author_txtbox.TabIndex = 1;
            // 
            // list_bttn
            // 
            this.list_bttn.BackColor = System.Drawing.Color.Transparent;
            this.list_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_bttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_bttn.Location = new System.Drawing.Point(491, 78);
            this.list_bttn.Name = "list_bttn";
            this.list_bttn.Size = new System.Drawing.Size(112, 30);
            this.list_bttn.TabIndex = 2;
            this.list_bttn.Text = "List";
            this.list_bttn.UseVisualStyleBackColor = false;
            this.list_bttn.Click += new System.EventHandler(this.list_bttn_Click);
            this.list_bttn.MouseEnter += new System.EventHandler(this.list_bttn_MouseEnter);
            this.list_bttn.MouseLeave += new System.EventHandler(this.list_bttn_MouseLeave);
            // 
            // add_bttn
            // 
            this.add_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_bttn.Location = new System.Drawing.Point(491, 121);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(112, 31);
            this.add_bttn.TabIndex = 3;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = false;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            this.add_bttn.MouseEnter += new System.EventHandler(this.save_bttn_MouseEnter);
            this.add_bttn.MouseLeave += new System.EventHandler(this.save_bttn_MouseLeave);
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.Transparent;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_bttn.Location = new System.Drawing.Point(609, 121);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(112, 31);
            this.delete_bttn.TabIndex = 6;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            this.delete_bttn.MouseEnter += new System.EventHandler(this.delete_bttn_MouseEnter);
            this.delete_bttn.MouseLeave += new System.EventHandler(this.delete_bttn_MouseLeave);
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_bttn.Location = new System.Drawing.Point(609, 78);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(112, 30);
            this.update_bttn.TabIndex = 5;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            this.update_bttn.MouseEnter += new System.EventHandler(this.update_bttn_MouseEnter);
            this.update_bttn.MouseLeave += new System.EventHandler(this.update_bttn_MouseLeave);
            // 
            // id_txtbox
            // 
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_txtbox.Location = new System.Drawing.Point(267, 60);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(190, 30);
            this.id_txtbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(130, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Number: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.update_bttn);
            this.Controls.Add(this.add_bttn);
            this.Controls.Add(this.list_bttn);
            this.Controls.Add(this.author_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.Button list_bttn;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label3;
    }
}

