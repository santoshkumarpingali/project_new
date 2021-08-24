using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Creating_Directory_and_text_file
{
    public partial class sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createfolder(object sender, EventArgs e)
        {
            string location = @"D:/SS";
            string path = System.IO.Path.Combine(location, "created folder");
            System.IO.Directory.CreateDirectory(path);

            //createtextfile();
            gettextfile();
        }
        protected void createtextfile()
        {
            string location = @"D:/SS/created folder";
            string file = System.IO.Path.Combine(location, "Sample");
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
                string message = string.Empty;
                message = "Folder and Text file is Created ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
            }
            else
            {
                string message = string.Empty;
                message = "Text file is already Created";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
            }
            // create_text_in_textfile();
            gettextfile();
        }
        protected void create_text_in_textfile()
        {

            StreamWriter sw = new StreamWriter("D:/SS/created folder//Sample.text");
            //StreamWriter sw = new StreamWriter("myfile.text");

            sw.Write("Hello World!!");
            sw.Close();


        }
        public void gettextfile()
        {
            string fileName = @"D:/SS/created folder/Sample.txt";
            FileInfo fi = new FileInfo(fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    string message = string.Empty;
                    message = "Text file is already Created";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);

                }

                else
                {
                    // Create a new file     
                    using (StreamWriter sw = fi.CreateText())
                    {
                        
                        sw.WriteLine("Hello World");
                        sw.WriteLine("Welocome to JENKINS !!!");

                    }

                    // Write file contents on console.     
                    //using (StreamReader sr = File.OpenText(fileName))
                    //{
                    //    string s = "";
                    //    while ((s = sr.ReadLine()) != null)
                    //    {
                    //        Console.WriteLine(s);
                    //    }
                    //}
                    string message = string.Empty;
                    message = "Folder and Text file is Created ";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);


                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}