Public Class GlobalVariables

    Public Structure user
        Public Username As String    'length 12; start 1 ; end 12
        Public Password As String    'length 12; start 13; end 24
        Public AccessLevel As String 'length 1; start 25; end 25;
    End Structure

    Public Structure customer
        Public ID As String       'length 3 ; start 1 ; end 3
        Public Name As String     'length 25; start 4 ; end 28
        Public Number As String   'length 11; start 29; end 39
        Public Address As String  'length 25; start 40; end 64
        Public Area As String     'length 12; start 65; end 76
        Public Postcode As String 'length 7 ; start 77; end 83
    End Structure

    Public Structure booking
        Public ID As String         'length 3 ; start 1 ; end 3
        Public customerID As String 'length 3 ; start 4 ; end 6
        Public jobID As String      'length 3 ; start 7 ; end 9
        Public jobLength As String  'length 3 ; start 10; end 12

        Public area As String           'length 12; start 65; end 76   (FROM CUSTOMER FILE)
        Public postcode As String       'length 7 ; start 77; end 83   (FROM CUSTOMER FILE)
    End Structure

    Public Structure timetableItem
        Public ID As String         'length 3 ; start 1 ; end 3
        Public bookingID As String  'length 3 ; start 4 ; end 6
        Public day As String        'length 3 ; start 8 ; end 10
        Public startTime As String  'length 3 ; start 12; end 14
        Public jobLength As String  'length 3 ; start 16; end 18

        Public week As String       'length 10; start 19
    End Structure

    Public Structure material
        Public ID As String         'length 3 ; start 1 ; end 3
        Public name As String       'length 25; start 4 ; end 28
        Public type As String       'length 8 ; start 29; end 36
        Public pricePerUnit As String 'length 3;start 37
    End Structure

    Public Structure job
        Public ID As String         'length 3 ; start 1 ; end 3
        Public Name As String       'length 25; start 4 ; end 28
        Public RP As String         'length 3 ; start 29; end 31
        Public LP As String         'length 3 ; start 32;
    End Structure

End Class
