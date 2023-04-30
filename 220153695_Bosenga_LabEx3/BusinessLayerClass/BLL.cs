using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerClass;

namespace BusinessLayerClass
{
    public class BLL
    {
        //class of the data layer
        DLL data = new DLL();
        //class to calculate the age
        Age age = new Age();
        //class to generate the email
        Email email = new Email();
        public BLL() { }
        //Function that return the email from the class email
        public string DisplayEmail(string name, string surname)
        {
            return email.GenerateEmail(name,surname);
        }
        //Function that return the age using the class age
        public string DisplayAge(string id)
        {
            return age.CalculateAge(id);
        }
        //A void function that will write the age and the email into the database using class of the data layer
        public void WriteToDatabase(string id, string name, string surname, string email, string age)
        {
            data.WriteToDB(id, name, surname, email, age);
        }
        //Function that helps us to read in the business logic layer
        public List<string> ReadFromDataBase()
        {
            DataTable dataTable = data.GetTable();
            List<string> membersData = new List<string>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string row = "";
                var rows = dataTable.Rows[i].ItemArray;
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    row += rows[j].ToString() + "; \t";
                }
                membersData.Add(row);  
            }
            return membersData;
        }
    }
}
