using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacCalculating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private bool NamNhuan(int nam)
        {
            if (nam % 400 == 0 || nam % 4 == 0 && nam % 100 != 0)
                return true;
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int NgayLonNhat;
                int ngay = Int32.Parse(textBox1.Text);
                int thang = Int32.Parse(textBox2.Text);
                int nam = Int32.Parse(textBox3.Text);
                if (nam < 1930)
                {
                    MessageBox.Show("Năm không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                }

                if (thang < 1 || thang > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                }
                bool Kiemtra = NamNhuan(nam);
                if (thang == 2 && Kiemtra == true)
                {
                    NgayLonNhat = 29;
                }
                else
                {
                    switch (thang)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            NgayLonNhat = 30;
                            break;
                        case 2:
                            NgayLonNhat = 28;
                            break;
                        default:
                            NgayLonNhat = 31;
                            break;
                    }
                }
                if (ngay < 1 || ngay > NgayLonNhat)
                {
                    MessageBox.Show("Ngày không hợp lệ vì vượt quá số ngày của tháng", "Thông báo", MessageBoxButtons.OK);
                }
                DateTime date = new DateTime(nam, thang, ngay);
                int NgayTrongTuan = (int)date.DayOfWeek + 1;
                if (NgayTrongTuan == 1)
                    richTextBox1.Text += "Đây là ngày đầu tiên trong tuần (Chủ nhật)";
                else
                    richTextBox1.Text += "Đây là ngày thứ " + NgayTrongTuan.ToString() + " " + "trong tuần" + " " + "(Thứ " + NgayTrongTuan + ")" + "\n";

                switch (thang)
                {
                    case 1:
                        if (ngay >= 20)
                        {
                            richTextBox3.Text = "Bảo Bình";
                        }
                        else
                        {
                            richTextBox3.Text = "Ma Kết";
                        }
                        break;

                    case 2:
                        if (ngay >= 19)
                        {
                            richTextBox3.Text = "Song Ngư";
                        }
                        else
                        {
                            richTextBox3.Text = "Bảo Bình";
                        }
                        break;

                    case 3:
                        if (ngay >= 21)
                        {
                            richTextBox3.Text = "Bạch Dương";
                        }
                        else
                        {
                            richTextBox3.Text = "Song Ngư";
                        }
                        break;

                    case 4:
                        if (ngay < 20)
                        {
                            richTextBox3.Text = "Bạch Dương";
                        }
                        else
                        {
                            richTextBox3.Text = "Kim Ngưu";
                        }
                        break;

                    case 5:
                        if (ngay >= 21)
                        {
                            richTextBox3.Text = "Song Tử";
                        }
                        else
                        {
                            richTextBox3.Text = "Kim Ngưu";
                        }
                        break;

                    case 6:
                        if (ngay < 21)
                        {
                            richTextBox3.Text = "Song Tử";
                        }
                        else
                        {
                            richTextBox3.Text = "Cự Giải";
                        }
                        break;

                    case 7:
                        if (ngay >= 23)
                        {
                            richTextBox3.Text = "Sư Tử";
                        }
                        else
                        {
                            richTextBox3.Text = "Cự Giải";
                        }
                        break;

                    case 8:
                        if (ngay < 23)
                        {
                            richTextBox3.Text = "Sư Tử";
                        }
                        else
                        {
                            richTextBox3.Text = "Xử Nữ";
                        }
                        break;

                    case 9:
                        if (ngay >= 23)
                        {
                            richTextBox3.Text = "Thiên Bình";
                        }
                        else
                        {
                            richTextBox3.Text = "Xử Nữ";
                        }
                        break;

                    case 10:
                        if (ngay < 23)
                        {
                            richTextBox3.Text = "Thiên Bình";
                        }
                        else
                        {
                            richTextBox3.Text = "Thần Nông";
                        }
                        break;

                    case 11:
                        if (ngay >= 22)
                        {
                            richTextBox3.Text = "Nhân Mã";
                        }
                        else
                        {
                            richTextBox3.Text = "Thần Nông";
                        }
                        break;

                    case 12:
                        if (ngay < 22)
                        {
                            richTextBox3.Text = "Nhân Mã";
                        }
                        else
                        {
                            richTextBox3.Text = "Ma Kết";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Text = "21/03 - 20/04 : Cung Bạch Dương \n" +
              "21/04 - 21/05 : Cung Kim Ngưu \n" +
              "22/05 - 21/06 : Cung Song Tử \n" +
              "22/06 - 22/07 : Cung Cự Giải \n" +
              "23/07 - 22/08 : Cung Sư Tử \n" +
              "23/08 - 23/09 : Cung Xử Nữ \n" +
              "24/09 - 23/10 : Cung Thiên Bình \n" +
              "24/10 - 22/11 : Cung Thần Nông \n" +
              "23/11 - 21/12 : Cung Nhân Mã \n" +
              "22/12 - 20/01 : Cung Ma Kết \n" +
              "21/01 - 19/02 : Cung Bảo Bình \n" +
              "20/02 - 20/03 : Cung Song Ngư \n";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            richTextBox1.Text = " ";
            richTextBox2.Text = " ";
            richTextBox3.Text = " ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
