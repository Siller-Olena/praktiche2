using System.Collections.Generic;

namespace Schoolsearch
{//клас 'Teacher' є похідним від класу 'Person'
    public class Teacher : Person
    {
        private int classroom;
        
        public int Classroom { get => classroom; }//властивості до сlassroom, тільки для прочитання
        
        public Teacher(string aLastName, string aFirstName, int aClassroom) : base(aLastName, aFirstName, PersonType.PT_Teacher)
        {//конструктор класу
            classroom = aClassroom;//задаються приватні змінні
        }

        public override string GetFormatedHeader()//абстрактні методи класу 'Person' реалізовано та переписано для похідного класу 'Teacher'     
        {//метод класу 'Teacher' який повертає рядок заголовку вихідної таблиці у вигляді рядка
            string data = "╔════════════╦═════════════════════════╦═════════════════════════╦════════════╗\r\n";
            data += string.Format("║{0,-12}║{1,-25}║{2,-25}║{3,-12:0}║\r\n", "  Type", " LastName", " Firstname", " Classroom");
            data += "╠════════════╬═════════════════════════╬═════════════════════════╬════════════╣";
            return data;
        }

        public override string GetFormatedData()
        {// метод класу 'Teacher'що виводить данні про Teacher у вигляді рядка таблиці
            return string.Format("║{0,-12}║{1,-25}║{2,-25}║{3,-12:0}║", " Teacher", " "+LastName, " "+FirstName, "    " +Classroom);
        }
    }
}
