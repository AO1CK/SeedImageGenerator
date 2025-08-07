using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace 图种生成器
{
    public partial class Instructions : UIForm
    {
        public Instructions()
        {
            InitializeComponent();
            SetupTextBoxEvents();
            SetupScrollToTop();
            SetupMouseWheelScrolling();
        }

        private void SetupTextBoxEvents()
        {
            // 为所有文本框添加防全选事件
            txtPerfect.GotFocus += TextBox_GotFocus;
            txtMost.GotFocus += TextBox_GotFocus;
            txtIncompatible.GotFocus += TextBox_GotFocus;
            txtSuggestions.GotFocus += TextBox_GotFocus;
            txtTechnical.GotFocus += TextBox_GotFocus;
        }

        private void SetupScrollToTop()
        {
            // 窗体加载完成后将滚动条重置到顶部
            this.Load += (sender, e) =>
            {
                // 延迟执行，确保窗体完全加载
                this.BeginInvoke(new Action(() =>
                {
                    scrollPanel.VerticalScroll.Value = 0;
                    scrollPanel.AutoScrollPosition = new Point(0, 0);
                }));
            };
        }

        private void SetupMouseWheelScrolling()
        {
            // 为窗体添加鼠标滚轮事件
            this.MouseWheel += (sender, e) =>
            {
                // 计算滚动距离
                int scrollAmount = e.Delta / 120 * 20; // 每次滚动20像素
                
                // 获取当前滚动位置
                int currentScroll = scrollPanel.VerticalScroll.Value;
                int newScroll = currentScroll - scrollAmount;
                
                // 确保滚动范围在有效范围内
                if (newScroll < 0)
                    newScroll = 0;
                if (newScroll > scrollPanel.VerticalScroll.Maximum)
                    newScroll = scrollPanel.VerticalScroll.Maximum;
                
                // 设置新的滚动位置
                scrollPanel.VerticalScroll.Value = newScroll;
            };

            // 为所有子控件添加鼠标滚轮事件
            AddMouseWheelToControls(this);
        }

        private void AddMouseWheelToControls(Control parent)
        {
            // 为当前控件添加鼠标滚轮事件
            parent.MouseWheel += (sender, e) =>
            {
                // 计算滚动距离
                int scrollAmount = e.Delta / 120 * 30;
                
                // 获取当前滚动位置
                int currentScroll = scrollPanel.VerticalScroll.Value;
                int newScroll = currentScroll - scrollAmount;
                
                // 确保滚动范围在有效范围内
                if (newScroll < 0)
                    newScroll = 0;
                if (newScroll > scrollPanel.VerticalScroll.Maximum)
                    newScroll = scrollPanel.VerticalScroll.Maximum;
                
                // 设置新的滚动位置
                scrollPanel.VerticalScroll.Value = newScroll;
            };

            // 递归为所有子控件添加事件
            foreach (Control child in parent.Controls)
            {
                AddMouseWheelToControls(child);
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
    }
}
