using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        BooksDB db_book = new BooksDB();
        private void list_bttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db_book.View_List();
        }

        private void list_bttn_MouseEnter(object sender, EventArgs e)
        {
            list_bttn.BackColor = Color.DarkKhaki;
        }

        private void list_bttn_MouseLeave(object sender, EventArgs e)
        {
            list_bttn.BackColor = Color.Transparent;
        }

        private void save_bttn_MouseEnter(object sender, EventArgs e)
        {
            add_bttn.BackColor = Color.DarkKhaki;
        }

        private void save_bttn_MouseLeave(object sender, EventArgs e)
        {
            add_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkKhaki;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.TabStop = false;
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.DarkKhaki;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void delete_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.DarkKhaki;
        }

        private void delete_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Transparent;
        }
        void clean()
        {
            id_txtbox.Text = "";
            name_txtbox.Text = "";
            author_txtbox.Text = "";
        }
        private void add_bttn_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Name = name_txtbox.Text;
            b.Author = author_txtbox.Text;
            db_book.Add_Book(b);
            dataGridView1.DataSource = db_book.View_List();
            clean();
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Name = name_txtbox.Text;
            b.Author = author_txtbox.Text;
            b.ID = Convert.ToInt16(id_txtbox.Text);
            db_book.Update_Book(b);
            dataGridView1.DataSource = db_book.View_List();
            clean();
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.ID = Convert.ToInt16(id_txtbox.Text);
            db_book.Delete_Book(b);
            dataGridView1.DataSource = db_book.View_List();
            clean();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            id_txtbox.Text = dataGridView1.Rows[no].Cells[0].Value.ToString();
            name_txtbox.Text = dataGridView1.Rows[no].Cells[1].Value.ToString();
            author_txtbox.Text = dataGridView1.Rows[no].Cells[2].Value.ToString();
        }
    }
}
