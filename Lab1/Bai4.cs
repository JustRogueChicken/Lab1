using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        Dictionary<string, int> GiaTien = new Dictionary<string, int>
        {
            {"Đào, phở và piano", 45000},
            {"Mai", 100000},
            {"Gặp lại chị bầu", 70000},
            {"Tarot", 90000}
        };

        Dictionary<string, string[]> PhongPhim = new Dictionary<string, string[]>
        {
            {"Đào, phở và piano", new string[] {"Phòng Chiếu 1", "Phòng Chiếu 2", "Phòng Chiếu 3"}},
            {"Mai", new string[] { "Phòng Chiếu2", "Phòng Chiếu3"}},
            {"Gặp lại chị bầu", new string[] {"Phòng Chiếu1"}},
            {"Tarot", new string[] {"Phòng Chiếu3"}}
        };

        Dictionary<string, string[]> LoaiGhe = new Dictionary<string, string[]>
        {
            {"Vé vớt", new string[] {"A1", "A5", "C1", "C5"}},
            {"Vé thường", new string[] {"A2", "A3", "A4", "C2", "C3", "C4"}},
            {"Vé VIP", new string[] {"B2", "B3", "B4"}}
        };

        string ChonPhim = "";
        string ChonPhong = "";
        List<string> ChonGhe = new List<string>();

        public Bai4()
        {
            InitializeComponent();
            foreach (string Phim in GiaTien.Keys)
            {
                comboBox1.Items.Add(Phim);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonPhim = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();
            foreach (string Phong in PhongPhim[ChonPhim])
            {
                comboBox2.Items.Add(Phong);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonPhong = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenKhachHang = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(TenKhachHang))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            if (string.IsNullOrEmpty(ChonPhim))
            {
                MessageBox.Show("Vui lòng chọn phim.");
                return;
            }

            if (string.IsNullOrEmpty(ChonPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu.");
                return;
            }

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại vé.");
                return;
            }

            string Phim = ChonPhim;
            string Phong = ChonPhong;
            int TongTien = 0;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                string seatCategory = item.ToString();

                if (seatCategory == "A1" || seatCategory == "A5" || seatCategory == "C1" || seatCategory == "C5")
                {
                    TongTien += GiaTien[Phim] / 4;
                }
                else if (seatCategory == "A2" || seatCategory == "A3" || seatCategory == "A4" || seatCategory == "C2" || seatCategory == "C3" || seatCategory == "C4")
                {
                    TongTien += GiaTien[Phim];
                }
                else if (seatCategory == "B2" || seatCategory == "B3" || seatCategory == "B4")
                {
                    TongTien += GiaTien[Phim] * 2;
                }
            }

            string bookingInfo = $"Họ và tên:" + " " + TenKhachHang.ToString() + Environment.NewLine;
            bookingInfo += "Phim:" + " " + Phim.ToString() + Environment.NewLine;
            bookingInfo += "Phòng chiếu:" + " " + Phong.ToString() + Environment.NewLine;
            bookingInfo += "Loại vé:" + " " + string.Join(", ", checkedListBox1.CheckedItems.Cast<string>().ToArray()) + Environment.NewLine;
            bookingInfo += "Số tiền cần thanh toán:" + " " + TongTien.ToString() + " " + "VND";
            MessageBox.Show(bookingInfo, "Thông tin đặt vé");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
