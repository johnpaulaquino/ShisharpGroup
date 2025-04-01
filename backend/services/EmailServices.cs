using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend;
using MailKit.Net.Smtp;
using MimeKit;

namespace BMS.backend.utils {
    public class EmailServices {
        private readonly Settings settings;
        public EmailServices() {
            settings = new Settings();

        }

        public async Task SendEmail(string EmailRecipient,
        string EmailSubject,
        string EmailMessages, string EmailAttachmentFilePath,
        string EMailFileName) {

            var _MimeMessage = new MimeMessage();
            _MimeMessage.From.Add(new MailboxAddress(settings.EMAIL_USERNAME, settings.EMAIL));
            _MimeMessage.To.Add(new MailboxAddress(EmailRecipient, EmailRecipient));
            _MimeMessage.Subject = EmailSubject;

            var _Body = new TextPart("plain") {
                Text = EmailMessages
            };

            var _Attachment = new MimePart("application", "pdf") {

                Content = new MimeContent(File.OpenRead(EmailAttachmentFilePath)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = EMailFileName
            };

            // Combine message and the attachment 
            var _Multipart = new Multipart() {
                _Body,
                _Attachment
            };


            _MimeMessage.Body = _Multipart;

            using (client = new SmtpClient()) {
                await client.ConnectAsync(settings.EMAIL_SERVER, settings.EMAIL_PORT, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(settings.EMAIL, settings.EMAIL_PASSWORD);
                await client.SendAsync(_MimeMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}