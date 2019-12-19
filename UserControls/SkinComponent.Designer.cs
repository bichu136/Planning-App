namespace Do_An.UserControls
{
    partial class SkinComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSkin = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.ColorPicker = new DevExpress.XtraEditors.ColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSkin
            // 
            this.labelSkin.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelSkin.Appearance.Options.UseFont = true;
            this.labelSkin.Location = new System.Drawing.Point(75, 99);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(63, 30);
            this.labelSkin.TabIndex = 0;
            this.labelSkin.Text = "Skin :";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(160, 108);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(298, 22);
            this.comboBoxEdit1.TabIndex = 1;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // ColorPicker
            // 
            this.ColorPicker.EditValue = System.Drawing.Color.Empty;
            this.ColorPicker.Location = new System.Drawing.Point(295, 198);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.ColorPicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColorPicker.Size = new System.Drawing.Size(125, 22);
            this.ColorPicker.TabIndex = 2;
            this.ColorPicker.EditValueChanged += new System.EventHandler(this.ColorPicker_EditValueChanged);
            // 
            // SkinComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelSkin);
            this.Name = "SkinComponent";
            this.Size = new System.Drawing.Size(640, 404);
            this.Load += new System.EventHandler(this.SkinComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelSkin;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private DevExpress.XtraEditors.ColorPickEdit ColorPicker;
    }
}
