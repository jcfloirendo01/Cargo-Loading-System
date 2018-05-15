Public Class UserData
    Public Structure Person
        Public id As Integer
        Public name As String
        Public username As String
    End Structure

    Public Structure Cargo
        Public id As Integer
        Public name As String
        Public weight As Double
        Public volume As Double
        Public created_by As Integer
    End Structure

    Public Structure Item
        Public id As Integer
        Public name As String
        Public weight As Double
        Public volume As Double
        Public value As Double
        Public created_by As Double
    End Structure

    Public Structure Knapsack
        Public value As Double
        Public weight As Double
        Public volume As Double
        Public item_index As Integer
        Public k_x As Integer
        Public k_y As Integer
    End Structure
End Class
