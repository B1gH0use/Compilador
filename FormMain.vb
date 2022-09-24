Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Metadata.Ecma335

Public Class FormMain
    Dim ListGlobalToken As New List(Of Token)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Validform()
            ProcessLexico()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error lexico")
        End Try
    End Sub

    Private Sub SintaticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SintaticoToolStripMenuItem.Click
        MsgBox("Não está feito ainda moço")
    End Sub

    Private Sub SemanticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanticoToolStripMenuItem.Click
        MsgBox("Não está feito ainda moço")
    End Sub

    Private Sub DepurarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepurarTodosToolStripMenuItem.Click
        MsgBox("Não está feito ainda moço")
    End Sub

    Private Sub CarregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarToolStripMenuItem.Click
        MsgBox("Não está feito ainda moço")
    End Sub

    'Functions

    Private Sub ProcessLexico()
        Try

            Dim _token As New List(Of Token)

            Dim _fullText As String() = RichTextBoxCode.Text.Split("\n")
            _fullText = _fullText.First.Split(vbLf)
            Dim _listLine As New List(Of String)

            For Each objline In _fullText
                If objline = "" Then Continue For
                _listLine.Add(objline.ToLower.Trim)
            Next

            _token = ValidTonkens(_listLine)
            BSTerminals.DataSource = _token

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function ValidTonkens(ByRef pLine As List(Of String))


        Dim _dicTokens As New DictionaryTokens
        _dicTokens.ListOfTerminals.AddRange(ListTerminalsFuncition())
        Dim _comment As Boolean

        For Each objline In pLine

            Dim _symbol As String = ""
            Dim i As Integer = 0

            Do While (i < objline.Length)

                Dim _char As Char = objline(i)

                'Comment 1 Etapa
                If _char = "/" And i < objline.Length + 1 AndAlso objline.Chars(i + 1) = "*" Then

                    If _symbol <> "" Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Comentario Etapa 1: iniciar o comentário")

                    _comment = True

                ElseIf _char = "*" And i < objline.Length + 1 AndAlso objline.Chars(i + 1) = "/" Then

                    _comment = False

                ElseIf _comment Then

                    Continue Do

                    'Literal 2 Etapa
                ElseIf _char = "@" Then

                    _symbol = ""

                    Dim j As Integer = i + 1

                    If j < objline.Length Then
                        _char = objline(j)

                        Do While (_char <> "@")
                            _symbol += _char.ToString

                            j = j + 1

                            If j = objline.Length Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Literal Etapa 2: não foi fechado na linha de abertura")

                            _char = objline(j)

                        Loop

                    Else
                        Throw New Exception($"Erro Lexico | Line: {objline.Count} | Literal Etapa 2: Erro não foi fechado na linha de abertura")
                    End If

                    If _symbol.Length > 255 Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Literal Etapa 2: maior que 255 caracteres")

                    Dim auxToken = GenerateToken("literal", _symbol, _dicTokens, objline.Count)

                    If auxToken IsNot Nothing Then
                        ListGlobalToken.Add(auxToken)
                        _symbol = ""
                    End If
                    _symbol = ""
                    i = j + 1
                    Continue Do

                    'Identificadores 3 Etapa
                ElseIf _char >= "a" And _char <= "z" Then

                    Dim j As Integer = i

                    _symbol = ""

                    Do While _char >= "a" And _char <= "z" Or _char >= "0" And _char <= "9"

                        _symbol += _char.ToString

                        j = j + 1

                        If j = objline.Length Then Exit Do

                        _char = objline(j)

                    Loop

                    If _symbol.Length > 30 Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Identificador Etapa 3: Maior que 30 caracteres")
                    Dim auxToken

                    If _symbol = "string" Or _symbol = "char" Then
                        auxToken = GenerateToken("Identificador", _symbol, _dicTokens, objline.Count)
                    Else
                        auxToken = GenerateToken("nomevariavel", _symbol, _dicTokens, objline.Count)
                    End If

                    If auxToken IsNot Nothing Then
                        ListGlobalToken.Add(auxToken)
                        _symbol = ""
                    End If
                    _symbol = ""
                    i = j
                    Continue Do
                    'Numerais 4 Etapa
                ElseIf (_char >= "0" And _char <= "9") Or (_char = "-" And i < objline.Length + 1) AndAlso (objline(i + 1) >= "0" And objline(i + 1) <= "9") Then

                    Dim j As Integer = i

                    _symbol = ""

                    If _char = "-" Then

                        _symbol += _char.ToString

                        j = j + 1

                    End If

                    If j < objline.Length - 1 Then _char = objline(j)

                    Do While _char >= "0" And _char <= "9" Or _char = ","
                        _symbol += _char.ToString

                        j = j + 1

                        If j = objline.Length Then Exit Do

                        _char = objline(j)

                    Loop

                    Dim auxToken

                    If _symbol.Contains(",") Then
                        auxToken = GenerateToken("numerofloat", _symbol, _dicTokens, objline.Count)
                    Else
                        auxToken = GenerateToken("numerointeiro", _symbol, _dicTokens, objline.Count)
                    End If

                    Dim int As Integer = _symbol
                    If int > 32767 Or int < -32767 Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Inteiro Etapa 4: Ultrapassou os limites do Integer")

                    If auxToken IsNot Nothing Then
                        ListGlobalToken.Add(auxToken)
                        _symbol = ""
                    End If

                    _symbol = ""

                    i = j

                    Continue Do
                    'Outros Simbolos 5 Etapa
                ElseIf _char <> " " And _char <> "\t" Then

                    _symbol = _char.ToString

                    Dim auxToken = GenerateToken(Nothing, _symbol, _dicTokens, objline.Count)

                    If auxToken IsNot Nothing Then

                        If objline.Length > i + 1 Then

                            _symbol = objline

                            Dim auxToken2 = GenerateToken(Nothing, _symbol, _dicTokens, objline.Count)

                            If auxToken2 IsNot Nothing Then
                                ListGlobalToken.Add(auxToken2)
                                i = i + 1
                            Else
                                ListGlobalToken.Add(auxToken)
                            End If

                        Else
                            ListGlobalToken.Add(auxToken)
                        End If

                        _symbol = ""
                        i = i + 1
                        Continue Do
                    ElseIf _symbol = """" Then
                        Dim j As Integer = i + 1
                        If j < objline.Length Then
                            _char = objline(j)

                            Do While (_char >= "a" And _char <= "z")
                                _symbol += _char.ToString

                                j = j + 1

                                If j = objline.Length Then Throw New Exception($"Erro Lexico | Line: {objline.Count} | Erro Simbolos Etapa 5: não foi fechado na linha de abertura a String")

                                _char = objline(j)

                            Loop
                            If _symbol.Contains("""") Then _symbol = _symbol.Replace("""", "")
                            auxToken = GenerateToken("nomedastring", _symbol, _dicTokens, objline.Count)
                            If auxToken IsNot Nothing Then
                                ListGlobalToken.Add(auxToken)
                                _symbol = ""
                            End If
                            _symbol = ""
                            i = j + 1
                            Continue Do
                        Else
                            Throw New Exception($"Erro Lexico | Line: {objline.Count} | Literal Etapa 2: Erro não foi fechado na linha de abertura")
                        End If
                    ElseIf _symbol = "'" Then
                        Dim j As Integer = i + 1
                        If j < objline.Length Then
                            _char = objline(j)

                            Do While (_char >= "a" And _char <= "z")
                                _symbol += _char.ToString

                                j = j + 1

                                _char = objline(j)

                            Loop
                            If _symbol.Contains("'") Then _symbol = _symbol.Replace("'", "")
                            auxToken = GenerateToken("nomedochar", _symbol, _dicTokens, objline.Count)
                            If auxToken IsNot Nothing Then
                                ListGlobalToken.Add(auxToken)
                                _symbol = ""
                            End If
                            _symbol = ""
                            i = j + 1
                            Continue Do
                        Else
                            Throw New Exception($"Erro Lexico | Line: {objline.Count} | Literal Etapa 2: Erro não foi fechado na linha de abertura")
                        End If
                    End If


                End If

                i = i + 1
            Loop
        Next

        Return ListGlobalToken
    End Function

    Private Function GenerateToken(ByVal pType As String, ByVal pSymbol As String, ByVal pPossibleTokens As DictionaryTokens, ByVal pNumberLine As Integer) As Token
        If pSymbol Is Nothing Or pSymbol = "" Then Throw New Exception($"The Null exception {pType}   {pSymbol}   {pNumberLine}")

        If pType = "literal" Then Return New Token With {.Code = 12, .Symbol = pSymbol, .Line = pNumberLine}

        If pType = "numerofloat" Then Return New Token With {.Code = 6, .Symbol = pSymbol, .Line = pNumberLine}

        If pType = "numerointeiro" Then Return New Token With {.Code = 5, .Symbol = pSymbol, .Line = pNumberLine}

        If pType = "nomevariavel" Then Return New Token With {.Code = 7, .Symbol = pSymbol, .Line = pNumberLine}

        If pType = "nomedochar" Then Return New Token With {.Code = 8, .Symbol = pSymbol, .Line = pNumberLine}

        If pType = "nomedastring" Then Return New Token With {.Code = 10, .Symbol = pSymbol, .Line = pNumberLine}

        For Each Terminal In pPossibleTokens.ListOfTerminals
            If Terminal.Value = pSymbol Then
                Return New Token With {.Code = Terminal.Key, .Symbol = pSymbol, .Line = pNumberLine}
            End If
        Next

        Return Nothing
    End Function

    Private Function ListTerminalsFuncition()
        Dim pObject As New List(Of KeyValuePair(Of Integer, String))
        pObject.Add(New KeyValuePair(Of Integer, String)(1, “while”))
        pObject.Add(New KeyValuePair(Of Integer, String)(2, “void”))
        pObject.Add(New KeyValuePair(Of Integer, String)(3, “string”))
        pObject.Add(New KeyValuePair(Of Integer, String)(4, “return”))
        pObject.Add(New KeyValuePair(Of Integer, String)(5, “numerointeiro”))
        pObject.Add(New KeyValuePair(Of Integer, String)(6, “numerofloat”))
        pObject.Add(New KeyValuePair(Of Integer, String)(7, “nomevariavel”))
        pObject.Add(New KeyValuePair(Of Integer, String)(8, “nomedochar”))
        'pObject.Add(New KeyValuePair(Of Integer, String)(9, “nomedavariavel”))
        pObject.Add(New KeyValuePair(Of Integer, String)(10, “nomedastring”))
        pObject.Add(New KeyValuePair(Of Integer, String)(11, “main”))
        pObject.Add(New KeyValuePair(Of Integer, String)(12, “literal”))
        pObject.Add(New KeyValuePair(Of Integer, String)(13, “integer“))
        pObject.Add(New KeyValuePair(Of Integer, String)(14, “int”))
        pObject.Add(New KeyValuePair(Of Integer, String)(15, “inicio”))
        pObject.Add(New KeyValuePair(Of Integer, String)(16, “if“))
        pObject.Add(New KeyValuePair(Of Integer, String)(17, “null”))
        pObject.Add(New KeyValuePair(Of Integer, String)(18, “for“))
        pObject.Add(New KeyValuePair(Of Integer, String)(19, “float”))
        pObject.Add(New KeyValuePair(Of Integer, String)(20, “fim“))
        pObject.Add(New KeyValuePair(Of Integer, String)(21, “else”))
        pObject.Add(New KeyValuePair(Of Integer, String)(22, “double“))
        pObject.Add(New KeyValuePair(Of Integer, String)(23, “do”))
        pObject.Add(New KeyValuePair(Of Integer, String)(24, “cout“))
        pObject.Add(New KeyValuePair(Of Integer, String)(25, “cin“))
        pObject.Add(New KeyValuePair(Of Integer, String)(26, “char”))
        pObject.Add(New KeyValuePair(Of Integer, String)(27, “callfuncao”))
        pObject.Add(New KeyValuePair(Of Integer, String)(28, “>>”))
        pObject.Add(New KeyValuePair(Of Integer, String)(29, “>=”))
        pObject.Add(New KeyValuePair(Of Integer, String)(30, “>”))
        pObject.Add(New KeyValuePair(Of Integer, String)(31, “==”))
        pObject.Add(New KeyValuePair(Of Integer, String)(32, “=”))
        pObject.Add(New KeyValuePair(Of Integer, String)(33, “<=”))
        pObject.Add(New KeyValuePair(Of Integer, String)(34, “<<"))
        pObject.Add(New KeyValuePair(Of Integer, String)(35, “<”))
        pObject.Add(New KeyValuePair(Of Integer, String)(36, “++”))
        pObject.Add(New KeyValuePair(Of Integer, String)(37, “+”))
        pObject.Add(New KeyValuePair(Of Integer, String)(38, “}”))
        pObject.Add(New KeyValuePair(Of Integer, String)(39, "{”))
        pObject.Add(New KeyValuePair(Of Integer, String)(40, “;”))
        pObject.Add(New KeyValuePair(Of Integer, String)(41, “:”))
        pObject.Add(New KeyValuePair(Of Integer, String)(42, “/”))
        pObject.Add(New KeyValuePair(Of Integer, String)(43, “,”))
        pObject.Add(New KeyValuePair(Of Integer, String)(44, “*”))
        pObject.Add(New KeyValuePair(Of Integer, String)(45, “)”))
        pObject.Add(New KeyValuePair(Of Integer, String)(46, “(”))
        pObject.Add(New KeyValuePair(Of Integer, String)(47, “$”))
        pObject.Add(New KeyValuePair(Of Integer, String)(48, “!=”))
        pObject.Add(New KeyValuePair(Of Integer, String)(49, “--”))
        pObject.Add(New KeyValuePair(Of Integer, String)(50, “-”))


        Return pObject

    End Function

    Private Sub Validform()
        BSTerminals.Clear()
        ListGlobalToken.Clear()
    End Sub

End Class
