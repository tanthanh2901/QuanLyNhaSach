﻿using QuanLyNhaSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau(string userName)
        {
            InitializeComponent();
            txtUserName.Text = userName;
        }
        BLLTaiKhoan BLLTaiKhoan = new BLLTaiKhoan();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPW.Text != string.Empty && txtPassWord.Text != string.Empty && txtReNewPW.Text != string.Empty)
            {
                if (BLLTaiKhoan.CheckUser(txtUserName.Text, txtPassWord.Text))
                {
                    if (txtNewPW.Text == txtReNewPW.Text)
                    {
                        if (!BLLTaiKhoan.DoiMatKhau(txtUserName.Text, txtNewPW.Text))
                            MessageBox.Show("Đổi mật khẩu không thành công !!", "Thông báo", MessageBoxButtons.OK);
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thành công !!", "Thông báo", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                    else MessageBox.Show("Mật khẩu không trùng khớp !!", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Sai mật khẩu, Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin !!");
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn thoát!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void imgShowHide_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (txtPassWord.PasswordChar == '*')
                {
                    pb.Image = Properties.Resources.Hide_Password_256;
                    txtPassWord.PasswordChar = '\0';
                }
                else
                {
                    pb.Image = Properties.Resources.Show_Password_256;
                    txtPassWord.PasswordChar = '*';
                }
            }
        }

        private void imgShowHideNewPW_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (txtNewPW.PasswordChar == '*')
                {
                    pb.Image = Properties.Resources.Hide_Password_256;
                    txtNewPW.PasswordChar = '\0';
                }
                else
                {
                    pb.Image = Properties.Resources.Show_Password_256;
                    txtNewPW.PasswordChar = '*';
                }
            }
        }

        private void imgShowHideReNewPW_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (txtReNewPW.PasswordChar == '*')
                {
                    pb.Image = Properties.Resources.Hide_Password_256;
                    txtReNewPW.PasswordChar = '\0';
                }
                else
                {
                    pb.Image = Properties.Resources.Show_Password_256;
                    txtReNewPW.PasswordChar = '*';
                }
            }
        }
    }
}
