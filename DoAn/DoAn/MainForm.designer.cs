using System;
using System.Windows.Forms;

namespace DoAn
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            if (sortingThread != null)  // Hủy thread nếu lúc tắt vẫn đang chạy
                sortingThread.Abort();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sortPanel = new System.Windows.Forms.Panel();
            this.heapSortRadioButton = new System.Windows.Forms.RadioButton();
            this.sortLabel = new System.Windows.Forms.Label();
            this.insertionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.thoiGianChay_GiayLabel = new System.Windows.Forms.Label();
            this.thoiGianChay_PhutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batDauButton = new System.Windows.Forms.Button();
            this.tamDungButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.debugPanel = new System.Windows.Forms.Panel();
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.directionPanel = new System.Windows.Forms.Panel();
            this.giamRadioButton = new System.Windows.Forms.RadioButton();
            this.directionLabel = new System.Windows.Forms.Label();
            this.tangRadioButton = new System.Windows.Forms.RadioButton();
            this.statePanel = new System.Windows.Forms.Panel();
            this.yTuongTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.codePanel = new System.Windows.Forms.Panel();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.unsortedPanel = new System.Windows.Forms.Panel();
            this.sortingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.destroyPanel = new System.Windows.Forms.Panel();
            this.cancelSortingButton = new System.Windows.Forms.Button();
            this.destroyLabel = new System.Windows.Forms.Label();
            this.destroyButton = new System.Windows.Forms.Button();
            this.initializationPanel = new System.Windows.Forms.Panel();
            this.nhapMotDayButton = new System.Windows.Forms.Button();
            this.soPhanTuLabel = new System.Windows.Forms.Label();
            this.soPhanTuTextBox = new System.Windows.Forms.TextBox();
            this.nhapTayButton = new System.Windows.Forms.Button();
            this.taoNgauNghienButton = new System.Windows.Forms.Button();
            this.initializationLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoiGianChayTimer = new System.Windows.Forms.Timer(this.components);
            this.sortPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.debugPanel.SuspendLayout();
            this.directionPanel.SuspendLayout();
            this.statePanel.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.unsortedPanel.SuspendLayout();
            this.sortingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.destroyPanel.SuspendLayout();
            this.initializationPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sortPanel.Controls.Add(this.heapSortRadioButton);
            this.sortPanel.Controls.Add(this.sortLabel);
            this.sortPanel.Controls.Add(this.insertionSortRadioButton);
            this.sortPanel.Controls.Add(this.bubbleSortRadioButton);
            this.sortPanel.Controls.Add(this.selectionSortRadioButton);
            this.sortPanel.Location = new System.Drawing.Point(484, 663);
            this.sortPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(500, 235);
            this.sortPanel.TabIndex = 3;
            // 
            // heapSortRadioButton
            // 
            this.heapSortRadioButton.AutoSize = true;
            this.heapSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.heapSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heapSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.heapSortRadioButton.Location = new System.Drawing.Point(54, 76);
            this.heapSortRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.heapSortRadioButton.Name = "heapSortRadioButton";
            this.heapSortRadioButton.Size = new System.Drawing.Size(122, 31);
            this.heapSortRadioButton.TabIndex = 11;
            this.heapSortRadioButton.Text = "Heap sort";
            this.heapSortRadioButton.UseVisualStyleBackColor = false;
            this.heapSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.sortLabel.Location = new System.Drawing.Point(5, 5);
            this.sortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(221, 23);
            this.sortLabel.TabIndex = 99;
            this.sortLabel.Text = "Các phương pháp sắp xếp";
            // 
            // insertionSortRadioButton
            // 
            this.insertionSortRadioButton.AutoSize = true;
            this.insertionSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.insertionSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.insertionSortRadioButton.Location = new System.Drawing.Point(289, 38);
            this.insertionSortRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertionSortRadioButton.Name = "insertionSortRadioButton";
            this.insertionSortRadioButton.Size = new System.Drawing.Size(154, 31);
            this.insertionSortRadioButton.TabIndex = 6;
            this.insertionSortRadioButton.Text = "Insertion sort";
            this.insertionSortRadioButton.UseVisualStyleBackColor = false;
            this.insertionSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.bubbleSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(54, 40);
            this.bubbleSortRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(137, 31);
            this.bubbleSortRadioButton.TabIndex = 10;
            this.bubbleSortRadioButton.Text = "Bubble sort";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = false;
            this.bubbleSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.selectionSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectionSortRadioButton.Location = new System.Drawing.Point(289, 76);
            this.selectionSortRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(159, 31);
            this.selectionSortRadioButton.TabIndex = 8;
            this.selectionSortRadioButton.Text = "Selection sort";
            this.selectionSortRadioButton.UseVisualStyleBackColor = false;
            this.selectionSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.thoiGianChay_GiayLabel);
            this.controlPanel.Controls.Add(this.thoiGianChay_PhutLabel);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.batDauButton);
            this.controlPanel.Controls.Add(this.tamDungButton);
            this.controlPanel.Controls.Add(this.controlLabel);
            this.controlPanel.Controls.Add(this.debugButton);
            this.controlPanel.Location = new System.Drawing.Point(1156, 450);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(408, 160);
            this.controlPanel.TabIndex = 15;
            this.controlPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(293, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = ":";
            // 
            // thoiGianChay_GiayLabel
            // 
            this.thoiGianChay_GiayLabel.AutoSize = true;
            this.thoiGianChay_GiayLabel.BackColor = System.Drawing.Color.Transparent;
            this.thoiGianChay_GiayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thoiGianChay_GiayLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.thoiGianChay_GiayLabel.Location = new System.Drawing.Point(304, 48);
            this.thoiGianChay_GiayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thoiGianChay_GiayLabel.Name = "thoiGianChay_GiayLabel";
            this.thoiGianChay_GiayLabel.Size = new System.Drawing.Size(34, 25);
            this.thoiGianChay_GiayLabel.TabIndex = 107;
            this.thoiGianChay_GiayLabel.Text = "00";
            // 
            // thoiGianChay_PhutLabel
            // 
            this.thoiGianChay_PhutLabel.AutoSize = true;
            this.thoiGianChay_PhutLabel.BackColor = System.Drawing.Color.Transparent;
            this.thoiGianChay_PhutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thoiGianChay_PhutLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.thoiGianChay_PhutLabel.Location = new System.Drawing.Point(264, 48);
            this.thoiGianChay_PhutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thoiGianChay_PhutLabel.Name = "thoiGianChay_PhutLabel";
            this.thoiGianChay_PhutLabel.Size = new System.Drawing.Size(34, 25);
            this.thoiGianChay_PhutLabel.TabIndex = 106;
            this.thoiGianChay_PhutLabel.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "Thời gian thực hiện:";
            // 
            // batDauButton
            // 
            this.batDauButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.batDauButton.Enabled = false;
            this.batDauButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.batDauButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.batDauButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.batDauButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batDauButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batDauButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.batDauButton.Location = new System.Drawing.Point(17, 94);
            this.batDauButton.Margin = new System.Windows.Forms.Padding(4);
            this.batDauButton.Name = "batDauButton";
            this.batDauButton.Size = new System.Drawing.Size(113, 44);
            this.batDauButton.TabIndex = 33;
            this.batDauButton.Text = "Bắt đầu";
            this.batDauButton.UseVisualStyleBackColor = false;
            this.batDauButton.Click += new System.EventHandler(this.BatDauButton_Click);
            // 
            // tamDungButton
            // 
            this.tamDungButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tamDungButton.Enabled = false;
            this.tamDungButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tamDungButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tamDungButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tamDungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamDungButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamDungButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tamDungButton.Location = new System.Drawing.Point(151, 94);
            this.tamDungButton.Margin = new System.Windows.Forms.Padding(4);
            this.tamDungButton.Name = "tamDungButton";
            this.tamDungButton.Size = new System.Drawing.Size(113, 44);
            this.tamDungButton.TabIndex = 32;
            this.tamDungButton.Text = "Tạm Dừng";
            this.tamDungButton.UseVisualStyleBackColor = false;
            this.tamDungButton.Click += new System.EventHandler(this.TamDungButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.BackColor = System.Drawing.Color.Transparent;
            this.controlLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.controlLabel.Location = new System.Drawing.Point(7, 6);
            this.controlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(144, 23);
            this.controlLabel.TabIndex = 99;
            this.controlLabel.Text = "Bảng điều khiển";
            // 
            // debugButton
            // 
            this.debugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.debugButton.Enabled = false;
            this.debugButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.debugButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.debugButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.debugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.debugButton.Location = new System.Drawing.Point(280, 94);
            this.debugButton.Margin = new System.Windows.Forms.Padding(4);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(112, 44);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = false;
            this.debugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // debugPanel
            // 
            this.debugPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.debugPanel.Controls.Add(this.debugCheckBox);
            this.debugPanel.Controls.Add(this.debugLabel);
            this.debugPanel.Location = new System.Drawing.Point(991, 794);
            this.debugPanel.Margin = new System.Windows.Forms.Padding(4);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(159, 105);
            this.debugPanel.TabIndex = 16;
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.debugCheckBox.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.debugCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.debugCheckBox.Location = new System.Drawing.Point(23, 46);
            this.debugCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(101, 33);
            this.debugCheckBox.TabIndex = 1;
            this.debugCheckBox.Text = "Debug";
            this.debugCheckBox.UseVisualStyleBackColor = false;
            this.debugCheckBox.CheckedChanged += new System.EventHandler(this.debugCheckBox_CheckedChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.BackColor = System.Drawing.Color.Transparent;
            this.debugLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.debugLabel.Location = new System.Drawing.Point(5, 7);
            this.debugLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(126, 23);
            this.debugLabel.TabIndex = 99;
            this.debugLabel.Text = "Chế độ Debug";
            // 
            // directionPanel
            // 
            this.directionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.directionPanel.Controls.Add(this.giamRadioButton);
            this.directionPanel.Controls.Add(this.directionLabel);
            this.directionPanel.Controls.Add(this.tangRadioButton);
            this.directionPanel.Location = new System.Drawing.Point(991, 663);
            this.directionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.directionPanel.Name = "directionPanel";
            this.directionPanel.Size = new System.Drawing.Size(159, 123);
            this.directionPanel.TabIndex = 17;
            // 
            // giamRadioButton
            // 
            this.giamRadioButton.AutoSize = true;
            this.giamRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.giamRadioButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.giamRadioButton.Location = new System.Drawing.Point(23, 71);
            this.giamRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.giamRadioButton.Name = "giamRadioButton";
            this.giamRadioButton.Size = new System.Drawing.Size(88, 33);
            this.giamRadioButton.TabIndex = 15;
            this.giamRadioButton.Text = "Giảm";
            this.giamRadioButton.UseVisualStyleBackColor = false;
            this.giamRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.BackColor = System.Drawing.Color.Transparent;
            this.directionLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.directionLabel.Location = new System.Drawing.Point(5, 5);
            this.directionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(135, 23);
            this.directionLabel.TabIndex = 99;
            this.directionLabel.Text = "Hướng sắp xếp";
            // 
            // tangRadioButton
            // 
            this.tangRadioButton.AutoSize = true;
            this.tangRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.tangRadioButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tangRadioButton.Location = new System.Drawing.Point(23, 37);
            this.tangRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.tangRadioButton.Name = "tangRadioButton";
            this.tangRadioButton.Size = new System.Drawing.Size(83, 33);
            this.tangRadioButton.TabIndex = 14;
            this.tangRadioButton.Text = "Tăng";
            this.tangRadioButton.UseVisualStyleBackColor = false;
            this.tangRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // statePanel
            // 
            this.statePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.statePanel.Controls.Add(this.yTuongTextBox);
            this.statePanel.Controls.Add(this.stateLabel);
            this.statePanel.Location = new System.Drawing.Point(484, 450);
            this.statePanel.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(665, 206);
            this.statePanel.TabIndex = 17;
            this.statePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.yTuongTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.yTuongTextBox.Location = new System.Drawing.Point(12, 38);
            this.yTuongTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.yTuongTextBox.Size = new System.Drawing.Size(647, 160);
            this.yTuongTextBox.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.stateLabel.Location = new System.Drawing.Point(5, 5);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(171, 23);
            this.stateLabel.TabIndex = 99;
            this.stateLabel.Text = "Ý tưởng thuật toán";
            // 
            // codePanel
            // 
            this.codePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.codePanel.Controls.Add(this.codeListBox);
            this.codePanel.Controls.Add(this.codeLabel);
            this.codePanel.Location = new System.Drawing.Point(0, 450);
            this.codePanel.Margin = new System.Windows.Forms.Padding(4);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(479, 448);
            this.codePanel.TabIndex = 18;
            this.codePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 24;
            this.codeListBox.Location = new System.Drawing.Point(11, 38);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(457, 384);
            this.codeListBox.TabIndex = 100;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.codeLabel.Location = new System.Drawing.Point(5, 5);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(87, 23);
            this.codeLabel.TabIndex = 99;
            this.codeLabel.Text = "Code C++";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.BackColor = System.Drawing.Color.Transparent;
            this.originalLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.originalLabel.Location = new System.Drawing.Point(5, 5);
            this.originalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(155, 23);
            this.originalLabel.TabIndex = 99;
            this.originalLabel.Text = "Dãy chưa sắp xếp";
            // 
            // unsortedPanel
            // 
            this.unsortedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.unsortedPanel.Controls.Add(this.originalLabel);
            this.unsortedPanel.Location = new System.Drawing.Point(0, 356);
            this.unsortedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.unsortedPanel.Name = "unsortedPanel";
            this.unsortedPanel.Size = new System.Drawing.Size(1565, 87);
            this.unsortedPanel.TabIndex = 19;
            this.unsortedPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // sortingPanel
            // 
            this.sortingPanel.AutoSize = true;
            this.sortingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sortingPanel.Controls.Add(this.label2);
            this.sortingPanel.Controls.Add(this.speedTrackBar);
            this.sortingPanel.Location = new System.Drawing.Point(0, 33);
            this.sortingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sortingPanel.Name = "sortingPanel";
            this.sortingPanel.Size = new System.Drawing.Size(1565, 314);
            this.sortingPanel.TabIndex = 21;
            this.sortingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(1489, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 101;
            this.label2.Text = "Tốc Độ";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.speedTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedTrackBar.LargeChange = 1;
            this.speedTrackBar.Location = new System.Drawing.Point(1501, 37);
            this.speedTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.speedTrackBar.Maximum = 0;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedTrackBar.Size = new System.Drawing.Size(56, 273);
            this.speedTrackBar.TabIndex = 22;
            this.speedTrackBar.TickFrequency = 10;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedTrackBar.ValueChanged += new System.EventHandler(this.speedTrackBar_ValueChanged);
            // 
            // destroyPanel
            // 
            this.destroyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.destroyPanel.Controls.Add(this.cancelSortingButton);
            this.destroyPanel.Controls.Add(this.destroyLabel);
            this.destroyPanel.Controls.Add(this.destroyButton);
            this.destroyPanel.Location = new System.Drawing.Point(1156, 789);
            this.destroyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.destroyPanel.Name = "destroyPanel";
            this.destroyPanel.Size = new System.Drawing.Size(408, 110);
            this.destroyPanel.TabIndex = 16;
            // 
            // cancelSortingButton
            // 
            this.cancelSortingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cancelSortingButton.Enabled = false;
            this.cancelSortingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelSortingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cancelSortingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.cancelSortingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSortingButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSortingButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.cancelSortingButton.Location = new System.Drawing.Point(220, 46);
            this.cancelSortingButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelSortingButton.Name = "cancelSortingButton";
            this.cancelSortingButton.Size = new System.Drawing.Size(125, 44);
            this.cancelSortingButton.TabIndex = 100;
            this.cancelSortingButton.Text = "Hủy quá trình";
            this.cancelSortingButton.UseVisualStyleBackColor = false;
            this.cancelSortingButton.Click += new System.EventHandler(this.cancelSortingButton_Click);
            // 
            // destroyLabel
            // 
            this.destroyLabel.AutoSize = true;
            this.destroyLabel.BackColor = System.Drawing.Color.Transparent;
            this.destroyLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destroyLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.destroyLabel.Location = new System.Drawing.Point(7, 6);
            this.destroyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destroyLabel.Name = "destroyLabel";
            this.destroyLabel.Size = new System.Drawing.Size(103, 23);
            this.destroyLabel.TabIndex = 99;
            this.destroyLabel.Text = "Chế độ hủy";
            // 
            // destroyButton
            // 
            this.destroyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.destroyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.destroyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.destroyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.destroyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destroyButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destroyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.destroyButton.Location = new System.Drawing.Point(75, 46);
            this.destroyButton.Margin = new System.Windows.Forms.Padding(4);
            this.destroyButton.Name = "destroyButton";
            this.destroyButton.Size = new System.Drawing.Size(125, 44);
            this.destroyButton.TabIndex = 4;
            this.destroyButton.Text = "Xóa mảng";
            this.destroyButton.UseVisualStyleBackColor = false;
            this.destroyButton.Click += new System.EventHandler(this.DestroyButton_Click);
            // 
            // initializationPanel
            // 
            this.initializationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.initializationPanel.Controls.Add(this.nhapMotDayButton);
            this.initializationPanel.Controls.Add(this.soPhanTuLabel);
            this.initializationPanel.Controls.Add(this.soPhanTuTextBox);
            this.initializationPanel.Controls.Add(this.nhapTayButton);
            this.initializationPanel.Controls.Add(this.taoNgauNghienButton);
            this.initializationPanel.Controls.Add(this.initializationLabel);
            this.initializationPanel.Location = new System.Drawing.Point(1156, 618);
            this.initializationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.initializationPanel.Name = "initializationPanel";
            this.initializationPanel.Size = new System.Drawing.Size(408, 164);
            this.initializationPanel.TabIndex = 14;
            // 
            // nhapMotDayButton
            // 
            this.nhapMotDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nhapMotDayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nhapMotDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nhapMotDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.nhapMotDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhapMotDayButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapMotDayButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.nhapMotDayButton.Location = new System.Drawing.Point(280, 94);
            this.nhapMotDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.nhapMotDayButton.Name = "nhapMotDayButton";
            this.nhapMotDayButton.Size = new System.Drawing.Size(112, 52);
            this.nhapMotDayButton.TabIndex = 100;
            this.nhapMotDayButton.Text = "Nhập một dãy";
            this.nhapMotDayButton.UseVisualStyleBackColor = false;
            this.nhapMotDayButton.Click += new System.EventHandler(this.nhapMotDayButton_Click);
            // 
            // soPhanTuLabel
            // 
            this.soPhanTuLabel.AutoSize = true;
            this.soPhanTuLabel.BackColor = System.Drawing.Color.Transparent;
            this.soPhanTuLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soPhanTuLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.soPhanTuLabel.Location = new System.Drawing.Point(108, 44);
            this.soPhanTuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soPhanTuLabel.Name = "soPhanTuLabel";
            this.soPhanTuLabel.Size = new System.Drawing.Size(107, 24);
            this.soPhanTuLabel.TabIndex = 99;
            this.soPhanTuLabel.Text = "Số phần tử:";
            // 
            // soPhanTuTextBox
            // 
            this.soPhanTuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soPhanTuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soPhanTuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soPhanTuTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.soPhanTuTextBox.Location = new System.Drawing.Point(232, 41);
            this.soPhanTuTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soPhanTuTextBox.MaxLength = 2;
            this.soPhanTuTextBox.Name = "soPhanTuTextBox";
            this.soPhanTuTextBox.Size = new System.Drawing.Size(65, 30);
            this.soPhanTuTextBox.TabIndex = 0;
            this.soPhanTuTextBox.Text = "10";
            this.soPhanTuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soPhanTuTextBox.TextChanged += new System.EventHandler(this.SoPhanTuTextBox_TextChanged);
            this.soPhanTuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoPhanTuTextBox_KeyPress);
            this.soPhanTuTextBox.LostFocus += new System.EventHandler(this.SoPhanTuTextBox_LostFocus);
            // 
            // nhapTayButton
            // 
            this.nhapTayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nhapTayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nhapTayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nhapTayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.nhapTayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhapTayButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapTayButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.nhapTayButton.Location = new System.Drawing.Point(151, 92);
            this.nhapTayButton.Margin = new System.Windows.Forms.Padding(4);
            this.nhapTayButton.Name = "nhapTayButton";
            this.nhapTayButton.Size = new System.Drawing.Size(113, 52);
            this.nhapTayButton.TabIndex = 33;
            this.nhapTayButton.Text = "Nhập bằng tay";
            this.nhapTayButton.UseVisualStyleBackColor = false;
            this.nhapTayButton.Click += new System.EventHandler(this.NhapTayButton_Click);
            // 
            // taoNgauNghienButton
            // 
            this.taoNgauNghienButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.taoNgauNghienButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.taoNgauNghienButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.taoNgauNghienButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.taoNgauNghienButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taoNgauNghienButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoNgauNghienButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.taoNgauNghienButton.Location = new System.Drawing.Point(17, 94);
            this.taoNgauNghienButton.Margin = new System.Windows.Forms.Padding(4);
            this.taoNgauNghienButton.Name = "taoNgauNghienButton";
            this.taoNgauNghienButton.Size = new System.Drawing.Size(113, 52);
            this.taoNgauNghienButton.TabIndex = 30;
            this.taoNgauNghienButton.Text = "Tạo ngẫu nhiên";
            this.taoNgauNghienButton.UseVisualStyleBackColor = false;
            this.taoNgauNghienButton.Click += new System.EventHandler(this.TaoNgauNghienButton_Click);
            // 
            // initializationLabel
            // 
            this.initializationLabel.AutoSize = true;
            this.initializationLabel.BackColor = System.Drawing.Color.Transparent;
            this.initializationLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializationLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.initializationLabel.Location = new System.Drawing.Point(8, 9);
            this.initializationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initializationLabel.Name = "initializationLabel";
            this.initializationLabel.Size = new System.Drawing.Size(82, 23);
            this.initializationLabel.TabIndex = 99;
            this.initializationLabel.Text = "Khởi tạo";
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem1});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1564, 28);
            this.menuStrip.TabIndex = 23;
            this.menuStrip.Text = "Thanh Menu";
            // 
            // càiĐặtToolStripMenuItem1
            // 
            this.càiĐặtToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.càiĐặtToolStripMenuItem1.Name = "càiĐặtToolStripMenuItem1";
            this.càiĐặtToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.càiĐặtToolStripMenuItem1.Text = "Cài đặt";
            this.càiĐặtToolStripMenuItem1.Click += new System.EventHandler(this.càiĐặtToolStripMenuItem_Click);
            // 
            // thoiGianChayTimer
            // 
            this.thoiGianChayTimer.Interval = 1000;
            this.thoiGianChayTimer.Tick += new System.EventHandler(this.thoiGianChayTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1564, 894);
            this.Controls.Add(this.sortingPanel);
            this.Controls.Add(this.debugPanel);
            this.Controls.Add(this.unsortedPanel);
            this.Controls.Add(this.codePanel);
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.directionPanel);
            this.Controls.Add(this.destroyPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.initializationPanel);
            this.Controls.Add(this.sortPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật toán sắp xếp";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.sortPanel.ResumeLayout(false);
            this.sortPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.debugPanel.ResumeLayout(false);
            this.debugPanel.PerformLayout();
            this.directionPanel.ResumeLayout(false);
            this.directionPanel.PerformLayout();
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.unsortedPanel.ResumeLayout(false);
            this.unsortedPanel.PerformLayout();
            this.sortingPanel.ResumeLayout(false);
            this.sortingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.destroyPanel.ResumeLayout(false);
            this.destroyPanel.PerformLayout();
            this.initializationPanel.ResumeLayout(false);
            this.initializationPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sortPanel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.RadioButton insertionSortRadioButton;
        private System.Windows.Forms.RadioButton selectionSortRadioButton;
        private System.Windows.Forms.RadioButton heapSortRadioButton;
        private System.Windows.Forms.RadioButton bubbleSortRadioButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Panel debugPanel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Panel directionPanel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Panel unsortedPanel;
        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.RadioButton giamRadioButton;
        private System.Windows.Forms.RadioButton tangRadioButton;
        private System.Windows.Forms.TextBox yTuongTextBox;
        private System.Windows.Forms.Panel sortingPanel;
        public System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Button tamDungButton;
        private System.Windows.Forms.Button batDauButton;
        private System.Windows.Forms.ListBox codeListBox;
        private System.Windows.Forms.Panel destroyPanel;
        private System.Windows.Forms.Button cancelSortingButton;
        private System.Windows.Forms.Label destroyLabel;
        private System.Windows.Forms.Button destroyButton;
        private System.Windows.Forms.Panel initializationPanel;
        private System.Windows.Forms.Label soPhanTuLabel;
        private System.Windows.Forms.TextBox soPhanTuTextBox;
        private System.Windows.Forms.Button nhapTayButton;
        private System.Windows.Forms.Button taoNgauNghienButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Label initializationLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button nhapMotDayButton;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label thoiGianChay_GiayLabel;
        private System.Windows.Forms.Label thoiGianChay_PhutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer thoiGianChayTimer;
        private System.Windows.Forms.Label label2;
    }
}

