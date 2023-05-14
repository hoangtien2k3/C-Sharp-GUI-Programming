namespace QuanLyBenhNhanNoiTru
{
    partial class Form_ShowDaKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShowDaKham));
            this.Grv_KhamBenh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaBS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPhongKham = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTinhTrangHienTai = new System.Windows.Forms.TextBox();
            this.txtLyDoKham = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbNhipTho = new System.Windows.Forms.ComboBox();
            this.cbbNhietDo = new System.Windows.Forms.ComboBox();
            this.cbbHuyetAp = new System.Windows.Forms.ComboBox();
            this.cbbNhomMau = new System.Windows.Forms.ComboBox();
            this.cbbMach = new System.Windows.Forms.ComboBox();
            this.cbbCanNang = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grv_KhamBenh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grv_KhamBenh
            // 
            this.Grv_KhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grv_KhamBenh.Location = new System.Drawing.Point(19, 132);
            this.Grv_KhamBenh.Name = "Grv_KhamBenh";
            this.Grv_KhamBenh.RowHeadersWidth = 51;
            this.Grv_KhamBenh.RowTemplate.Height = 24;
            this.Grv_KhamBenh.Size = new System.Drawing.Size(659, 382);
            this.Grv_KhamBenh.TabIndex = 0;
            this.Grv_KhamBenh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_KhamBenh_CellClick);
            this.Grv_KhamBenh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_KhamBenh_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 66);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1385, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(505, 9);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(354, 39);
            this.label25.TabIndex = 1;
            this.label25.Text = "Danh Sách Đã Khám";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(456, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 42);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa TT BN";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(19, 84);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 42);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm Bênh Nhân";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(456, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 42);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa Bệnh Nhân";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(141, 94);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(537, 24);
            this.cbbMaBN.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaBS);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbPhongKham);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpNgayKham);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTinhTrangHienTai);
            this.groupBox2.Controls.Add(this.txtLyDoKham);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbbNhipTho);
            this.groupBox2.Controls.Add(this.cbbNhietDo);
            this.groupBox2.Controls.Add(this.cbbHuyetAp);
            this.groupBox2.Controls.Add(this.cbbNhomMau);
            this.groupBox2.Controls.Add(this.cbbMach);
            this.groupBox2.Controls.Add(this.cbbCanNang);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(719, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(612, 382);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // cbbMaBS
            // 
            this.cbbMaBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbMaBS.FormattingEnabled = true;
            this.cbbMaBS.Location = new System.Drawing.Point(162, 223);
            this.cbbMaBS.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaBS.Name = "cbbMaBS";
            this.cbbMaBS.Size = new System.Drawing.Size(161, 24);
            this.cbbMaBS.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã BS";
            // 
            // cbbPhongKham
            // 
            this.cbbPhongKham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbPhongKham.FormattingEnabled = true;
            this.cbbPhongKham.Items.AddRange(new object[] {
            "PK001",
            "PK002",
            "PK003",
            "PK004",
            "PK005",
            "PK006",
            "PK007",
            "PK008",
            "PK009",
            "PK010",
            "PK011",
            "PK012",
            "PK013",
            "PK014",
            "PK015",
            "PK016",
            "PK017",
            "PK018",
            "PK019",
            "PK020"});
            this.cbbPhongKham.Location = new System.Drawing.Point(163, 257);
            this.cbbPhongKham.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPhongKham.Name = "cbbPhongKham";
            this.cbbPhongKham.Size = new System.Drawing.Size(160, 24);
            this.cbbPhongKham.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Phòng Khám";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.Location = new System.Drawing.Point(162, 291);
            this.dtpNgayKham.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(161, 22);
            this.dtpNgayKham.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày Khám";
            // 
            // txtTinhTrangHienTai
            // 
            this.txtTinhTrangHienTai.Location = new System.Drawing.Point(168, 155);
            this.txtTinhTrangHienTai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinhTrangHienTai.Name = "txtTinhTrangHienTai";
            this.txtTinhTrangHienTai.Size = new System.Drawing.Size(391, 22);
            this.txtTinhTrangHienTai.TabIndex = 18;
            // 
            // txtLyDoKham
            // 
            this.txtLyDoKham.Location = new System.Drawing.Point(168, 112);
            this.txtLyDoKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDoKham.Name = "txtLyDoKham";
            this.txtLyDoKham.Size = new System.Drawing.Size(391, 22);
            this.txtLyDoKham.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(47, 155);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 53);
            this.label21.TabIndex = 16;
            this.label21.Text = "Tình trạng hiện tại";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(47, 115);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "Lý do khám";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(380, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "mmHg";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(180, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "/phút";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(180, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "kg";
            // 
            // cbbNhipTho
            // 
            this.cbbNhipTho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbNhipTho.FormattingEnabled = true;
            this.cbbNhipTho.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbbNhipTho.Location = new System.Drawing.Point(511, 69);
            this.cbbNhipTho.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhipTho.Name = "cbbNhipTho";
            this.cbbNhipTho.Size = new System.Drawing.Size(64, 24);
            this.cbbNhipTho.TabIndex = 11;
            // 
            // cbbNhietDo
            // 
            this.cbbNhietDo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbNhietDo.FormattingEnabled = true;
            this.cbbNhietDo.Items.AddRange(new object[] {
            "35.9°C",
            "36.1°C",
            "36.3°C",
            "36.5°C",
            "36.7°C",
            "36.9°C",
            "37.1°C",
            "37.3°C",
            "37.5°C",
            "37.7°C",
            "37.9°C",
            "38.1°C",
            "38.3°C",
            "38.5°C",
            "38.7°C",
            "38.9°C",
            "39.1°C",
            "39.3°C",
            "39.5°C",
            "39.7°C",
            "39.9°C",
            "40.1°C",
            "40.3°C"});
            this.cbbNhietDo.Location = new System.Drawing.Point(511, 32);
            this.cbbNhietDo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhietDo.Name = "cbbNhietDo";
            this.cbbNhietDo.Size = new System.Drawing.Size(64, 24);
            this.cbbNhietDo.TabIndex = 10;
            // 
            // cbbHuyetAp
            // 
            this.cbbHuyetAp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbHuyetAp.FormattingEnabled = true;
            this.cbbHuyetAp.Items.AddRange(new object[] {
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119"});
            this.cbbHuyetAp.Location = new System.Drawing.Point(311, 67);
            this.cbbHuyetAp.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHuyetAp.Name = "cbbHuyetAp";
            this.cbbHuyetAp.Size = new System.Drawing.Size(60, 24);
            this.cbbHuyetAp.TabIndex = 9;
            this.cbbHuyetAp.Text = "mmHg";
            // 
            // cbbNhomMau
            // 
            this.cbbNhomMau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbNhomMau.FormattingEnabled = true;
            this.cbbNhomMau.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "O",
            "AB"});
            this.cbbNhomMau.Location = new System.Drawing.Point(321, 31);
            this.cbbNhomMau.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhomMau.Name = "cbbNhomMau";
            this.cbbNhomMau.Size = new System.Drawing.Size(49, 24);
            this.cbbNhomMau.TabIndex = 8;
            // 
            // cbbMach
            // 
            this.cbbMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbMach.FormattingEnabled = true;
            this.cbbMach.Items.AddRange(new object[] {
            "50 bpm",
            "55 bpm",
            "60 bpm",
            "65 bpm",
            "70 bpm",
            "75 bpm",
            "80 bpm",
            "85 bpm",
            "90 bpm",
            "95 bpm",
            "100 bpm",
            "105 bpm",
            "110 bpm",
            "115 bpm",
            "120 bpm",
            "125 bpm",
            "130 bpm",
            "135 bpm",
            "140 bpm",
            "145 bpm",
            "150 bpm",
            "155 bpm",
            "160 bpm"});
            this.cbbMach.Location = new System.Drawing.Point(113, 67);
            this.cbbMach.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMach.Name = "cbbMach";
            this.cbbMach.Size = new System.Drawing.Size(57, 24);
            this.cbbMach.TabIndex = 7;
            // 
            // cbbCanNang
            // 
            this.cbbCanNang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCanNang.FormattingEnabled = true;
            this.cbbCanNang.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cbbCanNang.Location = new System.Drawing.Point(113, 28);
            this.cbbCanNang.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCanNang.Name = "cbbCanNang";
            this.cbbCanNang.Size = new System.Drawing.Size(57, 24);
            this.cbbCanNang.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(440, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nhịp thở";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(439, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nhiệt độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huyết áp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhóm máu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mạch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cân nặng";
            // 
            // Form_ShowDaKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1355, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbbMaBN);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grv_KhamBenh);
            this.Name = "Form_ShowDaKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Da Kham";
            this.Load += new System.EventHandler(this.Form_ShowDaKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grv_KhamBenh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grv_KhamBenh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTinhTrangHienTai;
        private System.Windows.Forms.TextBox txtLyDoKham;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbNhipTho;
        private System.Windows.Forms.ComboBox cbbNhietDo;
        private System.Windows.Forms.ComboBox cbbHuyetAp;
        private System.Windows.Forms.ComboBox cbbNhomMau;
        private System.Windows.Forms.ComboBox cbbMach;
        private System.Windows.Forms.ComboBox cbbCanNang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPhongKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label5;
    }
}