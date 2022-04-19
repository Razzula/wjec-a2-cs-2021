Imports System.IO

Public Class FileHandling

    Dim fileName As String, fileHeader As String, fileContents() As String, ID As Integer

    Sub New(fileName, fileHeader)

        Me.fileName = fileName
        Me.fileHeader = fileHeader

        'create file if nonexistent
        If Dir$(fileName) = "" Then 'check
            Dim sw As New StreamWriter(Application.StartupPath & "\" & fileName, True)
            sw.WriteLine(fileHeader)
            sw.Close()

            MsgBox("A new file (" & fileName & ") has been created.", vbExclamation, "Warning!") 'feedback
        End If

        fileContents = File.ReadAllLines(Dir$(fileName))

    End Sub

    Function GetFileContents()

        Return fileContents

    End Function

    Sub WriteLineToFile(dataToWrite)

        Dim sw As New StreamWriter(Application.StartupPath & "\" & fileName, True)
        sw.WriteLine(dataToWrite)
        sw.Close()

    End Sub

    Function GenerateID()

        fileContents = File.ReadAllLines(Dir$(fileName))

        'GENERATE ID
        Dim highestValue As Integer, currentValue As Integer

        For x = 1 To fileContents.Count - 1

            currentValue = Trim(Mid(fileContents(x), 1, 3))

            If currentValue > highestValue Then
                highestValue = currentValue
            End If

        Next

        ID = highestValue + 1

        Return ID

    End Function

    Function GetID()

        Return ID

    End Function

    Sub IncrementID()

        ID += 1

    End Sub

    Sub ClearFile()

        System.IO.File.WriteAllText(Application.StartupPath & "\" & fileName, fileHeader)
        WriteLineToFile("")

    End Sub

End Class