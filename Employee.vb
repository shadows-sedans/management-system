Public Class Employee
    Public Property Name As String
    Public Property Department As Department
    Public Property Salary As Decimal

    Public Sub New(name As String, department As Department, salary As Decimal)
        Me.Name = name
        Me.Department = department
        Me.Salary = salary
    End Sub

    Public Sub DisplayDetails()
        Console.WriteLine($"Employee: {Name}")
        Console.WriteLine($"Department: {Department.Name}")
        Console.WriteLine($"Salary: ${Salary}")
        Console.WriteLine()
    End Sub
End Class
