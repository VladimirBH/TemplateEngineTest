using TemplateEngineTest.Classes;
using Xceed.Words.NET;

namespace TemplateEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            {
                new(_userLastName: "Сазонов", _userFirstName: "Иван"),
                new(_userLastName: "Михайлов", _userFirstName: "Антон", _userMiddleName: "Иванович")
            };
            ReplaceFullName(users.Where(u => u.UserLastName == "Сазонов").First(), "Sazonov");
            ReplaceFullName(users.Where(u => u.UserLastName == "Михайлов").First(), "Mikhailov");
        }


        public static void ReplaceFullName(User user, string outputDocName)
        {
            using DocX document = DocX.Load("D:\\for_work\\Vacancy\\TemplateEngineTest\\Template.docx");
            string text = document.Text;
            string fullName = "";
            if(user.UserMiddleName != null)
            {
                fullName = user.UserLastName + " " + user.UserFirstName[0] + ". " + user.UserMiddleName[0] + ".";
            }
            else
            {
                fullName = user.UserLastName + " " + user.UserFirstName[0]+ ".";
            }
            text = text.Replace("[[GuestFullName]]", fullName);

            document.ReplaceText(document.Text, text);

            document.SaveAs("D:\\for_work\\Vacancy\\TemplateEngineTest\\" + outputDocName + ".docx");
        }
    }

}