﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fDonViThuoc : Form
    {
        BUS_LoaiDonVi bus_loaiDonVi = new BUS_LoaiDonVi();
        DataTable dtLoaiDonVi;

        public fDonViThuoc()
        {
            InitializeComponent();
            ReloadDSLoaiDonVi();
        }
        void ReloadDSLoaiDonVi()
        {
            dtLoaiDonVi = bus_loaiDonVi.GetThongTinTatCaLoaiDonVi();
            dtLoaiDonVi.Columns[0].ColumnName = "Mã loại đơn vị";
            dtLoaiDonVi.Columns[1].ColumnName = "Tên loại đơn vị";

            grvDSDonVi.DataSource = dtLoaiDonVi;

        }

        bool isThem = false;
        bool isSua = false;
        private void grvDSDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isThem || isSua)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDSDonVi.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells["Mã loại đơn vị"].Value.ToString() == "")
                    return;

                tbxMaLoaiDonVi.Text = row.Cells["Mã loại đơn vị"].Value.ToString();
                tbxTenLoaiDonVi.Text = row.Cells["Tên loại đơn vị"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)//them
            {
                tbxMaLoaiDonVi.Text = bus_loaiDonVi.GetMaLoaiDonViNext();
                tbxTenLoaiDonVi.ReadOnly = false;
                btnThem.Text = "Hoàn tất";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            else//Luu
            {
                if(tbxTenLoaiDonVi.Text.Length==0)
                {
                    MessageBox.Show("Tên đơn vị không được để trống!");
                    return;
                }
                if(tbxTenLoaiDonVi.Text.Length>10)
                {
                    MessageBox.Show("Tên đơn vị không được quá 10 ký tự!");
                    return;
                }
                try
                {
                    DTO_LoaiDonVi loaiDonVi = new DTO_LoaiDonVi(tbxMaLoaiDonVi.Text, tbxTenLoaiDonVi.Text);
                    if (!bus_loaiDonVi.Add(loaiDonVi))
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!");
                        ReloadDSLoaiDonVi();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                    return;
                }

                btnThem.Text = "Thêm";
                tbxTenLoaiDonVi.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
            isThem = !isThem;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiDonVi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại đơn vị để sửa!");
                return;
            }
             
            if (!isSua)//Sua
            {
                tbxTenLoaiDonVi.ReadOnly = false;
                btnSua.Text = "Hoàn tất";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (tbxTenLoaiDonVi.Text.Length > 10)
                {
                    MessageBox.Show("Tên đơn vị không được quá 10 ký tự!");
                    return;
                }
                if (tbxTenLoaiDonVi.Text.Length == 0)
                {
                    MessageBox.Show("Tên đơn vị không được để trống!");
                    return;
                }
                try
                {
                    DTO_LoaiDonVi loaiDonVi = new DTO_LoaiDonVi(tbxMaLoaiDonVi.Text, tbxTenLoaiDonVi.Text);
                    if (!bus_loaiDonVi.Update(loaiDonVi))
                    {
                        MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!");
                        ReloadDSLoaiDonVi();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                tbxTenLoaiDonVi.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }

            isSua = !isSua;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiDonVi.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã loại đơn vị!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại đơn vị này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = bus_loaiDonVi.Delete(tbxMaLoaiDonVi.Text);
                if (kq)
                {
                    ReloadDSLoaiDonVi();
                    tbxMaLoaiDonVi.Text = "";
                    tbxTenLoaiDonVi.Text = "";
                    MessageBox.Show("Xóa loại đơn vị thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa loại đơn vị thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;

                tbxTenLoaiDonVi.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                tbxMaLoaiDonVi.Text = "";
                tbxTenLoaiDonVi.Text = "";
                ReloadDSLoaiDonVi();
            }
            else if (isThem)
            {
                isThem = false;

                tbxTenLoaiDonVi.ReadOnly = true;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


                tbxMaLoaiDonVi.Text = "";
                tbxTenLoaiDonVi.Text = "";
                ReloadDSLoaiDonVi();
            }

        }
    }
}
