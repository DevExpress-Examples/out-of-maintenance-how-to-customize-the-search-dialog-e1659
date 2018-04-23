namespace SearchFormExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnShowSearchForm = new DevExpress.XtraEditors.SimpleButton();
            this.myRichEditControl1 = new SearchFormExample.MyRichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnShowSearchForm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(613, 50);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(139, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // btnShowSearchForm
            // 
            this.btnShowSearchForm.Location = new System.Drawing.Point(13, 12);
            this.btnShowSearchForm.Name = "btnShowSearchForm";
            this.btnShowSearchForm.Size = new System.Drawing.Size(113, 23);
            this.btnShowSearchForm.TabIndex = 0;
            this.btnShowSearchForm.Text = "Show Search Form";
            this.btnShowSearchForm.Click += new System.EventHandler(this.btnShowSearchForm_Click);
            // 
            // myRichEditControl1
            // 
            this.myRichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myRichEditControl1.Location = new System.Drawing.Point(0, 50);
            this.myRichEditControl1.Name = "myRichEditControl1";
            this.myRichEditControl1.Size = new System.Drawing.Size(613, 324);
            this.myRichEditControl1.TabIndex = 0;
            this.myRichEditControl1.Text = "myRichEditControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.myRichEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyRichEditControl myRichEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnShowSearchForm;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}

