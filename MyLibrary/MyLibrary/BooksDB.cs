using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MyLibrary
{
    internal class BooksDB
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bengi\Desktop\Library.mdb");

        public List<Books> View_List()
        {
            List<Books> book = new List<Books>();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Books", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Books b = new Books();
                b.ID = Convert.ToInt16(dr[0].ToString());
                b.Name = dr[1].ToString();
                b.Author = dr[2].ToString();

                book.Add(b);
            }
            conn.Close();
            return book;
        }

        public void Add_Book(Books book)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Books (BookName,BookAuthor) values (@p1,@p2)", conn);
            cmd.Parameters.AddWithValue("@p1", book.Name);
            cmd.Parameters.AddWithValue("@p2",book.Author);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New book is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update_Book(Books book)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update Books set BookName = @p1,BookAuthor = @p2 where ID = @p3", conn);
            cmd.Parameters.AddWithValue("@p1", book.Name);
            cmd.Parameters.AddWithValue("@p2", book.Author);
            cmd.Parameters.AddWithValue("@p3", book.ID);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Book information is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete_Book(Books book)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from Books where ID = @p1",conn);
            cmd.Parameters.AddWithValue("@p1", book.ID);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Book is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
