using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /*
            ITheme darkTheme = new DarkTheme();
            Note reminder = new ReminderNote("Don't forget the meeting!", darkTheme);
            reminder.Show();
            */

            /*
            ITheme lightTheme = new LightTheme();
            ITheme darkTheme = new DarkTheme();

            GroupNote groupNote1 = new GroupNote("Project Update", lightTheme);
            groupNote1.AddMember("Nikola");
            groupNote1.AddMember("Vanja");

            GroupNote groupNote2 = new GroupNote("Team Meeting", darkTheme);
            groupNote2.AddMember("Marina");
            groupNote2.AddMember("David");

            groupNote1.Show();
            groupNote2.Show();
            */

            ITheme lightTheme = new LightTheme();
            ITheme darkTheme = new DarkTheme();

            Notebook notebook = new Notebook(lightTheme);

            Note note1 = new Note("First note", lightTheme);
            notebook.AddNote(note1);
            Console.WriteLine("Notebook display after adding first note:");
            notebook.Display();

            Note note2 = new Note("Second note", lightTheme);
            notebook.AddNote(note2);
            Console.WriteLine("Notebook display after adding second note:");
            notebook.Display();

            notebook.ChangeTheme(darkTheme);

            Note note3 = new Note("Third note", darkTheme);
            notebook.AddNote(note3);
            Console.WriteLine("Notebook display after changing theme and adding third note:");
            notebook.Display();
        }
    }
}
