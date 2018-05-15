Imports System.Data.OleDb
Public Class SendCargo
    Dim con As OleDbConnection
    Dim cb As OleDbCommand
    Dim dr As OleDbDataReader
    Dim success As Boolean
    Dim cargo_selected As Integer
    Dim created_by As Integer = 1
    Dim cargo As New UserData.Cargo
    Dim optimizedItem As New List(Of UserData.Item)
    Dim batchList As New List(Of List(Of UserData.Item))
    Dim worldItem() As UserData.Item
    Dim tx As New DataTable
    Dim batches As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\cargo.mdb")
        getAllCargoes()
        getAllItems()
        itemDoneButton.Enabled = False
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dashboard.Show()
        Me.Close()
    End Sub
    Private Sub getAllCargoes()
        'Gets all cargoes
        cb = New OleDbCommand("SELECT * FROM Cargoes;", con)
        Try
            con.Open()
            dr = cb.ExecuteReader()
            Dim tb As New DataTable
            tb.Columns.Add("text", GetType(String))
            tb.Columns.Add("id", GetType(Integer))
            dr.Read()
            tb.Rows.Add(dr("cargo_name"), dr("cargo_id"))
            cargoNameSelect.Text = dr("cargo_name")
            cargoWeightSelect.Text = dr("cargo_weight")
            cargoVolumeSelect.Text = dr("cargo_volume")
            While dr.Read()
                tb.Rows.Add(dr("cargo_name"), dr("cargo_id"))
            End While
            cargoComboBox.DataSource = tb
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            selectCargoButton.Enabled = False
        End Try
    End Sub
    Private Sub getAllItems()
        'Gets all items
        cb = New OleDbCommand("SELECT * FROM Items;", con)
        Try
            con.Open()
            dr = cb.ExecuteReader()
            'Dim tx As New DataTable
            tx.Columns.Add("text", GetType(String))
            tx.Columns.Add("id", GetType(Integer))
            dr.Read()
            tx.Rows.Add(dr("item_name"), dr("item_id"))
            quantitySelect.Value = 1.0
            itemNameSelect.Text = dr("item_name")
            itemWeightSelect.Value = dr("item_weight")
            itemVolumeSelect.Value = dr("item_volume")
            itemValueSelect.Value = dr("item_value")
            While dr.Read()
                tx.Rows.Add(dr("item_name"), dr("item_id"))
            End While
            itemNameSelect.DataSource = tx
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            selectItemButton.Enabled = False
        End Try
    End Sub
    Private Sub cargoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cargoComboBox.SelectedIndexChanged
        cb = New OleDbCommand("SELECT * FROM Cargoes WHERE cargo_id = " + cargoComboBox.SelectedValue.ToString + ";", con)
        'cargo_selected = cargoComboBox.SelectedValue
        Try
            Try
                con.Open()
            Catch ex As Exception
                con.Close()
                con.Open()
            End Try
            dr = cb.ExecuteReader()
            dr.Read()
            cargoNameSelect.Text = dr("cargo_name")
            cargoWeightSelect.Value = dr("cargo_weight")
            cargoVolumeSelect.Value = dr("cargo_volume")
            cargo.id = dr("cargo_id")
            cargo.name = dr("cargo_name")
            cargo.volume = dr("cargo_volume")
            cargo.weight = dr("cargo_weight")
            cargo.created_by = dr("created_by")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        If itemNameBox.Text.Length > 0 And itemVolumeBox.Value > 0 And itemWeightBox.Value > 0 And itemValueBox.Value > 0 And quantityBox.Value Then
            Dim item_name As String = itemNameBox.Text
            Dim item_weight As Double = itemWeightBox.Value
            Dim item_volume As Double = itemVolumeBox.Value
            Dim item_value As Double = itemValueBox.Value
            Dim quantity As Integer = quantityBox.Value
            cb = New OleDbCommand("SELECT * FROM Items WHERE item_name = '" + item_name + "';", con)

            Try
                'Read if Item Exists
                con.Open()
                dr = cb.ExecuteReader()
                success = dr.Read()
                con.Close()
                If success Then
                    MessageBox.Show("An item with the same name already exists!")
                Else
                    'Write to Items Table
                    cb = New OleDbCommand("INSERT INTO Items (item_name, item_weight, item_volume, item_value, created_by) VALUES('" + item_name + "', '" + item_weight.ToString + "', '" + item_volume.ToString + "', '" + item_value.ToString + "', '" + created_by.ToString + "');", con)
                    con.Open()
                    cb.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show(item_name + "( W = " + item_weight.ToString + "kg ; Vol = " + item_volume.ToString + "cu. units; Value = " + item_volume.ToString + " PHP ) successfully added! Continuing.....")

                    'Read the Id of the new Item
                    cb = New OleDbCommand("SELECT * FROM Items WHERE item_name = '" + item_name + "';", con)
                    con.Open()
                    dr = cb.ExecuteReader()
                    success = dr.Read()
                    If success Then
                        'Set the data of item into the table
                        MessageBox.Show("ITEM ID = " + dr("item_id").ToString)
                        itemList.Rows.Add(dr("item_id"), dr("item_name"), dr("item_weight").ToString, dr("item_volume").ToString, dr("item_value").ToString, quantity.ToString)
                        'getAllItems()
                        clearForm()
                    Else
                        MessageBox.Show("Somehow something went wrong")
                    End If
                    con.Close()
                    itemDoneButton.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("Please fill all fields accordingly!")
        End If
    End Sub
    Private Sub selectItemButton_Click(sender As Object, e As EventArgs) Handles selectItemButton.Click
        If quantitySelect.Value > 0 Then
            itemList.Rows.Add(itemNameSelect.SelectedValue.ToString, itemNameSelect.Text, itemWeightSelect.Value.ToString, itemVolumeSelect.Value.ToString, itemValueSelect.Value.ToString, quantitySelect.Value.ToString)
            Dim dr As DataRow
            For i As Integer = 0 To tx.Rows.Count - 1
                dr = tx.Rows(i)
                If dr("id") = itemNameSelect.SelectedValue Then
                    dr.Delete()
                    Exit For
                End If
            Next
            clearForm()
            itemDoneButton.Enabled = True
        Else
            MessageBox.Show("Please complete all fields necessary!")
        End If
    End Sub
    Private Sub clearForm()
        cargoNameBox.Text = ""
        cargoVolumeBox.Value = 0.00
        cargoWeightBox.Value = 0.00
        itemNameBox.Text = ""
        itemVolumeBox.Value = 0.00
        itemWeightBox.Value = 0.00
        itemValueBox.Value = 0.00
        quantityBox.Value = 0
        quantitySelect.Value = 0
        'cargoComboBox.SelectedIndex = 0
        If itemNameSelect.Items.Count >= 1 Then
            itemNameSelect.SelectedIndex = 0
            updateItems()
        Else
            itemNameSelect.Enabled = False
            selectItemButton.Enabled = False
        End If
    End Sub
    Private Sub updateItems()
        Try
            cb = New OleDbCommand("SELECT * FROM Items WHERE item_id = " + itemNameSelect.SelectedValue.ToString + ";", con)
            Try
                Try
                    con.Open()
                Catch ex As Exception
                    con.Close()
                    con.Open()
                End Try
                dr = cb.ExecuteReader()
                dr.Read()
                quantitySelect.Value = 1.0
                itemNameSelect.Text = dr("item_name")
                itemWeightSelect.Value = dr("item_weight")
                itemVolumeSelect.Value = dr("item_volume")
                itemValueSelect.Value = dr("item_value")
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub itemNameSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemNameSelect.SelectedIndexChanged
        updateItems()
    End Sub
    Private Sub selectCargoButton_Click(sender As Object, e As EventArgs) Handles selectCargoButton.Click
        sendCargoWizard.SelectedTab = itemPage
    End Sub
    Private Sub addCargoButton_Click(sender As Object, e As EventArgs) Handles addCargoButton.Click
        If cargoNameBox.Text.Length > 0 And cargoVolumeBox.Value > 0 And cargoWeightBox.Value > 0 Then
            Dim cargo_name As String = cargoNameBox.Text
            Dim cargo_weight As Double = cargoWeightBox.Value
            Dim cargo_volume As Double = cargoVolumeBox.Value

            cb = New OleDbCommand("SELECT * FROM Cargoes WHERE cargo_name = '" + cargo_name + "';", con)

            Try
                'Read if Cargo Exists
                con.Open()
                dr = cb.ExecuteReader()
                success = dr.Read()
                con.Close()
                If success Then
                    MessageBox.Show("A cargo with the same name already exists!")
                Else
                    'Write to Cargoes Table
                    cb = New OleDbCommand("INSERT INTO Cargoes (cargo_name, cargo_weight, cargo_volume, created_by) VALUES('" + cargo_name + "', '" + cargo_weight.ToString + "', '" + cargo_volume.ToString + "', '" + created_by.ToString + "');", con)
                    con.Open()
                    cb.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show(cargo_name + "( W = " + cargo_weight.ToString + "kg ; H = " + cargo_volume.ToString + "cu. units ) successfully added! Continuing.....")

                    'Read the Id of the new Cargo
                    cb = New OleDbCommand("SELECT * FROM Cargoes WHERE cargo_name = '" + cargo_name + "';", con)
                    con.Open()
                    dr = cb.ExecuteReader()
                    success = dr.Read()
                    If success Then
                        'Set the data of cargo into the limits then proceed to next page
                        'MessageBox.Show("CARGO ID = " + dr("cargo_id").ToString)
                        cargo.id = dr("cargo_id")
                        cargo.name = dr("cargo_name")
                        cargo.volume = dr("cargo_volume")
                        cargo.weight = dr("cargo_weight")
                        cargo.created_by = dr("created_by")
                        sendCargoWizard.SelectedTab = itemPage
                    Else
                        MessageBox.Show("Somehow something went wrong")
                    End If
                    con.Close()
                    getAllCargoes()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("Please fill all fields accordingly!")
        End If
    End Sub

    Private Sub itemDoneButton_Click(sender As Object, e As EventArgs) Handles itemDoneButton.Click
        If itemList.RowCount > 0 Then
            Dim rowCount As Integer = itemList.RowCount - 1

            'Count the rows plus yung quantity
            Dim quantityCtr As Integer = 0
            For row As Integer = 0 To rowCount
                quantityCtr += itemList.Rows(row).Cells(5).Value
            Next
            'MessageBox.Show(quantityCtr.ToString)

            'Ilagay yung data sa Structure tapos icalculate yung density nung weight and volume
            Dim items(quantityCtr) As UserData.Item
            Dim ctr As Integer = 0
            Dim status As Boolean = False
            For row As Integer = 0 To rowCount
                For quantityCheck As Integer = 1 To itemList.Rows(row).Cells(5).Value
                    items(ctr).id = itemList.Rows(row).Cells(0).Value
                    items(ctr).name = itemList.Rows(row).Cells(1).Value
                    items(ctr).weight = itemList.Rows(row).Cells(2).Value
                    items(ctr).volume = itemList.Rows(row).Cells(3).Value
                    items(ctr).value = itemList.Rows(row).Cells(4).Value
                    'MessageBox.Show("Id: " + items(ctr).id.ToString + ";Name: " + items(ctr).name + ";Weight: " + items(ctr).weight.ToString + ";Value: " + items(ctr).value.ToString + ";Volume: " + items(ctr).volume.ToString)
                    If items(ctr).volume <= cargo.volume And items(ctr).weight <= cargo.weight Then
                        status = True
                    End If
                    ctr += 1
                Next
            Next
            worldItem = items

            If status Then

                'Solve Knapsack
                Dim max = knapsack(items)
                MessageBox.Show(max)

                'itemid itemname
                itemLeftList.Rows.Clear()
                For r As Integer = 0 To worldItem.Length - 2
                    itemLeftList.Rows.Add(worldItem(r).id, worldItem(r).name, worldItem(r).weight, worldItem(r).volume, worldItem(r).value, 1)
                Next

                'Display Result
                sendCargoWizard.SelectedTab = optimizePage
                cargoLabel.Text = cargo.name
                Dim totalweight As Double = 0.0
                Dim totalvalue As Double = 0.0
                Dim totalvolume As Double = 0.0
                itemTakenList.Rows.Clear()

                For i As Integer = 0 To optimizedItem.Count - 1
                    itemTakenList.Rows.Add(optimizedItem.Item(i).id, optimizedItem.Item(i).name, optimizedItem.Item(i).weight, optimizedItem.Item(i).volume, optimizedItem.Item(i).value)
                    totalweight += optimizedItem.Item(i).weight
                    totalvolume += optimizedItem.Item(i).volume
                    totalvalue += optimizedItem.Item(i).value
                    'MessageBox.Show("NAME : " + optimizedItem.Item(i).name)
                Next i
                weightLabel.Text = totalweight.ToString + "/" + cargo.weight.ToString + " kg"
                volumeLabel.Text = totalvolume.ToString + "/" + cargo.volume.ToString + " cu. units"
                valueLabel.Text = totalvalue.ToString + " PHP"

                batches += 1
                batch1Page.Text = "Batch " + batches.ToString
                batchCombo.Items.Add("Batch " + batches.ToString)
                Dim batchitem As New List(Of UserData.Item)
                batchitem.AddRange(optimizedItem)
                batchList.Add(batchitem)
                batchCombo.SelectedItem = "Batch " + batches.ToString

            Else
                MessageBox.Show("No Item would fit in the cargo !")
            End If
        Else
            MessageBox.Show("You cannot proceed without any items queued!")
        End If
    End Sub

    Private Function knapsack(items() As UserData.Item)
        Dim n As Integer = items.Length - 1
        'Dim K(n + 1, cargo.volume + 1) As Double
        Dim K(n + 1, cargo.volume + 1) As UserData.Knapsack
        Dim util As New Utility
        optimizedItem.Clear()
        For i As Integer = 0 To n
            For w As Integer = 0 To cargo.volume
                If i = 0 Or w = 0 Then
                    'K(i, w) = 0
                    K(i, w).value = 0
                    K(i, w).volume = 0
                    K(i, w).weight = 0
                    K(i, w).item_index = -1
                    K(i, w).k_x = -1
                    K(i, w).k_y = -1
                ElseIf items(i - 1).volume <= w Then
                    'CHANGE THIS
                    If util.max(items(i - 1).value + K(i - 1, w - items(i - 1).volume).value, K(i - 1, w).value) = items(i - 1).value + K(i - 1, w - items(i - 1).volume).value Then
                        If items(i - 1).weight + K(i - 1, w - items(i - 1).volume).weight <= cargo.weight And items(i - 1).volume + K(i - 1, w - items(i - 1).volume).volume <= cargo.volume Then
                            K(i, w).weight = items(i - 1).weight + K(i - 1, w - items(i - 1).volume).weight
                            K(i, w).volume = items(i - 1).volume + K(i - 1, w - items(i - 1).volume).volume
                            K(i, w).value = items(i - 1).value + K(i - 1, w - items(i - 1).volume).value
                            K(i, w).item_index = i - 1
                            K(i, w).k_x = i - 1
                            K(i, w).k_y = w - items(i - 1).volume
                        Else
                            K(i, w) = K(i - 1, w)
                        End If
                    Else
                        K(i, w) = K(i - 1, w)
                    End If
                Else
                    K(i, w) = K(i - 1, w)
                End If
            Next
        Next

        'TEST
        Dim str As String = ""
        For i As Integer = 0 To n
            For w As Integer = 0 To cargo.volume
                str += "Value: " + K(i, w).value.ToString + "Weight: " + K(i, w).weight.ToString + "Volume: " + K(i, w).volume.ToString + " ; K(" + i.ToString + "," + w.ToString + ") --> K(" + K(i, w).k_x.ToString + "," + K(i, w).k_y.ToString + ") "
                Try
                    If i > 0 Then
                        str += "; Item (" + items(K(i, w).item_index).name + ") ||| "
                    End If
                Catch ex As Exception
                    'MessageBox.Show(K(i, w).item_index.ToString)
                End Try
            Next
            str += vbNewLine
        Next
        MessageBox.Show(str)

        '--------------METHOD IN GETTING THE ITEMS, REWORKED
        Dim curr_x = n
        Dim curr_y = cargo.volume
        Dim temp_x = 0
        Dim temp_y = 0
        While curr_x > 0 And curr_y > 0 And K(curr_x, curr_y).item_index >= 0
            'MessageBox.Show(curr_x.ToString + "," + curr_y.ToString)
            Try
                optimizedItem.Add(items(K(curr_x, curr_y).item_index))
            Catch ex As Exception
                MessageBox.Show(curr_x.ToString + "," + curr_y.ToString)
                'MessageBox.Show(K(curr_x, curr_y).item_index.ToString)
            End Try
            temp_x = K(curr_x, curr_y).k_x
            temp_y = K(curr_x, curr_y).k_y
            curr_x = temp_x
            curr_y = temp_y
            'MessageBox.Show(curr_x.ToString + "," + curr_y.ToString)
        End While

        Dim tempoOptItem As New List(Of UserData.Item)
        tempoOptItem.AddRange(optimizedItem)
        Dim tempoWorldItem(worldItem.Length - 1 - optimizedItem.Count) As UserData.Item
        Dim ctr = 0
        Dim condition = False
        Dim cond_identity = 0
        For i As Integer = 0 To worldItem.Length - 2
            condition = False
            For x As Integer = 0 To tempoOptItem.Count - 1
                If worldItem(i).id = tempoOptItem(x).id Then
                    condition = True
                    cond_identity = x
                End If
            Next
            If condition Then
                tempoOptItem.RemoveAt(cond_identity)
            Else
                tempoWorldItem(ctr) = worldItem(i)
                ctr += 1
            End If
        Next
        worldItem = tempoWorldItem

        Return K(n, cargo.volume).value
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles optimizeAgainButton.Click
        If itemLeftList.RowCount > 0 Then
            Dim rowCount As Integer = itemLeftList.RowCount - 1

            'Count the rows plus yung quantity
            Dim quantityCtr As Integer = 0
            For row As Integer = 0 To rowCount
                quantityCtr += itemLeftList.Rows(row).Cells(5).Value
            Next
            'MessageBox.Show(quantityCtr.ToString)

            'Ilagay yung data sa Structure tapos icalculate yung density nung weight and volume
            Dim items(quantityCtr) As UserData.Item
            Dim ctr As Integer = 0
            Dim status As Boolean = False
            For row As Integer = 0 To rowCount
                For quantityCheck As Integer = 1 To itemLeftList.Rows(row).Cells(5).Value
                    items(ctr).id = itemLeftList.Rows(row).Cells(0).Value
                    items(ctr).name = itemLeftList.Rows(row).Cells(1).Value
                    items(ctr).weight = itemLeftList.Rows(row).Cells(2).Value
                    items(ctr).volume = itemLeftList.Rows(row).Cells(3).Value
                    items(ctr).value = itemLeftList.Rows(row).Cells(4).Value
                    'MessageBox.Show("Id: " + items(ctr).id.ToString + ";Name: " + items(ctr).name + ";Weight: " + items(ctr).weight.ToString + ";Value: " + items(ctr).value.ToString + ";Volume: " + items(ctr).volume.ToString)
                    If items(ctr).volume <= cargo.volume And items(ctr).weight <= cargo.weight Then
                        status = True
                    End If
                    ctr += 1
                Next
            Next
            worldItem = items

            If status Then

                'Solve Knapsack
                Dim max = knapsack(items)
                MessageBox.Show(max)

                'itemid itemname
                itemLeftList.Rows.Clear()
                For r As Integer = 0 To worldItem.Length - 2
                    itemLeftList.Rows.Add(worldItem(r).id, worldItem(r).name, worldItem(r).weight, worldItem(r).volume, worldItem(r).value, 1)
                Next

                'Display Result
                sendCargoWizard.SelectedTab = optimizePage
                cargoLabel.Text = cargo.name
                Dim totalweight As Double = 0.0
                Dim totalvalue As Double = 0.0
                Dim totalvolume As Double = 0.0
                itemTakenList.Rows.Clear()

                For i As Integer = 0 To optimizedItem.Count - 1
                    itemTakenList.Rows.Add(optimizedItem.Item(i).id, optimizedItem.Item(i).name, optimizedItem.Item(i).weight, optimizedItem.Item(i).volume, optimizedItem.Item(i).value)
                    totalweight += optimizedItem.Item(i).weight
                    totalvolume += optimizedItem.Item(i).volume
                    totalvalue += optimizedItem.Item(i).value
                    'MessageBox.Show("NAME : " + optimizedItem.Item(i).name)
                Next i
                weightLabel.Text = totalweight.ToString + "/" + cargo.weight.ToString + " kg"
                volumeLabel.Text = totalvolume.ToString + "/" + cargo.volume.ToString + " cu. units"
                valueLabel.Text = totalvalue.ToString + " PHP"

                batches += 1
                batch1Page.Text = "Batch " + batches.ToString
                batchCombo.Items.Add("Batch " + batches.ToString)
                Dim batchitem As New List(Of UserData.Item)
                batchitem.AddRange(optimizedItem)
                batchList.Add(batchitem)
                batchCombo.SelectedItem = "Batch " + batches.ToString
            Else
                MessageBox.Show("No Item would fit in the cargo !")
                optimizeAgainButton.Enabled = False
            End If
        Else
            MessageBox.Show("You cannot proceed without any items queued!")
            optimizeAgainButton.Enabled = False
        End If
    End Sub

    Private Sub batchCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles batchCombo.SelectedIndexChanged
        'Display Result
        cargoLabel.Text = cargo.name
        Dim totalweight As Double = 0.0
        Dim totalvalue As Double = 0.0
        Dim totalvolume As Double = 0.0
        Dim selIndex As Integer = batchCombo.SelectedIndex
        itemTakenList.Rows.Clear()
        batch1Page.Text = "Batch " + (selIndex + 1).ToString

        For i As Integer = 0 To batchList(selIndex).Count - 1
            itemTakenList.Rows.Add(batchList(selIndex).Item(i).id, batchList(selIndex).Item(i).name, batchList(selIndex).Item(i).weight, batchList(selIndex).Item(i).volume, batchList(selIndex).Item(i).value)
            totalweight += batchList(selIndex).Item(i).weight
            totalvolume += batchList(selIndex).Item(i).volume
            totalvalue += batchList(selIndex).Item(i).value
        Next i

        weightLabel.Text = totalweight.ToString + "/" + cargo.weight.ToString + " kg"
        volumeLabel.Text = totalvolume.ToString + "/" + cargo.volume.ToString + " cu. units"
        valueLabel.Text = totalvalue.ToString + " PHP"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim totalweight As Double = 0.0
        Dim totalvalue As Double = 0.0
        Dim totalvolume As Double = 0.0
        Dim batch_id As Integer = 0
        For n As Integer = 0 To batchList.Count - 1
            totalvalue = 0
            totalvolume = 0
            totalweight = 0
            For i As Integer = 0 To batchList(n).Count - 1
                totalweight += batchList(n).Item(i).weight
                totalvolume += batchList(n).Item(i).volume
                totalvalue += batchList(n).Item(i).value
            Next
            cb = New OleDbCommand("INSERT INTO Batches (user_id, cargo_id, total_weight, total_volume, total_value) VALUES('" + created_by.ToString + "', '" + cargo.id.ToString + "', '" + totalweight.ToString + "', '" + totalvolume.ToString + "', '" + totalvalue.ToString + "');", con)
            con.Open()
            cb.ExecuteNonQuery()

            cb = New OleDbCommand("SELECT @@IDENTITY;", con)
            dr = cb.ExecuteReader()
            While dr.Read
                batch_id = dr(0)
            End While
            For i As Integer = 0 To batchList(n).Count - 1
                cb = New OleDbCommand("INSERT INTO Bundles (batch_id, item_id, quantity) VALUES('" + batch_id.ToString + "', '" + batchList(n).Item(i).id.ToString + "', '1');", con)
                cb.ExecuteNonQuery()
            Next
            con.Close()
        Next

        MessageBox.Show("Cargo scheduled for sending ! Refer to database for information.")
        Dashboard.Show()
        Me.Close()
    End Sub
End Class