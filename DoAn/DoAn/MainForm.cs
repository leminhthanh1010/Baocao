using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.Drawing.Imaging;


namespace DoAn
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            InitializeComponentExtend();

            // Tắt các Button cần tắt khi khởi động
            destroyButton.Enabled = batDauButton.Enabled = tamDungButton.Enabled = debugButton.Enabled = cancelSortingButton.Enabled = false;

            // track bar
            speedTrackBar.Maximum = ThamSo.TocDo;
            speedTrackBar.Minimum = 0;
            speedTrackBar.Value = ThamSo.TocDo / 2;
            speedTrackBar.LargeChange = 1;

            // radiobutton check
            tangRadioButton.Checked = true;
            interchangeSortRadioButton.Checked = true;

            // menuStrip
            menuStrip.Renderer = new MySR();
            menuStrip.BackColor = Color.FromArgb(51, 51, 51);
            menuStrip.ForeColor = Color.Gainsboro;

            // Load các thông tin cài đặt của người dùng 
            ThamSo.MauNenNode = Properties.Settings.Default.MauNenNode;
            ThamSo.MauNodeDangXet = Properties.Settings.Default.MauNodeDangXet;
            ThamSo.MauNodeDaXetQua = Properties.Settings.Default.MauNodeDaXetQua;
            ThamSo.KichCoNode = Properties.Settings.Default.KichCoNode;
            ThamSo.KhoanCachGiuaCacNode = Properties.Settings.Default.KhoanCachGiuaCacNode;
            soPhanTuTextBox.Text = Properties.Settings.Default.SoLuongPhanTuMacDinh.ToString();
            yTuongTextBox.Font = Properties.Settings.Default.fontYTuongTextBox;
            codeListBox.Font = Properties.Settings.Default.fontCodeListBox;

            // Đổi màu nền Form
            DoiMauNenForm(Properties.Settings.Default.MauNenForm);

            // Tắt phần check lỗi Cross-thread : lỗi xảy ra do thread con điều khiển những tài nguyên vốn dĩ k do nó tạo ra
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void DoiMauNenForm(bool mauToi)
        {
            if (mauToi)
            {
                // Tông màu tối
                this.BackColor = sortingPanel.BackColor = speedTrackBar.BackColor = menuStrip.BackColor = Color.FromArgb(51, 51, 51);
                soPhanTuTextBox.ForeColor =  soPhanTuTextBox.BackColor = unsortedPanel.BackColor = codePanel.BackColor = codeListBox.BackColor = statePanel.BackColor = yTuongTextBox.BackColor = sortPanel.BackColor = directionPanel.BackColor = debugPanel.BackColor = controlPanel.BackColor = initializationPanel.BackColor = destroyPanel.BackColor = Color.FromArgb(60, 60, 60);
                directionLabel.ForeColor = originalLabel.ForeColor = codeLabel.ForeColor = stateLabel.ForeColor = sortLabel.ForeColor = debugLabel.ForeColor = controlLabel.ForeColor = initializationLabel.ForeColor = destroyLabel.ForeColor = Color.DarkGray;
                daySoChuaSapXepLabel.ForeColor = Color.Cornsilk;

                List<Button> lst = new List<Button>() { batDauButton, tamDungButton, debugButton, taoNgauNghienButton, nhapTayButton, nhapMotDayButton, destroyButton, cancelSortingButton };
                foreach (Button bt in lst)
                {
                    bt.BackColor = Color.FromArgb(51, 51, 51);
                    bt.FlatAppearance.BorderColor = Color.Black;
                    bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 31, 31);
                    bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 63, 63);
                    bt.ForeColor = Color.GhostWhite;
                } 
            }
            else
            {
                // Tông màu sáng
                this.BackColor = sortingPanel.BackColor = speedTrackBar.BackColor = Color.FromArgb(133, 161, 198);
                menuStrip.BackColor = Color.FromArgb(191, 191, 191);
                soPhanTuTextBox.BackColor = unsortedPanel.BackColor = codePanel.BackColor = codeListBox.BackColor = statePanel.BackColor = yTuongTextBox.BackColor = sortPanel.BackColor = directionPanel.BackColor = debugPanel.BackColor = controlPanel.BackColor = initializationPanel.BackColor = destroyPanel.BackColor = Color.FromArgb(177, 210, 251);
                directionLabel.ForeColor = originalLabel.ForeColor = codeLabel.ForeColor = stateLabel.ForeColor = sortLabel.ForeColor = debugLabel.ForeColor = controlLabel.ForeColor = initializationLabel.ForeColor = destroyLabel.ForeColor = Color.Black;
                daySoChuaSapXepLabel.ForeColor = Color.Black;
                List<Button> lst = new List<Button>() { batDauButton, tamDungButton, debugButton, taoNgauNghienButton, nhapTayButton, nhapMotDayButton, destroyButton, cancelSortingButton };
                foreach (Button bt in lst)
                {
                    bt.BackColor = Color.FromArgb(184, 235, 239);
                    bt.FlatAppearance.BorderColor = Color.FromArgb(184, 235, 239);
                    bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 210, 251);
                    bt.FlatAppearance.MouseOverBackColor = Color.BurlyWood;
                    bt.ForeColor = Color.Black;
                }
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                CapNhatYTuongVaCode();
            }
            
        }

        private void CapNhatYTuongVaCode()
        {
            // Chỉ định listbox và text box
            CodeC.codeListBox = codeListBox;
            CodeC.yTuongTextBox = yTuongTextBox;
            bool tang = tangRadioButton.Checked;
            // Chọn các sort thích hợp
            if (selectionSortRadioButton.Checked)
            {
                CodeC.SelectionSort(tang);
                hamSapXep = SelectionSort;
            }
            else if (insertionSortRadioButton.Checked)
            {
                CodeC.InsertionSort(tang);
                hamSapXep = InsertionSort;
            }
            else if (interchangeSortRadioButton.Checked)
            {
                CodeC.InterchangeSort(tang);
                hamSapXep = InterchangeSort;
            }
            else if (bubbleSortRadioButton.Checked)
            {
                CodeC.BubbleSort(tang);
                hamSapXep = BubbleSort;
            }
            else if (heapSortRadioButton.Checked)
            {
                CodeC.HeapSort();
                hamSapXep = HeapSort;
            }
            else if (quickSortRadioButton.Checked)
            {
                CodeC.QuickSort(tang);
                hamSapXep = QuickSort;
            }
            else if (mergeSortRadioButton.Checked)
            {
                CodeC.MergeSort();
                hamSapXep = MergeSort;
            }
        }

        private void TaoNgauNghienButton_Click(object sender, EventArgs e)
        {
            TaoMangNgauNhien(int.Parse(soPhanTuTextBox.Text));
            
        }

        private void TamDungButton_Click(object sender, EventArgs e)
        {
            TamDung();
        }
        
        private void BatDauButton_Click(object sender, EventArgs e)
        {
            BatDauSapXep();
        }

        private void NhapTayButton_Click(object sender, EventArgs e)
        {
            NhapTay(int.Parse(soPhanTuTextBox.Text));
        }

        private void DestroyButton_Click(object sender, EventArgs e)
        {
            XoaMang();
            batDauButton.Enabled = false;
        }


        private void SoPhanTuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')    // nếu là nút BackSpace thì bỏ qua bước check này --> cho phép nút Backspace hoạt động
            {
                e.Handled = !char.IsNumber(e.KeyChar);
                // Handled == true thì event bị hủy
                // isNumber(True) + not = false --> cho phép nhập
            }
        }
        private void SoPhanTuTextBox_TextChanged(object sender, EventArgs e)
        {
            if (soPhanTuTextBox.Text != "")
            {
                int soPhanTu = int.Parse(soPhanTuTextBox.Text);
                if (mergeSortRadioButton.Checked == true && soPhanTu > 10)
                {
                    soPhanTuTextBox.Text = "10";
                }
                if (soPhanTu > ThamSo.SoLuongPhanTuMax)
                {
                    soPhanTuTextBox.Text = ThamSo.SoLuongPhanTuMax.ToString();
                }
            }
        }

        

        private void SoPhanTuTextBox_LostFocus(object sender, EventArgs e)
        {
            if (soPhanTuTextBox.Text == ""  || soPhanTuTextBox.Text == "0")     
            {
                soPhanTuTextBox.Text = "1";
            }
        }


        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            batDauButton.Focus();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            soPhanTuTextBox.Focus();
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            //  Nếu đang ở chế độ thường thì chuyển thành Debug
            if (!debugCheckBox.Checked)
                debugCheckBox.Checked = true;

            // Chạy code
            codeListBoxPauseStatus.Set();
            CodeListBoxIsPause = false;
        }

        private void debugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Chuyển tốc độ nhanh lên khi chạy Debug
            if (debugCheckBox.Checked)
            {
                ThamSo.TocDo = 1;
                speedTrackBar.Value = speedTrackBar.Maximum - 1;
                tamDungButton.Enabled = false;

                // Nếu đang tạm dừng khi đang hoán vị thì chạy xong rồi mới vào debug
                tamDungButton.Enabled = false;
                Node.pauseStatus.Set(); 
                Node.IsPause = false;
            }
                
            // Nếu tắt chế độ Debug thì cho code chạy bình thường
            if (!debugCheckBox.Checked)
            {
                codeListBoxPauseStatus.Set();
                CodeListBoxIsPause = false;

                // tiếp tục chạy
                tamDungButton.Enabled = true;
                Node.pauseStatus.Set();    
                Node.IsPause = false;

                speedTrackBar.Value = speedTrackBar.Maximum/2;
                TamDung();
            }

            // Khi chạy debug thì không tính thời gian
            thoiGianChayTimer.Stop();
            thoiGianChay_GiayLabel.Text = thoiGianChay_PhutLabel.Text = "00";
        }

        private void speedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ThamSo.TocDo = speedTrackBar.Maximum - speedTrackBar.Value;
        }

        private void cancelSortingButton_Click(object sender, EventArgs e)
        {
            HuyQuaTrinh(nodeArr.Count);
            
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaiDat caiDat = new CaiDat(yTuongTextBox,codeListBox);
            caiDat.ShowDialog();
            // Đổi màu nền form khi đã chỉnh cài đặt xong
            DoiMauNenForm(Properties.Settings.Default.MauNenForm);           
        }

        private void nhapMotDayButton_Click(object sender, EventArgs e)
        {
            NhapMotDay nhapMotDayForm = new NhapMotDay();
            DialogResult rs = nhapMotDayForm.ShowDialog();
            if (rs == DialogResult.OK)
            {
                soPhanTuTextBox.Text = nhapMotDayForm.dayCanNhap.Count.ToString();
                NhapMotDay(nhapMotDayForm.dayCanNhap);
                
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (nodeArr.Count == 0)
                    {
                        taoNgauNghienButton.PerformClick();
                        return true;
                    }
                    else
                    {
                        batDauButton.PerformClick();
                        return true;
                    }
                    return true;
                case Keys.F1:
                    taoNgauNghienButton.PerformClick();
                    return true;
                case Keys.F2:
                    nhapTayButton.PerformClick();
                    return true;
                case Keys.F3:
                    nhapMotDayButton.PerformClick();
                    return true;
                case Keys.F4:
                    batDauButton.PerformClick();
                    return true;
                case Keys.F5:
                    tamDungButton.PerformClick();
                    return true;
                case Keys.F6:
                    debugButton.PerformClick();
                    return true;
                case Keys.F7:
                    destroyButton.PerformClick();
                    return true;
                case Keys.F8:
                    cancelSortingButton.PerformClick();
                    return true;
                case Keys.F12:
                    càiĐặtToolStripMenuItem1.PerformClick();
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.Up:
                    if(speedTrackBar.Value < speedTrackBar.Maximum)
                        speedTrackBar.Value += 1;
                    return true;
                case Keys.Down:
                    if (speedTrackBar.Value > speedTrackBar.Minimum)
                        speedTrackBar.Value -= 1;
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void thoiGianChayTimer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(thoiGianChay_GiayLabel.Text) == 59)
            {
                thoiGianChay_GiayLabel.Text = "00";
                thoiGianChay_PhutLabel.Text = (int.Parse(thoiGianChay_PhutLabel.Text) + 1).ToString("00");
            }
            else
            {
                thoiGianChay_GiayLabel.Text = (int.Parse(thoiGianChay_GiayLabel.Text) + 1).ToString("00");
            }
        }

        private void copyDãySốChưaSắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (daySoChuaSapXepLabel.Text == "")
                MessageBox.Show("Dãy không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Clipboard.SetText(daySoChuaSapXepLabel.Text);

        }

        private void copyDãySốĐangSắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < nodeArr.Count; i++)
            {
                int t = nodeArr[i].giaTri;
                temp += t.ToString() + " ";
            }
            if (temp == "")
                MessageBox.Show("Dãy không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Clipboard.SetText(temp);
        }
    }

    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }
    }
}
