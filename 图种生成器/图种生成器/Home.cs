using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.IO;
using System.Net.Http;
using System.Security.Policy;

namespace 图种生成器
{
    public partial class Home : UIForm
    {
        private string currentLanguage = "zh-CN";
        private string currentTheme = "light";

        public Home()
        {
            InitializeComponent();
            
            // 为导入按钮添加点击事件
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            
            // 为菜单项添加点击事件
            说明ToolStripMenuItem.Click += 说明ToolStripMenuItem_Click;
            中文ToolStripMenuItem.Click += 中文ToolStripMenuItem_Click;
            englishToolStripMenuItem.Click += EnglishToolStripMenuItem_Click;
            日语ToolStripMenuItem.Click += 日语ToolStripMenuItem_Click;
            俄语ToolStripMenuItem.Click += 俄语ToolStripMenuItem_Click;
            明亮ToolStripMenuItem.Click += 明亮ToolStripMenuItem_Click;
            暗夜ToolStripMenuItem.Click += 暗夜ToolStripMenuItem_Click;
            
            // 为文本框添加事件，防止自动全选
            textBox1.GotFocus += TextBox_GotFocus;
            textBox2.GotFocus += TextBox_GotFocus;
            
            // 初始化主题
            UpdateTheme();
        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("zh-CN");
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
        }

        private void 日语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ja-JP");
        }

        private void 俄语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru-RU");
        }

        private void 明亮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("light");
        }

        private void 暗夜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("dark");
        }

        private void ChangeTheme(string theme)
        {
            currentTheme = theme;
            UpdateTheme();
            //MessageBox.Show($"主题已切换到: {GetThemeName(theme)}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetThemeName(string theme)
        {
            switch (theme)
            {
                case "light": return "明亮";
                case "dark": return "暗夜";
                default: return theme;
            }
        }

        private void ChangeLanguage(string language)
        {
            currentLanguage = language;
            UpdateLanguage();
            //MessageBox.Show($"语言已切换到: {GetLanguageName(language)}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetLanguageName(string language)
        {
            switch (language)
            {
                case "zh-CN": return "中文";
                case "en-US": return "English";
                case "ja-JP": return "日本語";
                case "ru-RU": return "Русский";
                default: return language;
            }
        }

        private void UpdateLanguage()
        {
            switch (currentLanguage)
            {
                case "zh-CN":
                    this.Text = "图种生成器";
                    lblTitle.Text = "图种生成器";
                    uiLabel1.Text = "原始文件路径：";
                    uiLabel2.Text = "压缩文件路径：";
                    textBox1.Text = "(支持PNG、BMP、MP3等文件格式)";
                    textBox2.Text = "(支持ZIP、7z等文件格式)";
                    button1.Text = "选择文件";
                    button2.Text = "选择文件";
                    button3.Text = "生成文件";
                    文件ToolStripMenuItem.Text = "设置";
                    关于ToolStripMenuItem.Text = "关于";
                    说明ToolStripMenuItem.Text = "兼容性说明";
                    作者ToolStripMenuItem.Text = "作者";
                    语言ToolStripMenuItem.Text = "语言";
                    主题ToolStripMenuItem.Text = "主题";
                    中文ToolStripMenuItem.Text = "中文";
                    englishToolStripMenuItem.Text = "English";
                    日语ToolStripMenuItem.Text = "日本語";
                    俄语ToolStripMenuItem.Text = "Русский";
                    明亮ToolStripMenuItem.Text = "明亮";
                    暗夜ToolStripMenuItem.Text = "暗夜";
                    break;
                    
                case "en-US":
                    this.Text = "Image Steganography Generator";
                    lblTitle.Text = "Image Steganography Generator";
                    uiLabel1.Text = "Original File Path:";
                    uiLabel2.Text = "Compressed File Path:";
                    textBox1.Text = "(Supports PNG, BMP, MP3 and other file formats)";
                    textBox2.Text = "(Supports ZIP, 7z and other formats)";
                    button1.Text = "Select File";
                    button2.Text = "Select File";
                    button3.Text = "Generate File";
                    文件ToolStripMenuItem.Text = "Settings";
                    关于ToolStripMenuItem.Text = "About";
                    说明ToolStripMenuItem.Text = "Compatibility Guide";
                    作者ToolStripMenuItem.Text = "Author";
                    语言ToolStripMenuItem.Text = "Language";
                    主题ToolStripMenuItem.Text = "Theme";
                    中文ToolStripMenuItem.Text = "中文";
                    englishToolStripMenuItem.Text = "English";
                    日语ToolStripMenuItem.Text = "日本語";
                    俄语ToolStripMenuItem.Text = "Русский";
                    明亮ToolStripMenuItem.Text = "Light";
                    暗夜ToolStripMenuItem.Text = "Dark";
                    break;
                    
                case "ja-JP":
                    this.Text = "画像ステガノグラフィ生成器";
                    lblTitle.Text = "画像ステガノグラフィ生成器";
                    uiLabel1.Text = "元ファイルパス：";
                    uiLabel2.Text = "圧縮ファイルパス：";
                    textBox1.Text = "(PNG、BMP、MP3などのファイル形式をサポート)";
                    textBox2.Text = "(ZIP、7zなどの形式をサポート)";
                    button1.Text = "ファイル選択";
                    button2.Text = "ファイル選択";
                    button3.Text = "ファイル生成";
                    文件ToolStripMenuItem.Text = "設定";
                    关于ToolStripMenuItem.Text = "について";
                    说明ToolStripMenuItem.Text = "互換性ガイド";
                    作者ToolStripMenuItem.Text = "作者";
                    语言ToolStripMenuItem.Text = "言語";
                    主题ToolStripMenuItem.Text = "テーマ";
                    中文ToolStripMenuItem.Text = "中文";
                    englishToolStripMenuItem.Text = "English";
                    日语ToolStripMenuItem.Text = "日本語";
                    俄语ToolStripMenuItem.Text = "Русский";
                    明亮ToolStripMenuItem.Text = "ライト";
                    暗夜ToolStripMenuItem.Text = "ダーク";
                    break;
                    
                case "ru-RU":
                    this.Text = "Генератор стеганографии изображений";
                    lblTitle.Text = "Генератор стеганографии изображений";
                    uiLabel1.Text = "Путь к исходному файлу:";
                    uiLabel2.Text = "Путь к сжатому файлу:";
                    textBox1.Text = "(Поддерживает PNG, BMP, MP3 и другие форматы файлов)";
                    textBox2.Text = "(Поддерживает ZIP, 7z и другие форматы)";
                    button1.Text = "Выбрать файл";
                    button2.Text = "Выбрать файл";
                    button3.Text = "Создать файл";
                    文件ToolStripMenuItem.Text = "Настройки";
                    关于ToolStripMenuItem.Text = "О программе";
                    说明ToolStripMenuItem.Text = "Руководство по совместимости";
                    作者ToolStripMenuItem.Text = "Автор";
                    语言ToolStripMenuItem.Text = "Язык";
                    主题ToolStripMenuItem.Text = "Тема";
                    中文ToolStripMenuItem.Text = "中文";
                    englishToolStripMenuItem.Text = "English";
                    日语ToolStripMenuItem.Text = "日本語";
                    俄语ToolStripMenuItem.Text = "Русский";
                    明亮ToolStripMenuItem.Text = "Светлая";
                    暗夜ToolStripMenuItem.Text = "Темная";
                    break;
            }
        }

        private void UpdateTheme()
        {
            if (currentTheme == "dark")
            {
                // 暗夜主题
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.TitleColor = Color.FromArgb(45, 45, 45);
                
                // 主面板
                panelMain.BackColor = Color.FromArgb(40, 40, 40);
                panelContent.BackColor = Color.FromArgb(50, 50, 50);
                
                // 文件选择面板
                panelFile1.BackColor = Color.FromArgb(60, 60, 60);
                panelFile2.BackColor = Color.FromArgb(60, 60, 60);
                panelGenerate.BackColor = Color.FromArgb(60, 60, 60);
                
                // 标签颜色
                lblTitle.ForeColor = Color.White;
                uiLabel1.ForeColor = Color.White;
                uiLabel2.ForeColor = Color.White;
                
                // 文本框颜色
                textBox1.BackColor = Color.FromArgb(70, 70, 70);
                textBox1.ForeColor = Color.White;
                textBox2.BackColor = Color.FromArgb(70, 70, 70);
                textBox2.ForeColor = Color.White;
                
                // 按钮颜色
                button1.BackColor = Color.FromArgb(0, 120, 215);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(0, 120, 215);
                button2.ForeColor = Color.White;
                button3.BackColor = Color.FromArgb(0, 150, 136);
                button3.ForeColor = Color.White;
                
                // 菜单栏颜色
                menuStrip1.BackColor = Color.FromArgb(45, 45, 45);
                menuStrip1.ForeColor = Color.White;
            }
            else
            {
                // 明亮主题
                this.BackColor = Color.FromArgb(248, 249, 250);
                this.TitleColor = Color.FromArgb(52, 73, 94);
                
                // 主面板
                panelMain.BackColor = Color.FromArgb(248, 249, 250);
                panelContent.BackColor = Color.White;
                
                // 文件选择面板
                panelFile1.BackColor = Color.FromArgb(248, 249, 250);
                panelFile2.BackColor = Color.FromArgb(248, 249, 250);
                panelGenerate.BackColor = Color.FromArgb(248, 249, 250);
                
                // 标签颜色
                lblTitle.ForeColor = Color.FromArgb(52, 73, 94);
                uiLabel1.ForeColor = Color.FromArgb(52, 73, 94);
                uiLabel2.ForeColor = Color.FromArgb(52, 73, 94);
                
                // 文本框颜色
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.FromArgb(108, 117, 125);
                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.FromArgb(108, 117, 125);
                
                // 按钮颜色
                button1.BackColor = Color.FromArgb(52, 152, 219);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(52, 152, 219);
                button2.ForeColor = Color.White;
                button3.BackColor = Color.FromArgb(46, 204, 113);
                button3.ForeColor = Color.White;
                
                // 菜单栏颜色
                menuStrip1.BackColor = Color.FromArgb(245, 245, 245);
                menuStrip1.ForeColor = Color.Black;
            }
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开说明窗体
            Instructions instructionsForm = new Instructions();
            instructionsForm.ShowDialog(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 创建文件选择对话框
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "选择原始文件";
                openFileDialog.Filter = "所有支持的文件|*.png;*.bmp;*.mp3;*.wav;|图片文件|*.png;*.bmp;|音频文件|*.mp3;|所有文件|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 将选择的文件路径显示在文本框中
                    textBox1.Text = openFileDialog.FileName;
                    textBox1.ForeColor = Color.Black; // 将文本颜色改为黑色
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 创建文件选择对话框
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "选择压缩文件";
                openFileDialog.Filter = "压缩文件|*.zip;*.7z;|ZIP文件|*.zip|7z文件|*.7z|所有文件|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 将选择的文件路径显示在文本框中
                    textBox2.Text = openFileDialog.FileName;
                    textBox2.ForeColor = Color.Black; // 将文本颜色改为黑色
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // 检查是否已选择文件
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "(支持PNG、BMP、MP3等文件格式)")
            {
                MessageBox.Show("请先选择原始文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "(支持ZIP、7z等文件格式)")
            {
                MessageBox.Show("请先选择压缩文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 检查文件是否存在
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("原始文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(textBox2.Text))
            {
                MessageBox.Show("压缩文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 验证文件格式兼容性
            string originalExtension = Path.GetExtension(textBox1.Text).ToLower();
            string compressedExtension = Path.GetExtension(textBox2.Text).ToLower();
            
            // 定义支持的格式
            string[] supportedOriginalFormats = { ".png", ".bmp", ".mp3", ".wav", ".tif", ".tiff" };
            string[] supportedCompressedFormats = { ".zip", ".7z" };
            
            bool isOriginalFormatSupported = supportedOriginalFormats.Contains(originalExtension);
            bool isCompressedFormatSupported = supportedCompressedFormats.Contains(compressedExtension);
            
            // 如果格式不完全支持，显示警告
            if (!isOriginalFormatSupported || !isCompressedFormatSupported)
            {
                string warningMessage = "检测到可能不兼容的文件格式：\n\n";
                
                if (!isOriginalFormatSupported)
                {
                    warningMessage += $"原始文件格式：{originalExtension}\n";
                    warningMessage += "支持的原始文件格式：PNG、BMP、MP3、WAV、TIF、TIFF\n\n";
                }
                
                if (!isCompressedFormatSupported)
                {
                    warningMessage += $"压缩文件格式：{compressedExtension}\n";
                    warningMessage += "支持的压缩文件格式：ZIP、7Z\n\n";
                }
                
                warningMessage += "使用不兼容的格式可能导致：\n";
                warningMessage += "• 生成的文件无法正常打开\n";
                warningMessage += "• 文件损坏或数据丢失\n";
                warningMessage += "• 兼容性问题\n\n";
                warningMessage += "是否继续生成？";
                
                DialogResult result = MessageBox.Show(warningMessage, "格式兼容性警告", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (result == DialogResult.No)
                {
                    return; // 用户选择取消
                }
            }

            try
            {
                // 获取原始文件信息
                string originalFilePath = textBox1.Text;
                string compressedFilePath = textBox2.Text;
                
                // 获取原始文件的扩展名和文件名
                string originalFileName = Path.GetFileNameWithoutExtension(originalFilePath);
                
                // 设置默认保存路径（桌面）
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string defaultFileName = originalFileName + "图床" + originalExtension;
                string defaultSavePath = Path.Combine(desktopPath, defaultFileName);

                // 创建保存文件对话框
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "选择保存位置";
                    saveFileDialog.FileName = defaultFileName;
                    saveFileDialog.InitialDirectory = desktopPath;
                    
                    // 根据原始文件类型设置过滤器
                    switch (originalExtension.ToLower())
                    {
                        case ".png":
                            saveFileDialog.Filter = "PNG文件|*.png";
                            break;
                        case ".bmp":
                            saveFileDialog.Filter = "BMP文件|*.bmp";
                            break;
                        case ".mp3":
                            saveFileDialog.Filter = "MP3文件|*.mp3";
                            break;
                        case ".wav":
                            saveFileDialog.Filter = "WAV文件|*.wav";
                            break;
                        case ".tiff":
                        case ".tif":
                            saveFileDialog.Filter = "TIFF文件|*.tiff;*.tif";
                            break;
                        default:
                            saveFileDialog.Filter = "所有文件|*.*";
                            break;
                    }

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 执行文件嵌入操作
                        EmbedFile(originalFilePath, compressedFilePath, saveFileDialog.FileName);
                        
                        MessageBox.Show("图床生成成功！\n保存位置：" + saveFileDialog.FileName, 
                            "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成过程中发生错误：" + ex.Message, "错误", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmbedFile(string originalFilePath, string compressedFilePath, string outputFilePath)
        {
            // 读取原始文件
            byte[] originalFileBytes = File.ReadAllBytes(originalFilePath);
            
            // 读取压缩文件
            byte[] compressedFileBytes = File.ReadAllBytes(compressedFilePath);
            
            // 创建输出文件流
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
            {
                // 写入原始文件内容
                outputStream.Write(originalFileBytes, 0, originalFileBytes.Length);
                
                // 写入分隔符（用于标识嵌入文件的开始）
                byte[] separator = Encoding.UTF8.GetBytes("EMBEDDED_FILE_START");
                outputStream.Write(separator, 0, separator.Length);
                
                // 写入压缩文件大小信息
                byte[] sizeBytes = BitConverter.GetBytes(compressedFileBytes.Length);
                outputStream.Write(sizeBytes, 0, sizeBytes.Length);
                
                // 写入压缩文件内容
                outputStream.Write(compressedFileBytes, 0, compressedFileBytes.Length);
                
                // 写入结束标记
                byte[] endMarker = Encoding.UTF8.GetBytes("EMBEDDED_FILE_END");
                outputStream.Write(endMarker, 0, endMarker.Length);
            }
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            // 防止文本框获得焦点时自动全选文本
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // 延迟设置光标位置到文本末尾，避免全选
                textBox.BeginInvoke(new Action(() =>
                {
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }));
            }
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://zdy123.top";
            System.Diagnostics.Process.Start(url);
        }
    }
}
