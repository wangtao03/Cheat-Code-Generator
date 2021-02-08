namespace CheatCodeGenerator
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpCodeInject = new System.Windows.Forms.TabPage();
            this.tlpCodeInject = new System.Windows.Forms.TableLayoutPanel();
            this.btnCICheat = new System.Windows.Forms.Button();
            this.grpCIAddrSetting = new System.Windows.Forms.GroupBox();
            this.tlpCIAddrSetting = new System.Windows.Forms.TableLayoutPanel();
            this.labCIDestAddr = new System.Windows.Forms.Label();
            this.labCIInjectAddr = new System.Windows.Forms.Label();
            this.txtCIInjectAddr = new System.Windows.Forms.TextBox();
            this.labCIBaseAddr = new System.Windows.Forms.Label();
            this.txtCIBaseAddr = new System.Windows.Forms.TextBox();
            this.txtCIDestAddr = new System.Windows.Forms.TextBox();
            this.labZero1 = new System.Windows.Forms.Label();
            this.labZero2 = new System.Windows.Forms.Label();
            this.labZero3 = new System.Windows.Forms.Label();
            this.grpCIBranchType = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoCIUseB = new System.Windows.Forms.RadioButton();
            this.rdoCIUseBL = new System.Windows.Forms.RadioButton();
            this.chkJumpBack = new System.Windows.Forms.CheckBox();
            this.btnCI2Asm = new System.Windows.Forms.Button();
            this.grpCIAsm = new System.Windows.Forms.GroupBox();
            this.txtCIAsm = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpCICheat = new System.Windows.Forms.GroupBox();
            this.txtCICheat = new System.Windows.Forms.TextBox();
            this.tsCodeInject = new System.Windows.Forms.ToolStrip();
            this.tsbtnCIAsmFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCIAsmStyel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCIConvert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCISaveAsm = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSaveCheat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tpNormal = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tpCodeInject.SuspendLayout();
            this.tlpCodeInject.SuspendLayout();
            this.grpCIAddrSetting.SuspendLayout();
            this.tlpCIAddrSetting.SuspendLayout();
            this.grpCIBranchType.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCIAsm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCIAsm)).BeginInit();
            this.grpCICheat.SuspendLayout();
            this.tsCodeInject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpCodeInject);
            this.tabMain.Controls.Add(this.tpNormal);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(681, 397);
            this.tabMain.TabIndex = 1;
            // 
            // tpCodeInject
            // 
            this.tpCodeInject.Controls.Add(this.tlpCodeInject);
            this.tpCodeInject.Location = new System.Drawing.Point(4, 26);
            this.tpCodeInject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCodeInject.Name = "tpCodeInject";
            this.tpCodeInject.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCodeInject.Size = new System.Drawing.Size(673, 367);
            this.tpCodeInject.TabIndex = 1;
            this.tpCodeInject.Text = "汇编代码";
            this.tpCodeInject.UseVisualStyleBackColor = true;
            // 
            // tlpCodeInject
            // 
            this.tlpCodeInject.ColumnCount = 5;
            this.tlpCodeInject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpCodeInject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpCodeInject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCodeInject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpCodeInject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tlpCodeInject.Controls.Add(this.btnCICheat, 3, 1);
            this.tlpCodeInject.Controls.Add(this.grpCIAddrSetting, 0, 1);
            this.tlpCodeInject.Controls.Add(this.grpCIBranchType, 0, 2);
            this.tlpCodeInject.Controls.Add(this.btnCI2Asm, 1, 1);
            this.tlpCodeInject.Controls.Add(this.grpCIAsm, 2, 1);
            this.tlpCodeInject.Controls.Add(this.grpCICheat, 4, 1);
            this.tlpCodeInject.Controls.Add(this.tsCodeInject, 0, 0);
            this.tlpCodeInject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCodeInject.Location = new System.Drawing.Point(3, 4);
            this.tlpCodeInject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpCodeInject.Name = "tlpCodeInject";
            this.tlpCodeInject.RowCount = 4;
            this.tlpCodeInject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpCodeInject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpCodeInject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCodeInject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCodeInject.Size = new System.Drawing.Size(667, 359);
            this.tlpCodeInject.TabIndex = 0;
            // 
            // btnCICheat
            // 
            this.btnCICheat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCICheat.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.btnCICheat.Image = global::CheatCodeGenerator.Properties.Resources.next;
            this.btnCICheat.Location = new System.Drawing.Point(445, 225);
            this.btnCICheat.Name = "btnCICheat";
            this.btnCICheat.Size = new System.Drawing.Size(29, 29);
            this.btnCICheat.TabIndex = 11;
            this.btnCICheat.TabStop = false;
            this.btnCICheat.UseVisualStyleBackColor = true;
            this.btnCICheat.Click += new System.EventHandler(this.BtnCICheat_Click);
            // 
            // grpCIAddrSetting
            // 
            this.grpCIAddrSetting.Controls.Add(this.tlpCIAddrSetting);
            this.grpCIAddrSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCIAddrSetting.Location = new System.Drawing.Point(3, 61);
            this.grpCIAddrSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCIAddrSetting.Name = "grpCIAddrSetting";
            this.grpCIAddrSetting.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCIAddrSetting.Size = new System.Drawing.Size(154, 192);
            this.grpCIAddrSetting.TabIndex = 6;
            this.grpCIAddrSetting.TabStop = false;
            this.grpCIAddrSetting.Text = "地址设置:";
            // 
            // tlpCIAddrSetting
            // 
            this.tlpCIAddrSetting.ColumnCount = 2;
            this.tlpCIAddrSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCIAddrSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCIAddrSetting.Controls.Add(this.labCIDestAddr, 1, 4);
            this.tlpCIAddrSetting.Controls.Add(this.labCIInjectAddr, 1, 2);
            this.tlpCIAddrSetting.Controls.Add(this.txtCIInjectAddr, 1, 3);
            this.tlpCIAddrSetting.Controls.Add(this.labCIBaseAddr, 1, 0);
            this.tlpCIAddrSetting.Controls.Add(this.txtCIBaseAddr, 1, 1);
            this.tlpCIAddrSetting.Controls.Add(this.txtCIDestAddr, 1, 5);
            this.tlpCIAddrSetting.Controls.Add(this.labZero1, 0, 1);
            this.tlpCIAddrSetting.Controls.Add(this.labZero2, 0, 3);
            this.tlpCIAddrSetting.Controls.Add(this.labZero3, 0, 5);
            this.tlpCIAddrSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCIAddrSetting.Location = new System.Drawing.Point(3, 20);
            this.tlpCIAddrSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpCIAddrSetting.Name = "tlpCIAddrSetting";
            this.tlpCIAddrSetting.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tlpCIAddrSetting.RowCount = 7;
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCIAddrSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCIAddrSetting.Size = new System.Drawing.Size(148, 168);
            this.tlpCIAddrSetting.TabIndex = 0;
            // 
            // labCIDestAddr
            // 
            this.labCIDestAddr.AutoSize = true;
            this.labCIDestAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labCIDestAddr.Location = new System.Drawing.Point(33, 109);
            this.labCIDestAddr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.labCIDestAddr.Name = "labCIDestAddr";
            this.labCIDestAddr.Size = new System.Drawing.Size(106, 20);
            this.labCIDestAddr.TabIndex = 5;
            this.labCIDestAddr.Text = "目的地址";
            this.labCIDestAddr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labCIInjectAddr
            // 
            this.labCIInjectAddr.AutoSize = true;
            this.labCIInjectAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labCIInjectAddr.Location = new System.Drawing.Point(33, 55);
            this.labCIInjectAddr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.labCIInjectAddr.Name = "labCIInjectAddr";
            this.labCIInjectAddr.Size = new System.Drawing.Size(106, 20);
            this.labCIInjectAddr.TabIndex = 4;
            this.labCIInjectAddr.Text = "注入地址";
            this.labCIInjectAddr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtCIInjectAddr
            // 
            this.txtCIInjectAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCIInjectAddr.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.txtCIInjectAddr.Location = new System.Drawing.Point(33, 82);
            this.txtCIInjectAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 7);
            this.txtCIInjectAddr.MaxLength = 6;
            this.txtCIInjectAddr.Name = "txtCIInjectAddr";
            this.txtCIInjectAddr.Size = new System.Drawing.Size(106, 25);
            this.txtCIInjectAddr.TabIndex = 1;
            this.txtCIInjectAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddr_KeyPress);
            // 
            // labCIBaseAddr
            // 
            this.labCIBaseAddr.AutoSize = true;
            this.labCIBaseAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labCIBaseAddr.Location = new System.Drawing.Point(33, 1);
            this.labCIBaseAddr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.labCIBaseAddr.Name = "labCIBaseAddr";
            this.labCIBaseAddr.Size = new System.Drawing.Size(106, 20);
            this.labCIBaseAddr.TabIndex = 1;
            this.labCIBaseAddr.Text = "基础地址";
            this.labCIBaseAddr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtCIBaseAddr
            // 
            this.txtCIBaseAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCIBaseAddr.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.txtCIBaseAddr.Location = new System.Drawing.Point(33, 28);
            this.txtCIBaseAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 7);
            this.txtCIBaseAddr.MaxLength = 8;
            this.txtCIBaseAddr.Name = "txtCIBaseAddr";
            this.txtCIBaseAddr.Size = new System.Drawing.Size(106, 25);
            this.txtCIBaseAddr.TabIndex = 0;
            this.txtCIBaseAddr.Text = "00000000";
            this.txtCIBaseAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddr_KeyPress);
            // 
            // txtCIDestAddr
            // 
            this.txtCIDestAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCIDestAddr.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.txtCIDestAddr.Location = new System.Drawing.Point(33, 136);
            this.txtCIDestAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCIDestAddr.MaxLength = 6;
            this.txtCIDestAddr.Name = "txtCIDestAddr";
            this.txtCIDestAddr.Size = new System.Drawing.Size(106, 25);
            this.txtCIDestAddr.TabIndex = 2;
            this.txtCIDestAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAddr_KeyPress);
            // 
            // labZero1
            // 
            this.labZero1.AutoSize = true;
            this.labZero1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labZero1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.labZero1.Location = new System.Drawing.Point(0, 24);
            this.labZero1.Margin = new System.Windows.Forms.Padding(0);
            this.labZero1.Name = "labZero1";
            this.labZero1.Size = new System.Drawing.Size(30, 30);
            this.labZero1.TabIndex = 6;
            this.labZero1.Text = "0x";
            this.labZero1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labZero2
            // 
            this.labZero2.AutoSize = true;
            this.labZero2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labZero2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.labZero2.Location = new System.Drawing.Point(0, 78);
            this.labZero2.Margin = new System.Windows.Forms.Padding(0);
            this.labZero2.Name = "labZero2";
            this.labZero2.Size = new System.Drawing.Size(30, 30);
            this.labZero2.TabIndex = 7;
            this.labZero2.Text = "0x";
            this.labZero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labZero3
            // 
            this.labZero3.AutoSize = true;
            this.labZero3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labZero3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.labZero3.Location = new System.Drawing.Point(0, 132);
            this.labZero3.Margin = new System.Windows.Forms.Padding(0);
            this.labZero3.Name = "labZero3";
            this.labZero3.Size = new System.Drawing.Size(30, 30);
            this.labZero3.TabIndex = 8;
            this.labZero3.Text = "0x";
            this.labZero3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpCIBranchType
            // 
            this.grpCIBranchType.Controls.Add(this.tableLayoutPanel1);
            this.grpCIBranchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCIBranchType.Location = new System.Drawing.Point(3, 260);
            this.grpCIBranchType.Name = "grpCIBranchType";
            this.grpCIBranchType.Size = new System.Drawing.Size(154, 94);
            this.grpCIBranchType.TabIndex = 7;
            this.grpCIBranchType.TabStop = false;
            this.grpCIBranchType.Text = "跳转类型:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rdoCIUseB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoCIUseBL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkJumpBack, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdoCIUseB
            // 
            this.rdoCIUseB.AutoSize = true;
            this.rdoCIUseB.Checked = true;
            this.rdoCIUseB.Location = new System.Drawing.Point(13, 3);
            this.rdoCIUseB.Name = "rdoCIUseB";
            this.rdoCIUseB.Size = new System.Drawing.Size(102, 18);
            this.rdoCIUseB.TabIndex = 3;
            this.rdoCIUseB.TabStop = true;
            this.rdoCIUseB.Text = "普通跳转 ( B )";
            this.rdoCIUseB.UseVisualStyleBackColor = true;
            // 
            // rdoCIUseBL
            // 
            this.rdoCIUseBL.AutoSize = true;
            this.rdoCIUseBL.Location = new System.Drawing.Point(13, 27);
            this.rdoCIUseBL.Name = "rdoCIUseBL";
            this.rdoCIUseBL.Size = new System.Drawing.Size(128, 18);
            this.rdoCIUseBL.TabIndex = 4;
            this.rdoCIUseBL.Text = "带链接的跳转( BL )";
            this.rdoCIUseBL.UseVisualStyleBackColor = true;
            // 
            // chkJumpBack
            // 
            this.chkJumpBack.AutoSize = true;
            this.chkJumpBack.Checked = true;
            this.chkJumpBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJumpBack.Location = new System.Drawing.Point(13, 51);
            this.chkJumpBack.Name = "chkJumpBack";
            this.chkJumpBack.Size = new System.Drawing.Size(87, 18);
            this.chkJumpBack.TabIndex = 5;
            this.chkJumpBack.Text = "跳回注入点";
            this.chkJumpBack.UseVisualStyleBackColor = true;
            // 
            // btnCI2Asm
            // 
            this.btnCI2Asm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCI2Asm.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.btnCI2Asm.Image = global::CheatCodeGenerator.Properties.Resources.next;
            this.btnCI2Asm.Location = new System.Drawing.Point(163, 225);
            this.btnCI2Asm.Name = "btnCI2Asm";
            this.btnCI2Asm.Size = new System.Drawing.Size(29, 29);
            this.btnCI2Asm.TabIndex = 8;
            this.btnCI2Asm.TabStop = false;
            this.btnCI2Asm.UseVisualStyleBackColor = true;
            this.btnCI2Asm.Click += new System.EventHandler(this.BtnCI2Asm_Click);
            // 
            // grpCIAsm
            // 
            this.grpCIAsm.Controls.Add(this.txtCIAsm);
            this.grpCIAsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCIAsm.Location = new System.Drawing.Point(198, 60);
            this.grpCIAsm.Name = "grpCIAsm";
            this.tlpCodeInject.SetRowSpan(this.grpCIAsm, 3);
            this.grpCIAsm.Size = new System.Drawing.Size(241, 296);
            this.grpCIAsm.TabIndex = 9;
            this.grpCIAsm.TabStop = false;
            this.grpCIAsm.Text = "注入汇编代码:";
            // 
            // txtCIAsm
            // 
            this.txtCIAsm.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCIAsm.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);";
            this.txtCIAsm.AutoScrollMinSize = new System.Drawing.Size(27, 19);
            this.txtCIAsm.BackBrush = null;
            this.txtCIAsm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCIAsm.CharHeight = 19;
            this.txtCIAsm.CharUnicodeWidth = 16;
            this.txtCIAsm.CharWidth = 8;
            this.txtCIAsm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIAsm.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCIAsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCIAsm.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.txtCIAsm.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtCIAsm.IsReplaceMode = false;
            this.txtCIAsm.LineInterval = 2;
            this.txtCIAsm.Location = new System.Drawing.Point(3, 19);
            this.txtCIAsm.Name = "txtCIAsm";
            this.txtCIAsm.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCIAsm.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCIAsm.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCIAsm.ServiceColors")));
            this.txtCIAsm.Size = new System.Drawing.Size(235, 274);
            this.txtCIAsm.TabIndex = 0;
            this.txtCIAsm.TextLines = new string[] {
        ""};
            this.txtCIAsm.Zoom = 100;
            // 
            // grpCICheat
            // 
            this.grpCICheat.Controls.Add(this.txtCICheat);
            this.grpCICheat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCICheat.Location = new System.Drawing.Point(480, 60);
            this.grpCICheat.Name = "grpCICheat";
            this.tlpCodeInject.SetRowSpan(this.grpCICheat, 3);
            this.grpCICheat.Size = new System.Drawing.Size(184, 296);
            this.grpCICheat.TabIndex = 10;
            this.grpCICheat.TabStop = false;
            this.grpCICheat.Text = "作弊代码输出:";
            // 
            // txtCICheat
            // 
            this.txtCICheat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCICheat.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.txtCICheat.Location = new System.Drawing.Point(3, 19);
            this.txtCICheat.Multiline = true;
            this.txtCICheat.Name = "txtCICheat";
            this.txtCICheat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCICheat.Size = new System.Drawing.Size(178, 274);
            this.txtCICheat.TabIndex = 7;
            this.txtCICheat.WordWrap = false;
            // 
            // tsCodeInject
            // 
            this.tlpCodeInject.SetColumnSpan(this.tsCodeInject, 5);
            this.tsCodeInject.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tsCodeInject.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsCodeInject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCIAsmFont,
            this.toolStripSeparator1,
            this.tsbtnCIAsmStyel,
            this.toolStripSeparator2,
            this.tsbtnCIConvert,
            this.toolStripSeparator3,
            this.tsbtnCISaveAsm,
            this.tsbtnSaveCheat,
            this.toolStripSeparator4});
            this.tsCodeInject.Location = new System.Drawing.Point(0, 0);
            this.tsCodeInject.Name = "tsCodeInject";
            this.tsCodeInject.Size = new System.Drawing.Size(667, 56);
            this.tsCodeInject.TabIndex = 12;
            this.tsCodeInject.Text = "toolStrip1";
            // 
            // tsbtnCIAsmFont
            // 
            this.tsbtnCIAsmFont.Image = global::CheatCodeGenerator.Properties.Resources.font;
            this.tsbtnCIAsmFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCIAsmFont.Name = "tsbtnCIAsmFont";
            this.tsbtnCIAsmFont.Size = new System.Drawing.Size(60, 53);
            this.tsbtnCIAsmFont.Text = "设置字体";
            this.tsbtnCIAsmFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCIAsmFont.Click += new System.EventHandler(this.TsbtnCIAsmFont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnCIAsmStyel
            // 
            this.tsbtnCIAsmStyel.Image = global::CheatCodeGenerator.Properties.Resources.styel;
            this.tsbtnCIAsmStyel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCIAsmStyel.Name = "tsbtnCIAsmStyel";
            this.tsbtnCIAsmStyel.Size = new System.Drawing.Size(60, 53);
            this.tsbtnCIAsmStyel.Text = "重载样式";
            this.tsbtnCIAsmStyel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCIAsmStyel.Click += new System.EventHandler(this.TsbtnCIAsmStyel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnCIConvert
            // 
            this.tsbtnCIConvert.Image = global::CheatCodeGenerator.Properties.Resources.hex;
            this.tsbtnCIConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCIConvert.Name = "tsbtnCIConvert";
            this.tsbtnCIConvert.Size = new System.Drawing.Size(72, 53);
            this.tsbtnCIConvert.Text = "ASM>HEX";
            this.tsbtnCIConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCIConvert.Click += new System.EventHandler(this.TsbtnCIConvert_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnCISaveAsm
            // 
            this.tsbtnCISaveAsm.Image = global::CheatCodeGenerator.Properties.Resources.asm;
            this.tsbtnCISaveAsm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCISaveAsm.Name = "tsbtnCISaveAsm";
            this.tsbtnCISaveAsm.Size = new System.Drawing.Size(60, 53);
            this.tsbtnCISaveAsm.Text = "保存汇编";
            this.tsbtnCISaveAsm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCISaveAsm.Click += new System.EventHandler(this.TsbtnCISaveAsm_Click);
            // 
            // tsbtnSaveCheat
            // 
            this.tsbtnSaveCheat.Image = global::CheatCodeGenerator.Properties.Resources.cheat;
            this.tsbtnSaveCheat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSaveCheat.Name = "tsbtnSaveCheat";
            this.tsbtnSaveCheat.Size = new System.Drawing.Size(72, 53);
            this.tsbtnSaveCheat.Text = "保存作弊码";
            this.tsbtnSaveCheat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSaveCheat.Click += new System.EventHandler(this.TsbtnSaveCheat_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
            // 
            // tpNormal
            // 
            this.tpNormal.Location = new System.Drawing.Point(4, 26);
            this.tpNormal.Name = "tpNormal";
            this.tpNormal.Size = new System.Drawing.Size(673, 367);
            this.tpNormal.TabIndex = 2;
            this.tpNormal.Text = "常规代码";
            this.tpNormal.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 403);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(695, 430);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Nintendo 3DS 作弊码生成器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tpCodeInject.ResumeLayout(false);
            this.tlpCodeInject.ResumeLayout(false);
            this.tlpCodeInject.PerformLayout();
            this.grpCIAddrSetting.ResumeLayout(false);
            this.tlpCIAddrSetting.ResumeLayout(false);
            this.tlpCIAddrSetting.PerformLayout();
            this.grpCIBranchType.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpCIAsm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCIAsm)).EndInit();
            this.grpCICheat.ResumeLayout(false);
            this.grpCICheat.PerformLayout();
            this.tsCodeInject.ResumeLayout(false);
            this.tsCodeInject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpCodeInject;
        private System.Windows.Forms.TableLayoutPanel tlpCodeInject;
        private System.Windows.Forms.TextBox txtCIInjectAddr;
        private System.Windows.Forms.TextBox txtCIDestAddr;
        private System.Windows.Forms.Label labCIInjectAddr;
        private System.Windows.Forms.Label labCIDestAddr;
        private System.Windows.Forms.GroupBox grpCIAddrSetting;
        private System.Windows.Forms.TableLayoutPanel tlpCIAddrSetting;
        private System.Windows.Forms.Label labCIBaseAddr;
        private System.Windows.Forms.TextBox txtCIBaseAddr;
        private System.Windows.Forms.Label labZero1;
        private System.Windows.Forms.Label labZero2;
        private System.Windows.Forms.Label labZero3;
        private System.Windows.Forms.GroupBox grpCIBranchType;
        private System.Windows.Forms.Button btnCI2Asm;
        private System.Windows.Forms.GroupBox grpCIAsm;
        private System.Windows.Forms.GroupBox grpCICheat;
        private System.Windows.Forms.Button btnCICheat;
        private System.Windows.Forms.TextBox txtCICheat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoCIUseB;
        private System.Windows.Forms.RadioButton rdoCIUseBL;
        private System.Windows.Forms.CheckBox chkJumpBack;
        private System.Windows.Forms.ToolStrip tsCodeInject;
        private System.Windows.Forms.ToolStripButton tsbtnCIAsmFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnCIAsmStyel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnCISaveAsm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnSaveCheat;
        private FastColoredTextBoxNS.FastColoredTextBox txtCIAsm;
        private System.Windows.Forms.ToolStripButton tsbtnCIConvert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabPage tpNormal;
    }
}

