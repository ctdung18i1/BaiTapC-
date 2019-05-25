using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace BaiTap24_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FilldataGi();
        }
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da;
        DataSet ds;
        public void ConnectDB()
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-8RGET33\\SQLEXPRESS; Initial Catalog=FaceBook; Integrated Security=SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FilldataGi()
        {
            try
            {
                ConnectDB();
                da = new SqlDataAdapter("select * from Bang 1 ", conn);
                ds = new DataSet();
                da.Fill(ds);
                dataGi.ItemsSource = ds.Tables[0].DefaultView;
                dataGi.DisplayMemberPath = "CustomerID";
                dataGi.SelectedValuePath = "CompanyName";
                conn.Close();
                da.Dispose();
                ds.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ConnectDB();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into Bang 2 values(@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostaCode,@Country,@Phone,@Fax)";
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = txtID.Text;
                cmd.Parameters.Add("@ComparyName", SqlDbType.VarChar).Value = txtCompany.Text;
                cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = txtContact.Text;
                cmd.Parameters.Add("@ContactTitle", SqlDbType.VarChar).Value = txtcct.Text;
                cmd.Parameters.Add("@Addiess", SqlDbType.VarChar).Value = txtadd.Text;
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtcity.Text;
                cmd.Parameters.Add("@Region", SqlDbType.VarChar).Value = txtregion.Text;
                cmd.Parameters.Add("@PostaCode", SqlDbType.VarChar).Value = txtCode.Text;
                cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = txtcountry.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtphone.Text;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = txtfax.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Bang 1 where CustomerID = '" + txtID.Text + "'";
            int n = cmd.ExecuteNonQuery();
            if (n > 0) MessageBox.Show("Success");
            else MessageBox.Show("Fail");
        }

        private void BtnL_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            var load = new MainWindow();
            load.Show();
            this.Hide();
        }
    }
}