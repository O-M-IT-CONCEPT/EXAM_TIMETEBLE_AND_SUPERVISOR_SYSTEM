Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Module Exportingtypes
    Public Sub ExportToPDF(ByVal dataGridView As DataGridView, ByVal saveFileDialog As SaveFileDialog)
        ' Create a Document object
        Dim document As New Document()

        Try
            ' Show the SaveFileDialog to get the file path
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Create a PdfWriter object to write to the specified file path
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(saveFileDialog.FileName, FileMode.Create))

                ' Open the document
                document.Open()

                ' Create a PdfPTable with the same number of columns as the DataGridView
                Dim pdfTable As New PdfPTable(dataGridView.ColumnCount)

                ' Add column headers from the DataGridView to the PdfPTable
                For j As Integer = 0 To dataGridView.Columns.Count - 1
                    pdfTable.AddCell(dataGridView.Columns(j).HeaderText)
                Next

                ' Add row data from the DataGridView to the PdfPTable
                For i As Integer = 0 To dataGridView.Rows.Count - 1
                    For j As Integer = 0 To dataGridView.Columns.Count - 1
                        If dataGridView.Rows(i).Cells(j).Value IsNot Nothing Then
                            pdfTable.AddCell(dataGridView.Rows(i).Cells(j).Value.ToString())
                        Else
                            pdfTable.AddCell("")
                        End If
                    Next
                Next

                ' Add the PdfPTable to the document
                document.Add(pdfTable)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error exporting to PDF: " & ex.Message)
        Finally
            ' Close the document
            document.Close()
        End Try
    End Sub
End Module
