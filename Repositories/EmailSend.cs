using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BookTreasure.Repositories
{
    public delegate void SendEmail(string email);
    public enum Operator
    {
        codesend,
        rqstaccept,
        rqstdelete
    }
    class EmailSend
    {
        public int pin;
        public SendEmail GetSendEmail(Operator op)
        {
            SendEmail em = null;
            switch( op)
            {
                case Operator.codesend:
                    em = codeEmailSend;
                    return em;
                case Operator.rqstaccept:
                    em = EmployeeRqstAccept;
                    return em;
                case Operator.rqstdelete:
                    em = EmployeeRqstDecline;
                    return em;
                default:
                    return em;
            }
        }
        public void codeEmailSend(string email)
        {
                Random x = new Random();
                pin = x.Next(0, 100000);
                string to, from, pass;
                MailMessage message = new MailMessage();
                to = email;
                from = "book.treasure11@gmail.com";
                pass = "holaP@pis4";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "Your Book Treaasure account verification code is " + pin.ToString() + ". If it is you then verify your account through this code.";
                message.Subject = "Book Tresure.";
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    DialogResult code = MessageBox.Show("Email sent. Please check.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        public void EmployeeRqstAccept(string email)
        {
            string to, from, pass;
            MailMessage message = new MailMessage();
            to = email;
            from = "book.treasure11@gmail.com";
            pass = "holaP@pis4";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Dear "+EmployeeAppointForm.name+" Congratulation! Your request has been accepted for the employee post in Book-Treasure. Happy Journey.. ";
            message.Subject = "Book Tresure.";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EmployeeRqstDecline(string email)
        {
            string to, from, pass;
            MailMessage message = new MailMessage();
            to = email;
            from = "book.treasure11@gmail.com";
            pass = "holaP@pis4";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Dear " + EmployeeAppointForm.name + " Sorry! There is something wrong about you. That's why you request for the employee post has been declined. If you have any query contact to the administation. ";
            message.Subject = "Book Tresure.";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
