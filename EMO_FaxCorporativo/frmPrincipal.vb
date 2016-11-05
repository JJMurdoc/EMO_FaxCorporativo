Imports System.Net.Mail

Public Class frmPrincipal
    'Declaración de variables
    Dim objMensaje As New MailMessage
    Dim objSMTP As New SmtpClient
    Dim objOpenFileDialog As New OpenFileDialog
    Dim strFicheroAdjunto As String
    Dim strDestinatarioFax As String
    Dim intNumero As Integer

    Private Sub botEnviarMensaje_Click(sender As Object, e As EventArgs) Handles botEnviarMensaje.Click
        'Comprobaciones previas
        If Me.txtNumeroFax.Text = "" Then
            MessageBox.Show("Indica el número de fax del destinatario.", "EMO - Fax Corporativo", MessageBoxButtons.OK)
            Exit Sub
        End If
        If Me.objListaFicherosAdjuntos.Items.Count = 0 Then
            MessageBox.Show("Añade los ficheros que quieres enviar por fax al destinatario.", "EMO - Fax Corporativo", MessageBoxButtons.OK)
            Exit Sub
        End If

        'Desactiva los controles
        Me.txtNumeroFax.Enabled = False
        Me.objListaFicherosAdjuntos.Enabled = False
        Me.botAnadirAdjuntos.Enabled = False
        Me.botEnviarMensaje.Enabled = False

        'Confirguracion del SMTP
        Me.objSMTP.Host = "mail.emo.org.es"
        Me.objSMTP.Credentials = New Net.NetworkCredential("fax@emo.org.es", "OME111234")

        'Composicion del FAX
        Me.objMensaje.From = New MailAddress("fax@emo.org.es")
        strDestinatarioFax = Me.txtNumeroFax.Text & "@fax.movistar.ecomfax.com"
        Me.objMensaje.To.Add(strDestinatarioFax)
        Me.objMensaje.Subject = "1234"
        Me.objMensaje.Body = ""
        Me.objMensaje.Priority = MailPriority.Normal
        For intNumero = 0 To Me.objListaFicherosAdjuntos.Items.Count - 1
            Me.objMensaje.Attachments.Add(New Attachment(Me.objListaFicherosAdjuntos.Items(intNumero)))
        Next intNumero

        'Envio del FAX
        Me.objBarraInformacion.Text = "Enviado fax al destinatario...espere un momento."
        Me.Refresh()
        Try
            Me.objSMTP.Send(Me.objMensaje)
            Me.objBarraInformacion.Text = "Fax enviado correctamente."
            'MessageBox.Show("Mensaje enviado correctamente", "EMO - Fax Corporativo", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "EMO - Fax Corporativo", MessageBoxButtons.OK)
        End Try

        'Activa y limpia los controles 
        Me.txtNumeroFax.Enabled = True
        Me.txtNumeroFax.Text = ""
        Me.objListaFicherosAdjuntos.Enabled = True
        Me.objListaFicherosAdjuntos.Items.Clear()
        Me.botAnadirAdjuntos.Enabled = True
        Me.botEnviarMensaje.Enabled = True
    End Sub

    Private Sub botAnadirAdjuntos_Click(sender As Object, e As EventArgs) Handles botAnadirAdjuntos.Click
        'Añade los ficheros del FAX

        'Abre la ventana de seleccionar fichero
        objOpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        objOpenFileDialog.Filter = "Todos los archivos (*.*)|*.*"
        objOpenFileDialog.Multiselect = True
        If (objOpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                strFicheroAdjunto = objOpenFileDialog.FileName
                Me.objListaFicherosAdjuntos.Items.Add(strFicheroAdjunto)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "EMO - Fax Corporativo", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Muestra el titulo de la ventana
        Me.Text = "EMO - Fax Corporativo v." & Me.ProductVersion
    End Sub
End Class