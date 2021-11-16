
using System;

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
            System.Windows.Forms.Button buttonHtml;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.GroupBox groupBox5;
            System.Windows.Forms.GroupBox groupBoxResults;
            System.Windows.Forms.Panel panel2;
            this.buttonProcess = new System.Windows.Forms.Button();
            this.radioButtonLinqToXml = new System.Windows.Forms.RadioButton();
            this.radioButtonSax = new System.Windows.Forms.RadioButton();
            this.radioButtonDom = new System.Windows.Forms.RadioButton();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxSubgroup = new System.Windows.Forms.ComboBox();
            this.comboBoxPairIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxDayIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxGroupName = new System.Windows.Forms.ComboBox();
            this.panelResults = new System.Windows.Forms.Panel();
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
            buttonHtml = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            groupBoxResults = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.buttonProcess);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(this.groupBoxFilters);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(808, 353);
            panel1.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonProcess.Location = new System.Drawing.Point(577, 23);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(185, 53);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Завантажити";
            this.buttonProcess.UseVisualStyleBackColor = false;
            this.buttonProcess.Visible = false;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.radioButtonLinqToXml);
            groupBox2.Controls.Add(this.radioButtonSax);
            groupBox2.Controls.Add(this.radioButtonDom);
            groupBox2.Location = new System.Drawing.Point(12, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(559, 62);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // radioButtonLinqToXml
            // 
            this.radioButtonLinqToXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLinqToXml.AutoSize = true;
            this.radioButtonLinqToXml.Location = new System.Drawing.Point(370, 26);
            this.radioButtonLinqToXml.Name = "radioButtonLinqToXml";
            this.radioButtonLinqToXml.Size = new System.Drawing.Size(114, 24);
            this.radioButtonLinqToXml.TabIndex = 2;
            this.radioButtonLinqToXml.Text = "LINQ to XML";
            this.radioButtonLinqToXml.UseVisualStyleBackColor = true;
            this.radioButtonLinqToXml.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSax
            // 
            this.radioButtonSax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonSax.AutoSize = true;
            this.radioButtonSax.Location = new System.Drawing.Point(194, 26);
            this.radioButtonSax.Name = "radioButtonSax";
            this.radioButtonSax.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSax.TabIndex = 1;
            this.radioButtonSax.Text = "SAX";
            this.radioButtonSax.UseVisualStyleBackColor = true;
            this.radioButtonSax.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDom
            // 
            this.radioButtonDom.AutoSize = true;
            this.radioButtonDom.Location = new System.Drawing.Point(6, 26);
            this.radioButtonDom.Name = "radioButtonDom";
            this.radioButtonDom.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDom.TabIndex = 0;
            this.radioButtonDom.Text = "DOM";
            this.radioButtonDom.UseVisualStyleBackColor = true;
            this.radioButtonDom.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(flowLayoutPanel8);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel4);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel7);
            this.groupBoxFilters.Controls.Add(flowLayoutPanel3);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 82);
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
            this.comboBoxTeacherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTeacherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Location = new System.Drawing.Point(90, 33);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(651, 28);
            this.comboBoxTeacherName.TabIndex = 9;
            this.comboBoxTeacherName.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxTeacherName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            flowLayoutPanel4.TabIndex = 4;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(90, 33);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(651, 28);
            this.comboBoxSubject.TabIndex = 8;
            this.comboBoxSubject.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxSubject.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            flowLayoutPanel7.TabIndex = 3;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(612, 33);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(129, 28);
            this.comboBoxFormat.TabIndex = 7;
            this.comboBoxFormat.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxFormat.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            this.comboBoxWeek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWeek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Location = new System.Drawing.Point(336, 33);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(119, 28);
            this.comboBoxWeek.TabIndex = 6;
            this.comboBoxWeek.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxWeek.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            this.comboBoxSubgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubgroup.FormattingEnabled = true;
            this.comboBoxSubgroup.Location = new System.Drawing.Point(91, 33);
            this.comboBoxSubgroup.Name = "comboBoxSubgroup";
            this.comboBoxSubgroup.Size = new System.Drawing.Size(88, 28);
            this.comboBoxSubgroup.TabIndex = 5;
            this.comboBoxSubgroup.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxSubgroup.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            flowLayoutPanel3.Controls.Add(this.comboBoxDayIndex);
            flowLayoutPanel3.Controls.Add(label9);
            flowLayoutPanel3.Controls.Add(this.comboBoxGroupName);
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
            this.comboBoxPairIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPairIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPairIndex.FormattingEnabled = true;
            this.comboBoxPairIndex.Location = new System.Drawing.Point(612, 3);
            this.comboBoxPairIndex.Name = "comboBoxPairIndex";
            this.comboBoxPairIndex.Size = new System.Drawing.Size(129, 28);
            this.comboBoxPairIndex.TabIndex = 4;
            this.comboBoxPairIndex.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxPairIndex.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            // comboBoxDayIndex
            // 
            this.comboBoxDayIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDayIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDayIndex.FormattingEnabled = true;
            this.comboBoxDayIndex.Location = new System.Drawing.Point(336, 3);
            this.comboBoxDayIndex.Name = "comboBoxDayIndex";
            this.comboBoxDayIndex.Size = new System.Drawing.Size(119, 28);
            this.comboBoxDayIndex.TabIndex = 3;
            this.comboBoxDayIndex.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxDayIndex.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            // comboBoxGroupName
            // 
            this.comboBoxGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroupName.FormattingEnabled = true;
            this.comboBoxGroupName.Location = new System.Drawing.Point(91, 3);
            this.comboBoxGroupName.Name = "comboBoxGroupName";
            this.comboBoxGroupName.Size = new System.Drawing.Size(88, 28);
            this.comboBoxGroupName.TabIndex = 2;
            this.comboBoxGroupName.TextChanged += new System.EventHandler(this.ClearResults);
            this.comboBoxGroupName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
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
            // buttonHtml
            // 
            buttonHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            buttonHtml.BackColor = System.Drawing.Color.PaleTurquoise;
            buttonHtml.Location = new System.Drawing.Point(814, 26);
            buttonHtml.Name = "buttonHtml";
            buttonHtml.Size = new System.Drawing.Size(304, 53);
            buttonHtml.TabIndex = 0;
            buttonHtml.TabStop = false;
            buttonHtml.Text = "Зберегти весь розклад в HTML";
            buttonHtml.UseVisualStyleBackColor = false;
            buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonHtml);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox4.Location = new System.Drawing.Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(1124, 89);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBoxResults);
            groupBox5.Controls.Add(panel1);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox5.Location = new System.Drawing.Point(0, 89);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(1124, 379);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // groupBoxResults
            // 
            groupBoxResults.Controls.Add(this.panelResults);
            groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxResults.Location = new System.Drawing.Point(811, 23);
            groupBoxResults.Name = "groupBoxResults";
            groupBoxResults.Size = new System.Drawing.Size(310, 353);
            groupBoxResults.TabIndex = 1;
            groupBoxResults.TabStop = false;
            groupBoxResults.Text = "Результати пошуку";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Black;
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1124, 1);
            panel2.TabIndex = 4;
            // 
            // panelResults
            // 
            this.panelResults.AutoScroll = true;
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.Location = new System.Drawing.Point(3, 23);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(304, 327);
            this.panelResults.TabIndex = 0;
            // 
            // Window
            // 
            this.AcceptButton = this.buttonProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 468);
            this.Controls.Add(panel2);
            this.Controls.Add(groupBox5);
            this.Controls.Add(groupBox4);
            this.MinimumSize = new System.Drawing.Size(1142, 515);
            this.Name = "Window";
            this.Text = "XML";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxPairIndex;
        private System.Windows.Forms.ComboBox comboBoxDayIndex;
        private System.Windows.Forms.ComboBox comboBoxGroupName;
        private System.Windows.Forms.ComboBox comboBoxSubgroup;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton radioButtonDom;
        private System.Windows.Forms.RadioButton radioButtonSax;
        private System.Windows.Forms.RadioButton radioButtonLinqToXml;
        private System.Windows.Forms.Panel panelResults;
    }
}

