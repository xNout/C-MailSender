# GMAIL MailSender

Con ayuda de esta clase podemos hacer más sencillo el envio de emails desde gmail a cualquier correo.


## Ejemplos de uso


bool envio = mailerSend.sendEmail("micorreo@gmail.com", "micontraseña", "receptor@email.com", "Asunto", codigo_html);

if (envio)
{
    Console.WriteLine("Envio correcto de email!");
}
else
{
    Console.WriteLine("Acceso denegado, por favor asegurate de que el correo permita el acceso a aplicaciones terceras o que el correo este bien escrito");
}

## Ejemplo de codigo HTML

<body style='padding: 20px; background: #000;'>
	
	<b style='color: white'>Buenos dias, sres.</b>
	<p style='color: white'>El motivo del email es para solicitar los certificados de retención</p>

</body>