﻿namespace Do_An
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            this.Onwaiting_Panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelControlGeneral = new DevExpress.XtraEditors.PanelControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGeneral)).BeginInit();
            this.panelControlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Onwaiting_Panel
            // 
            this.Onwaiting_Panel.AutoScroll = true;
            this.Onwaiting_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Onwaiting_Panel.Location = new System.Drawing.Point(2, 2);
            this.Onwaiting_Panel.Name = "Onwaiting_Panel";
            this.Onwaiting_Panel.Size = new System.Drawing.Size(696, 418);
            this.Onwaiting_Panel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.passedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.onToolStripMenuItem.Text = "OnWait";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // passedToolStripMenuItem
            // 
            this.passedToolStripMenuItem.Name = "passedToolStripMenuItem";
            this.passedToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.passedToolStripMenuItem.Text = "Passed";
            this.passedToolStripMenuItem.Click += new System.EventHandler(this.passedToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelControlGeneral
            // 
            this.panelControlGeneral.Controls.Add(this.Onwaiting_Panel);
            this.panelControlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGeneral.Location = new System.Drawing.Point(0, 28);
            this.panelControlGeneral.Name = "panelControlGeneral";
            this.panelControlGeneral.Size = new System.Drawing.Size(700, 422);
            this.panelControlGeneral.TabIndex = 9;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panelControlGeneral);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGeneral)).EndInit();
            this.panelControlGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Onwaiting_Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passedToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControlGeneral;
    }
}