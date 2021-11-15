
namespace ParsingXML
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.GroupBox groupBox3;
            this.radioButtonLinqToXml = new System.Windows.Forms.RadioButton();
            this.radioButtonSax = new System.Windows.Forms.RadioButton();
            this.radioButtonDom = new System.Windows.Forms.RadioButton();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxSubgroup = new System.Windows.Forms.ComboBox();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxPairIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxDayIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxGroupName = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            label8 = new System.Windows.Forms.Label();
            flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(808, 478);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.radioButtonLinqToXml);
            groupBox2.Controls.Add(this.radioButtonSax);
            groupBox2.Controls.Add(this.radioButtonDom);
            groupBox2.Location = new System.Drawing.Point(70, 371);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(668, 81);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Спосіб аналізу";
            // 
            // radioButtonLinqToXml
            // 
            this.radioButtonLinqToXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLinqToXml.AutoSize = true;
            this.radioButtonLinqToXml.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonLinqToXml.Location = new System.Drawing.Point(532, 26);
            this.radioButtonLinqToXml.Name = "radioButtonLinqToXml";
            this.radioButtonLinqToXml.Size = new System.Drawing.Size(97, 40);
            this.radioButtonLinqToXml.TabIndex = 2;
            this.radioButtonLinqToXml.TabStop = true;
            this.radioButtonLinqToXml.Text = "LINQ to XML";
            this.radioButtonLinqToXml.UseVisualStyleBackColor = true;
            this.radioButtonLinqToXml.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSax
            // 
            this.radioButtonSax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonSax.AutoSize = true;
            this.radioButtonSax.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonSax.Location = new System.Drawing.Point(277, 26);
            this.radioButtonSax.Name = "radioButtonSax";
            this.radioButtonSax.Size = new System.Drawing.Size(40, 40);
            this.radioButtonSax.TabIndex = 1;
            this.radioButtonSax.TabStop = true;
            this.radioButtonSax.Text = "SAX";
            this.radioButtonSax.UseVisualStyleBackColor = true;
            this.radioButtonSax.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDom
            // 
            this.radioButtonDom.AutoSize = true;
            this.radioButtonDom.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonDom.Location = new System.Drawing.Point(6, 26);
            this.radioButtonDom.Name = "radioButtonDom";
            this.radioButtonDom.Size = new System.Drawing.Size(48, 40);
            this.radioButtonDom.TabIndex = 0;
            this.radioButtonDom.TabStop = true;
            this.radioButtonDom.Text = "DOM";
            this.radioButtonDom.UseVisualStyleBackColor = true;
            this.radioButtonDom.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(flowLayoutPanel8);
            groupBox1.Controls.Add(flowLayoutPanel7);
            groupBox1.Controls.Add(flowLayoutPanel6);
            groupBox1.Controls.Add(flowLayoutPanel5);
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new System.Drawing.Point(29, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(750, 303);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтри";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(this.comboBoxTeacherName);
            flowLayoutPanel8.Controls.Add(label8);
            flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel8.Location = new System.Drawing.Point(3, 261);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel8.TabIndex = 7;
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Location = new System.Drawing.Point(90, 3);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(651, 28);
            this.comboBoxTeacherName.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 0);
            label8.MinimumSize = new System.Drawing.Size(0, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 28);
            label8.TabIndex = 1;
            label8.Text = "Викладач";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(this.comboBoxFormat);
            flowLayoutPanel7.Controls.Add(label7);
            flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new System.Drawing.Point(3, 227);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(90, 3);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(651, 28);
            this.comboBoxFormat.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 0);
            label7.MinimumSize = new System.Drawing.Size(0, 28);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 28);
            label7.TabIndex = 1;
            label7.Text = "Формат";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(this.comboBoxSubgroup);
            flowLayoutPanel6.Controls.Add(label6);
            flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel6.Location = new System.Drawing.Point(3, 193);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel6.TabIndex = 5;
            // 
            // comboBoxSubgroup
            // 
            this.comboBoxSubgroup.FormattingEnabled = true;
            this.comboBoxSubgroup.Location = new System.Drawing.Point(90, 3);
            this.comboBoxSubgroup.Name = "comboBoxSubgroup";
            this.comboBoxSubgroup.Size = new System.Drawing.Size(651, 28);
            this.comboBoxSubgroup.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 0);
            label6.MinimumSize = new System.Drawing.Size(0, 28);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 28);
            label6.TabIndex = 1;
            label6.Text = "Підгрупа";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(this.comboBoxWeek);
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new System.Drawing.Point(3, 159);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // comboBoxWeek
            // 
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Location = new System.Drawing.Point(90, 3);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(651, 28);
            this.comboBoxWeek.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 0);
            label5.MinimumSize = new System.Drawing.Size(0, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 28);
            label5.TabIndex = 1;
            label5.Text = "Тиждень";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(this.comboBoxSubject);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 125);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(90, 3);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(651, 28);
            this.comboBoxSubject.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 0);
            label4.MinimumSize = new System.Drawing.Size(0, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 28);
            label4.TabIndex = 1;
            label4.Text = "Предмет";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(this.comboBoxPairIndex);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxPairIndex
            // 
            this.comboBoxPairIndex.FormattingEnabled = true;
            this.comboBoxPairIndex.Location = new System.Drawing.Point(90, 3);
            this.comboBoxPairIndex.Name = "comboBoxPairIndex";
            this.comboBoxPairIndex.Size = new System.Drawing.Size(651, 28);
            this.comboBoxPairIndex.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 0);
            label3.MinimumSize = new System.Drawing.Size(0, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 28);
            label3.TabIndex = 1;
            label3.Text = "Пара";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(this.comboBoxDayIndex);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // comboBoxDayIndex
            // 
            this.comboBoxDayIndex.FormattingEnabled = true;
            this.comboBoxDayIndex.Location = new System.Drawing.Point(90, 3);
            this.comboBoxDayIndex.Name = "comboBoxDayIndex";
            this.comboBoxDayIndex.Size = new System.Drawing.Size(651, 28);
            this.comboBoxDayIndex.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 0);
            label2.MinimumSize = new System.Drawing.Size(0, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 28);
            label2.TabIndex = 1;
            label2.Text = "День";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(this.comboBoxGroupName);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxGroupName
            // 
            this.comboBoxGroupName.FormattingEnabled = true;
            this.comboBoxGroupName.Location = new System.Drawing.Point(90, 3);
            this.comboBoxGroupName.Name = "comboBoxGroupName";
            this.comboBoxGroupName.Size = new System.Drawing.Size(651, 28);
            this.comboBoxGroupName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 0);
            label1.MinimumSize = new System.Drawing.Size(0, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 28);
            label1.TabIndex = 1;
            label1.Text = "Група";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button1.AutoSize = true;
            button1.Location = new System.Drawing.Point(308, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(192, 30);
            button1.TabIndex = 0;
            button1.Text = "Трансформувати в HTML";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.flowLayoutPanelResults);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(808, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(303, 478);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результати пошуку";
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(297, 452);
            this.flowLayoutPanelResults.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 478);
            this.Controls.Add(groupBox3);
            this.Controls.Add(panel1);
            this.Name = "Window";
            this.Text = "Аналіз XML";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxGroupName;
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxSubgroup;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxPairIndex;
        private System.Windows.Forms.ComboBox comboBoxDayIndex;
        private System.Windows.Forms.RadioButton radioButtonDom;
        private System.Windows.Forms.RadioButton radioButtonLinqToXml;
        private System.Windows.Forms.RadioButton radioButtonSax;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
    }
}

