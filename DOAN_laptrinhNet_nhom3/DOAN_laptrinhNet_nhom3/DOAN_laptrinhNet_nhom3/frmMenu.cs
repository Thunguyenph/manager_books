using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_laptrinhNet_nhom3
{ 
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlysach f = new frmQuanlysach();
            f.ShowDialog();
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhacungcap f = new frmNhacungcap();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChitiethoadonbanhang f = new frmChitiethoadonbanhang();
            f.ShowDialog();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonbanhang f = new frmHoadonbanhang();
            f.ShowDialog();
        }

        private void lịchSửHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichsuhoadonbanhang f = new frmLichsuhoadonbanhang();
            f.ShowDialog();
        }

        private void lýDoHủyĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLydohuydonbanhang f = new frmLydohuydonbanhang();
            f.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            f.ShowDialog();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonnhaphang f = new frmHoadonnhaphang();
            f.ShowDialog();
        }

        private void lịchSửHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichsuhoadonnhaphang f = new frmLichsuhoadonnhaphang();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChitiethoadonnhaphang f = new frmChitiethoadonnhaphang();
            f.ShowDialog();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkedoanhthu f = new frmThongkedoanhthu();
            f.ShowDialog();
        }

        private void thốngKêKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkekhohang f = new frmThongkekhohang();
            f.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoan f = new frmQuanlytaikhoan();
            f.ShowDialog();
         
        }

        private void mnuQuanlysach_Click(object sender, EventArgs e)
        {
            frmQuanlysach f = new frmQuanlysach();
            f.ShowDialog();
        }

        private void tàiKhoảnĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaikhoandangnhap f = new frmTaikhoandangnhap();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.No) return;
            else
            Close();
            
        }
    }
}
