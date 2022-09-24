
Public Class DictionaryTokens
    Public Property ListOfTerminals As New List(Of KeyValuePair(Of Integer, String))

    'Public Function DictionaryTokens()
    '    auxObjTokens.Add(1, “while”)
    'auxObjTokens.Add(2, “void”)
    'auxObjTokens.Add(3, “string”)
    'auxObjTokens.Add(4, “return”)
    'auxObjTokens.Add(5, “numerointeiro”)
    'auxObjTokens.Add(6, “numerofloat”)
    'auxObjTokens.Add(7, “nomevariavel”)
    'auxObjTokens.Add(8, “nomedochar”)
    'auxObjTokens.Add(9, “nomedavariavel”)
    'auxObjTokens.Add(10, “nomedastring”)
    'auxObjTokens.Add(11, “main”)
    'auxObjTokens.Add(12, “literal”)
    'auxObjTokens.Add(13, “integer“)
    'auxObjTokens.Add(14, “int”)
    'auxObjTokens.Add(15, “inicio”)
    'auxObjTokens.Add(16, “if“)
    'auxObjTokens.Add(17, “null”)
    'auxObjTokens.Add(18, “for“)
    'auxObjTokens.Add(19, “float”)
    'auxObjTokens.Add(20, “fim“)
    'auxObjTokens.Add(21, “else”)
    'auxObjTokens.Add(22, “double“)
    'auxObjTokens.Add(23, “do”)
    'auxObjTokens.Add(24, “cout“)
    'auxObjTokens.Add(25, “cin“)
    'auxObjTokens.Add(26, “char”)
    'auxObjTokens.Add(27, “callfuncao”)
    'auxObjTokens.Add(28, “>>”)
    'auxObjTokens.Add(29, “>=”)
    'auxObjTokens.Add(30, “>”)
    'auxObjTokens.Add(31, “==”)
    'auxObjTokens.Add(32, “=”)
    'auxObjTokens.Add(33, “<=”)
    'auxObjTokens.Add(34, “<<")
    'auxObjTokens.Add(35, “<”)
    'auxObjTokens.Add(36, “++”)
    'auxObjTokens.Add(37, “+”)
    'auxObjTokens.Add(38, “}”)
    'auxObjTokens.Add(39, "{”)
    'auxObjTokens.Add(40, “;”)
    'auxObjTokens.Add(41, “:”)
    'auxObjTokens.Add(42, “/”)
    'auxObjTokens.Add(43, “,”)
    'auxObjTokens.Add(44, “*”)
    'auxObjTokens.Add(45, “)”)
    'auxObjTokens.Add(46, “(”)
    'auxObjTokens.Add(47, “$”)
    'auxObjTokens.Add(48, “!=”)
    'auxObjTokens.Add(49, “--”)
    'auxObjTokens.Add(50, “-”)
    '    Return _DictionaryTerminals
    'End Function

    Private Function ReservedWords() As String()
        Dim vector() As String = {"while", "void", "string", "return", "main", "integer", "int", "if", "for", "float", "else",
            "double", "do", "cout", "cin", "char"}
        Return vector
    End Function



End Class
