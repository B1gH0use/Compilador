<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBoxCode = New System.Windows.Forms.RichTextBox()
        Me.DataGridViewTerminal = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSTerminals = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewNoTerminal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DepurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LexicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintaticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepurarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTerminal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSTerminals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewNoTerminal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxCode
        '
        Me.RichTextBoxCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxCode.Location = New System.Drawing.Point(12, 56)
        Me.RichTextBoxCode.Name = "RichTextBoxCode"
        Me.RichTextBoxCode.Size = New System.Drawing.Size(663, 379)
        Me.RichTextBoxCode.TabIndex = 1
        Me.RichTextBoxCode.Text = "void main{" & Global.Microsoft.VisualBasic.ChrW(10) & "string str:=""victor"";" & Global.Microsoft.VisualBasic.ChrW(10) & "integer valorint:=40" & Global.Microsoft.VisualBasic.ChrW(10) & "float valorFloat:=1,10" & Global.Microsoft.VisualBasic.ChrW(10) & "char" &
    " strchar:='a'" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "cout<<@testeliteral testandoliteral@" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataGridViewTerminal
        '
        Me.DataGridViewTerminal.AllowUserToAddRows = False
        Me.DataGridViewTerminal.AllowUserToDeleteRows = False
        Me.DataGridViewTerminal.AllowUserToResizeColumns = False
        Me.DataGridViewTerminal.AllowUserToResizeRows = False
        Me.DataGridViewTerminal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTerminal.AutoGenerateColumns = False
        Me.DataGridViewTerminal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.SymbolDataGridViewTextBoxColumn, Me.LineDataGridViewTextBoxColumn})
        Me.DataGridViewTerminal.DataSource = Me.BSTerminals
        Me.DataGridViewTerminal.Location = New System.Drawing.Point(681, 42)
        Me.DataGridViewTerminal.MultiSelect = False
        Me.DataGridViewTerminal.Name = "DataGridViewTerminal"
        Me.DataGridViewTerminal.ReadOnly = True
        Me.DataGridViewTerminal.RowHeadersVisible = False
        Me.DataGridViewTerminal.RowTemplate.Height = 25
        Me.DataGridViewTerminal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTerminal.Size = New System.Drawing.Size(306, 276)
        Me.DataGridViewTerminal.TabIndex = 2
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SymbolDataGridViewTextBoxColumn
        '
        Me.SymbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol"
        Me.SymbolDataGridViewTextBoxColumn.HeaderText = "Símbolo"
        Me.SymbolDataGridViewTextBoxColumn.Name = "SymbolDataGridViewTextBoxColumn"
        Me.SymbolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LineDataGridViewTextBoxColumn
        '
        Me.LineDataGridViewTextBoxColumn.DataPropertyName = "Line"
        Me.LineDataGridViewTextBoxColumn.HeaderText = "Linha"
        Me.LineDataGridViewTextBoxColumn.Name = "LineDataGridViewTextBoxColumn"
        Me.LineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BSTerminals
        '
        Me.BSTerminals.DataSource = GetType(CompiladorVB.Token)
        '
        'DataGridViewNoTerminal
        '
        Me.DataGridViewNoTerminal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewNoTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNoTerminal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridViewNoTerminal.Location = New System.Drawing.Point(681, 339)
        Me.DataGridViewNoTerminal.Name = "DataGridViewNoTerminal"
        Me.DataGridViewNoTerminal.ReadOnly = True
        Me.DataGridViewNoTerminal.RowHeadersVisible = False
        Me.DataGridViewNoTerminal.RowTemplate.Height = 25
        Me.DataGridViewNoTerminal.Size = New System.Drawing.Size(306, 274)
        Me.DataGridViewNoTerminal.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Palavra"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Linha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepurarToolStripMenuItem, Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(999, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DepurarToolStripMenuItem
        '
        Me.DepurarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LexicoToolStripMenuItem, Me.SintaticoToolStripMenuItem, Me.SemanticoToolStripMenuItem, Me.DepurarTodosToolStripMenuItem})
        Me.DepurarToolStripMenuItem.Name = "DepurarToolStripMenuItem"
        Me.DepurarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DepurarToolStripMenuItem.Text = "Depurar"
        '
        'LexicoToolStripMenuItem
        '
        Me.LexicoToolStripMenuItem.Name = "LexicoToolStripMenuItem"
        Me.LexicoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LexicoToolStripMenuItem.Text = "Lexico"
        '
        'SintaticoToolStripMenuItem
        '
        Me.SintaticoToolStripMenuItem.Name = "SintaticoToolStripMenuItem"
        Me.SintaticoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SintaticoToolStripMenuItem.Text = "Sintatico"
        '
        'SemanticoToolStripMenuItem
        '
        Me.SemanticoToolStripMenuItem.Name = "SemanticoToolStripMenuItem"
        Me.SemanticoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SemanticoToolStripMenuItem.Text = "Semantico"
        '
        'DepurarTodosToolStripMenuItem
        '
        Me.DepurarTodosToolStripMenuItem.Name = "DepurarTodosToolStripMenuItem"
        Me.DepurarTodosToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DepurarTodosToolStripMenuItem.Text = "Depurar todos"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarregarToolStripMenuItem, Me.SalvarArquivoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'CarregarToolStripMenuItem
        '
        Me.CarregarToolStripMenuItem.Name = "CarregarToolStripMenuItem"
        Me.CarregarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CarregarToolStripMenuItem.Text = "Carregar Arquivo"
        '
        'SalvarArquivoToolStripMenuItem
        '
        Me.SalvarArquivoToolStripMenuItem.Name = "SalvarArquivoToolStripMenuItem"
        Me.SalvarArquivoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SalvarArquivoToolStripMenuItem.Text = "Salvar Arquivo"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 456)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(663, 157)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Console"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 625)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DataGridViewNoTerminal)
        Me.Controls.Add(Me.DataGridViewTerminal)
        Me.Controls.Add(Me.RichTextBoxCode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Compilador"
        CType(Me.DataGridViewTerminal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSTerminals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewNoTerminal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxCode As RichTextBox
    Friend WithEvents DataGridViewTerminal As DataGridView
    Friend WithEvents DataGridViewNoTerminal As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DepurarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LexicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SintaticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemanticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepurarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BSTerminals As BindingSource
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymbolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
