<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("clsBeispielbild", -1)
      Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Name")
      Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bild")
      Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Me.btnBeispielbilderLaden = New Infragistics.Win.Misc.UltraButton()
      Me.gridBeispielbilder = New Infragistics.Win.UltraWinGrid.UltraGrid()
      Me.DirectorySearcher = New System.DirectoryServices.DirectorySearcher()
      Me.bsBild = New System.Windows.Forms.BindingSource(Me.components)
      Me.btnNetzErstellen = New Infragistics.Win.Misc.UltraButton()
      CType(Me.gridBeispielbilder, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bsBild, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnBeispielbilderLaden
      '
      Me.btnBeispielbilderLaden.Location = New System.Drawing.Point(8, 7)
      Me.btnBeispielbilderLaden.Name = "btnBeispielbilderLaden"
      Me.btnBeispielbilderLaden.Size = New System.Drawing.Size(94, 45)
      Me.btnBeispielbilderLaden.TabIndex = 0
      Me.btnBeispielbilderLaden.Text = "Beispielbilder laden"
      '
      'gridBeispielbilder
      '
      Me.gridBeispielbilder.DataSource = Me.bsBild
      Appearance1.BackColor = System.Drawing.SystemColors.Window
      Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
      Me.gridBeispielbilder.DisplayLayout.Appearance = Appearance1
      Appearance2.FontData.SizeInPoints = 14.0!
      UltraGridColumn1.CellAppearance = Appearance2
      UltraGridColumn1.Header.VisiblePosition = 0
      UltraGridColumn2.Header.VisiblePosition = 1
      UltraGridColumn2.Width = 126
      UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
      UltraGridBand1.Expandable = False
      Me.gridBeispielbilder.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
      Me.gridBeispielbilder.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Me.gridBeispielbilder.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
      Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
      Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
      Appearance3.BorderColor = System.Drawing.SystemColors.Window
      Me.gridBeispielbilder.DisplayLayout.GroupByBox.Appearance = Appearance3
      Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridBeispielbilder.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
      Me.gridBeispielbilder.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Me.gridBeispielbilder.DisplayLayout.GroupByBox.Hidden = True
      Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
      Appearance5.BackColor2 = System.Drawing.SystemColors.Control
      Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridBeispielbilder.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
      Me.gridBeispielbilder.DisplayLayout.MaxColScrollRegions = 1
      Me.gridBeispielbilder.DisplayLayout.MaxRowScrollRegions = 1
      Appearance6.BackColor = System.Drawing.SystemColors.Window
      Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
      Me.gridBeispielbilder.DisplayLayout.Override.ActiveCellAppearance = Appearance6
      Appearance7.BackColor = System.Drawing.SystemColors.Highlight
      Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
      Me.gridBeispielbilder.DisplayLayout.Override.ActiveRowAppearance = Appearance7
      Me.gridBeispielbilder.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
      Me.gridBeispielbilder.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
      Appearance8.BackColor = System.Drawing.SystemColors.Window
      Me.gridBeispielbilder.DisplayLayout.Override.CardAreaAppearance = Appearance8
      Appearance9.BorderColor = System.Drawing.Color.Silver
      Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
      Me.gridBeispielbilder.DisplayLayout.Override.CellAppearance = Appearance9
      Me.gridBeispielbilder.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
      Me.gridBeispielbilder.DisplayLayout.Override.CellPadding = 0
      Appearance10.BackColor = System.Drawing.SystemColors.Control
      Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
      Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance10.BorderColor = System.Drawing.SystemColors.Window
      Me.gridBeispielbilder.DisplayLayout.Override.GroupByRowAppearance = Appearance10
      Appearance11.TextHAlignAsString = "Left"
      Me.gridBeispielbilder.DisplayLayout.Override.HeaderAppearance = Appearance11
      Me.gridBeispielbilder.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
      Me.gridBeispielbilder.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
      Appearance12.BackColor = System.Drawing.SystemColors.Window
      Appearance12.BorderColor = System.Drawing.Color.Silver
      Me.gridBeispielbilder.DisplayLayout.Override.RowAppearance = Appearance12
      Me.gridBeispielbilder.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
      Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
      Me.gridBeispielbilder.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
      Me.gridBeispielbilder.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
      Me.gridBeispielbilder.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
      Me.gridBeispielbilder.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
      Me.gridBeispielbilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gridBeispielbilder.Location = New System.Drawing.Point(8, 68)
      Me.gridBeispielbilder.Name = "gridBeispielbilder"
      Me.gridBeispielbilder.Size = New System.Drawing.Size(249, 653)
      Me.gridBeispielbilder.TabIndex = 1
      Me.gridBeispielbilder.Text = "UltraGrid1"
      '
      'DirectorySearcher
      '
      Me.DirectorySearcher.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
      Me.DirectorySearcher.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
      Me.DirectorySearcher.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
      '
      'bsBild
      '
      Me.bsBild.DataSource = GetType(NN02.clsBeispielbild)
      '
      'btnNetzErstellen
      '
      Me.btnNetzErstellen.Location = New System.Drawing.Point(108, 7)
      Me.btnNetzErstellen.Name = "btnNetzErstellen"
      Me.btnNetzErstellen.Size = New System.Drawing.Size(94, 45)
      Me.btnNetzErstellen.TabIndex = 2
      Me.btnNetzErstellen.Text = "Netz erstellen"
      '
      'frmStart
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 726)
      Me.Controls.Add(Me.btnNetzErstellen)
      Me.Controls.Add(Me.gridBeispielbilder)
      Me.Controls.Add(Me.btnBeispielbilderLaden)
      Me.Name = "frmStart"
      Me.Text = "frmStart"
      CType(Me.gridBeispielbilder, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bsBild, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents btnBeispielbilderLaden As Infragistics.Win.Misc.UltraButton
   Friend WithEvents gridBeispielbilder As Infragistics.Win.UltraWinGrid.UltraGrid
   Friend WithEvents bsBild As BindingSource
   Friend WithEvents DirectorySearcher As DirectoryServices.DirectorySearcher
   Friend WithEvents btnNetzErstellen As Infragistics.Win.Misc.UltraButton
End Class
