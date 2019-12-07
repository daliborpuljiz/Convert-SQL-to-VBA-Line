Public Class frmConvertSQLToVBA

 Private Sub cbtConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtConvert.Click
  Const strcLineEnd = " "" & _" & vbNewLine & """"
  Const strcInLine = " "
  Dim strSQL As String
  Dim lngI As Long
  strSQL = tbxSQL.Text
  strSQL = Replace(strSQL, """", "'")
  strSQL = Replace(strSQL, vbCrLf, strcInLine)
  strSQL = Replace(strSQL, " FROM", strcLineEnd & " FROM")
  strSQL = Replace(strSQL, " WHERE", strcLineEnd & " WHERE")
  strSQL = Replace(strSQL, " GROUP BY", strcLineEnd & " GROUP BY")
  strSQL = Replace(strSQL, " ORDER BY", strcLineEnd & " ORDER BY")
  strSQL = Replace(strSQL, " HAVING", strcLineEnd & " HAVING")
  strSQL = Replace(strSQL, " SET", strcLineEnd & " SET")
  strSQL = Replace(strSQL, " INSERT", strcLineEnd & " INSERT")
  strSQL = Replace(strSQL, " UNION", strcLineEnd & " UNION")
  strSQL = Replace(strSQL, " SELECT", strcLineEnd & " SELECT")
  strSQL = Replace(strSQL, " DECLARE", strcLineEnd & " DECLARE")
  strSQL = Replace(strSQL, " CREATE", strcLineEnd & " CREATE")
  'strSQL = Replace(strSQL, " WITH", strcLineEnd & " WITH")
  strSQL = Replace(strSQL, " DROP", strcLineEnd & " DROP")
  strSQL = Replace(strSQL, " INNER JOIN", strcLineEnd & " INNER JOIN")
  strSQL = Replace(strSQL, " LEFT JOIN", strcLineEnd & " LEFT JOIN")
  strSQL = Replace(strSQL, " RIGHT JOIN", strcLineEnd & " RIGHT JOIN")
  strSQL = " = """ & strSQL & """"
  For lngI = 1 To 10
   strSQL = Replace(strSQL, "  ", " ")
   tbxSQL.Text = strSQL
  Next
 End Sub

End Class
