using FastColoredTextBoxNS;

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheatCodeGenerator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCI2Asm_Click(object sender, EventArgs e)
        {
            try
            {
                btnCI2Asm.Enabled = false;

                var injectAddr = Convert.ToUInt32(txtCIInjectAddr.Text, 16);
                var destAddr = Convert.ToUInt32(txtCIDestAddr.Text, 16);
                var useLink = rdoCIUseBL.Checked;
                var jumpBack = chkJumpBack.Checked;
                txtCIAsm.Text = string.Join("\r\n", Assembler.AssemblerGenerator(injectAddr, destAddr, new string[] { }, useLink, jumpBack));
            }
            catch
            {
                MessageBox.Show("输入的数据有误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCI2Asm.Enabled = true;
            }
        }

        private void BtnCICheat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCIAsm.Text.Trim().Length < 2) return;

                btnCICheat.Enabled = false;

                var baseAddr = Convert.ToUInt32(txtCIBaseAddr.Text, 16);
                var injectAddr = Convert.ToUInt32(txtCIInjectAddr.Text, 16);
                var destAddr = Convert.ToUInt32(txtCIDestAddr.Text, 16);
                var useLink = rdoCIUseBL.Checked;
                var jumpBack = chkJumpBack.Checked;

                var asm = txtCIAsm.Text;

                asm = Regex.Replace(asm, @"\/\*[\s\S]*?\*\/|\/\/.*", "");

                var cheatCode = Assembler.CheatCodeGenerator(baseAddr, injectAddr, destAddr, asm.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries), useLink, jumpBack);
                txtCICheat.Text = "[作弊功能说明]\r\n";
                txtCICheat.AppendText(cheatCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCICheat.Enabled = true;
            }
        }

        private void TxtCIAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //Console.WriteLine((byte)e.KeyChar);
            var contolCharBytes = new byte[] { 1, 3, 8, 22, 24, 26 };
            if (TestKeyChar(e.KeyChar, contolCharBytes))
            {
                e.Handled = false;
                return;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (TestKeyChar(e.KeyChar, 'a', 'f')) e.KeyChar = char.ToUpper(e.KeyChar);
            if (TestKeyChar(e.KeyChar, 'A', 'F'))
            {
                e.Handled = false;
                return;
            }
        }

        private bool TestKeyChar(char key, byte[] bytes)
        {
            bool tmp = false;
            foreach (var b in bytes)
            {
                tmp = tmp || (key == b);
            }
            return tmp;
        }

        private bool TestKeyChar(char key, char min, char max)
        {
            if (key >= min && key <= max) return true;
            return false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSetting();
            LoadStyel();
        }

        private void TsbtnCIAsmFont_Click(object sender, EventArgs e)
        {
            using (var fontDialog = new FontDialog()
            {
                FixedPitchOnly = true,
                AllowVerticalFonts = false,
                Font = txtCIAsm.Font,
            })
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCIAsm.Font = fontDialog.Font;
                    txtCIAsm.LineInterval = 2;

                    Properties.Settings.Default.font = txtCIAsm.Font;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void LoadSetting()
        {
            txtCIAsm.Font = Properties.Settings.Default.font;
        }

        private void TsbtnCIAsmStyel_Click(object sender, EventArgs e)
        {
            LoadStyel();
        }

        /// <summary>
        /// 载入高亮样式
        /// </summary>
        private void LoadStyel()
        {
            if (File.Exists("style.xml"))
            {
                txtCIAsm.ClearStyle(StyleIndex.All);
                txtCIAsm.DescriptionFile = "style.xml";
                txtCIAsm.SyntaxHighlighter.LoadXMLdescriptionFile("style.xml");
                txtCIAsm.OnSyntaxHighlight(new TextChangedEventArgs(txtCIAsm.Range));
            }
        }

        private void TsbtnCISaveAsm_Click(object sender, EventArgs e)
        {
            if (txtCIAsm.Text.Length < 2) return;
            using (var saveFileDialog = new SaveFileDialog()
            {
                Title = "保存汇编代码",
                AddExtension = true,
                Filter = "汇编文件(*.asm)|*.asm|文本文档(*.txt)|*.txt",
                DefaultExt = ".asm",
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtCIAsm.Text);
                }
            }
        }

        private void TsbtnSaveCheat_Click(object sender, EventArgs e)
        {
            if (txtCIAsm.Text.Length < 2) return;
            using (var saveFileDialog = new SaveFileDialog()
            {
                Title = "保存作弊代码",
                AddExtension = true,
                Filter = "文本文档(*.txt)|*.txt",
                DefaultExt = ".txt",
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtCICheat.Text);
                }
            }
        }
    }
}