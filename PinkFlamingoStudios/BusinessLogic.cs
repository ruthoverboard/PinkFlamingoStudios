using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Net.Mail;

namespace PinkFlamingoStudios
{
    public class BusinessLogic
    {
        SqlConnection pfCon = new SqlConnection(@"Data Source=(localdb)\V12.0;Initial Catalog=PinkFlamingos;Integrated Security=True");
        public static bool name { get; set; }
        public static bool creditCard { get; set; }
        public static bool address { get; set; }

        public void connect()
        {
           pfCon.Open();
        }

        public void addOrder(string firstName, string secondName, string firstLastName, string secondLastName, string email)
        {      
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO PreOrder (firstName, secondName, firstLastName, secondLastName, email) VALUES ("+ firstName + ","+ secondName +
                "," + firstLastName+ "," + secondLastName + "," + email + ")";
            cmd.Connection = pfCon;
            connect();
            cmd.ExecuteNonQuery();
        }

        public void sendMail(string from, string body)
        {
            MailMessage mail = new MailMessage(from, "pinkflamingogames2016@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            if (from.Contains("gmail.com"))
                client.Host = "smtp.google.com";

            else if (from.Contains("hotmail.com"))
                client.Host = "smtp.live.com";
            else if (from.Contains("outlook.com"))
                client.Host = "smtp-mail.outlook.com";
            
            mail.Subject = "Hey, there!";
            mail.Body = body;
            client.Send(mail);
        }
    }
}