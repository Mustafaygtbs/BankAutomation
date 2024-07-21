using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BankAutomation
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=ProjelerVT;Integrated Security=True;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileriGoruntule();
            dataGridView1.ClearSelection();
            textBoxMusteriId.Text = "0";
        }

        private void verileriGoruntule()
        {
            try
            {
                string Sorgu = "SELECT * FROM MusteriBilgileri";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database \nError code:A3106 \n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriId.Text = dataGridView1.Rows[selection].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selection].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[selection].Cells[2].Value.ToString();
            textBoxMaas.Text = dataGridView1.Rows[selection].Cells[3].Value.ToString();
            textBoxCity.Text = dataGridView1.Rows[selection].Cells[5].Value.ToString();

            textBoxAvaible.Text = dataGridView1.Rows[selection].Cells[4].Value.ToString();
            string metin = dataGridView1.Rows[selection].Cells[4].Value.ToString();
            if (metin.Equals("True"))
            {
                textBoxAvaible.Text = "Evet";
            }
            else
            {
                textBoxAvaible.Text = "Hayýr";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO MusteriBilgileri (Ad, Soyad, AylikGelir, KrediyeUygunMu, Sehir) " +
                                                        "VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSurname.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxMaas.Text);
                if (Convert.ToInt32(textBoxMaas.Text) >= 2750)
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 1);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 0);
                }
                sqlCommand.Parameters.AddWithValue("@P5", textBoxCity.Text);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data to database \nError code:A3107 \n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
            verileriGoruntule();
            MetinKutulariniTemizle();
            dataGridView1.ClearSelection();

        }
        private void MetinKutulariniTemizle()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxMaas.Text = "0";
            textBoxCity.Clear();
            textBoxMaas.Clear();
            textBoxCity.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetinKutulariniTemizle();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer to delete");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM MusteriBilgileri WHERE MusteriId=@P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxMusteriId.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data from database \nError code:A3108 \n" + ex.Message);
                }
                finally
                {
                    if (baglanti != null)
                        baglanti.Close();
                }
            }
            verileriGoruntule();
            MetinKutulariniTemizle();
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer to delete");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE MusteriBilgileri SET Ad=@P1, Soyad=@P2, AylikGelir=@P3, KrediyeUygunMu=@P4, Sehir=@P5 WHERE MusteriId=@P6", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxName.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSurname.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxMaas.Text);
                    if (Convert.ToInt32(textBoxMaas.Text) >= 2750)
                    {
                        sqlCommand.Parameters.AddWithValue("@P4", 1);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@P4", 0);
                    }
                    sqlCommand.Parameters.AddWithValue("@P5", textBoxCity.Text);
                    sqlCommand.Parameters.AddWithValue("@P6", textBoxMusteriId.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data in database \nError code:A3109 \n" + ex.Message);
                }
                finally
                {
                    if (baglanti != null)
                        baglanti.Close();
                }
                verileriGoruntule();
                MetinKutulariniTemizle();
                dataGridView1.ClearSelection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM MusteriBilgileri WHERE Ad LIKE '" + textBoxName.Text + "%'"
                                                             + "AND Soyad LIKE '" + textBoxSurname.Text + "%'"
                                                             + "AND Sehir LIKE '" + textBoxCity.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database \nError code:A3110 \n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
            MetinKutulariniTemizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
            MetinKutulariniTemizle();
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM MusteriBilgileri WHERE AylikGelir = " +textBoxMaas.Text;
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database \nError code:A3111 \n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
            MetinKutulariniTemizle();

        }
    }
}
