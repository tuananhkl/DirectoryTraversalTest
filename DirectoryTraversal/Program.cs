using System;
using System.IO;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNet.Mvc;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //if file name != "" and length of file name > 0
             var filePath = @"C:\Users\anh.nguyen50\helloWorld.cs";
             var fileName = @"helloWorld.cs";
            
             var maliciousFilePath = @"..\..\..\etc\passwd";
             // TestPath(maliciousFilePath);
             // Console.WriteLine(TestRegex(maliciousFilePath));
             Console.WriteLine(ReadHtml(filePath));

            // var ebookName = "Anna Karenina.epub";
            // var maliciousEbookName = "..\\Anna Karenina.epub";
            // var result = Download1(maliciousEbookName);
            // Console.WriteLine(result);
        }
        
        public static bool Download1(string ebookName)
        {
            const string PATH = "d:\\app\\web\\ebooks";
            ActionResult result = new HttpNotFoundResult();

            var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
            if (!regex.IsMatch(ebookName))
            {
                // string epub = System.IO.Path.GetFullPath(PATH + ebookName);
                // if (epub.StartsWith(PATH) && System.IO.File.Exists(epub))
                // {
                //     using (var file = System.IO.File.OpenRead(epub))
                //     {
                //         return new FileStreamResult(file, "application/octet-stream");
                //     }
                // }
                return true;
            }
            // return result;
            return false;
        }

        private static void TestPath(string filePath)
        {
            var fileName = Path.GetFileName(filePath);

            Console.WriteLine(fileName);
        }

        private static bool TestRegex(string sURLPath)
        {
            var fileName = Path.GetFileName(sURLPath);
            var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
            if (!regex.IsMatch(fileName))
            {
                return true;
            }

            return false;
        }
        
        public static string ReadHtml(string sURLPath)
        {
            var fileName = Path.GetFileName(sURLPath);
            var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
            if (!regex.IsMatch(sURLPath)) // !regex.IsMatch(fileName)
            {
                // FileInfo fi = new FileInfo(sURLPath);
                // StreamReader sr = new StreamReader(sURLPath, Encoding.ASCII);
                // string _Contents = "";
                // if (File.Exists(sURLPath))
                // {
                //     sr = File.OpenText(sURLPath);
                //     _Contents += sr.ReadToEnd();
                //     sr.Close();
                //     sr.Dispose();
                // }
                // return _Contents;
                return "true";
            }

            // return "";
            return "false";
        }

        public ActionResult Download(string ebookName)
        {
            const string PATH = "d:\\app\\web\\ebooks";
            ActionResult result = new HttpNotFoundResult();
            
            var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
            if (!regex.IsMatch(ebookName))
            {
                string epub = Path.GetFullPath(PATH + ebookName);
                if (epub.StartsWith(PATH) && File.Exists(epub))
                {
                    using (var file = File.OpenRead(epub))
                    {
                        return new FileStreamResult(file, "application/octet-stream");
                    }
                }
            }
            return result;
        }
        
        // public static bool SendAttachment(clsMailServer MailServer, string SqlConn, string sFrom, string sTo, string sEmailAdd, string sSubject, string sContent, bool bIsHTML, string sFilePath, bool Ssl)
        // {
        //     Attachment[] attach = new Attachment[1];
        //     attach[0] = new Attachment(sFilePath);
        //     MailMessage mail_msg = genEmail(SqlConn, sFrom, sTo, sEmailAdd, "", sSubject, sContent, bIsHTML, "", attach);
        //     if (mail_msg != null)
        //     {
        //         return sendEmail(MailServer, mail_msg, Ssl, SqlConn);
        //     }
        //     return false;
        //
        // }

        #region OG code

        // public static string ReadHtml(string sURLPath)
        // {
        //     var fileName = Path.GetFileName(sURLPath);
        //     var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
        //     if (!regex.IsMatch(fileName))
        //     {
        //         FileInfo fi = new FileInfo(sURLPath);
        //         StreamReader sr = new StreamReader(sURLPath, Encoding.ASCII);
        //         string _Contents = "";
        //         if (File.Exists(sURLPath))
        //         {
        //             sr = File.OpenText(sURLPath);
        //             _Contents += sr.ReadToEnd();
        //             sr.Close();
        //             sr.Dispose();
        //         }
        //         return _Contents;
        //     }
        //
        //     return "";
        // }

        #endregion
        // public static string ReadHtml(string sURLPath)
        // {
        //     var fileName = Path.GetFileName(sURLPath);
        //     var regex = new System.Text.RegularExpressions.Regex(@"\.\.|\\|\/");
        //     if (!regex.IsMatch(fileName))
        //     {
        //         FileInfo fi = new FileInfo(sURLPath);
        //         StreamReader sr = new StreamReader(sURLPath, Encoding.ASCII);
        //         string _Contents = "";
        //         if (File.Exists(sURLPath))
        //         {
        //             sr = File.OpenText(sURLPath);
        //             _Contents += sr.ReadToEnd();
        //             sr.Close();
        //             sr.Dispose();
        //         }
        //         return _Contents;
        //     }
        //
        //     return "";
        // }
        
        
    }
    
    // public class clsMailServer
    // {
    //     private string _SmtpServer = "";
    //     private string _SmtpServer_user = "";
    //     private string _SmtpServer_user_pw = "";
    //     private int _SmtpServer_Port = 25;
    //
    //     public clsMailServer()
    //     {
    //     }
    //
    //     public clsMailServer(string SmtpServer)
    //     {
    //         _SmtpServer = SmtpServer;
    //     }
    //
    //     public clsMailServer(string SmtpServer, string SmtpServer_user, string SmtpServer_user_pw, int SmtpServer_Port)
    //     {
    //         _SmtpServer = SmtpServer;
    //         _SmtpServer_user = SmtpServer_user;
    //         _SmtpServer_user_pw = SmtpServer_user_pw;
    //         _SmtpServer_Port = SmtpServer_Port;
    //
    //     }
    //
    //     public string SmtpServer
    //     {
    //         set { _SmtpServer = value; }
    //         get { return _SmtpServer; }
    //     }
    //
    //     public string SmtpServer_user
    //     {
    //         set { _SmtpServer_user = value; }
    //         get { return _SmtpServer_user; }
    //     }
    //
    //     public string SmtpServer_user_pw
    //     {
    //         set { _SmtpServer_user_pw = value; }
    //         get { return _SmtpServer_user_pw; }
    //     }
    //
    //     public int SmtpServer_Port
    //     {
    //         set 
    //         {
    //             if (value >= 0 && value <= 65535)
    //                 _SmtpServer_Port = value; 
    //         }
    //         get { return _SmtpServer_Port; }
    //     }
    //
    // }
}