using System.Data;
using System.Data.SQLite;

namespace VesselsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var connection = Repository.CreateConnection();
            string query = "Select * from Vessel ";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connection = Repository.CreateConnection();

            var rowId = idBox.Text;
            var rowName = nameBox.Text;
            var query = new SQLiteCommand(connection);
            query.CommandText = "INSERT INTO Vessel(Id, Name) values (@id, @name)";
            query.Parameters.AddWithValue("@id", rowId);
            query.Parameters.AddWithValue("@name", rowName);
            query.ExecuteNonQuery();

            button1_Click_1(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var connection = Repository.CreateConnection();

            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var rowId = row.Cells[0].Value;
                var query = new SQLiteCommand(connection);
                query.CommandText = "delete from Vessel where Id = @id";
                query.Parameters.AddWithValue("@id", rowId);
                try
                {
                    query.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }

            button1_Click_1(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var connection = Repository.CreateConnection();

            var query = new SQLiteCommand(connection);
            query.CommandText = "update Vessel set name = @name where id = @id";
            query.Parameters.AddWithValue("@name", nameBox.Text);
            query.Parameters.AddWithValue("@id", idBox.Text);

            query.ExecuteNonQuery();
;
            button1_Click_1(sender, e);

        }
    }
}
