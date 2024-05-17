using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class GroupNote : Note
    {
        private List<string> groupMembers;

        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.groupMembers = new List<string>();
        }

        public void AddMember(string name)
        {
            this.groupMembers.Add(name);
        }

        public void RemoveMember(string name)
        {
            this.groupMembers.Remove(name);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROUP NOTE: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.WriteLine("Group Members: " + string.Join(", ", groupMembers));
            Console.ResetColor();
        }
    }
}
