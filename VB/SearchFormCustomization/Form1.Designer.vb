Imports Microsoft.VisualBasic
Imports System
Namespace SearchFormExample
    Public Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.btnShowSearchForm = New DevExpress.XtraEditors.SimpleButton()
            Me.myRichEditControl1 = New SearchFormExample.MyRichEditControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.btnShowSearchForm)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(613, 50)
            Me.panelControl1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
            Me.labelControl1.Location = New System.Drawing.Point(139, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' btnShowSearchForm
            ' 
            Me.btnShowSearchForm.Location = New System.Drawing.Point(13, 12)
            Me.btnShowSearchForm.Name = "btnShowSearchForm"
            Me.btnShowSearchForm.Size = New System.Drawing.Size(113, 23)
            Me.btnShowSearchForm.TabIndex = 0
            Me.btnShowSearchForm.Text = "Show Search Form"
'            Me.btnShowSearchForm.Click += New System.EventHandler(Me.btnShowSearchForm_Click);
            ' 
            ' myRichEditControl1
            ' 
            Me.myRichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myRichEditControl1.Location = New System.Drawing.Point(0, 50)
            Me.myRichEditControl1.Name = "myRichEditControl1"
            Me.myRichEditControl1.Size = New System.Drawing.Size(613, 324)
            Me.myRichEditControl1.TabIndex = 0
            Me.myRichEditControl1.Text = "myRichEditControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(613, 374)
            Me.Controls.Add(Me.myRichEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myRichEditControl1 As MyRichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnShowSearchForm As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl

    End Class
End Namespace

