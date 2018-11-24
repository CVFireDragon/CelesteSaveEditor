Imports System.Drawing.Text

Public Class TextEditor

#Region "Editor and Timer"

    Private Sub TextEditor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        For fntSize = 10 To 75

        Next


        Dim fonts As New InstalledFontCollection()

        '-----------------------------

    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        lblCharCount.Text = "Characters in the current document: " & Document.TextLength.ToString()


        lblZoom.Text = Document.ZoomFactor.ToString()



    End Sub


    Private Sub Document_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles Document.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub


#End Region


#Region "Main Menu Bar"
    Private Sub mMNew_Click(sender As System.Object, e As System.EventArgs) Handles mMNew.Click
        NewDocument()
    End Sub

    Private Sub mMOpen_Click(sender As System.Object, e As System.EventArgs) Handles mMOpen.Click
        Open()
    End Sub

    Private Sub mMSave_Click(sender As System.Object, e As System.EventArgs) Handles mMSave.Click
        Save()
    End Sub

    Private Sub mMExit_Click(sender As System.Object, e As System.EventArgs) Handles mMExit.Click
        ExitApplication()
    End Sub



    '----------------------------

    Private Sub mMUndo_Click(sender As System.Object, e As System.EventArgs) Handles mMUndo.Click
        Undo()
    End Sub

    Private Sub mMRedo_Click(sender As System.Object, e As System.EventArgs) Handles mMRedo.Click
        Redo()
    End Sub

    Private Sub mMCut_Click(sender As System.Object, e As System.EventArgs) Handles mMCut.Click
        Cut()
    End Sub

    Private Sub mMCopy_Click(sender As System.Object, e As System.EventArgs) Handles mMCopy.Click
        Copy()
    End Sub

    Private Sub mMPaste_Click(sender As System.Object, e As System.EventArgs) Handles mMPaste.Click
        Paste()
    End Sub

    Private Sub mMSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles mMSelectAll.Click
        SelectAll()
    End Sub

    '-----------------------

#End Region


#Region "Toolbar"


    Private Sub tbNew_Click(sender As System.Object, e As System.EventArgs)
        NewDocument()
    End Sub

    Private Sub tbOpen_Click(sender As System.Object, e As System.EventArgs) Handles tbOpen.Click
        Open()
    End Sub

    Private Sub tbSave_Click(sender As System.Object, e As System.EventArgs) Handles tbSave.Click
        Save()
    End Sub

    Private Sub tbCut_Click(sender As System.Object, e As System.EventArgs) Handles tbCut.Click
        Cut()
    End Sub

    Private Sub tbCopy_Click(sender As System.Object, e As System.EventArgs) Handles tbCopy.Click
        Copy()
    End Sub

    Private Sub tbPaste_Click(sender As System.Object, e As System.EventArgs) Handles tbPaste.Click
        Paste()
    End Sub


    '---------------------------------

    Private Sub tbBold_Click(sender As System.Object, e As System.EventArgs)
        Dim bfont As New Font(Document.Font, FontStyle.Bold)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)

        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Bold Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = bfont
        End If

    End Sub

    Private Sub tbItalic_Click(sender As System.Object, e As System.EventArgs)

        Dim Ifont As New Font(Document.Font, FontStyle.Italic)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)

        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Italic Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Ifont
        End If
    End Sub

    Private Sub tbUnderline_Click(sender As System.Object, e As System.EventArgs)

        Dim Ufont As New Font(Document.Font, FontStyle.Underline)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)

        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Underline Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Ufont
        End If
    End Sub

    Private Sub tbStrike_Click(sender As System.Object, e As System.EventArgs)
        Dim Sfont As New Font(Document.Font, FontStyle.Strikeout)
        Dim rfont As New Font(Document.Font, FontStyle.Regular)


        If Document.SelectedText.Length = 0 Then Exit Sub
        If Document.SelectionFont.Strikeout Then
            Document.SelectionFont = rfont
        Else
            Document.SelectionFont = Sfont
        End If
    End Sub

    ' -------------------------------


    Private Sub tbAlignLeft_Click(sender As System.Object, e As System.EventArgs)
        Document.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub tbAlignCentre_Click(sender As System.Object, e As System.EventArgs)
        Document.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub tbAlignRight_Click(sender As System.Object, e As System.EventArgs)
        Document.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    '----------------------------------------------

    Private Sub tbUpper_Click(sender As System.Object, e As System.EventArgs)
        Document.SelectedText = Document.SelectedText.ToUpper()
    End Sub

    Private Sub tbLower_Click(sender As System.Object, e As System.EventArgs)
        Document.SelectedText = Document.SelectedText.ToLower()
    End Sub

    '---------------------------------------


    Private Sub tbZoom_Click(sender As System.Object, e As System.EventArgs)
        If Document.ZoomFactor = 63 Then

            Exit Sub
        Else

            Document.ZoomFactor = Document.ZoomFactor + 1
        End If


    End Sub

    Private Sub tbZoomOut_Click(sender As System.Object, e As System.EventArgs)
        If Document.ZoomFactor = 1 Then
            Exit Sub

        Else

            Document.ZoomFactor = Document.ZoomFactor - 1
        End If



    End Sub




#End Region


#Region "Methods"

#Region "File"

    'CLEAR THE RICHTEXTBOX - MAKES NEW DOCUMENT
    Private Sub NewDocument()
        Document.Clear()
    End Sub

    'OPEN WORK AS PLAIN TEXT FILE
    Private Sub Open()
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then

            Document.LoadFile(openWork.FileName,
                              RichTextBoxStreamType.PlainText)

        End If
    End Sub

    'SAVE WORK AS PLAIN TEXT FILE
    Private Sub Save()
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Document.SaveFile(saveWork.FileName,
                                  RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'EXIT THE PROGRAM
    Private Sub ExitApplication()
        Me.Close()
    End Sub



#End Region

#Region "Edit"

    Private Sub Undo()
        Document.Undo()
    End Sub

    Private Sub Redo()
        Document.Redo()
    End Sub

    Private Sub Cut()
        Document.Cut()
    End Sub

    Private Sub Copy()
        Document.Copy()
    End Sub

    Private Sub Paste()
        Document.Paste()
    End Sub

    Private Sub SelectAll()
        Document.SelectAll()
    End Sub


#End Region


#End Region


#Region "RightClickMenu"

    Private Sub UndoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub
#End Region









End Class
