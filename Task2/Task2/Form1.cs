

using Microsoft.Data.SqlClient;
using System.Data;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
       SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Task2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public object ScriptManager { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

            Group = (DataGridViewTextBoxColumn)comboBox1.SelectedValue;
            Item = (DataGridViewTextBoxColumn)comboBox2.SelectedValue;
            con.Open();

            SqlCommand comm = new SqlCommand("Insert into Item Values ('" + Group + "','" + Item + "')", con);
            comm.ExecuteNonQuery();
            con.Close();

            // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully saved')", true);

            LoadRecord();

        }
        void LoadRecord()
        {

            SqlCommand comm = new SqlCommand("Select * from Item", con);
            SqlDataAdapter sd = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            object dataBind = dataGridView1.DataBindings;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            Group = (DataGridViewTextBoxColumn)comboBox1.SelectedValue;
            Item = (DataGridViewTextBoxColumn)comboBox2.SelectedValue;
            con.Open();

            SqlCommand comm = new SqlCommand(" Update  Item set  Group ='" + Group + "', where Item='" + Item + "' ", con);
            comm.ExecuteNonQuery();
            con.Close();
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully updated')", true);
            LoadRecord();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            Group = (DataGridViewTextBoxColumn)comboBox1.SelectedValue;
            Item = (DataGridViewTextBoxColumn)comboBox2.SelectedValue;
            con.Open();

            SqlCommand comm = new SqlCommand(" Delete  Item  where Item='" + Item + "' ", con);
            comm.ExecuteNonQuery();
            con.Close();
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully deleted')", true);
            LoadRecord();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
