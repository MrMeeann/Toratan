﻿namespace Toratan
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnu_TopMenu = new System.Windows.Forms.MenuStrip();
            this.sts_BottomStatus = new System.Windows.Forms.StatusStrip();
            this.btn_File = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logs = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Line = new System.Windows.Forms.ToolStripSeparator();
            this.btn_About = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OnePageReport = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_PCapFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_PCapFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Line_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_PacketsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_PacketsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Line_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgb_BackProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_Line_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctx_NowStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.txt_PCapSelect = new System.Windows.Forms.TextBox();
            this.lbl_SelectPCap = new System.Windows.Forms.Label();
            this.btn_SelectPcap = new System.Windows.Forms.Button();
            this.btn_CapturePackets = new System.Windows.Forms.Button();
            this.mnu_TopMenu.SuspendLayout();
            this.sts_BottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_TopMenu
            // 
            this.mnu_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_File,
            this.btn_Report});
            this.mnu_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_TopMenu.Name = "mnu_TopMenu";
            this.mnu_TopMenu.Size = new System.Drawing.Size(876, 24);
            this.mnu_TopMenu.TabIndex = 0;
            this.mnu_TopMenu.Text = "menuStrip1";
            // 
            // sts_BottomStatus
            // 
            this.sts_BottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_PCapFile,
            this.ctx_PCapFile,
            this.lbl_Line_1,
            this.lbl_PacketsStatus,
            this.ctx_PacketsStatus,
            this.lbl_Line_2,
            this.ctx_NowStatus,
            this.lbl_Line_3,
            this.pgb_BackProgress});
            this.sts_BottomStatus.Location = new System.Drawing.Point(0, 477);
            this.sts_BottomStatus.Name = "sts_BottomStatus";
            this.sts_BottomStatus.Size = new System.Drawing.Size(876, 22);
            this.sts_BottomStatus.TabIndex = 1;
            this.sts_BottomStatus.Text = "statusStrip1";
            // 
            // btn_File
            // 
            this.btn_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Logs,
            this.btn_Line,
            this.btn_About,
            this.btn_Exit});
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(37, 20);
            this.btn_File.Text = "File";
            // 
            // btn_Logs
            // 
            this.btn_Logs.Name = "btn_Logs";
            this.btn_Logs.Size = new System.Drawing.Size(180, 22);
            this.btn_Logs.Text = "Logs";
            // 
            // btn_Line
            // 
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(177, 6);
            // 
            // btn_About
            // 
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(180, 22);
            this.btn_About.Text = "About";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(180, 22);
            this.btn_Exit.Text = "Exit";
            // 
            // btn_Report
            // 
            this.btn_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_OnePageReport});
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(54, 20);
            this.btn_Report.Text = "Report";
            // 
            // btn_OnePageReport
            // 
            this.btn_OnePageReport.Name = "btn_OnePageReport";
            this.btn_OnePageReport.Size = new System.Drawing.Size(180, 22);
            this.btn_OnePageReport.Text = "One Page Report";
            // 
            // lbl_PCapFile
            // 
            this.lbl_PCapFile.Name = "lbl_PCapFile";
            this.lbl_PCapFile.Size = new System.Drawing.Size(59, 17);
            this.lbl_PCapFile.Text = "PCap File:";
            // 
            // ctx_PCapFile
            // 
            this.ctx_PCapFile.ForeColor = System.Drawing.Color.Red;
            this.ctx_PCapFile.Name = "ctx_PCapFile";
            this.ctx_PCapFile.Size = new System.Drawing.Size(69, 17);
            this.ctx_PCapFile.Text = "Not Loaded";
            // 
            // lbl_Line_1
            // 
            this.lbl_Line_1.Name = "lbl_Line_1";
            this.lbl_Line_1.Size = new System.Drawing.Size(10, 17);
            this.lbl_Line_1.Text = "|";
            // 
            // lbl_PacketsStatus
            // 
            this.lbl_PacketsStatus.Name = "lbl_PacketsStatus";
            this.lbl_PacketsStatus.Size = new System.Drawing.Size(85, 17);
            this.lbl_PacketsStatus.Text = "Packets Status:";
            // 
            // ctx_PacketsStatus
            // 
            this.ctx_PacketsStatus.ForeColor = System.Drawing.Color.Red;
            this.ctx_PacketsStatus.Name = "ctx_PacketsStatus";
            this.ctx_PacketsStatus.Size = new System.Drawing.Size(69, 17);
            this.ctx_PacketsStatus.Text = "Not Loaded";
            // 
            // lbl_Line_2
            // 
            this.lbl_Line_2.Name = "lbl_Line_2";
            this.lbl_Line_2.Size = new System.Drawing.Size(10, 17);
            this.lbl_Line_2.Text = "|";
            // 
            // pgb_BackProgress
            // 
            this.pgb_BackProgress.Name = "pgb_BackProgress";
            this.pgb_BackProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lbl_Line_3
            // 
            this.lbl_Line_3.Name = "lbl_Line_3";
            this.lbl_Line_3.Size = new System.Drawing.Size(10, 17);
            this.lbl_Line_3.Text = "|";
            // 
            // ctx_NowStatus
            // 
            this.ctx_NowStatus.Name = "ctx_NowStatus";
            this.ctx_NowStatus.Size = new System.Drawing.Size(16, 17);
            this.ctx_NowStatus.Text = "...";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Title.Location = new System.Drawing.Point(606, 50);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(108, 31);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Toratan";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Author.Location = new System.Drawing.Point(668, 81);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(118, 15);
            this.lbl_Author.TabIndex = 3;
            this.lbl_Author.Text = "by Morteza Hosseini";
            // 
            // txt_PCapSelect
            // 
            this.txt_PCapSelect.Location = new System.Drawing.Point(594, 133);
            this.txt_PCapSelect.Name = "txt_PCapSelect";
            this.txt_PCapSelect.Size = new System.Drawing.Size(234, 26);
            this.txt_PCapSelect.TabIndex = 4;
            // 
            // lbl_SelectPCap
            // 
            this.lbl_SelectPCap.AutoSize = true;
            this.lbl_SelectPCap.Location = new System.Drawing.Point(508, 136);
            this.lbl_SelectPCap.Name = "lbl_SelectPCap";
            this.lbl_SelectPCap.Size = new System.Drawing.Size(80, 20);
            this.lbl_SelectPCap.TabIndex = 5;
            this.lbl_SelectPCap.Text = "PCAP File";
            // 
            // btn_SelectPcap
            // 
            this.btn_SelectPcap.Location = new System.Drawing.Point(834, 133);
            this.btn_SelectPcap.Name = "btn_SelectPcap";
            this.btn_SelectPcap.Size = new System.Drawing.Size(30, 25);
            this.btn_SelectPcap.TabIndex = 6;
            this.btn_SelectPcap.Text = "...";
            this.btn_SelectPcap.UseVisualStyleBackColor = true;
            // 
            // btn_CapturePackets
            // 
            this.btn_CapturePackets.Location = new System.Drawing.Point(512, 174);
            this.btn_CapturePackets.Name = "btn_CapturePackets";
            this.btn_CapturePackets.Size = new System.Drawing.Size(352, 29);
            this.btn_CapturePackets.TabIndex = 7;
            this.btn_CapturePackets.Text = "Capture Packets";
            this.btn_CapturePackets.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.btn_CapturePackets);
            this.Controls.Add(this.btn_SelectPcap);
            this.Controls.Add(this.lbl_SelectPCap);
            this.Controls.Add(this.txt_PCapSelect);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.sts_BottomStatus);
            this.Controls.Add(this.mnu_TopMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_TopMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Toratan";
            this.mnu_TopMenu.ResumeLayout(false);
            this.mnu_TopMenu.PerformLayout();
            this.sts_BottomStatus.ResumeLayout(false);
            this.sts_BottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_TopMenu;
        private System.Windows.Forms.StatusStrip sts_BottomStatus;
        private System.Windows.Forms.ToolStripMenuItem btn_File;
        private System.Windows.Forms.ToolStripMenuItem btn_Logs;
        private System.Windows.Forms.ToolStripSeparator btn_Line;
        private System.Windows.Forms.ToolStripMenuItem btn_About;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem btn_Report;
        private System.Windows.Forms.ToolStripMenuItem btn_OnePageReport;
        private System.Windows.Forms.ToolStripStatusLabel lbl_PCapFile;
        private System.Windows.Forms.ToolStripStatusLabel ctx_PCapFile;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Line_1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_PacketsStatus;
        private System.Windows.Forms.ToolStripStatusLabel ctx_PacketsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Line_2;
        private System.Windows.Forms.ToolStripProgressBar pgb_BackProgress;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Line_3;
        private System.Windows.Forms.ToolStripStatusLabel ctx_NowStatus;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.TextBox txt_PCapSelect;
        private System.Windows.Forms.Label lbl_SelectPCap;
        private System.Windows.Forms.Button btn_SelectPcap;
        private System.Windows.Forms.Button btn_CapturePackets;
    }
}

