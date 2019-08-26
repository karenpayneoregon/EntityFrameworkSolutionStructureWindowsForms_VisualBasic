Imports North = NorthWind.Data.NorthWindOperations
Imports Human = NorthWind.Data.HumanResourcesOperations

<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub HumanResourcesTest()

        Dim operations As New Human.Operations
        Dim employeeItems = operations.EmployeeJoined()

        Assert.IsTrue(employeeItems.Count = 40,
                      "Expected 40 employees items")

    End Sub
    <TestMethod()> Public Sub NorthWindTest()

        Dim operations As New North.Operations
        Dim customerItems = operations.CustomerJoined()

        Assert.IsTrue(customerItems.Count = 98,
                      "Expected 98 customer items")

    End Sub
End Class