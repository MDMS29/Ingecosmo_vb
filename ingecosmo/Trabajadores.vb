Public Class Trabajadores
    Private Sub Trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.ColumnCount = 7

        DataGridView1.Columns(0).Name = "Nombres"
        DataGridView1.Columns(1).Name = "Apellidos"
        DataGridView1.Columns(2).Name = "Tipo Documento"
        DataGridView1.Columns(3).Name = "Idenificacion"
        DataGridView1.Columns(4).Name = "Cargo"
        DataGridView1.Columns(5).Name = "Direccion"
        DataGridView1.Columns(6).Name = "Acciones"

        Dim row1 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row1)
        Dim row2 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row2)
        Dim row3 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row3)
        Dim row4 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row4)
        Dim row5 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row5)
        Dim row6 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row6)
        Dim row7 As String() = New String() {"Isabella", "Collante", "CC", "14885236", "Torre de Control", "calle45", "apue"}
        DataGridView1.Rows.Add(row7)


    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        principal.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class