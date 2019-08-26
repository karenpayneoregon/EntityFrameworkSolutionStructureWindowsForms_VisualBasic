Imports NorthWind.Data.HumanResourcesModel

Namespace HumanResourcesOperations
    Public Class Operations
        Public Function EmployeeJoined() As List(Of EmployeeItem)

            Using context As New HumanResourcesContext
                Return (From employee In context.Employees
                        Join dept In context.Departments On employee.DepartmentId _
                            Equals dept.DepartmentId
                        Join job In context.Jobs On employee.JobId _
                            Equals job.JobId
                        Select New EmployeeItem With
                            {
                                .Id = employee.EmployeeId,
                                .Title = job.JobTitle,
                                .FirstName = employee.FirstName,
                                .LastName = employee.LastName,
                                .Department = dept.DepartmentName,
                                .Location = dept.Location
                            }
                        ).ToList()
            End Using
        End Function
    End Class
End Namespace