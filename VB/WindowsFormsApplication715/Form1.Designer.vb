Namespace WindowsFormsApplication715
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
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
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
            DirectCast(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colorPickEdit1
            ' 
            Me.colorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit1.Location = New System.Drawing.Point(22, 22)
            Me.colorPickEdit1.Name = "colorPickEdit1"
            Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "MoreColors", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.palette_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True) _
            })
            Me.colorPickEdit1.Size = New System.Drawing.Size(279, 22)
            Me.colorPickEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(339, 115)
            Me.Controls.Add(Me.colorPickEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit
    End Class
End Namespace

