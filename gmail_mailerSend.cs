
class mailerSend
{

    public static bool sendEmail( string emisor, string emisorPassword, string receptor, string asunto, string estructuraHTML )
    {
        bool enviado;
        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new System.Net.NetworkCredential(emisor, emisorPassword)
        };

        MailMessage mmsg = new MailMessage
        {
            From = new MailAddress(emisor),
            Body = estructuraHTML,
            Subject = asunto,
            IsBodyHtml = true

        };

        mmsg.To.Add(new MailAddress(receptor));
        try
        {    
            smtp.Send(mmsg);
            enviado = true;
        }
        catch (SmtpException ex)
        {
            enviado = false;
        }

        return enviado;
    }

}