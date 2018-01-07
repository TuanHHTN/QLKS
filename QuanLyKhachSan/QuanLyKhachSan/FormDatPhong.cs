using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyKhachSan
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataSet dataset;

        public double tongtien;
        public FormThuePhong frmTP;
        public FormKhachHang frmKH;
        public FormMain frmMain;
        public string maphieudat;
        public string khachhang = "";

        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            LoadComboKH();
            TimPhongTrong();
            LoadCTKH();
        }

        private void LoadComboKH()
        {
            SqlCommand cmd = new SqlCommand("SELECT makh, tenkh FROM [tblkhachhang]", DataBase.GetConnection());
            dataset = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            if (dataset.Tables != null)
            {
                dataset.Tables.Clear();
            }
            adapter.Fill(dataset, "makh");
            cbkh.DataSource = dataset.Tables["makh"];
            cbkh.DisplayMember = "tenkh";
            cbkh.ValueMember = "makh";
        }
        private void LoadDataKh()
        {
            SqlCommand cmd = new SqlCommand("DSPhieudatPhong", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvDatPhong.DataSource = tb;
            gvDatPhong.ClearSelection();
        }

        private void ChonPhong()
        {
            lvdp.Items.Clear();
            if (gvTimPhong.SelectedRows.Count > 0)
            {
                for (int i = 0; i < gvTimPhong.SelectedRows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    DataGridViewRow row = gvTimPhong.SelectedRows[i];
                    item.SubItems.Add(row.Cells["Phòng"].Value.ToString());
                    item.SubItems.Add(row.Cells["Loại"].Value.ToString());
                    item.SubItems.Add(row.Cells["Số người"].Value.ToString());
                    item.SubItems.Add(row.Cells["Giá"].Value.ToString());
                    lvdp.Items.Add(item);
                }

            }
        }

        private void TimPhongTrong()
        {
            SqlCommand cmd = new SqlCommand("TimPhongTrong", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@songuoi", txtSonguoi.Text);
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                gvTimPhong.DataSource = tb;
            }
            else
                MessageBox.Show("Không quá phòng nào thỏa mãn!", "Tìm phòng trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChonPhong();
        }

        public void LoadCTKH()
        {
            string makh = cbkh.SelectedValue.ToString();
            txtSonguoi.Clear();
            txtTiencoc.Clear();
            lsvChiTiet.Items[7].SubItems[1].Text = dateTimePicker1.Value.ToShortDateString();
            lsvChiTiet.Items[8].SubItems[1].Text = dateTimePicker2.Value.ToShortDateString();
            lsvChiTiet.Items[9].SubItems[1].Text = "";
            lsvChiTiet.Items[10].SubItems[1].Text = "";
            SqlCommand cmd = new SqlCommand("TimKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lsvChiTiet.Items[0].SubItems[1].Text = dt.Rows[0]["makh"].ToString();
                lsvChiTiet.Items[1].SubItems[1].Text = dt.Rows[0]["tenkh"].ToString();
                lsvChiTiet.Items[2].SubItems[1].Text = dt.Rows[0]["gioitinh"].ToString();
                lsvChiTiet.Items[3].SubItems[1].Text = dt.Rows[0]["ngaysinh"].ToString();
                lsvChiTiet.Items[4].SubItems[1].Text = dt.Rows[0]["cmnd"].ToString();
                lsvChiTiet.Items[5].SubItems[1].Text = dt.Rows[0]["diachi"].ToString();
                lsvChiTiet.Items[6].SubItems[1].Text = dt.Rows[0]["sdt"].ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimPhongTrong();
            ChonPhong();
        }

        private void cbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSonguoi.Clear();
            txtTiencoc.Clear();

            SqlCommand cmd = new SqlCommand("TimKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", cbkh.SelectedValue.ToString());
            adapter = new SqlDataAdapter(cmd);
            dataset = new DataSet();
            if (dataset.Tables != null)
            {
                dataset.Tables.Clear();
            }
            adapter.Fill(dataset);
            LoadCTKH();
        }
        public void LoadCTKH()
        {
            string makh = cbkh.SelectedValue.ToString();
            txtSonguoi.Clear();
            txtTiencoc.Clear();
            lsvChiTiet.Items[7].SubItems[1].Text = dateTimePicker1.Value.ToShortDateString();
            lsvChiTiet.Items[8].SubItems[1].Text = dateTimePicker2.Value.ToShortDateString();
            lsvChiTiet.Items[9].SubItems[1].Text = "";
            lsvChiTiet.Items[10].SubItems[1].Text = "";
            SqlCommand cmd = new SqlCommand("TimKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lsvChiTiet.Items[0].SubItems[1].Text = dt.Rows[0]["makh"].ToString();
                lsvChiTiet.Items[1].SubItems[1].Text = dt.Rows[0]["tenkh"].ToString();
                lsvChiTiet.Items[2].SubItems[1].Text = dt.Rows[0]["gioitinh"].ToString();
                lsvChiTiet.Items[3].SubItems[1].Text = dt.Rows[0]["ngaysinh"].ToString();
                lsvChiTiet.Items[4].SubItems[1].Text = dt.Rows[0]["cmnd"].ToString();
                lsvChiTiet.Items[5].SubItems[1].Text = dt.Rows[0]["diachi"].ToString();
                lsvChiTiet.Items[6].SubItems[1].Text = dt.Rows[0]["sdt"].ToString();
            }
        }

    }
}
