<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.GroupBoxCategory = New System.Windows.Forms.GroupBox()
        Me.CheckBoxLeaders = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxTypeName = New System.Windows.Forms.TextBox()
        Me.RadioButtonTypeNotContains = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTypeContains = New System.Windows.Forms.RadioButton()
        Me.DataGridViewFamilies = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSymbolsCheckNone = New System.Windows.Forms.Button()
        Me.ButtonSymbolsCheckAll = New System.Windows.Forms.Button()
        Me.ComboBoxTags = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.LabelCategoryName = New System.Windows.Forms.Label()
        Me.GroupBoxViews = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ButtonViewsCheckNone = New System.Windows.Forms.Button()
        Me.ButtonViewsCheckAll = New System.Windows.Forms.Button()
        Me.DataGridViews = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButtonViewContains = New System.Windows.Forms.RadioButton()
        Me.TextBoxViewName = New System.Windows.Forms.TextBox()
        Me.RadioButtonViewNotContains = New System.Windows.Forms.RadioButton()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBoxCategory.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFamilies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxViews.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxCategory
        '
        Me.GroupBoxCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCategory.Controls.Add(Me.CheckBoxLeaders)
        Me.GroupBoxCategory.Controls.Add(Me.PictureBox2)
        Me.GroupBoxCategory.Controls.Add(Me.PictureBox1)
        Me.GroupBoxCategory.Controls.Add(Me.TextBoxTypeName)
        Me.GroupBoxCategory.Controls.Add(Me.RadioButtonTypeNotContains)
        Me.GroupBoxCategory.Controls.Add(Me.RadioButtonTypeContains)
        Me.GroupBoxCategory.Controls.Add(Me.DataGridViewFamilies)
        Me.GroupBoxCategory.Controls.Add(Me.ButtonSymbolsCheckNone)
        Me.GroupBoxCategory.Controls.Add(Me.ButtonSymbolsCheckAll)
        Me.GroupBoxCategory.Controls.Add(Me.ComboBoxTags)
        Me.GroupBoxCategory.Controls.Add(Me.Label1)
        Me.GroupBoxCategory.Controls.Add(Me.ComboBoxCategory)
        Me.GroupBoxCategory.Controls.Add(Me.LabelCategoryName)
        Me.GroupBoxCategory.Location = New System.Drawing.Point(12, 11)
        Me.GroupBoxCategory.Name = "GroupBoxCategory"
        Me.GroupBoxCategory.Size = New System.Drawing.Size(610, 345)
        Me.GroupBoxCategory.TabIndex = 3
        Me.GroupBoxCategory.TabStop = False
        Me.GroupBoxCategory.Text = "Select a Category, then a Tag Family and Family Types that you want to Tag:"
        '
        'CheckBoxLeaders
        '
        Me.CheckBoxLeaders.AutoSize = True
        Me.CheckBoxLeaders.Location = New System.Drawing.Point(34, 231)
        Me.CheckBoxLeaders.Name = "CheckBoxLeaders"
        Me.CheckBoxLeaders.Size = New System.Drawing.Size(66, 16)
        Me.CheckBoxLeaders.TabIndex = 13
        Me.CheckBoxLeaders.Text = "Leaders"
        Me.CheckBoxLeaders.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.[Case].Subs.SuperTag.My.Resources.Resources.search
        Me.PictureBox2.Location = New System.Drawing.Point(335, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.[Case].Subs.SuperTag.My.Resources.Resources.Case_Clearly
        Me.PictureBox1.Location = New System.Drawing.Point(426, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBoxTypeName
        '
        Me.TextBoxTypeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTypeName.Location = New System.Drawing.Point(365, 103)
        Me.TextBoxTypeName.Name = "TextBoxTypeName"
        Me.TextBoxTypeName.Size = New System.Drawing.Size(239, 21)
        Me.TextBoxTypeName.TabIndex = 10
        '
        'RadioButtonTypeNotContains
        '
        Me.RadioButtonTypeNotContains.AutoSize = True
        Me.RadioButtonTypeNotContains.Location = New System.Drawing.Point(166, 104)
        Me.RadioButtonTypeNotContains.Name = "RadioButtonTypeNotContains"
        Me.RadioButtonTypeNotContains.Size = New System.Drawing.Size(149, 16)
        Me.RadioButtonTypeNotContains.TabIndex = 9
        Me.RadioButtonTypeNotContains.Text = "Name Does Not Contain"
        Me.RadioButtonTypeNotContains.UseVisualStyleBackColor = True
        '
        'RadioButtonTypeContains
        '
        Me.RadioButtonTypeContains.AutoSize = True
        Me.RadioButtonTypeContains.Checked = True
        Me.RadioButtonTypeContains.Location = New System.Drawing.Point(29, 104)
        Me.RadioButtonTypeContains.Name = "RadioButtonTypeContains"
        Me.RadioButtonTypeContains.Size = New System.Drawing.Size(101, 16)
        Me.RadioButtonTypeContains.TabIndex = 8
        Me.RadioButtonTypeContains.TabStop = True
        Me.RadioButtonTypeContains.Text = "Name Contains"
        Me.RadioButtonTypeContains.UseVisualStyleBackColor = True
        '
        'DataGridViewFamilies
        '
        Me.DataGridViewFamilies.AllowUserToAddRows = False
        Me.DataGridViewFamilies.AllowUserToDeleteRows = False
        Me.DataGridViewFamilies.AllowUserToResizeRows = False
        Me.DataGridViewFamilies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFamilies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridViewFamilies.Location = New System.Drawing.Point(110, 127)
        Me.DataGridViewFamilies.Name = "DataGridViewFamilies"
        Me.DataGridViewFamilies.RowHeadersVisible = False
        Me.DataGridViewFamilies.Size = New System.Drawing.Size(494, 212)
        Me.DataGridViewFamilies.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "isChecked"
        Me.Column1.HeaderText = ""
        Me.Column1.MinimumWidth = 30
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ElementFullName"
        Me.Column2.HeaderText = "Families to Tag"
        Me.Column2.MinimumWidth = 400
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 400
        '
        'ButtonSymbolsCheckNone
        '
        Me.ButtonSymbolsCheckNone.Location = New System.Drawing.Point(29, 170)
        Me.ButtonSymbolsCheckNone.Name = "ButtonSymbolsCheckNone"
        Me.ButtonSymbolsCheckNone.Size = New System.Drawing.Size(75, 37)
        Me.ButtonSymbolsCheckNone.TabIndex = 6
        Me.ButtonSymbolsCheckNone.Text = "Check None"
        Me.ButtonSymbolsCheckNone.UseVisualStyleBackColor = True
        '
        'ButtonSymbolsCheckAll
        '
        Me.ButtonSymbolsCheckAll.Location = New System.Drawing.Point(29, 127)
        Me.ButtonSymbolsCheckAll.Name = "ButtonSymbolsCheckAll"
        Me.ButtonSymbolsCheckAll.Size = New System.Drawing.Size(75, 37)
        Me.ButtonSymbolsCheckAll.TabIndex = 5
        Me.ButtonSymbolsCheckAll.Text = "Check All"
        Me.ButtonSymbolsCheckAll.UseVisualStyleBackColor = True
        '
        'ComboBoxTags
        '
        Me.ComboBoxTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTags.FormattingEnabled = True
        Me.ComboBoxTags.Location = New System.Drawing.Point(109, 63)
        Me.ComboBoxTags.Name = "ComboBoxTags"
        Me.ComboBoxTags.Size = New System.Drawing.Size(311, 20)
        Me.ComboBoxTags.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tag Family:"
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(109, 26)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(311, 20)
        Me.ComboBoxCategory.TabIndex = 1
        '
        'LabelCategoryName
        '
        Me.LabelCategoryName.AutoSize = True
        Me.LabelCategoryName.Location = New System.Drawing.Point(26, 29)
        Me.LabelCategoryName.Name = "LabelCategoryName"
        Me.LabelCategoryName.Size = New System.Drawing.Size(59, 12)
        Me.LabelCategoryName.TabIndex = 0
        Me.LabelCategoryName.Text = "Category:"
        '
        'GroupBoxViews
        '
        Me.GroupBoxViews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxViews.Controls.Add(Me.PictureBox3)
        Me.GroupBoxViews.Controls.Add(Me.ButtonViewsCheckNone)
        Me.GroupBoxViews.Controls.Add(Me.ButtonViewsCheckAll)
        Me.GroupBoxViews.Controls.Add(Me.DataGridViews)
        Me.GroupBoxViews.Controls.Add(Me.RadioButtonViewContains)
        Me.GroupBoxViews.Controls.Add(Me.TextBoxViewName)
        Me.GroupBoxViews.Controls.Add(Me.RadioButtonViewNotContains)
        Me.GroupBoxViews.Location = New System.Drawing.Point(12, 362)
        Me.GroupBoxViews.Name = "GroupBoxViews"
        Me.GroupBoxViews.Size = New System.Drawing.Size(610, 265)
        Me.GroupBoxViews.TabIndex = 4
        Me.GroupBoxViews.TabStop = False
        Me.GroupBoxViews.Text = "Select the Views to Tag Your Selected Elements In:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.[Case].Subs.SuperTag.My.Resources.Resources.search
        Me.PictureBox3.Location = New System.Drawing.Point(335, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'ButtonViewsCheckNone
        '
        Me.ButtonViewsCheckNone.Location = New System.Drawing.Point(29, 95)
        Me.ButtonViewsCheckNone.Name = "ButtonViewsCheckNone"
        Me.ButtonViewsCheckNone.Size = New System.Drawing.Size(75, 37)
        Me.ButtonViewsCheckNone.TabIndex = 17
        Me.ButtonViewsCheckNone.Text = "Check None"
        Me.ButtonViewsCheckNone.UseVisualStyleBackColor = True
        '
        'ButtonViewsCheckAll
        '
        Me.ButtonViewsCheckAll.Location = New System.Drawing.Point(29, 53)
        Me.ButtonViewsCheckAll.Name = "ButtonViewsCheckAll"
        Me.ButtonViewsCheckAll.Size = New System.Drawing.Size(75, 37)
        Me.ButtonViewsCheckAll.TabIndex = 16
        Me.ButtonViewsCheckAll.Text = "Check All"
        Me.ButtonViewsCheckAll.UseVisualStyleBackColor = True
        '
        'DataGridViews
        '
        Me.DataGridViews.AllowUserToAddRows = False
        Me.DataGridViews.AllowUserToDeleteRows = False
        Me.DataGridViews.AllowUserToResizeRows = False
        Me.DataGridViews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.Column3, Me.Column4})
        Me.DataGridViews.Location = New System.Drawing.Point(109, 53)
        Me.DataGridViews.Name = "DataGridViews"
        Me.DataGridViews.RowHeadersVisible = False
        Me.DataGridViews.Size = New System.Drawing.Size(495, 207)
        Me.DataGridViews.TabIndex = 15
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "isChecked"
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 30
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "ViewName"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Name"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 250
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewCheckBoxColumn2.Width = 250
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ViewLevel"
        Me.Column3.HeaderText = "Level"
        Me.Column3.MinimumWidth = 100
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ViewType"
        Me.Column4.HeaderText = "Type"
        Me.Column4.MinimumWidth = 100
        Me.Column4.Name = "Column4"
        '
        'RadioButtonViewContains
        '
        Me.RadioButtonViewContains.AutoSize = True
        Me.RadioButtonViewContains.Checked = True
        Me.RadioButtonViewContains.Location = New System.Drawing.Point(29, 30)
        Me.RadioButtonViewContains.Name = "RadioButtonViewContains"
        Me.RadioButtonViewContains.Size = New System.Drawing.Size(101, 16)
        Me.RadioButtonViewContains.TabIndex = 11
        Me.RadioButtonViewContains.TabStop = True
        Me.RadioButtonViewContains.Text = "Name Contains"
        Me.RadioButtonViewContains.UseVisualStyleBackColor = True
        '
        'TextBoxViewName
        '
        Me.TextBoxViewName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxViewName.Location = New System.Drawing.Point(365, 29)
        Me.TextBoxViewName.Name = "TextBoxViewName"
        Me.TextBoxViewName.Size = New System.Drawing.Size(239, 21)
        Me.TextBoxViewName.TabIndex = 14
        '
        'RadioButtonViewNotContains
        '
        Me.RadioButtonViewNotContains.AutoSize = True
        Me.RadioButtonViewNotContains.Location = New System.Drawing.Point(166, 30)
        Me.RadioButtonViewNotContains.Name = "RadioButtonViewNotContains"
        Me.RadioButtonViewNotContains.Size = New System.Drawing.Size(149, 16)
        Me.RadioButtonViewNotContains.TabIndex = 12
        Me.RadioButtonViewNotContains.Text = "Name Does Not Contain"
        Me.RadioButtonViewNotContains.UseVisualStyleBackColor = True
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHelp.Location = New System.Drawing.Point(385, 632)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(75, 37)
        Me.ButtonHelp.TabIndex = 9
        Me.ButtonHelp.Text = "?"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOk.Location = New System.Drawing.Point(466, 632)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 37)
        Me.ButtonOk.TabIndex = 7
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(547, 632)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 37)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 632)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(610, 37)
        Me.ProgressBar1.TabIndex = 8
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 680)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBoxViews)
        Me.Controls.Add(Me.GroupBoxCategory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 718)
        Me.Name = "Form_Main"
        Me.Text = "Form_Fix"
        Me.GroupBoxCategory.ResumeLayout(False)
        Me.GroupBoxCategory.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFamilies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxViews.ResumeLayout(False)
        Me.GroupBoxViews.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxCategory As System.Windows.Forms.GroupBox
  Friend WithEvents TextBoxTypeName As System.Windows.Forms.TextBox
  Friend WithEvents RadioButtonTypeNotContains As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButtonTypeContains As System.Windows.Forms.RadioButton
  Friend WithEvents DataGridViewFamilies As System.Windows.Forms.DataGridView
  Friend WithEvents ButtonSymbolsCheckNone As System.Windows.Forms.Button
  Friend WithEvents ButtonSymbolsCheckAll As System.Windows.Forms.Button
  Friend WithEvents ComboBoxTags As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxCategory As System.Windows.Forms.ComboBox
  Friend WithEvents LabelCategoryName As System.Windows.Forms.Label
  Friend WithEvents GroupBoxViews As System.Windows.Forms.GroupBox
  Friend WithEvents ButtonViewsCheckNone As System.Windows.Forms.Button
  Friend WithEvents ButtonViewsCheckAll As System.Windows.Forms.Button
  Friend WithEvents DataGridViews As System.Windows.Forms.DataGridView
  Friend WithEvents RadioButtonViewContains As System.Windows.Forms.RadioButton
  Friend WithEvents TextBoxViewName As System.Windows.Forms.TextBox
  Friend WithEvents RadioButtonViewNotContains As System.Windows.Forms.RadioButton
  Friend WithEvents ButtonHelp As System.Windows.Forms.Button
  Friend WithEvents ButtonOk As System.Windows.Forms.Button
  Friend WithEvents ButtonCancel As System.Windows.Forms.Button
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
  Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
  Friend WithEvents CheckBoxLeaders As System.Windows.Forms.CheckBox
  Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
