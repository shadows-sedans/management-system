Module MainModule
    Sub Main()
        ' Create departments
        Dim department1 As New Department("Engineering")
        Dim department2 As New Department("Sales")

        ' Create employees
        Dim employee1 As New Employee("John Doe", department1, 5000)
        Dim employee2 As New Employee("Jane Smith", department2, 4500)

        ' Display employee details
        employee1.DisplayDetails()
        employee2.DisplayDetails()
    End Sub
End Module
