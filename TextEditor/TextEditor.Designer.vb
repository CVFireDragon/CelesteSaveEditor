<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.tbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbCut = New System.Windows.Forms.ToolStripButton()
        Me.tbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.lblCharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.rcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveWork = New System.Windows.Forms.SaveFileDialog()
        Me.openWork = New System.Windows.Forms.OpenFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.mainMenu.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.rcMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(779, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMNew, Me.mMOpen, Me.toolStripSeparator, Me.mMSave, Me.toolStripSeparator2, Me.mMExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mMNew
        '
        Me.mMNew.Image = CType(resources.GetObject("mMNew.Image"), System.Drawing.Image)
        Me.mMNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMNew.Name = "mMNew"
        Me.mMNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMNew.Size = New System.Drawing.Size(180, 22)
        Me.mMNew.Text = "&New"
        '
        'mMOpen
        '
        Me.mMOpen.Image = CType(resources.GetObject("mMOpen.Image"), System.Drawing.Image)
        Me.mMOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMOpen.Name = "mMOpen"
        Me.mMOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mMOpen.Size = New System.Drawing.Size(180, 22)
        Me.mMOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'mMSave
        '
        Me.mMSave.Image = CType(resources.GetObject("mMSave.Image"), System.Drawing.Image)
        Me.mMSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMSave.Name = "mMSave"
        Me.mMSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMSave.Size = New System.Drawing.Size(180, 22)
        Me.mMSave.Text = "&Save"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'mMExit
        '
        Me.mMExit.Name = "mMExit"
        Me.mMExit.Size = New System.Drawing.Size(180, 22)
        Me.mMExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMUndo, Me.mMRedo, Me.toolStripSeparator3, Me.mMCut, Me.mMCopy, Me.mMPaste, Me.toolStripSeparator4, Me.mMSelectAll})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mMUndo
        '
        Me.mMUndo.Name = "mMUndo"
        Me.mMUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mMUndo.Size = New System.Drawing.Size(180, 22)
        Me.mMUndo.Text = "&Undo"
        '
        'mMRedo
        '
        Me.mMRedo.Name = "mMRedo"
        Me.mMRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mMRedo.Size = New System.Drawing.Size(180, 22)
        Me.mMRedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'mMCut
        '
        Me.mMCut.Image = CType(resources.GetObject("mMCut.Image"), System.Drawing.Image)
        Me.mMCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCut.Name = "mMCut"
        Me.mMCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mMCut.Size = New System.Drawing.Size(180, 22)
        Me.mMCut.Text = "Cu&t"
        '
        'mMCopy
        '
        Me.mMCopy.Image = CType(resources.GetObject("mMCopy.Image"), System.Drawing.Image)
        Me.mMCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCopy.Name = "mMCopy"
        Me.mMCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mMCopy.Size = New System.Drawing.Size(180, 22)
        Me.mMCopy.Text = "&Copy"
        '
        'mMPaste
        '
        Me.mMPaste.Image = CType(resources.GetObject("mMPaste.Image"), System.Drawing.Image)
        Me.mMPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMPaste.Name = "mMPaste"
        Me.mMPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mMPaste.Size = New System.Drawing.Size(180, 22)
        Me.mMPaste.Text = "Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'mMSelectAll
        '
        Me.mMSelectAll.Name = "mMSelectAll"
        Me.mMSelectAll.Size = New System.Drawing.Size(180, 22)
        Me.mMSelectAll.Text = "Select &All"
        '
        'Tools
        '
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbOpen, Me.tbSave, Me.toolStripSeparator1, Me.tbCut, Me.tbCopy, Me.tbPaste, Me.toolStripSeparator5})
        Me.Tools.Location = New System.Drawing.Point(0, 24)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(779, 25)
        Me.Tools.TabIndex = 1
        Me.Tools.Text = "ToolStrip1"
        '
        'tbOpen
        '
        Me.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbOpen.Image = CType(resources.GetObject("tbOpen.Image"), System.Drawing.Image)
        Me.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbOpen.Name = "tbOpen"
        Me.tbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tbOpen.Text = "&Open"
        '
        'tbSave
        '
        Me.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbSave.Image = CType(resources.GetObject("tbSave.Image"), System.Drawing.Image)
        Me.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(23, 22)
        Me.tbSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbCut
        '
        Me.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCut.Image = CType(resources.GetObject("tbCut.Image"), System.Drawing.Image)
        Me.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCut.Name = "tbCut"
        Me.tbCut.Size = New System.Drawing.Size(23, 22)
        Me.tbCut.Text = "C&ut"
        '
        'tbCopy
        '
        Me.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCopy.Image = CType(resources.GetObject("tbCopy.Image"), System.Drawing.Image)
        Me.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCopy.Name = "tbCopy"
        Me.tbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tbCopy.Text = "&Copy"
        '
        'tbPaste
        '
        Me.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPaste.Image = CType(resources.GetObject("tbPaste.Image"), System.Drawing.Image)
        Me.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPaste.Name = "tbPaste"
        Me.tbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tbPaste.Text = "&Paste"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharCount, Me.ToolStripStatusLabel2, Me.lblZoom})
        Me.Status.Location = New System.Drawing.Point(0, 429)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(779, 22)
        Me.Status.TabIndex = 2
        Me.Status.Text = "StatusStrip1"
        '
        'lblCharCount
        '
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(13, 17)
        Me.lblCharCount.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(712, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'lblZoom
        '
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(39, 17)
        Me.lblZoom.Text = "Zoom"
        '
        'Document
        '
        Me.Document.ContextMenuStrip = Me.rcMenu
        Me.Document.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Document.Location = New System.Drawing.Point(0, 49)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(779, 380)
        Me.Document.TabIndex = 3
        Me.Document.Text = ""
        '
        'rcMenu
        '
        Me.rcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.rcMenu.Name = "rcMenu"
        Me.rcMenu.Size = New System.Drawing.Size(104, 114)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'saveWork
        '
        Me.saveWork.Filter = "Celeste Files |*.celeste"
        Me.saveWork.Title = "Save"
        '
        'openWork
        '
        Me.openWork.Filter = "Celeste Files |*.celeste"
        Me.openWork.Title = "Open"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 451)
        Me.Controls.Add(Me.Document)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.MinimumSize = New System.Drawing.Size(795, 489)
        Me.Name = "TextEditor"
        Me.ShowIcon = False
        Me.Text = "CelesteSaveEditor"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.rcMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents Tools As System.Windows.Forms.ToolStrip
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents Document As System.Windows.Forms.RichTextBox
    Friend WithEvents rcMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents saveWork As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openWork As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblCharCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
