
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.GroupBox groupBox3;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLinqToXml = new System.Windows.Forms.Button();
            this.buttonSax = new System.Windows.Forms.Button();
            this.buttonDom = new System.Windows.Forms.Button();
            this.labelAnalyze = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxSubgroup = new System.Windows.Forms.ComboBox();
            this.comboBoxPairIndex = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            label8 = new System.Windows.Forms.Label();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(this.groupBoxFilters);
            panel1.Controls.Add(button1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(808, 555);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(29, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(750, 62);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLinqToXml);
            this.flowLayoutPanel1.Controls.Add(this.buttonSax);
            this.flowLayoutPanel1.Controls.Add(this.buttonDom);
            this.flowLayoutPanel1.Controls.Add(this.labelAnalyze);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonLinqToXml
            // 
            this.buttonLinqToXml.Location = new System.Drawing.Point(612, 3);
            this.buttonLinqToXml.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.buttonLinqToXml.Name = "buttonLinqToXml";
            this.buttonLinqToXml.Size = new System.Drawing.Size(129, 29);
            this.buttonLinqToXml.TabIndex = 3;
            this.buttonLinqToXml.Text = "LINQ to XML";
            this.buttonLinqToXml.UseVisualStyleBackColor = true;
            this.buttonLinqToXml.Click += new System.EventHandler(this.buttonLinqToXml_Click);
            // 
            // buttonSax
            // 
            this.buttonSax.Location = new System.Drawing.Point(440, 3);
            this.buttonSax.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.buttonSax.Name = "buttonSax";
            this.buttonSax.Size = new System.Drawing.Size(129, 29);
            this.buttonSax.TabIndex = 2;
            this.buttonSax.Text = "SAX";
            this.buttonSax.UseVisualStyleBackColor = true;
            this.buttonSax.Click += new System.EventHandler(this.buttonSax_Click);
            // 
            // buttonDom
            // 
            this.buttonDom.Location = new System.Drawing.Point(268, 3);
            this.buttonDom.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.buttonDom.Name = "buttonDom";
            this.buttonDom.Size = new System.Drawing.Size(129, 29);
            this.buttonDom.TabIndex = 1;
            this.buttonDom.Text = "DOM";
            this.buttonDom.UseVisualStyleBackColor = true;
            this.buttonDom.Click += new System.EventHandler(this.buttonDom_Click);
            // 
            // labelAnalyze
            // 
            this.labelAnalyze.Location = new System.Drawing.Point(12, 0);
            this.labelAnalyze.MinimumSize = new System.Drawing.Size(0, 29);
            this.labelAnalyze.Name = "labelAnalyze";
            this.labelAnalyze.Size = new System.Drawing.Size(213, 29);
            this.labelAnalyze.TabIndex = 0;
            this.labelAnalyze.Text = "Завантажити за допомогою:";
            this.labelAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(flowLayoutPanel8);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel4);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel7);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel3);
            this.groupBoxFilters.Location = new System.Drawing.Point(29, 48);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(750, 257);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фільтри";
            this.groupBoxFilters.Visible = false;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(this.comboBoxTeacherName);
            flowLayoutPanel8.Controls.Add(label8);
            flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel8.Location = new System.Drawing.Point(3, 185);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            flowLayoutPanel8.Size = new System.Drawing.Size(744, 64);
            flowLayoutPanel8.TabIndex = 7;
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Location = new System.Drawing.Point(90, 33);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(651, 28);
            this.comboBoxTeacherName.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 30);
            label8.MinimumSize = new System.Drawing.Size(0, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 28);
            label8.TabIndex = 1;
            label8.Text = "Викладач";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(this.comboBoxSubject);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 121);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            flowLayoutPanel4.Size = new System.Drawing.Size(744, 64);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(90, 33);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(651, 28);
            this.comboBoxSubject.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 30);
            label4.MinimumSize = new System.Drawing.Size(0, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 28);
            label4.TabIndex = 1;
            label4.Text = "Предмет";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(this.comboBoxFormat);
            flowLayoutPanel7.Controls.Add(label7);
            flowLayoutPanel7.Controls.Add(this.comboBoxWeek);
            flowLayoutPanel7.Controls.Add(label2);
            flowLayoutPanel7.Controls.Add(this.comboBoxSubgroup);
            flowLayoutPanel7.Controls.Add(label1);
            flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new System.Drawing.Point(3, 57);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            flowLayoutPanel7.Size = new System.Drawing.Size(744, 64);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(612, 33);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(129, 28);
            this.comboBoxFormat.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(461, 30);
            label7.MinimumSize = new System.Drawing.Size(20, 28);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(145, 28);
            label7.TabIndex = 1;
            label7.Text = "Формат";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxWeek
            // 
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Location = new System.Drawing.Point(336, 33);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(119, 28);
            this.comboBoxWeek.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(185, 30);
            label2.MinimumSize = new System.Drawing.Size(20, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 28);
            label2.TabIndex = 5;
            label2.Text = "Тиждень";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSubgroup
            // 
            this.comboBoxSubgroup.FormattingEnabled = true;
            this.comboBoxSubgroup.Location = new System.Drawing.Point(91, 33);
            this.comboBoxSubgroup.Name = "comboBoxSubgroup";
            this.comboBoxSubgroup.Size = new System.Drawing.Size(88, 28);
            this.comboBoxSubgroup.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 30);
            label1.MinimumSize = new System.Drawing.Size(0, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 28);
            label1.TabIndex = 3;
            label1.Text = "Підгрупа";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(this.comboBoxPairIndex);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(this.comboBox1);
            flowLayoutPanel3.Controls.Add(label9);
            flowLayoutPanel3.Controls.Add(this.comboBox2);
            flowLayoutPanel3.Controls.Add(label10);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(744, 34);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxPairIndex
            // 
            this.comboBoxPairIndex.FormattingEnabled = true;
            this.comboBoxPairIndex.Location = new System.Drawing.Point(612, 3);
            this.comboBoxPairIndex.Name = "comboBoxPairIndex";
            this.comboBoxPairIndex.Size = new System.Drawing.Size(129, 28);
            this.comboBoxPairIndex.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(461, 0);
            label3.MinimumSize = new System.Drawing.Size(145, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 28);
            label3.TabIndex = 1;
            label3.Text = "Пара";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(185, 0);
            label9.MinimumSize = new System.Drawing.Size(145, 28);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(145, 28);
            label9.TabIndex = 3;
            label9.Text = "День";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(36, 0);
            label10.MinimumSize = new System.Drawing.Size(0, 28);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(49, 28);
            label10.TabIndex = 5;
            label10.Text = "Група";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            groupBox3.Size = new System.Drawing.Size(303, 555);
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
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(297, 529);
            this.flowLayoutPanelResults.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 555);
            this.Controls.Add(groupBox3);
            this.Controls.Add(panel1);
            this.Name = "Window";
            this.Text = "Аналіз XML";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxPairIndex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxSubgroup;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelAnalyze;
        private System.Windows.Forms.Button buttonDom;
        private System.Windows.Forms.Button buttonSax;
        private System.Windows.Forms.Button buttonLinqToXml;
        private System.Windows.Forms.GroupBox groupBoxFilters;
    }
}

