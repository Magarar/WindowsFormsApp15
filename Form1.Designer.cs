namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "01", "12：45", "工(1 , 2)", "送餐模式", "循迹", "NULL", "时间12：45，01号机器人在工作区域的（1，2）位置，正常工作，处于送餐模式，正在进行循迹功能，无异常，无临时调度。" }, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] { "01", "12：40", "服务台", "送餐模式", "接餐", "NULL", "时间12：40" }, -1);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Title_Index = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title_Time = new System.Windows.Forms.Label();
            this.Title_Passager = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Title_State = new System.Windows.Forms.Label();
            this.Title_Power = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.Title_OnWorking = new System.Windows.Forms.Label();
            this.Title_Model = new System.Windows.Forms.Label();
            this.Title_dispatch = new System.Windows.Forms.Label();
            this.Title_Local = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.Title_Menu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "01", "02", "03", "04" });
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "01";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Title_Index
            // 
            this.Title_Index.AutoSize = true;
            this.Title_Index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Index.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Index.Location = new System.Drawing.Point(0, 0);
            this.Title_Index.Name = "Title_Index";
            this.Title_Index.Size = new System.Drawing.Size(116, 18);
            this.Title_Index.TabIndex = 1;
            this.Title_Index.Text = "机器人编号：";
            this.Title_Index.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Title_Time
            // 
            this.Title_Time.AutoSize = true;
            this.Title_Time.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Time.Location = new System.Drawing.Point(3, 18);
            this.Title_Time.Name = "Title_Time";
            this.Title_Time.Size = new System.Drawing.Size(269, 18);
            this.Title_Time.TabIndex = 3;
            this.Title_Time.Text = "时间：2024年10月12日 12时45分";
            this.Title_Time.Click += new System.EventHandler(this.label2_Click);
            // 
            // Title_Passager
            // 
            this.Title_Passager.AutoSize = true;
            this.Title_Passager.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Passager.Location = new System.Drawing.Point(304, 20);
            this.Title_Passager.Name = "Title_Passager";
            this.Title_Passager.Size = new System.Drawing.Size(116, 18);
            this.Title_Passager.TabIndex = 4;
            this.Title_Passager.Text = "客流量：12人";
            this.Title_Passager.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(10, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(736, 584);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Title_State
            // 
            this.Title_State.AutoSize = true;
            this.Title_State.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_State.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_State.Location = new System.Drawing.Point(3, 255);
            this.Title_State.Name = "Title_State";
            this.Title_State.Size = new System.Drawing.Size(356, 29);
            this.Title_State.TabIndex = 7;
            this.Title_State.Text = "状态：正常工作";
            this.Title_State.Click += new System.EventHandler(this.label5_Click);
            // 
            // Title_Power
            // 
            this.Title_Power.AutoSize = true;
            this.Title_Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Power.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Power.Location = new System.Drawing.Point(0, 0);
            this.Title_Power.Name = "Title_Power";
            this.Title_Power.Size = new System.Drawing.Size(98, 18);
            this.Title_Power.TabIndex = 8;
            this.Title_Power.Text = "电量：78％";
            this.Title_Power.Click += new System.EventHandler(this.label6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 20);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "运行日志：";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4, this.columnHeader5, this.columnHeader6, this.columnHeader7 });
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2 });
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 286);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "位置";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "动作";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "异常代码";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "详细信息";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 160;
            // 
            // Title_OnWorking
            // 
            this.Title_OnWorking.AutoSize = true;
            this.Title_OnWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_OnWorking.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_OnWorking.Location = new System.Drawing.Point(3, 316);
            this.Title_OnWorking.Name = "Title_OnWorking";
            this.Title_OnWorking.Size = new System.Drawing.Size(356, 27);
            this.Title_OnWorking.TabIndex = 13;
            this.Title_OnWorking.Text = "正在进行：送餐 循迹";
            // 
            // Title_Model
            // 
            this.Title_Model.AutoSize = true;
            this.Title_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Model.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Model.Location = new System.Drawing.Point(3, 284);
            this.Title_Model.Name = "Title_Model";
            this.Title_Model.Size = new System.Drawing.Size(356, 32);
            this.Title_Model.TabIndex = 14;
            this.Title_Model.Text = "模式：送餐模式";
            // 
            // Title_dispatch
            // 
            this.Title_dispatch.AutoSize = true;
            this.Title_dispatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_dispatch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_dispatch.Location = new System.Drawing.Point(3, 343);
            this.Title_dispatch.Name = "Title_dispatch";
            this.Title_dispatch.Size = new System.Drawing.Size(356, 118);
            this.Title_dispatch.TabIndex = 15;
            this.Title_dispatch.Text = "调度：初始工作范围";
            this.Title_dispatch.Click += new System.EventHandler(this.label10_Click);
            // 
            // Title_Local
            // 
            this.Title_Local.AutoSize = true;
            this.Title_Local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Local.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_Local.Location = new System.Drawing.Point(3, 225);
            this.Title_Local.Name = "Title_Local";
            this.Title_Local.Size = new System.Drawing.Size(356, 30);
            this.Title_Local.TabIndex = 18;
            this.Title_Local.Text = "位置代码：工（1，2）";
            this.Title_Local.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 461);
            this.panel1.TabIndex = 19;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer6.Size = new System.Drawing.Size(816, 461);
            this.splitContainer6.SplitterDistance = 362;
            this.splitContainer6.SplitterWidth = 2;
            this.splitContainer6.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Title_Local, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Title_dispatch, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Title_OnWorking, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Title_Model, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Title_State, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Title_Menu, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.70157F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.29843F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 461);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(2, 61);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.Title_Power);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer5.Size = new System.Drawing.Size(285, 20);
            this.splitContainer5.SplitterDistance = 93;
            this.splitContainer5.SplitterWidth = 2;
            this.splitContainer5.TabIndex = 21;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(2, 18);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.Title_Index);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer7.Size = new System.Drawing.Size(358, 39);
            this.splitContainer7.SplitterDistance = 119;
            this.splitContainer7.SplitterWidth = 2;
            this.splitContainer7.TabIndex = 23;
            // 
            // Title_Menu
            // 
            this.Title_Menu.AutoSize = true;
            this.Title_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Menu.Font = new System.Drawing.Font("宋体", 18F);
            this.Title_Menu.Location = new System.Drawing.Point(3, 0);
            this.Title_Menu.Name = "Title_Menu";
            this.Title_Menu.Size = new System.Drawing.Size(356, 16);
            this.Title_Menu.TabIndex = 19;
            this.Title_Menu.Text = "机器人监控窗口";
            this.Title_Menu.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Title_Passager);
            this.panel2.Controls.Add(this.Title_Time);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 58);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 529);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 313);
            this.panel3.TabIndex = 21;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listView1);
            this.splitContainer4.Size = new System.Drawing.Size(816, 313);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.SplitterWidth = 2;
            this.splitContainer4.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 844);
            this.panel4.TabIndex = 22;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 150);
            this.splitContainer3.Size = new System.Drawing.Size(756, 844);
            this.splitContainer3.SplitterDistance = 103;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 19;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer2.Location = new System.Drawing.Point(80, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Size = new System.Drawing.Size(609, 95);
            this.splitContainer2.SplitterDistance = 54;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 44);
            this.label11.TabIndex = 21;
            this.label11.Text = "机器人调度窗口";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 844);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1578, 844);
            this.splitContainer1.SplitterDistance = 820;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 8F);
            this.Name = "Form1";
            this.Text = "机器人监控上位机";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Title_Power;

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Title_Index;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title_Time;
        private System.Windows.Forms.Label Title_Passager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Title_State;
        private System.Windows.Forms.Label Title_Local;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label Title_OnWorking;
        private System.Windows.Forms.Label Title_Model;
        private System.Windows.Forms.Label Title_dispatch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Title_Menu;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label label11;
    }
}

