// Decompiled with JetBrains decompiler
// Type: DMM_View.Form1
// Assembly: DMM_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8766B025-EF85-4D30-9762-85F77D291D68
// Assembly location: D:\Program\HK68C\DMM_View.exe

using DMM_View.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SZRACER;

namespace DMM_View
{
  public class Form1 : Form
  {
    public const int WM_DEVICE_CHANGE = 537;
    public const int DBT_DEVICEARRIVAL = 32768;
    public const int DBT_DEVICE_REMOVE_COMPLETE = 32772;
    public const uint DBT_DEVTYP_PORT = 3;
    public const string strEOF = "A?";
    private IContainer components = (IContainer) null;
    private ToolStrip toolStrip1;
    private ToolStripButton ToolStripNew;
    private ToolStripButton ToolStripOpen;
    private ToolStripButton toolStripExport;
    private ToolStripButton ToolStripSave;
    private ToolStripButton ToolStripPrint;
    private ToolStripButton toolStripConnect;
    private ToolStripButton toolStripExit;
    private Panel panel1;
    private Label LCDMaxMin;
    private Label LCDRel;
    private Label LCDAuto;
    private Label LCDUnit;
    private Label LCDFunction;
    private Label LCDValue;
    private DataGridView dataGridView1;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripProgressBar toolStripProgressBar1;
    private System.Windows.Forms.Timer timer1;
    private ToolStripButton 帮助LToolStripButton;
    private Panel panel2;
    private CheckBox checkBox1;
    private TextBox textBox2;
    private TextBox textBox1;
    private DataGridViewTextBoxColumn Function;
    private DataGridViewTextBoxColumn MeasValue;
    private DataGridViewTextBoxColumn MeasUnit;
    private DataGridViewTextBoxColumn REL;
    private DataGridViewTextBoxColumn MaxMin;
    private DataGridViewTextBoxColumn Date_Time;
    private Label label2;
    private Label label1;
    private HScrollBar hScrollBar1;
    private ZGraph zGraph1;
    private Panel panel3;
    private Button button1;
    private Button button2;
    private string portName = "Auto";
    private bool findPort = false;
    private bool newFile = false;
    public string fileName = "Default.txt";
    public string filePath = Application.StartupPath;
    private int[] arrPortData = new int[15]
    {
      16,
      32,
      48,
      64,
      80,
      96,
      112,
      128,
      144,
      160,
      176,
      192,
      208,
      224,
      240
    };
    private List<string> listReceiveData = new List<string>();
    private Form1.structCurrentData CurrentData = new Form1.structCurrentData();
    private SerialPort serialPort1 = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
    private int watchDogCounter = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      this.toolStrip1 = new ToolStrip();
      this.ToolStripNew = new ToolStripButton();
      this.ToolStripOpen = new ToolStripButton();
      this.ToolStripSave = new ToolStripButton();
      this.toolStripExport = new ToolStripButton();
      this.ToolStripPrint = new ToolStripButton();
      this.toolStripConnect = new ToolStripButton();
      this.toolStripExit = new ToolStripButton();
      this.帮助LToolStripButton = new ToolStripButton();
      this.panel1 = new Panel();
      this.LCDMaxMin = new Label();
      this.LCDRel = new Label();
      this.LCDAuto = new Label();
      this.LCDUnit = new Label();
      this.LCDFunction = new Label();
      this.LCDValue = new Label();
      this.dataGridView1 = new DataGridView();
      this.Function = new DataGridViewTextBoxColumn();
      this.MeasValue = new DataGridViewTextBoxColumn();
      this.MeasUnit = new DataGridViewTextBoxColumn();
      this.REL = new DataGridViewTextBoxColumn();
      this.MaxMin = new DataGridViewTextBoxColumn();
      this.Date_Time = new DataGridViewTextBoxColumn();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.toolStripProgressBar1 = new ToolStripProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel2 = new Panel();
      this.label2 = new Label();
      this.label1 = new Label();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.checkBox1 = new CheckBox();
      this.hScrollBar1 = new HScrollBar();
      this.zGraph1 = new ZGraph();
      this.panel3 = new Panel();
      this.button2 = new Button();
      this.button1 = new Button();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.statusStrip.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      this.toolStrip1.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.toolStrip1.Font = new Font("Arial", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.toolStrip1.ImageScalingSize = new Size(32, 32);
      this.toolStrip1.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.ToolStripNew,
        (ToolStripItem) this.ToolStripOpen,
        (ToolStripItem) this.ToolStripSave,
        (ToolStripItem) this.toolStripExport,
        (ToolStripItem) this.ToolStripPrint,
        (ToolStripItem) this.toolStripConnect,
        (ToolStripItem) this.toolStripExit,
        (ToolStripItem) this.帮助LToolStripButton
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RenderMode = ToolStripRenderMode.System;
      this.toolStrip1.Size = new Size(792, 39);
      this.toolStrip1.TabIndex = 16;
      this.toolStrip1.Text = "toolStrip1";
      this.ToolStripNew.Image = (Image) componentResourceManager.GetObject("ToolStripNew.Image");
      this.ToolStripNew.ImageTransparentColor = Color.Magenta;
      this.ToolStripNew.Name = "ToolStripNew";
      this.ToolStripNew.Size = new Size(70, 36);
      this.ToolStripNew.Text = "&New";
      this.ToolStripNew.Click += new EventHandler(this.ToolStripNew_Click);
      this.ToolStripOpen.Image = (Image) componentResourceManager.GetObject("ToolStripOpen.Image");
      this.ToolStripOpen.ImageTransparentColor = Color.Magenta;
      this.ToolStripOpen.Name = "ToolStripOpen";
      this.ToolStripOpen.Size = new Size(79, 36);
      this.ToolStripOpen.Text = "&Open";
      this.ToolStripOpen.Click += new EventHandler(this.ToolStripOpen_Click);
      this.ToolStripSave.Image = (Image) componentResourceManager.GetObject("ToolStripSave.Image");
      this.ToolStripSave.ImageTransparentColor = Color.Magenta;
      this.ToolStripSave.Name = "ToolStripSave";
      this.ToolStripSave.Size = new Size(76, 36);
      this.ToolStripSave.Text = "&Save";
      this.ToolStripSave.Click += new EventHandler(this.ToolStripSave_Click);
      this.toolStripExport.Image = (Image) componentResourceManager.GetObject("toolStripExport.Image");
      this.toolStripExport.ImageTransparentColor = Color.Magenta;
      this.toolStripExport.Name = "toolStripExport";
      this.toolStripExport.Size = new Size(85, 36);
      this.toolStripExport.Text = "ExPort";
      this.toolStripExport.Click += new EventHandler(this.toolStripExport_Click);
      this.ToolStripPrint.Image = (Image) componentResourceManager.GetObject("ToolStripPrint.Image");
      this.ToolStripPrint.ImageTransparentColor = Color.Magenta;
      this.ToolStripPrint.Name = "ToolStripPrint";
      this.ToolStripPrint.Size = new Size(73, 36);
      this.ToolStripPrint.Text = "&Print";
      this.ToolStripPrint.Visible = false;
      this.toolStripConnect.Alignment = ToolStripItemAlignment.Right;
      this.toolStripConnect.Font = new Font("Arial", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.toolStripConnect.ForeColor = Color.Red;
      this.toolStripConnect.Image = (Image) Resources.usb_connected;
      this.toolStripConnect.ImageTransparentColor = Color.Magenta;
      this.toolStripConnect.Name = "toolStripConnect";
      this.toolStripConnect.Size = new Size(103, 36);
      this.toolStripConnect.Text = "&Connect";
      this.toolStripConnect.ToolTipText = "Click me";
      this.toolStripConnect.Visible = false;
      this.toolStripConnect.Click += new EventHandler(this.toolStripConnect_Click);
      this.toolStripExit.Image = (Image) componentResourceManager.GetObject("toolStripExit.Image");
      this.toolStripExit.ImageTransparentColor = Color.Magenta;
      this.toolStripExit.Name = "toolStripExit";
      this.toolStripExit.Size = new Size(66, 36);
      this.toolStripExit.Text = "Exit";
      this.toolStripExit.Click += new EventHandler(this.toolStripExit_Click);
      this.帮助LToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.帮助LToolStripButton.Image = (Image) componentResourceManager.GetObject("帮助LToolStripButton.Image");
      this.帮助LToolStripButton.ImageTransparentColor = Color.Magenta;
      this.帮助LToolStripButton.Name = "帮助LToolStripButton";
      this.帮助LToolStripButton.Size = new Size(36, 36);
      this.帮助LToolStripButton.Text = "帮助(&L)";
      this.帮助LToolStripButton.Visible = false;
      this.panel1.BackColor = Color.FromArgb(64, 64, 64);
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.LCDMaxMin);
      this.panel1.Controls.Add((Control) this.LCDRel);
      this.panel1.Controls.Add((Control) this.LCDAuto);
      this.panel1.Controls.Add((Control) this.LCDUnit);
      this.panel1.Controls.Add((Control) this.LCDFunction);
      this.panel1.Controls.Add((Control) this.LCDValue);
      this.panel1.Location = new Point(0, 39);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(360, 172);
      this.panel1.TabIndex = 17;
      this.LCDMaxMin.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LCDMaxMin.ForeColor = Color.Lime;
      this.LCDMaxMin.Location = new Point(230, 8);
      this.LCDMaxMin.Name = "LCDMaxMin";
      this.LCDMaxMin.Size = new Size(100, 26);
      this.LCDMaxMin.TabIndex = 7;
      this.LCDRel.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LCDRel.ForeColor = Color.Lime;
      this.LCDRel.Location = new Point(170, 10);
      this.LCDRel.Name = "LCDRel";
      this.LCDRel.Size = new Size(54, 26);
      this.LCDRel.TabIndex = 6;
      this.LCDAuto.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LCDAuto.ForeColor = Color.Lime;
      this.LCDAuto.Location = new Point(96, 11);
      this.LCDAuto.Name = "LCDAuto";
      this.LCDAuto.Size = new Size(68, 23);
      this.LCDAuto.TabIndex = 4;
      this.LCDUnit.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LCDUnit.ForeColor = Color.Lime;
      this.LCDUnit.Location = new Point(311, 65);
      this.LCDUnit.Name = "LCDUnit";
      this.LCDUnit.Size = new Size(47, 26);
      this.LCDUnit.TabIndex = 3;
      this.LCDFunction.Font = new Font("Arial", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LCDFunction.ForeColor = Color.Lime;
      this.LCDFunction.Location = new Point(15, 11);
      this.LCDFunction.Name = "LCDFunction";
      this.LCDFunction.Size = new Size(75, 26);
      this.LCDFunction.TabIndex = 2;
      this.LCDValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LCDValue.Font = new Font("NI7SEG", 54.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LCDValue.ForeColor = Color.Lime;
      this.LCDValue.Location = new Point(-14, 23);
      this.LCDValue.Name = "LCDValue";
      this.LCDValue.Size = new Size(311, 145);
      this.LCDValue.TabIndex = 1;
      this.LCDValue.Text = "-----";
      this.LCDValue.TextAlign = ContentAlignment.MiddleRight;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
      this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
      this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.Function, (DataGridViewColumn) this.MeasValue, (DataGridViewColumn) this.MeasUnit, (DataGridViewColumn) this.REL, (DataGridViewColumn) this.MaxMin, (DataGridViewColumn) this.Date_Time);
      this.dataGridView1.GridColor = Color.Gray;
      this.dataGridView1.Location = new Point(0, 289);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersWidth = 10;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new Size(360, 252);
      this.dataGridView1.TabIndex = 19;
      gridViewCellStyle1.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Function.DefaultCellStyle = gridViewCellStyle1;
      this.Function.HeaderText = "Func";
      this.Function.Name = "Function";
      this.Function.ReadOnly = true;
      this.Function.Width = 35;
      gridViewCellStyle2.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.MeasValue.DefaultCellStyle = gridViewCellStyle2;
      this.MeasValue.HeaderText = "Value";
      this.MeasValue.Name = "MeasValue";
      this.MeasValue.ReadOnly = true;
      this.MeasValue.Width = 45;
      gridViewCellStyle3.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.MeasUnit.DefaultCellStyle = gridViewCellStyle3;
      this.MeasUnit.HeaderText = "Unit";
      this.MeasUnit.Name = "MeasUnit";
      this.MeasUnit.ReadOnly = true;
      this.MeasUnit.Width = 30;
      gridViewCellStyle4.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.REL.DefaultCellStyle = gridViewCellStyle4;
      this.REL.HeaderText = "REL";
      this.REL.Name = "REL";
      this.REL.ReadOnly = true;
      this.REL.Width = 25;
      gridViewCellStyle5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.MaxMin.DefaultCellStyle = gridViewCellStyle5;
      this.MaxMin.HeaderText = "MAX-MIN";
      this.MaxMin.Name = "MaxMin";
      this.MaxMin.ReadOnly = true;
      this.MaxMin.Width = 48;
      gridViewCellStyle6.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Date_Time.DefaultCellStyle = gridViewCellStyle6;
      this.Date_Time.HeaderText = "Date/Time";
      this.Date_Time.Name = "Date_Time";
      this.Date_Time.ReadOnly = true;
      this.Date_Time.Width = 150;
      this.statusStrip.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.statusStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripStatusLabel1,
        (ToolStripItem) this.toolStripProgressBar1
      });
      this.statusStrip.Location = new Point(0, 544);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(792, 22);
      this.statusStrip.TabIndex = 20;
      this.statusStrip.Text = "statusStrip1";
      this.toolStripStatusLabel1.Font = new Font("Arial", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.toolStripStatusLabel1.ForeColor = Color.FromArgb(0, 64, 0);
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(51, 17);
      this.toolStripStatusLabel1.Text = "Ready";
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new Size(600, 16);
      this.toolStripProgressBar1.Visible = false;
      this.timer1.Interval = 50;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.panel2.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.panel2.BorderStyle = BorderStyle.Fixed3D;
      this.panel2.Controls.Add((Control) this.label2);
      this.panel2.Controls.Add((Control) this.label1);
      this.panel2.Controls.Add((Control) this.textBox2);
      this.panel2.Controls.Add((Control) this.textBox1);
      this.panel2.Controls.Add((Control) this.checkBox1);
      this.panel2.Location = new Point(363, 42);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(429, 88);
      this.panel2.TabIndex = 23;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label2.ForeColor = Color.Blue;
      this.label2.Location = new Point(112, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(103, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "Set Low Limit:";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label1.ForeColor = Color.Blue;
      this.label1.Location = new Point(112, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(110, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "Set High Limit:";
      this.textBox2.Enabled = false;
      this.textBox2.Location = new Point(228, 40);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(93, 21);
      this.textBox2.TabIndex = 2;
      this.textBox2.Text = "-600";
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.textBox1.Enabled = false;
      this.textBox1.Location = new Point(228, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(93, 21);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "600";
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = CheckState.Checked;
      this.checkBox1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.checkBox1.Location = new Point(12, 16);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(94, 16);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Auto RANGE";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.hScrollBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.hScrollBar1.LargeChange = 1;
      this.hScrollBar1.Location = new Point(363, 521);
      this.hScrollBar1.Maximum = 0;
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new Size(429, 20);
      this.hScrollBar1.TabIndex = 21;
      this.hScrollBar1.Scroll += new ScrollEventHandler(this.hScrollBar1_Scroll);
      this.zGraph1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.zGraph1.BackColor = Color.White;
      this.zGraph1.BorderStyle = BorderStyle.FixedSingle;
      this.zGraph1.Location = new Point(363, 133);
      this.zGraph1.m_backColorH = Color.FromArgb((int) byte.MaxValue, 192, (int) byte.MaxValue);
      this.zGraph1.m_backColorL = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.zGraph1.m_coordinateLineColor = Color.Blue;
      this.zGraph1.m_coordinateStringColor = Color.Fuchsia;
      this.zGraph1.m_coordinateStringTitleColor = Color.Fuchsia;
      this.zGraph1.m_fXBeginSYS = 0.0f;
      this.zGraph1.m_fXEndSYS = 100f;
      this.zGraph1.m_fYBeginSYS = -600f;
      this.zGraph1.m_fYEndSYS = 600f;
      this.zGraph1.m_GraphBackColor = Color.FromArgb(0, 64, 64);
      this.zGraph1.m_iLineShowColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.zGraph1.m_iLineShowColorAlpha = 50;
      this.zGraph1.m_SySnameX = "Time";
      this.zGraph1.m_SySnameY = "Value";
      this.zGraph1.m_SyStitle = "";
      this.zGraph1.m_titleBorderColor = Color.FromArgb(250, 250, 250);
      this.zGraph1.m_titleColor = Color.FromArgb(0, 0, 0);
      this.zGraph1.m_titlePosition = 0.4f;
      this.zGraph1.m_titleSize = 14;
      this.zGraph1.Margin = new Padding(0);
      this.zGraph1.MinimumSize = new Size(390, 270);
      this.zGraph1.Name = "zGraph1";
      this.zGraph1.Size = new Size(429, 388);
      this.zGraph1.TabIndex = 22;
      this.panel3.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.panel3.BorderStyle = BorderStyle.FixedSingle;
      this.panel3.Controls.Add((Control) this.button2);
      this.panel3.Controls.Add((Control) this.button1);
      this.panel3.Location = new Point(0, 217);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(360, 66);
      this.panel3.TabIndex = 24;
      this.button2.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.button2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = Color.Red;
      this.button2.Location = new Point(209, 10);
      this.button2.Name = "button2";
      this.button2.Size = new Size(111, 42);
      this.button2.TabIndex = 1;
      this.button2.Text = "STOP";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.button1.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = Color.Red;
      this.button1.Location = new Point(34, 10);
      this.button1.Name = "button1";
      this.button1.Size = new Size(111, 42);
      this.button1.TabIndex = 0;
      this.button1.Text = "START";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(792, 566);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.zGraph1);
      this.Controls.Add((Control) this.hScrollBar1);
      this.Controls.Add((Control) this.statusStrip);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.toolStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MinimumSize = new Size(400, 300);
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.Resize += new EventHandler(this.Form1_Resize);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 537)
      {
        switch (m.WParam.ToInt32())
        {
          case 32768:
            if (((Form1.DEV_BROADCAST_HDR) Marshal.PtrToStructure(m.LParam, typeof (Form1.DEV_BROADCAST_HDR))).dbch_devicetype != 3U)
              break;
            break;
          case 32772:
            if (this.serialPort1.IsOpen)
              this.serialPort1.Close();
            this.timer1.Stop();
            this.toolStripConnect.Text = "&Connect";
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.toolStripStatusLabel1.Text = "Ready";
            this.findPort = false;
            this.ToolStripNew.Enabled = true;
            this.ToolStripOpen.Enabled = true;
            this.ToolStripSave.Enabled = true;
            this.toolStripExport.Enabled = true;
            this.ToolStripPrint.Enabled = true;
            this.hScrollBar1.Enabled = true;
            break;
        }
      }
      base.WndProc(ref m);
    }

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Text = "DMM_View-" + this.filePath + "\\" + this.fileName;
      this.hScrollBar1.Enabled = false;
      this.zGraph1.m_iLineShowColorAlpha = 40;
      this.zGraph1.strfXaxis = new string[6]
      {
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00"
      };
      this.zGraph1.m_fYBeginSYS = -600f;
      this.zGraph1.m_fYEndSYS = 600f;
      this.zGraph1.m_fYBeginSYS = -600f;
      this.zGraph1._isAutoModeXY = true;
      this.zGraph1.ManualY();
      this.dataGridView1.RowCount = 50;
      this.button1.ForeColor = Color.Red;
      this.button2.ForeColor = Color.Red;
      this.button1.Enabled = true;
      this.button2.Enabled = false;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (MessageBox.Show("Quite？", "System Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        base.OnFormClosing(e);
      else
        e.Cancel = true;
    }

    private void toolStripConnect_Click(object sender, EventArgs e)
    {
      if (this.serialPort1.IsOpen)
      {
        try
        {
          this.timer1.Stop();
          this.serialPort1.Close();
          this.toolStripConnect.Text = "&Connect";
          this.toolStripStatusLabel1.Text = "Ready";
          this.ToolStripNew.Enabled = true;
          this.ToolStripOpen.Enabled = true;
          this.ToolStripSave.Enabled = true;
          this.toolStripExport.Enabled = true;
          this.ToolStripPrint.Enabled = true;
          this.hScrollBar1.Enabled = true;
          this.button1.Enabled = true;
          this.button2.Enabled = false;
          return;
        }
        catch
        {
          this.toolStripConnect.Text = "&Connect";
          this.button1.Enabled = true;
          this.button2.Enabled = false;
          int num = (int) MessageBox.Show("DisConnect");
        }
      }
      try
      {
        if (this.portName == "Auto")
        {
          foreach (string portName in SerialPort.GetPortNames())
          {
            try
            {
              this.serialPort1.PortName = portName;
              this.serialPort1.BaudRate = 2400;
              this.serialPort1.DataBits = 8;
              this.serialPort1.Parity = Parity.None;
              this.serialPort1.StopBits = StopBits.One;
              this.serialPort1.ReadBufferSize = 10240;
              this.serialPort1.Encoding = Encoding.BigEndianUnicode;
              this.serialPort1.Open();
            }
            catch
            {
              continue;
            }
            Thread.Sleep(1000);
            Application.DoEvents();
            int index = 0;
            if (this.serialPort1.BytesToRead >= 30)
            {
              do
                ;
              while ((this.serialPort1.ReadByte() & 240) == 16);
              for (index = 1; index < 15; ++index)
              {
                if ((this.serialPort1.ReadByte() & 240) == this.arrPortData[index])
                  ;
              }
            }
            this.findPort = index >= 14;
            this.serialPort1.Close();
          }
        }
      }
      catch
      {
        this.toolStripConnect.Text = "&Connect";
        this.button1.Enabled = true;
        this.button2.Enabled = false;
        int num = (int) MessageBox.Show("DisConnect");
      }
      try
      {
        if (this.findPort)
        {
          this.toolStripConnect.Text = "dis&Connect";
          this.button1.Enabled = false;
          this.button2.Enabled = true;
          this.serialPort1.Open();
          this.serialPort1.ReadExisting();
          do
            ;
          while (this.serialPort1.BytesToRead < 30);
          int num = 0;
          while (num < 15 && (this.serialPort1.ReadByte() & 240) != 16)
            ++num;
          this.serialPort1.Read(new byte[20], 0, 14);
          if (!this.newFile)
            this.dataGridView1.RowCount = 0;
          this.timer1.Start();
          this.toolStripStatusLabel1.Text = "Receiving";
          this.ToolStripNew.Enabled = false;
          this.ToolStripOpen.Enabled = false;
          this.ToolStripSave.Enabled = false;
          this.toolStripExport.Enabled = false;
          this.ToolStripPrint.Enabled = false;
          this.hScrollBar1.Enabled = false;
        }
        else
        {
          int num1 = (int) MessageBox.Show("DisConnect");
        }
      }
      catch
      {
        this.toolStripConnect.Text = "&Connect";
        this.button1.Enabled = true;
        this.button2.Enabled = false;
        int num = (int) MessageBox.Show("DisConnect");
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      ++this.watchDogCounter;
      if (this.watchDogCounter > 600)
      {
        this.timer1.Stop();
        this.serialPort1.Close();
        this.toolStripConnect.Text = "&Connect";
        this.toolStripStatusLabel1.Text = "Ready";
        this.watchDogCounter = 0;
        this.ToolStripNew.Enabled = true;
        this.ToolStripOpen.Enabled = true;
        this.ToolStripSave.Enabled = true;
        this.toolStripExport.Enabled = true;
        this.ToolStripPrint.Enabled = true;
        this.hScrollBar1.Enabled = true;
        this.button1.Enabled = true;
        this.button2.Enabled = false;
        int num = (int) MessageBox.Show("The connection has been disconnected!!Please reconnect.", "Prompt");
      }
      else
      {
        if (!this.serialPort1.IsOpen)
          return;
        try
        {
          if (this.serialPort1.BytesToRead >= 15)
          {
            byte[] numArray = new byte[15];
            this.serialPort1.Read(numArray, 0, 15);
            string str1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string str2 = Form1.byteToHexStr(numArray) + str1;
            this.dataProess(numArray);
            if (this.CurrentData.MeasureVal != "")
            {
              this.watchDogCounter = 0;
              this.LCDValue.Text = this.CurrentData.MeasureVal;
              this.LCDAuto.Text = this.CurrentData.RangeState;
              this.LCDFunction.Text = this.CurrentData.Function;
              this.LCDMaxMin.Text = this.CurrentData.MAXMINState;
              this.LCDRel.Text = this.CurrentData.RelState;
              this.LCDUnit.Text = this.CurrentData.MeasureUnit;
              int index = this.dataGridView1.Rows.Add();
              this.dataGridView1.Rows[index].HeaderCell.Value = (object) index.ToString();
              this.dataGridView1.Rows[index].Cells[0].Value = (object) this.CurrentData.Function;
              this.dataGridView1.Rows[index].Cells[1].Value = (object) this.CurrentData.MeasureVal;
              this.dataGridView1.Rows[index].Cells[2].Value = (object) this.CurrentData.MeasureUnit;
              this.dataGridView1.Rows[index].Cells[3].Value = (object) this.CurrentData.RelState;
              this.dataGridView1.Rows[index].Cells[4].Value = (object) this.CurrentData.MAXMINState;
              this.dataGridView1.Rows[index].Cells[5].Value = (object) str2.Substring(30);
              this.dataGridView1.CurrentCell = this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0];
              this.listReceiveData.Add(str2);
              this.newFile = true;
              this.drawLine();
            }
            this.toolStripStatusLabel1.Text += ".";
            if (this.toolStripStatusLabel1.Text == "Receiving...............")
              this.toolStripStatusLabel1.Text = "Receiving";
          }
        }
        catch
        {
        }
      }
    }

    private void dataProess(byte[] arryByte)
    {
      this.CurrentData.Function = "";
      this.CurrentData.RangeState = "";
      this.CurrentData.MeasureUnit = "";
      this.CurrentData.RelState = "";
      this.CurrentData.MAXMINState = "";
      if (((int) arryByte[0] & 1) == 1)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).Function += "AC";
      }
      if (((int) arryByte[0] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).Function += "DC";
      }
      if (((int) arryByte[0] & 4) == 4)
        this.CurrentData.RangeState = "AUTO";
      if (((int) arryByte[9] & 1) == 1)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "u";
      }
      if (((int) arryByte[9] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "n";
      }
      if (((int) arryByte[9] & 4) == 4)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "k";
      }
      if (((int) arryByte[9] & 8) == 8)
        this.CurrentData.Function = "Diode";
      if (((int) arryByte[10] & 1) == 1)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "m";
      }
      if (((int) arryByte[10] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "%";
        this.CurrentData.Function = "%";
      }
      if (((int) arryByte[10] & 4) == 4)
        this.CurrentData.MeasureUnit = "M" + this.CurrentData.MeasureUnit;
      if (((int) arryByte[10] & 8) == 8)
        this.CurrentData.Function = "BUZ";
      if (((int) arryByte[11] & 8) == 8)
        this.CurrentData.HoldState = "HOLD";
      if (((int) arryByte[11] & 4) == 4)
        this.CurrentData.RelState = "REL";
      if (((int) arryByte[11] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "Ω";
        this.CurrentData.Function = "RES";
      }
      if (((int) arryByte[11] & 1) == 1)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "F";
        this.CurrentData.Function = "CAP";
      }
      if (((int) arryByte[12] & 8) == 8)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).DeviceState += "LoBat";
      }
      if (((int) arryByte[12] & 4) == 4)
      {
        this.CurrentData.Function = "FREQ";
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "Hz";
      }
      if (((int) arryByte[12] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).Function += "V";
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "V";
      }
      if (((int) arryByte[12] & 1) == 1)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).Function += "A";
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MeasureUnit += "A";
      }
      if (((int) arryByte[13] & 8) == 8)
        this.CurrentData.Function = "NCV";
      if (((int) arryByte[13] & 4) == 4)
        this.CurrentData.Function = "hFE";
      if (((int) arryByte[13] & 2) == 2)
      {
        this.CurrentData.Function = "TEMP";
        this.CurrentData.MeasureUnit = "℃";
      }
      if (((int) arryByte[13] & 1) == 1)
      {
        this.CurrentData.Function = "TEMP";
        this.CurrentData.MeasureUnit = "℉";
      }
      if (((int) arryByte[14] & 8) == 8)
        this.CurrentData.MAXMINState = "MAX";
      if (((int) arryByte[14] & 4) == 4)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MAXMINState += "-";
      }
      if (((int) arryByte[14] & 2) == 2)
      {
        // ISSUE: explicit reference operation
        (^ref this.CurrentData).MAXMINState += "MIN";
      }
      this.CurrentData.MeasureVal = ((int) arryByte[1] & 1) != 1 ? "" : "-";
      arryByte[1] &= (byte) 14;
      // ISSUE: explicit reference operation
      (^ref this.CurrentData).MeasureVal += this.SegCodeToDigital(arryByte[1], arryByte[2]);
      // ISSUE: explicit reference operation
      (^ref this.CurrentData).MeasureVal += this.SegCodeToDigital(arryByte[3], arryByte[4]);
      // ISSUE: explicit reference operation
      (^ref this.CurrentData).MeasureVal += this.SegCodeToDigital(arryByte[5], arryByte[6]);
      // ISSUE: explicit reference operation
      (^ref this.CurrentData).MeasureVal += this.SegCodeToDigital(arryByte[7], arryByte[8]);
    }

    private string SegCodeToDigital(byte HiByte, byte LoByte)
    {
      HiByte <<= 4;
      LoByte &= (byte) 15;
      HiByte += LoByte;
      string str;
      switch (HiByte)
      {
        case 0:
          str = "";
          break;
        case 10:
          str = "1";
          break;
        case 16:
          str = "";
          break;
        case 26:
          str = ".1";
          break;
        case 78:
          str = "4";
          break;
        case 94:
          str = ".4";
          break;
        case 97:
          str = "L";
          break;
        case 113:
          str = ".L";
          break;
        case 138:
          str = "7";
          break;
        case 143:
          str = "3";
          break;
        case 154:
          str = ".7";
          break;
        case 159:
          str = ".3";
          break;
        case 173:
          str = "2";
          break;
        case 189:
          str = ".2";
          break;
        case 199:
          str = "5";
          break;
        case 207:
          str = "9";
          break;
        case 215:
          str = ".5";
          break;
        case 223:
          str = ".9";
          break;
        case 231:
          str = "6";
          break;
        case 235:
          str = "0";
          break;
        case 239:
          str = "8";
          break;
        case 247:
          str = ".6";
          break;
        case 251:
          str = ".0";
          break;
        case byte.MaxValue:
          str = ".8";
          break;
        default:
          str = "";
          break;
      }
      return str;
    }

    private bool SaveAsFile()
    {
      string filePath = this.filePath;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = filePath;
      saveFileDialog.Filter = "Text file(*.txt)|*.txt|All files(*.*)|*.*";
      saveFileDialog.FilterIndex = 1;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return false;
      string path = saveFileDialog.FileName.ToString();
      FileStream fileStream = new FileStream(path, FileMode.Create);
      StreamWriter streamWriter = new StreamWriter((Stream) fileStream);
      for (int index = 0; index < this.listReceiveData.Count; ++index)
        streamWriter.Write(this.listReceiveData[index] + "A?");
      streamWriter.Flush();
      streamWriter.Close();
      fileStream.Close();
      this.filePath = path.Substring(0, path.LastIndexOf("\\"));
      this.Text = "DMM_View-" + path;
      this.newFile = false;
      return true;
    }

    public static string byteToHexStr(byte[] bytes)
    {
      string str = "";
      if (bytes != null)
      {
        for (int index = 0; index < bytes.Length; ++index)
          str += bytes[index].ToString("X2");
      }
      return str;
    }

    private void ToolStripSave_Click(object sender, EventArgs e) => this.SaveAsFile();

    private void ToolStripOpen_Click(object sender, EventArgs e)
    {
      if (this.newFile)
      {
        switch (MessageBox.Show("File Not Save,Save it？", "System Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Cancel:
            return;
          case DialogResult.Yes:
            if (!this.SaveAsFile())
              return;
            break;
        }
      }
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = this.filePath;
      openFileDialog.Filter = "Text file(*.txt)|*.txt|All files(*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        this.newFile = false;
        this.ToolStripNew_Click(sender, e);
        this.ToolStripNew.Enabled = false;
        this.ToolStripOpen.Enabled = false;
        this.ToolStripSave.Enabled = false;
        this.toolStripExport.Enabled = false;
        this.ToolStripPrint.Enabled = false;
        this.toolStripConnect.Enabled = false;
        this.hScrollBar1.Enabled = false;
        this.dataGridView1.RowCount = 0;
        string fileName = openFileDialog.FileName;
        this.listReceiveData.Clear();
        StreamReader streamReader = File.OpenText(fileName);
        string str1 = streamReader.ReadLine();
        streamReader.Close();
        this.listReceiveData = new List<string>((IEnumerable<string>) str1.Split(new string[1]
        {
          "A?"
        }, StringSplitOptions.None));
        this.toolStripProgressBar1.Visible = true;
        this.toolStripStatusLabel1.Text = "Opening...please wait";
        this.listReceiveData.Remove("");
        Thread.Sleep(1);
        Application.DoEvents();
        this.toolStripProgressBar1.Maximum = this.listReceiveData.Count;
        for (int index1 = 0; index1 < this.listReceiveData.Count; ++index1)
        {
          this.toolStripProgressBar1.Value = index1;
          string str2 = this.listReceiveData[index1];
          this.dataProess(new byte[15]
          {
            byte.Parse(str2.Substring(0, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(2, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(4, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(6, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(8, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(10, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(12, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(14, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(16, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(18, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(20, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(22, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(24, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(26, 2), NumberStyles.HexNumber),
            byte.Parse(str2.Substring(28, 2), NumberStyles.HexNumber)
          });
          int index2 = this.dataGridView1.Rows.Add();
          this.dataGridView1.Rows[index2].HeaderCell.Value = (object) index2.ToString();
          this.dataGridView1.Rows[index2].Cells[0].Value = (object) this.CurrentData.Function;
          this.dataGridView1.Rows[index2].Cells[1].Value = (object) this.CurrentData.MeasureVal;
          this.dataGridView1.Rows[index2].Cells[2].Value = (object) this.CurrentData.MeasureUnit;
          this.dataGridView1.Rows[index2].Cells[3].Value = (object) this.CurrentData.RelState;
          this.dataGridView1.Rows[index2].Cells[4].Value = (object) this.CurrentData.MAXMINState;
          this.dataGridView1.Rows[index2].Cells[5].Value = (object) str2.Substring(30);
          Application.DoEvents();
        }
        this.drawLine();
        this.hScrollBar1.Maximum = this.dataGridView1.Rows.Count - 950;
        this.hScrollBar1.Value = this.hScrollBar1.Maximum;
        this.toolStripProgressBar1.Visible = false;
        this.toolStripProgressBar1.Value = 0;
        this.toolStripStatusLabel1.Text = "Ready";
        this.dataGridView1.CurrentCell = this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0];
        this.LCDValue.Text = this.CurrentData.MeasureVal;
        this.LCDAuto.Text = this.CurrentData.RangeState;
        this.LCDFunction.Text = this.CurrentData.Function;
        this.LCDMaxMin.Text = this.CurrentData.MAXMINState;
        this.LCDRel.Text = this.CurrentData.RelState;
        this.LCDUnit.Text = this.CurrentData.MeasureUnit;
        this.filePath = fileName.Substring(0, fileName.LastIndexOf("\\"));
        this.Text = "DMM_View-" + fileName;
      }
      this.ToolStripNew.Enabled = true;
      this.ToolStripOpen.Enabled = true;
      this.ToolStripSave.Enabled = true;
      this.toolStripExport.Enabled = true;
      this.ToolStripPrint.Enabled = true;
      this.toolStripConnect.Enabled = true;
      this.hScrollBar1.Enabled = true;
    }

    private void toolStripExport_Click(object sender, EventArgs e) => this.DataToExcel(this.dataGridView1);

    public void DataToExcel(DataGridView m_DataView)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = "Save EXECL File";
      saveFileDialog.Filter = "EXECL File(*.xls) |*.xls |All File(*.*) |*.*";
      saveFileDialog.FilterIndex = 1;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string path = saveFileDialog.FileName + ".xls";
      this.ToolStripNew.Enabled = false;
      this.ToolStripOpen.Enabled = false;
      this.ToolStripSave.Enabled = false;
      this.toolStripExport.Enabled = false;
      this.ToolStripPrint.Enabled = false;
      this.toolStripConnect.Enabled = false;
      if (File.Exists(path))
        File.Delete(path);
      string str1 = "";
      FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
      StreamWriter streamWriter = new StreamWriter((Stream) fileStream, Encoding.Unicode);
      for (int index = 0; index < m_DataView.Columns.Count; ++index)
      {
        if (m_DataView.Columns[index].Visible)
          str1 = str1 + m_DataView.Columns[index].HeaderText.ToString() + (object) Convert.ToChar(9);
      }
      streamWriter.WriteLine(str1);
      string str2 = "";
      for (int index1 = 0; index1 < m_DataView.Rows.Count; ++index1)
      {
        if (m_DataView.Columns[0].Visible)
          str2 = m_DataView.Rows[index1].Cells[0].Value != null ? str2 + m_DataView.Rows[index1].Cells[0].Value.ToString() + (object) Convert.ToChar(9) : str2 + " " + (object) Convert.ToChar(9);
        for (int index2 = 1; index2 < m_DataView.Columns.Count; ++index2)
        {
          if (m_DataView.Columns[index2].Visible)
          {
            if (m_DataView.Rows[index1].Cells[index2].Value == null)
            {
              str2 = str2 + " " + (object) Convert.ToChar(9);
            }
            else
            {
              string str3 = m_DataView.Rows[index1].Cells[index2].Value.ToString();
              if (str3.IndexOf("\r\n") > 0)
                str3 = str3.Replace("\r\n", " ");
              if (str3.IndexOf("\t") > 0)
                str3 = str3.Replace("\t", " ");
              str2 = str2 + str3 + (object) Convert.ToChar(9);
            }
          }
        }
        streamWriter.WriteLine(str2);
        str2 = "";
      }
      streamWriter.Close();
      fileStream.Close();
      this.ToolStripNew.Enabled = true;
      this.ToolStripOpen.Enabled = true;
      this.ToolStripSave.Enabled = true;
      this.toolStripExport.Enabled = true;
      this.ToolStripPrint.Enabled = true;
      this.toolStripConnect.Enabled = true;
      int num = (int) MessageBox.Show((IWin32Window) this, "Export Success", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void toolStripExit_Click(object sender, EventArgs e) => Application.Exit();

    private void drawLine()
    {
      List<float> listX = new List<float>();
      List<string> stringList = new List<string>();
      List<float> listY = new List<float>();
      string[] strArray1 = new string[6]
      {
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00"
      };
      int num1 = 0;
      float result = 0.0f;
      bool flag = true;
      float num2 = this.StrDateTimeToFloat(this.dataGridView1[5, 0].Value.ToString());
      int rowIndex1;
      int rowCount;
      if (this.dataGridView1.RowCount > 950)
      {
        rowIndex1 = this.dataGridView1.RowCount - 950;
        rowCount = this.dataGridView1.RowCount;
        this.hScrollBar1.Maximum = rowIndex1;
        this.hScrollBar1.Value = rowIndex1;
      }
      else
      {
        rowIndex1 = 0;
        rowCount = this.dataGridView1.RowCount;
      }
      while ((double) this.StrDateTimeToFloat(this.dataGridView1[5, rowCount - 1].Value.ToString()) - (double) this.StrDateTimeToFloat(this.dataGridView1[5, rowIndex1].Value.ToString()) > 95.0)
      {
        ++rowIndex1;
        if (rowIndex1 > rowCount)
          break;
      }
      for (int rowIndex2 = rowIndex1; rowIndex2 < rowCount; ++rowIndex2)
      {
        if (float.TryParse(this.dataGridView1[1, rowIndex2].Value.ToString(), out result))
          listY.Add(result);
        else if (this.dataGridView1[1, rowIndex2].Value.ToString().Contains("L"))
          listY.Add(1E+09f);
        else if (rowIndex2 == 0)
        {
          listY.Add(0.0f);
        }
        else
        {
          flag = float.TryParse(this.dataGridView1[1, rowIndex2 - 1].Value.ToString(), out result);
          listY.Add(result);
        }
        result = this.StrDateTimeToFloat(this.dataGridView1[5, rowIndex2].Value.ToString());
        listX.Add(result - num2);
        stringList.Add(this.dataGridView1[5, rowIndex2].Value.ToString());
        if (num1 == 0)
          strArray1[0] = DateTime.Parse(stringList[0]).ToLongTimeString();
        if (num1 == 199)
          strArray1[1] = DateTime.Parse(stringList[199]).ToLongTimeString();
        if (num1 == 399)
          strArray1[2] = DateTime.Parse(stringList[399]).ToLongTimeString();
        if (num1 == 599)
          strArray1[3] = DateTime.Parse(stringList[599]).ToLongTimeString();
        if (num1 == 799)
          strArray1[4] = DateTime.Parse(stringList[799]).ToLongTimeString();
        if (num1 == 949)
          strArray1[5] = DateTime.Parse(stringList[949]).ToLongTimeString();
        ++num1;
      }
      if (rowIndex1 > 0)
      {
        DateTime dateTime;
        if (strArray1[5] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(stringList[stringList.Count - 1]);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[5] = longTimeString;
        }
        if (strArray1[4] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(strArray1[5]);
          dateTime = dateTime.AddSeconds(-20.0);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[4] = longTimeString;
        }
        if (strArray1[3] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(strArray1[5]);
          dateTime = dateTime.AddSeconds(-40.0);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[3] = longTimeString;
        }
        if (strArray1[2] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(strArray1[5]);
          dateTime = dateTime.AddSeconds(-60.0);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[2] = longTimeString;
        }
        if (strArray1[1] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(strArray1[5]);
          dateTime = dateTime.AddSeconds(-80.0);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[1] = longTimeString;
        }
        if (strArray1[0] == "00:00:00")
        {
          string[] strArray2 = strArray1;
          dateTime = DateTime.Parse(strArray1[5]);
          dateTime = dateTime.AddSeconds(-100.0);
          string longTimeString = dateTime.ToLongTimeString();
          strArray2[1] = longTimeString;
        }
      }
      for (int index = 1; index < listX.Count; ++index)
        listX[index] = listX[index] - listX[0] + this.zGraph1.m_fXBeginSYS;
      if (listX.Count > 0)
        listX[0] = 0.0f;
      this.zGraph1.strfXaxis = new string[6]
      {
        strArray1[0],
        strArray1[4],
        strArray1[3],
        strArray1[2],
        strArray1[1],
        strArray1[5]
      };
      this.zGraph1.f_LoadOnePix(ref listX, ref listY, Color.Red, 3);
      this.zGraph1.f_Refresh();
    }

    private float StrDateTimeToFloat(string str)
    {
      string[] strArray = str.Split('-', ' ', ':', '.');
      DateTime dateTime = new DateTime(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]), int.Parse(strArray[4]), int.Parse(strArray[5]), int.Parse(strArray[6]));
      return (float) (dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second) + (float) dateTime.Millisecond / 1000f;
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      List<float> listX = new List<float>();
      List<float> listY = new List<float>();
      List<string> stringList = new List<string>();
      string[] strArray = new string[6]
      {
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00"
      };
      int num1 = 0;
      float result = 0.0f;
      bool flag = true;
      float num2 = this.StrDateTimeToFloat(this.dataGridView1[5, 0].Value.ToString());
      int num3 = this.hScrollBar1.Value;
      int num4 = this.hScrollBar1.Value + 1000 >= this.dataGridView1.RowCount ? this.dataGridView1.RowCount : this.hScrollBar1.Value + 1000;
      for (int rowIndex = num3; rowIndex < num4; ++rowIndex)
      {
        if (float.TryParse(this.dataGridView1[1, rowIndex].Value.ToString(), out result))
          listY.Add(result);
        else if (this.dataGridView1[1, rowIndex].Value.ToString().Contains("L"))
          listY.Add(1E+09f);
        else if (rowIndex == 0)
        {
          listY.Add(0.0f);
        }
        else
        {
          flag = float.TryParse(this.dataGridView1[1, rowIndex - 1].Value.ToString(), out result);
          listY.Add(result);
        }
        result = this.StrDateTimeToFloat(this.dataGridView1[5, rowIndex].Value.ToString());
        listX.Add(result - num2);
        stringList.Add(this.dataGridView1[5, rowIndex].Value.ToString());
        if (num1 == 0)
          strArray[0] = DateTime.Parse(stringList[0]).ToLongTimeString();
        if (num1 == 199)
          strArray[1] = DateTime.Parse(stringList[199]).ToLongTimeString();
        if (num1 == 399)
          strArray[2] = DateTime.Parse(stringList[399]).ToLongTimeString();
        if (num1 == 599)
          strArray[3] = DateTime.Parse(stringList[599]).ToLongTimeString();
        if (num1 == 799)
          strArray[4] = DateTime.Parse(stringList[799]).ToLongTimeString();
        if (num1 == 949)
          strArray[5] = DateTime.Parse(stringList[949]).ToLongTimeString();
        ++num1;
      }
      for (int index = 1; index < listX.Count; ++index)
        listX[index] = listX[index] - listX[0] + this.zGraph1.m_fXBeginSYS;
      listX[0] = 0.0f;
      this.zGraph1.strfXaxis = new string[6]
      {
        strArray[0],
        strArray[4],
        strArray[3],
        strArray[2],
        strArray[1],
        strArray[5]
      };
      this.zGraph1.f_LoadOnePix(ref listX, ref listY, Color.Red, 3);
      this.zGraph1.f_Refresh();
    }

    private void ToolStripNew_Click(object sender, EventArgs e)
    {
      if (this.newFile)
      {
        switch (MessageBox.Show("File Not Save,Save it？", "System Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Cancel:
            return;
          case DialogResult.Yes:
            if (!this.SaveAsFile())
              return;
            this.newFile = false;
            break;
          case DialogResult.No:
            this.newFile = false;
            break;
        }
      }
      this.Text = "DMM_View-" + this.filePath + "\\" + this.fileName;
      this.hScrollBar1.Enabled = false;
      this.hScrollBar1.Value = 0;
      this.hScrollBar1.Maximum = 0;
      this.zGraph1.strfXaxis = new string[6]
      {
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00",
        "00:00:00"
      };
      this.zGraph1.f_ClearAllPix();
      this.zGraph1.ManualY();
      this.dataGridView1.Rows.Clear();
      this.LCDValue.Text = "-----";
      this.LCDAuto.Text = "";
      this.LCDFunction.Text = "";
      this.LCDMaxMin.Text = "";
      this.LCDRel.Text = "";
      this.LCDUnit.Text = "";
      this.listReceiveData.Clear();
      this.ToolStripNew.Enabled = true;
      this.ToolStripOpen.Enabled = true;
      this.ToolStripSave.Enabled = true;
      this.toolStripExport.Enabled = true;
      this.ToolStripPrint.Enabled = true;
      this.toolStripConnect.Enabled = true;
      this.button1.Enabled = true;
      this.button2.Enabled = false;
      this.hScrollBar1.Enabled = false;
      this.dataGridView1.RowCount = 50;
    }

    private void Form1_Resize(object sender, EventArgs e) => this.zGraph1.Refresh();

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox1.Checked)
      {
        this.textBox1.Enabled = false;
        this.textBox2.Enabled = false;
        this.zGraph1._isAutoModeXY = true;
        this.zGraph1.ManualY();
      }
      else
      {
        this.textBox1.Enabled = true;
        this.textBox2.Enabled = true;
        this.zGraph1.m_fYEndSYS = float.Parse(this.textBox1.Text);
        this.zGraph1.m_fYBeginSYS = float.Parse(this.textBox2.Text);
        this.zGraph1._isAutoModeXY = false;
        this.zGraph1.ManualY();
      }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b' && e.KeyChar != '.') && e.KeyChar != '-')
        e.Handled = true;
      if (e.KeyChar == '-' && this.textBox1.Text != "")
        e.Handled = true;
      if (e.KeyChar == '.' && ((Control) sender).Text.IndexOf('.') != -1)
        e.Handled = true;
      if (e.KeyChar == '.' && ((Control) sender).Text == "")
        e.Handled = true;
      if (e.KeyChar != '.' && ((Control) sender).Text == "0")
        e.Handled = true;
      if (!(((Control) sender).Text == "-") || e.KeyChar != '.')
        return;
      e.Handled = true;
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      this.zGraph1.m_fYEndSYS = float.Parse(this.textBox1.Text);
      this.zGraph1.m_fYBeginSYS = float.Parse(this.textBox2.Text);
      this.zGraph1._isAutoModeXY = false;
      this.zGraph1.ManualY();
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b' && e.KeyChar != '.') && e.KeyChar != '-')
        e.Handled = true;
      if (e.KeyChar == '-' && this.textBox1.Text != "")
        e.Handled = true;
      if (e.KeyChar == '.' && ((Control) sender).Text.IndexOf('.') != -1)
        e.Handled = true;
      if (e.KeyChar == '.' && ((Control) sender).Text == "")
        e.Handled = true;
      if (e.KeyChar != '.' && ((Control) sender).Text == "0")
        e.Handled = true;
      if (!(((Control) sender).Text == "-") || e.KeyChar != '.')
        return;
      e.Handled = true;
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      this.zGraph1.m_fYEndSYS = float.Parse(this.textBox1.Text);
      this.zGraph1.m_fYBeginSYS = float.Parse(this.textBox2.Text);
      this.zGraph1._isAutoModeXY = false;
      this.zGraph1.ManualY();
    }

    private void button1_Click(object sender, EventArgs e) => this.toolStripConnect_Click(sender, e);

    private void button2_Click(object sender, EventArgs e) => this.toolStripConnect_Click(sender, e);

    private struct DEV_BROADCAST_HDR
    {
      public uint dbch_size;
      public uint dbch_devicetype;
      public uint dbch_reserved;
    }

    protected struct DEV_BROADCAST_PORT_Fixed
    {
      public uint dbcp_size;
      public uint dbcp_devicetype;
      public uint dbcp_reserved;
    }

    public struct structCurrentData
    {
      public string Function;
      public string MeasureVal;
      public string MeasureUnit;
      public string RelState;
      public string MAXMINState;
      public string HoldState;
      public string RangeState;
      public string DeviceState;
      public string Date_Time;
    }
  }
}
