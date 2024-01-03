using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class CaiDat : Form
    {
        private TextBox _yTuongTextBox;
        private ListBox _codeListBox;

        // Toc Do : cang lon cang cham
        public bool mauNenForm ;
        public CaiDat(TextBox yTuongTextBox, ListBox codeListBox)
        {
            InitializeComponent();

            kichCoNodeTextBox.Text = ThamSo.KichCoNode.ToString();
            khoanCachGiuaCacNodeTextBox.Text = ThamSo.KhoanCachGiuaCacNode.ToString();

            mauNenNodeColorButton.BackColor = ThamSo.MauNenNode;
            mauNodeDaXetQuaColorButton.BackColor = ThamSo.MauNodeDaXetQua;
            mauNodeDangXetColorButton.BackColor = ThamSo.MauNodeDangXet;

            soLuongPhanTuMacDinhTextBox.Text = Properties.Settings.Default.SoLuongPhanTuMacDinh.ToString();

            if (Properties.Settings.Default.MauNenForm)
                mauToiRadioButton.Checked = true;
            else
                mauSangRadioButton.Checked = true;

            _yTuongTextBox = yTuongTextBox;
            _codeListBox = codeListBox;

            yTuongFontDialog.Font = yTuongTextBox.Font;
            codeFontDialog.Font = codeListBox.Font;

            fontYTuongTextBox.Text = string.Format("{0} {1}", yTuongTextBox.Font.Name, yTuongTextBox.Font.Size);
            fontCodeTextBox.Text = string.Format("{0} {1}", codeListBox.Font.Name, codeListBox.Font.Size);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                t.BackColor = colorDialog1.Color;
            }
        }

        private void fontYTuongTextBox_Click(object sender, EventArgs e)
        {
            DialogResult rs = yTuongFontDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Font yTuongFont = yTuongFontDialog.Font;
                fontYTuongTextBox.Text = string.Format("{0} {1}", yTuongFont.Name, yTuongFont.Size);

            }
        }

        private void fontCodeTextBox_Click(object sender, EventArgs e)
        {
            DialogResult rs = codeFontDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Font codeFont = codeFontDialog.Font;
                fontCodeTextBox.Text = string.Format("{0} {1}", codeFont.Name, codeFont.Size);

            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            int kichCoNode, khoanCachGiuaCacNode, soLuongPhanTuMacDinh;
            bool rs = int.TryParse(kichCoNodeTextBox.Text, out kichCoNode);
            if (rs = false || (kichCoNode < 30 || kichCoNode > 50))
            {
                MessageBox.Show("Kích cỡ Node phải là số nguyên và thuộc khoản từ 30 đến 50!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rs = int.TryParse(khoanCachGiuaCacNodeTextBox.Text, out khoanCachGiuaCacNode);
            if (rs = false || (khoanCachGiuaCacNode < 60 || khoanCachGiuaCacNode > 100))
            {
                MessageBox.Show("Khoảng cách giữa các Node phải là số nguyên và thuộc khoản từ 60 đến 100!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rs = int.TryParse(soLuongPhanTuMacDinhTextBox.Text, out soLuongPhanTuMacDinh);
            if (rs = false || (soLuongPhanTuMacDinh < 1 || soLuongPhanTuMacDinh > ThamSo.SoLuongPhanTuMax))
            {
                MessageBox.Show("Số lượng phần tử mặc định phải là số nguyên và thuộc khoản từ 1 đến " + ThamSo.SoLuongPhanTuMax + " !", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Properties.Settings.Default.KichCoNode = ThamSo.KichCoNode = kichCoNode;
            Properties.Settings.Default.KhoanCachGiuaCacNode = ThamSo.KhoanCachGiuaCacNode = khoanCachGiuaCacNode;

            Properties.Settings.Default.MauNenNode = ThamSo.MauNenNode = mauNenNodeColorButton.BackColor;
            Properties.Settings.Default.MauNodeDaXetQua = ThamSo.MauNodeDaXetQua = mauNodeDaXetQuaColorButton.BackColor;
            Properties.Settings.Default.MauNodeDangXet = ThamSo.MauNodeDangXet = mauNodeDangXetColorButton.BackColor;

            Properties.Settings.Default.fontYTuongTextBox = _yTuongTextBox.Font = yTuongFontDialog.Font;
            Properties.Settings.Default.fontCodeListBox = _codeListBox.Font = codeFontDialog.Font;

            Properties.Settings.Default.SoLuongPhanTuMacDinh = soLuongPhanTuMacDinh;

            Properties.Settings.Default.MauNenForm = mauToiRadioButton.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void macDinhButton_Click(object sender, EventArgs e)
        {
            kichCoNodeTextBox.Text = "40";
            khoanCachGiuaCacNodeTextBox.Text = "80";

            mauNenNodeColorButton.BackColor = Color.White;
            mauNodeDaXetQuaColorButton.BackColor = Color.DimGray;
            mauNodeDangXetColorButton.BackColor = Color.Aqua;

            yTuongFontDialog.Font = new Font("Segoe UI", 11);
            fontYTuongTextBox.Text = string.Format("{0} {1}", yTuongFontDialog.Font.Name, yTuongFontDialog.Font.Size);

            codeFontDialog.Font = new Font("Calibri", 12);
            fontCodeTextBox.Text = string.Format("{0} {1}", codeFontDialog.Font.Name, codeFontDialog.Font.Size);

        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
