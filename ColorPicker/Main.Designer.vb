<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LVCores = New System.Windows.Forms.ListView()
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.CBFormatos = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.CBMost = New System.Windows.Forms.CheckBox()
        Me.lightnessColorSlider = New Cyotek.Windows.Forms.LightnessColorSlider()
        Me.screenColorPicker = New Cyotek.Windows.Forms.ScreenColorPicker()
        Me.colorWheel = New Cyotek.Windows.Forms.ColorWheel()
        Me.colorEditor = New Cyotek.Windows.Forms.ColorEditor()
        Me.colorGrid = New Cyotek.Windows.Forms.ColorGrid()
        Me.previewPanel = New System.Windows.Forms.Panel()
        Me.CM = New Cyotek.Windows.Forms.ColorEditorManager()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Width = 205
        '
        'LVCores
        '
        Me.LVCores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        Me.LVCores.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVCores.ForeColor = System.Drawing.Color.Black
        Me.LVCores.FullRowSelect = True
        Me.LVCores.GridLines = True
        Me.LVCores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LVCores.Location = New System.Drawing.Point(62, 7)
        Me.LVCores.Name = "LVCores"
        Me.LVCores.Size = New System.Drawing.Size(367, 78)
        Me.LVCores.SmallImageList = Me.GList
        Me.LVCores.TabIndex = 1
        Me.LVCores.UseCompatibleStateImageBehavior = False
        Me.LVCores.View = System.Windows.Forms.View.Details
        '
        'GList
        '
        Me.GList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.GList.ImageSize = New System.Drawing.Size(16, 16)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        '
        'CBFormatos
        '
        Me.CBFormatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFormatos.DropDownWidth = 70
        Me.CBFormatos.Font = New System.Drawing.Font("Eras Light ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFormatos.FormattingEnabled = True
        Me.CBFormatos.Items.AddRange(New Object() {"HTML", "RGB", "RGB (.NET)", "HEX"})
        Me.CBFormatos.Location = New System.Drawing.Point(116, 93)
        Me.CBFormatos.Name = "CBFormatos"
        Me.CBFormatos.Size = New System.Drawing.Size(170, 22)
        Me.CBFormatos.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(292, 93)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(137, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "Add"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'CBMost
        '
        Me.CBMost.AutoSize = True
        Me.CBMost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBMost.Font = New System.Drawing.Font("Eras Light ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMost.Location = New System.Drawing.Point(62, 94)
        Me.CBMost.Name = "CBMost"
        Me.CBMost.Size = New System.Drawing.Size(51, 20)
        Me.CBMost.TabIndex = 11
        Me.CBMost.Text = "Most"
        Me.CBMost.UseVisualStyleBackColor = True
        '
        'lightnessColorSlider
        '
        Me.lightnessColorSlider.Location = New System.Drawing.Point(171, 118)
        Me.lightnessColorSlider.Name = "lightnessColorSlider"
        Me.lightnessColorSlider.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.lightnessColorSlider.Size = New System.Drawing.Size(28, 158)
        Me.lightnessColorSlider.TabIndex = 35
        '
        'screenColorPicker
        '
        Me.screenColorPicker.Color = System.Drawing.Color.Black
        Me.screenColorPicker.Image = CType(resources.GetObject("screenColorPicker.Image"), System.Drawing.Image)
        Me.screenColorPicker.Location = New System.Drawing.Point(7, 7)
        Me.screenColorPicker.Name = "screenColorPicker"
        Me.screenColorPicker.Size = New System.Drawing.Size(49, 49)
        Me.screenColorPicker.Zoom = 6
        '
        'colorWheel
        '
        Me.colorWheel.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorWheel.Location = New System.Drawing.Point(7, 118)
        Me.colorWheel.Name = "colorWheel"
        Me.colorWheel.Size = New System.Drawing.Size(158, 158)
        Me.colorWheel.TabIndex = 32
        '
        'colorEditor
        '
        Me.colorEditor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colorEditor.Font = New System.Drawing.Font("Eras Light ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorEditor.Location = New System.Drawing.Point(205, 118)
        Me.colorEditor.Name = "colorEditor"
        Me.colorEditor.Size = New System.Drawing.Size(224, 248)
        Me.colorEditor.TabIndex = 31
        '
        'colorGrid
        '
        Me.colorGrid.AutoAddColors = False
        Me.colorGrid.CellBorderStyle = Cyotek.Windows.Forms.ColorCellBorderStyle.None
        Me.colorGrid.EditMode = Cyotek.Windows.Forms.ColorEditingMode.Both
        Me.colorGrid.Location = New System.Drawing.Point(7, 294)
        Me.colorGrid.Name = "colorGrid"
        Me.colorGrid.Padding = New System.Windows.Forms.Padding(0)
        Me.colorGrid.Palette = Cyotek.Windows.Forms.ColorPalette.Paint
        Me.colorGrid.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.Standard
        Me.colorGrid.ShowCustomColors = False
        Me.colorGrid.Size = New System.Drawing.Size(192, 72)
        Me.colorGrid.Spacing = New System.Drawing.Size(0, 0)
        Me.colorGrid.TabIndex = 33
        '
        'previewPanel
        '
        Me.previewPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewPanel.Location = New System.Drawing.Point(7, 63)
        Me.previewPanel.Name = "previewPanel"
        Me.previewPanel.Size = New System.Drawing.Size(49, 49)
        Me.previewPanel.TabIndex = 34
        '
        'CM
        '
        Me.CM.ColorEditor = Me.colorEditor
        Me.CM.ColorGrid = Me.colorGrid
        Me.CM.ColorWheel = Me.colorWheel
        Me.CM.LightnessColorSlider = Me.lightnessColorSlider
        Me.CM.ScreenColorPicker = Me.screenColorPicker
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 373)
        Me.Controls.Add(Me.LVCores)
        Me.Controls.Add(Me.CBFormatos)
        Me.Controls.Add(Me.lightnessColorSlider)
        Me.Controls.Add(Me.screenColorPicker)
        Me.Controls.Add(Me.colorWheel)
        Me.Controls.Add(Me.colorEditor)
        Me.Controls.Add(Me.colorGrid)
        Me.Controls.Add(Me.previewPanel)
        Me.Controls.Add(Me.CBMost)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Picker By Aem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVCores As System.Windows.Forms.ListView
    Friend WithEvents CBFormatos As System.Windows.Forms.ComboBox
    Friend WithEvents GList As System.Windows.Forms.ImageList
    Friend WithEvents JColor2 As JustControl
    Friend WithEvents JColor1 As JustControl
    Friend WithEvents btnOK As Button
    Friend WithEvents CBMost As CheckBox
    Private WithEvents lightnessColorSlider As Cyotek.Windows.Forms.LightnessColorSlider
    Private WithEvents screenColorPicker As Cyotek.Windows.Forms.ScreenColorPicker
    Private WithEvents colorWheel As Cyotek.Windows.Forms.ColorWheel
    Private WithEvents colorEditor As Cyotek.Windows.Forms.ColorEditor
    Private WithEvents colorGrid As Cyotek.Windows.Forms.ColorGrid
    Private WithEvents previewPanel As Panel
    Private WithEvents CM As Cyotek.Windows.Forms.ColorEditorManager
End Class
