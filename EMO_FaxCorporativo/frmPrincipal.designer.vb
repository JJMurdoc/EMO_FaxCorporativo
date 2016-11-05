<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.botEnviarMensaje = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNumeroFax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.objListaFicherosAdjuntos = New System.Windows.Forms.ListBox()
        Me.botAnadirAdjuntos = New System.Windows.Forms.Button()
        Me.objBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.objBarraInformacion = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.objBarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'botEnviarMensaje
        '
        Me.botEnviarMensaje.Location = New System.Drawing.Point(422, 329)
        Me.botEnviarMensaje.Name = "botEnviarMensaje"
        Me.botEnviarMensaje.Size = New System.Drawing.Size(150, 50)
        Me.botEnviarMensaje.TabIndex = 2
        Me.botEnviarMensaje.Text = "Enviar FAX"
        Me.botEnviarMensaje.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Fax"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 170)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtNumeroFax
        '
        Me.txtNumeroFax.Location = New System.Drawing.Point(103, 176)
        Me.txtNumeroFax.Name = "txtNumeroFax"
        Me.txtNumeroFax.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroFax.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ficheros a enviar"
        '
        'objListaFicherosAdjuntos
        '
        Me.objListaFicherosAdjuntos.FormattingEnabled = True
        Me.objListaFicherosAdjuntos.Location = New System.Drawing.Point(103, 202)
        Me.objListaFicherosAdjuntos.Name = "objListaFicherosAdjuntos"
        Me.objListaFicherosAdjuntos.Size = New System.Drawing.Size(469, 121)
        Me.objListaFicherosAdjuntos.TabIndex = 5
        Me.objListaFicherosAdjuntos.TabStop = False
        '
        'botAnadirAdjuntos
        '
        Me.botAnadirAdjuntos.Location = New System.Drawing.Point(103, 329)
        Me.botAnadirAdjuntos.Name = "botAnadirAdjuntos"
        Me.botAnadirAdjuntos.Size = New System.Drawing.Size(150, 25)
        Me.botAnadirAdjuntos.TabIndex = 1
        Me.botAnadirAdjuntos.Text = "Añadir Ficheros"
        Me.botAnadirAdjuntos.UseVisualStyleBackColor = True
        '
        'objBarraEstado
        '
        Me.objBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objBarraInformacion})
        Me.objBarraEstado.Location = New System.Drawing.Point(0, 391)
        Me.objBarraEstado.Name = "objBarraEstado"
        Me.objBarraEstado.Size = New System.Drawing.Size(584, 22)
        Me.objBarraEstado.TabIndex = 6
        Me.objBarraEstado.Text = "StatusStrip1"
        '
        'objBarraInformacion
        '
        Me.objBarraInformacion.Name = "objBarraInformacion"
        Me.objBarraInformacion.Size = New System.Drawing.Size(569, 17)
        Me.objBarraInformacion.Spring = True
        Me.objBarraInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 413)
        Me.Controls.Add(Me.objBarraEstado)
        Me.Controls.Add(Me.botAnadirAdjuntos)
        Me.Controls.Add(Me.objListaFicherosAdjuntos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeroFax)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botEnviarMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMO - Fax Corporativo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.objBarraEstado.ResumeLayout(False)
        Me.objBarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botEnviarMensaje As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNumeroFax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents objListaFicherosAdjuntos As ListBox
    Friend WithEvents botAnadirAdjuntos As Button
    Friend WithEvents objBarraEstado As StatusStrip
    Friend WithEvents objBarraInformacion As ToolStripStatusLabel
End Class
