using Microsoft.VisualBasic.Logging;
using System.Text;

namespace Final__Project_Noey
{
    public partial class Form1 : Form
    {
        Court_Vision_Low_Next_Nature_1 court_Vision_Low_Next_Nature_1 = new Court_Vision_Low_Next_Nature_1();
        Court_Vision_Low_Next_Nature_2 court_Vision_Low_Next_Nature_2 = new Court_Vision_Low_Next_Nature_2();
        Court_Legacy_Lift_3 court_Legacy_Lift_3 = new Court_Legacy_Lift_3();
        Court_Vision_Alta_4 court_Vision_Alta_4 = new Court_Vision_Alta_4();
        Court_Vision_Alta_5 court_Vision_Alta_5 = new Court_Vision_Alta_5();
        Court_Legacy_Lift_6 court_Legacy_Lift_6 = new Court_Legacy_Lift_6();
        Court_Vision_Low_7 court_Vision_Low_7 = new Court_Vision_Low_7();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = court_Vision_Low_Next_Nature_1.getName();
            nameProduct.Text = name;

            string price = court_Vision_Low_Next_Nature_1.getPrice();
            Priceproduct.Text = price;

            string color = court_Vision_Low_Next_Nature_1.getColor();
            Colorproduct.Text = color;

            string size = court_Vision_Low_Next_Nature_1.getSize();
            Sizeproduct.Text = size;
        }

        private void Priceproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = court_Vision_Low_Next_Nature_2.getName();
            nameProduct.Text = name;

            string price = court_Vision_Low_Next_Nature_2.getPrice();
            Priceproduct.Text = price;

            string color = court_Vision_Low_Next_Nature_2.getColor();
            Colorproduct.Text = color;

            string size = court_Vision_Low_Next_Nature_2.getSize();
            Sizeproduct.Text = size;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = court_Legacy_Lift_3.getName();
            nameProduct.Text = name;

            string price = court_Legacy_Lift_3.getPrice();
            Priceproduct.Text = price;

            string color = court_Legacy_Lift_3.getColor();
            Colorproduct.Text = color;

            string size = court_Legacy_Lift_3.getSize();
            Sizeproduct.Text = size;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = court_Vision_Alta_4.getName();
            nameProduct.Text = name;

            string price = court_Vision_Alta_4.getPrice();
            Priceproduct.Text = price;

            string color = court_Vision_Alta_4.getColor();
            Colorproduct.Text = color;

            string size = court_Vision_Alta_4.getSize();
            Sizeproduct.Text = size;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = court_Vision_Alta_5.getName();
            nameProduct.Text = name;

            string price = court_Vision_Alta_5.getPrice();
            Priceproduct.Text = price;

            string color = court_Vision_Alta_5.getColor();
            Colorproduct.Text = color;

            string size = court_Vision_Alta_5.getSize();
            Sizeproduct.Text = size;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = court_Legacy_Lift_6.getName();
            nameProduct.Text = name;

            string price = court_Legacy_Lift_6.getPrice();
            Priceproduct.Text = price;

            string color = court_Legacy_Lift_6.getColor();
            Colorproduct.Text = color;

            string size = court_Legacy_Lift_6.getSize();
            Sizeproduct.Text = size;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = court_Vision_Low_7.getName();
            nameProduct.Text = name;

            string price = court_Vision_Low_7.getPrice();
            Priceproduct.Text = price;

            string color = court_Vision_Low_7.getColor();
            Colorproduct.Text = color;

            string size = court_Vision_Low_7.getSize();
            Sizeproduct.Text = size;
        }

        private void batton8_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = nameProduct.Text;
            dataGridView1.Rows[n].Cells[1].Value = Priceproduct.Text;
            dataGridView1.Rows[n].Cells[2].Value = Colorproduct.Text;
            dataGridView1.Rows[n].Cells[3].Value = Sizeproduct.Text;

            nameProduct.Text = "";
            Priceproduct.Text = "";
            Colorproduct.Text = "";
            Sizeproduct.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4]);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(.csv)|.csv";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCSV[0] += columnNames;
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                var cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                outputCSV[i] += cellValue != null ? cellValue.ToString() + "," : ",";
                            }
                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        MessageBox.Show("Exported to CSV successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int rowIndax = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndax);

        }
    }
}