namespace 图种生成器
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTechnical = new System.Windows.Forms.Panel();
            this.txtTechnical = new System.Windows.Forms.TextBox();
            this.lblTechnical = new System.Windows.Forms.Label();
            this.panelSuggestions = new System.Windows.Forms.Panel();
            this.txtSuggestions = new System.Windows.Forms.TextBox();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.panelIncompatible = new System.Windows.Forms.Panel();
            this.txtIncompatible = new System.Windows.Forms.TextBox();
            this.lblIncompatible = new System.Windows.Forms.Label();
            this.panelMost = new System.Windows.Forms.Panel();
            this.txtMost = new System.Windows.Forms.TextBox();
            this.lblMost = new System.Windows.Forms.Label();
            this.panelPerfect = new System.Windows.Forms.Panel();
            this.txtPerfect = new System.Windows.Forms.TextBox();
            this.lblPerfect = new System.Windows.Forms.Label();
            this.separatorLine = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.panelTechnical.SuspendLayout();
            this.panelSuggestions.SuspendLayout();
            this.panelIncompatible.SuspendLayout();
            this.panelMost.SuspendLayout();
            this.panelPerfect.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.mainPanel.Controls.Add(this.scrollPanel);
            this.mainPanel.Controls.Add(this.separatorLine);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(900, 765);
            this.mainPanel.TabIndex = 0;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.BackColor = System.Drawing.Color.White;
            this.scrollPanel.Controls.Add(this.contentPanel);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(20, 62);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(15);
            this.scrollPanel.Size = new System.Drawing.Size(860, 683);
            this.scrollPanel.TabIndex = 3;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.panelTechnical);
            this.contentPanel.Controls.Add(this.panelSuggestions);
            this.contentPanel.Controls.Add(this.panelIncompatible);
            this.contentPanel.Controls.Add(this.panelMost);
            this.contentPanel.Controls.Add(this.panelPerfect);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contentPanel.Location = new System.Drawing.Point(15, 15);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(813, 1928);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.WrapContents = false;
            // 
            // panelTechnical
            // 
            this.panelTechnical.BackColor = System.Drawing.Color.White;
            this.panelTechnical.Controls.Add(this.txtTechnical);
            this.panelTechnical.Controls.Add(this.lblTechnical);
            this.panelTechnical.Location = new System.Drawing.Point(3, 3);
            this.panelTechnical.Name = "panelTechnical";
            this.panelTechnical.Size = new System.Drawing.Size(800, 274);
            this.panelTechnical.TabIndex = 5;
            // 
            // txtTechnical
            // 
            this.txtTechnical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtTechnical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechnical.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTechnical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTechnical.Location = new System.Drawing.Point(15, 55);
            this.txtTechnical.Multiline = true;
            this.txtTechnical.Name = "txtTechnical";
            this.txtTechnical.ReadOnly = true;
            this.txtTechnical.Size = new System.Drawing.Size(770, 204);
            this.txtTechnical.TabIndex = 1;
            this.txtTechnical.Text = "图种生成器通过以下方式工作：\r\n1. 将原始文件作为载体（图床）\r\n2. 将压缩文件数据嵌入到载体文件末尾\r\n3. 使用特殊标记分隔嵌入的数据\r\n4. 保持原始文" +
    "件格式不变，确保正常打开\r\n\r\n注意事项：\r\n• 嵌入数据不会影响原始文件的正常使用\r\n• 文件大小会增加（原始文件大小 + 压缩文件大小）\r\n• 生成的图床文" +
    "件可以正常打开和使用";
            // 
            // lblTechnical
            // 
            this.lblTechnical.AutoSize = true;
            this.lblTechnical.BackColor = System.Drawing.Color.Transparent;
            this.lblTechnical.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTechnical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.lblTechnical.Location = new System.Drawing.Point(15, 20);
            this.lblTechnical.Name = "lblTechnical";
            this.lblTechnical.Size = new System.Drawing.Size(121, 26);
            this.lblTechnical.TabIndex = 0;
            this.lblTechnical.Text = "🔧 技术原理";
            // 
            // panelSuggestions
            // 
            this.panelSuggestions.BackColor = System.Drawing.Color.White;
            this.panelSuggestions.Controls.Add(this.txtSuggestions);
            this.panelSuggestions.Controls.Add(this.lblSuggestions);
            this.panelSuggestions.Location = new System.Drawing.Point(3, 283);
            this.panelSuggestions.Name = "panelSuggestions";
            this.panelSuggestions.Size = new System.Drawing.Size(800, 170);
            this.panelSuggestions.TabIndex = 4;
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuggestions.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSuggestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuggestions.Location = new System.Drawing.Point(15, 55);
            this.txtSuggestions.Multiline = true;
            this.txtSuggestions.Name = "txtSuggestions";
            this.txtSuggestions.ReadOnly = true;
            this.txtSuggestions.Size = new System.Drawing.Size(770, 107);
            this.txtSuggestions.TabIndex = 1;
            this.txtSuggestions.Text = "1. 优先使用完美支持的格式\r\n2. 使用其他格式前先测试\r\n3. 避免使用完全不兼容的格式\r\n4. 生成后及时验证文件可用性\r\n5. 重要文件建议备份";
            // 
            // lblSuggestions
            // 
            this.lblSuggestions.AutoSize = true;
            this.lblSuggestions.BackColor = System.Drawing.Color.Transparent;
            this.lblSuggestions.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuggestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSuggestions.Location = new System.Drawing.Point(15, 20);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(121, 26);
            this.lblSuggestions.TabIndex = 0;
            this.lblSuggestions.Text = "💡 使用建议";
            // 
            // panelIncompatible
            // 
            this.panelIncompatible.BackColor = System.Drawing.Color.White;
            this.panelIncompatible.Controls.Add(this.txtIncompatible);
            this.panelIncompatible.Controls.Add(this.lblIncompatible);
            this.panelIncompatible.Location = new System.Drawing.Point(3, 459);
            this.panelIncompatible.Name = "panelIncompatible";
            this.panelIncompatible.Size = new System.Drawing.Size(800, 594);
            this.panelIncompatible.TabIndex = 3;
            // 
            // txtIncompatible
            // 
            this.txtIncompatible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtIncompatible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncompatible.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIncompatible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncompatible.Location = new System.Drawing.Point(15, 55);
            this.txtIncompatible.Multiline = true;
            this.txtIncompatible.Name = "txtIncompatible";
            this.txtIncompatible.ReadOnly = true;
            this.txtIncompatible.Size = new System.Drawing.Size(770, 523);
            this.txtIncompatible.TabIndex = 1;
            this.txtIncompatible.Text = resources.GetString("txtIncompatible.Text");
            // 
            // lblIncompatible
            // 
            this.lblIncompatible.AutoSize = true;
            this.lblIncompatible.BackColor = System.Drawing.Color.Transparent;
            this.lblIncompatible.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIncompatible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.lblIncompatible.Location = new System.Drawing.Point(15, 20);
            this.lblIncompatible.Name = "lblIncompatible";
            this.lblIncompatible.Size = new System.Drawing.Size(311, 26);
            this.lblIncompatible.TabIndex = 0;
            this.lblIncompatible.Text = "❌ 完全不兼容的格式（禁止使用）";
            // 
            // panelMost
            // 
            this.panelMost.BackColor = System.Drawing.Color.White;
            this.panelMost.Controls.Add(this.txtMost);
            this.panelMost.Controls.Add(this.lblMost);
            this.panelMost.Location = new System.Drawing.Point(3, 1059);
            this.panelMost.Name = "panelMost";
            this.panelMost.Size = new System.Drawing.Size(800, 500);
            this.panelMost.TabIndex = 2;
            // 
            // txtMost
            // 
            this.txtMost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtMost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMost.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMost.Location = new System.Drawing.Point(15, 55);
            this.txtMost.Multiline = true;
            this.txtMost.Name = "txtMost";
            this.txtMost.ReadOnly = true;
            this.txtMost.Size = new System.Drawing.Size(770, 430);
            this.txtMost.TabIndex = 1;
            this.txtMost.Text = resources.GetString("txtMost.Text");
            // 
            // lblMost
            // 
            this.lblMost.AutoSize = true;
            this.lblMost.BackColor = System.Drawing.Color.Transparent;
            this.lblMost.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblMost.Location = new System.Drawing.Point(15, 20);
            this.lblMost.Name = "lblMost";
            this.lblMost.Size = new System.Drawing.Size(347, 26);
            this.lblMost.TabIndex = 0;
            this.lblMost.Text = "⚠️ 大部分支持的格式（80-95%兼容）";
            // 
            // panelPerfect
            // 
            this.panelPerfect.BackColor = System.Drawing.Color.White;
            this.panelPerfect.Controls.Add(this.txtPerfect);
            this.panelPerfect.Controls.Add(this.lblPerfect);
            this.panelPerfect.Location = new System.Drawing.Point(3, 1565);
            this.panelPerfect.Name = "panelPerfect";
            this.panelPerfect.Size = new System.Drawing.Size(800, 360);
            this.panelPerfect.TabIndex = 1;
            // 
            // txtPerfect
            // 
            this.txtPerfect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPerfect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerfect.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPerfect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPerfect.Location = new System.Drawing.Point(15, 55);
            this.txtPerfect.Multiline = true;
            this.txtPerfect.Name = "txtPerfect";
            this.txtPerfect.ReadOnly = true;
            this.txtPerfect.Size = new System.Drawing.Size(770, 279);
            this.txtPerfect.TabIndex = 1;
            this.txtPerfect.Text = "原始文件格式：\r\n• PNG - 最佳选择，最稳定\r\n• BMP - 位图格式，完全兼容\r\n• WAV - 无损音频格式\r\n• TIFF/TIF - 高质量图片格" +
    "式\r\n\r\n压缩文件格式：\r\n• ZIP - 标准压缩格式\r\n• 7Z - 高压缩比格式\r\n\r\n特点：\r\n• 生成的文件100%能正常打开\r\n• 无兼容性问题\r\n" +
    "• 推荐优先使用";
            // 
            // lblPerfect
            // 
            this.lblPerfect.AutoSize = true;
            this.lblPerfect.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfect.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPerfect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPerfect.Location = new System.Drawing.Point(15, 20);
            this.lblPerfect.Name = "lblPerfect";
            this.lblPerfect.Size = new System.Drawing.Size(308, 26);
            this.lblPerfect.TabIndex = 0;
            this.lblPerfect.Text = "✅ 完美支持的格式（100%兼容）";
            // 
            // separatorLine
            // 
            this.separatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.separatorLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorLine.Location = new System.Drawing.Point(20, 60);
            this.separatorLine.Name = "separatorLine";
            this.separatorLine.Size = new System.Drawing.Size(860, 2);
            this.separatorLine.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(860, 40);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "图种生成器 - 格式兼容性说明";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Instructions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.ControlBoxFillHoverColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Instructions";
            this.Text = "格式兼容性说明";
            this.TitleColor = System.Drawing.Color.Gray;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 900, 800);
            this.mainPanel.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.panelTechnical.ResumeLayout(false);
            this.panelTechnical.PerformLayout();
            this.panelSuggestions.ResumeLayout(false);
            this.panelSuggestions.PerformLayout();
            this.panelIncompatible.ResumeLayout(false);
            this.panelIncompatible.PerformLayout();
            this.panelMost.ResumeLayout(false);
            this.panelMost.PerformLayout();
            this.panelPerfect.ResumeLayout(false);
            this.panelPerfect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
        private System.Windows.Forms.Panel separatorLine;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panelPerfect;
        private System.Windows.Forms.Label lblPerfect;
        private System.Windows.Forms.TextBox txtPerfect;
        private System.Windows.Forms.Panel panelMost;
        private System.Windows.Forms.Label lblMost;
        private System.Windows.Forms.TextBox txtMost;
        private System.Windows.Forms.Panel panelIncompatible;
        private System.Windows.Forms.Label lblIncompatible;
        private System.Windows.Forms.TextBox txtIncompatible;
        private System.Windows.Forms.Panel panelSuggestions;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.TextBox txtSuggestions;
        private System.Windows.Forms.Panel panelTechnical;
        private System.Windows.Forms.Label lblTechnical;
        private System.Windows.Forms.TextBox txtTechnical;
    }
}