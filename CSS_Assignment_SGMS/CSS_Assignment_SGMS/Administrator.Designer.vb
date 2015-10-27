<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableAdapterManager1 = New CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager3 = New CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager()
        Me.SuspendLayout()
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserProfileTableAdapter = Nothing
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.UserProfileTableAdapter = Nothing
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.UserProfileTableAdapter = Nothing
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 330)
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager1 As CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager3 As CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager
End Class
