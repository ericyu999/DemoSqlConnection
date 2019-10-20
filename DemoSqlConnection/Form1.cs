using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSqlConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = Windows10; Initial Catalog = first; User ID = sa; Password = h335675u";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //MessageBox.Show("Connection Open !");
            //cnn.Close();


            //------------------read data from database
            //SqlCommand command;
            //SqlDataReader dataReader;
            //string sql, Output = "";

            //sql = "Select TutorialID, TutorialName from demotb";

            //command = new SqlCommand(sql, cnn);

            //dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);

            //dataReader.Close();


            //--------------insert data into database
            //SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //string sql = "";

            //sql = "Insert into demotb (TutorialID, TutorialName) values(3, '" + "VB.NET" + "')";

            //command = new SqlCommand(sql, cnn);

            //adapter.InsertCommand = new SqlCommand(sql, cnn);
            //adapter.InsertCommand.ExecuteNonQuery();



            //--------update data
            //SqlCommand command;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //string sql;

            //sql = "Update demotb set TutorialName = '"+"VB.Net Complete"+"' where TutorialID = 3";

            //command = new SqlCommand(sql, cnn);

            //adapter.InsertCommand = new SqlCommand(sql, cnn);
            //adapter.InsertCommand.ExecuteNonQuery();


            //----------delete data
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Delete demotb where TutorialID=3";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();



            command.Dispose();
            cnn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }
    }
}
