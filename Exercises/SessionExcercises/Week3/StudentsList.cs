using System.Collections.Generic;

namespace Exercises
{
    public class StudentsList
    {
        public List<string> GetStudentList()
        {
            List<string> studentNames = new List<string>
            {
            "Alexandru Chiperi",
            "Alexandru Cotorogea",
            "Csilla Maria Istvan",
            "Daniel Rusu",
            "Ecaterina Cornelia Comardicea",
            "Florin Orban",
            "Gabriel Mihalcea",
            "Dalmina Prejmerean",
            "Alexandra Grigorescu",
            "Claudiu Grigorescu",
            "Denisa Moldoveanu",
            "Nicolae Cacior-Salistean",
            "Chriss Ercau"
            };

            studentNames.Add("Razvan Rusnac");
            studentNames.Add("Silviu Hisom");

            return studentNames;
        }
    }
}

