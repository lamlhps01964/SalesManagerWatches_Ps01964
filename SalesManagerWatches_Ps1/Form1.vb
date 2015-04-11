Public Class frmMain
    'sự kiện menustrip thoát
    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        End
    End Sub
    'sự kiện nút đăng xuất
    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangXuat.Click
        'form Login xuất hiện
        Me.Hide()
       
    End Sub

    'sự kiện vào form thêm, sửa, xóa,...
    Private Sub mniThem_Click(sender As Object, e As EventArgs) Handles mniThem.Click

    End Sub
    'sự kiện form About
    Private Sub mniBanQuyen_Click(sender As Object, e As EventArgs) Handles mniBanQuyen.Click
        
    End Sub
    'sự kiện form trợ giúp
    Private Sub mniTroGiup_Click(sender As Object, e As EventArgs) Handles mniTroGiup.Click
        Help.ShowHelp(Me, "Help_Assignment_PS01964.chm")
    End Sub

    Private Sub mniKH_Click(sender As Object, e As EventArgs) Handles mniKH.Click

    End Sub
End Class