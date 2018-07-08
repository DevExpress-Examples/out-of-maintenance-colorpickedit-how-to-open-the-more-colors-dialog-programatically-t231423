Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorPick.Picker
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication715
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler colorPickEdit1.ButtonClick, AddressOf colorPickEdit1_ButtonClick
        End Sub

        Private Sub colorPickEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Caption <> "MoreColors" Then
                Return
            End If
            Dim edit As ColorPickEdit = TryCast(sender, ColorPickEdit)
            Dim ritem As RepositoryItemColorPickEdit = edit.Properties
            Try
                ritem.LockEventsCore()
                Using frm As New FrmColorPicker(ritem)
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Dim editorColor = CType(ritem.OwnerEdit.EditValue, Color)
                    frm.SelectedColor = If(editorColor.IsEmpty, Color.FromArgb(255, editorColor), editorColor)
                    frm.TopMost = True
                    If frm.ShowDialog(ritem.OwnerEdit.FindForm()) = System.Windows.Forms.DialogResult.OK Then
                        ritem.OwnerEdit.EditValue = frm.SelectedColor
                        'updating recent colors
                        ritem.RecentColors.InsertColor(frm.SelectedColor, 0)
                    End If
                End Using
            Finally
                ritem.ReleaseEventsCore(True)
            End Try
        End Sub
    End Class
End Namespace
