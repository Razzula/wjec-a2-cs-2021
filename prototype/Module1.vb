Module Module1

    Public mainArray = New String(8, 2) {{"0", "Brymbo", "LL115FD"}, {"1", "Marford", "LL128TX"}, {"2", "Borras", "LL139QW"}, {"3", "Brymbo", "LL116AB"}, {"4", "Borras", "LL139QW"}, {"5", "Wrexham", "LL112BG"}, {"6", "Marford", "LL128SZ"}, {"7", "Brymbo", "LL115FD"}, {"8", "Borras", "LL112AB"}}
    Public Borras(2, 2), Brymbo(2, 2), Marford(1, 2), Wrexham(0, 2) As String

    Public areas = New Array() {Borras, Brymbo, Marford, Wrexham}
    Public distances = New String(4, 3) {{"Borras", "Brymbo", "Marford", "Wrexham"}, {vbNull, 13, 10, 7}, {13, vbNull, 15, 9}, {10, 15, vbNull, 12}, {7, 9, 12, vbNull}}

    Public newArray(8, 2) As String

    Public random = New Integer(3) {6, 32, 5, 8}

    Sub Main()

        Console.WriteLine("INITIAL:")
        PrintArray(mainArray)
        Console.WriteLine()

        Console.WriteLine("GROUPED:")
        For x = 0 To areas.Length - 1
            Split(mainArray, areas(x), distances(0, x))
        Next

        Console.WriteLine("SORTED GROUPED:")
        For x = 0 To areas.Length - 1
            SortArray(areas(x))
        Next

        Console.ReadLine()

    End Sub

    Sub PrintArray(array)

        Dim x = 0, y = 0

        For y = 0 To (array.Length / 3) - 1

            Console.Write("{ ")
            For x = 0 To 2
                Console.Write(array(y, x) + " ")
            Next
            Console.Write("}")

            Console.WriteLine()

        Next
    End Sub

    Sub Split(inputArray, outputArray, outputArrayName)

        Dim y = 0, n = 0

        For y = 0 To (inputArray.Length / 3) - 1

            If inputArray(y, 1) = outputArrayName Then
                outputArray(n, 0) = inputArray(y, 0)
                outputArray(n, 1) = inputArray(y, 1)
                outputArray(n, 2) = inputArray(y, 2)

                n = n + 1
            End If

        Next

        PrintArray(outputArray)
        Console.WriteLine()

    End Sub

    Sub SortArray(array)

        Dim x As Integer, length = array.Length
        Dim temp As String, flag As Boolean = True
        While flag = True

            x = 0
            flag = False

            While x < (length / 3) - 1

                If array(x, 2) > array(x + 1, 2) Then

                    For y = 0 To 2

                        temp = array(x, y)
                        array(x, y) = array(x + 1, y)
                        array(x + 1, y) = temp

                    Next

                    flag = True
                End If

                x += 1
            End While

        End While

        PrintArray(array)
        Console.WriteLine()

    End Sub

    Sub MergeArray()

        For x = 0 To (mainArray.Length / 3) - 1



        Next


    End Sub

End Module
