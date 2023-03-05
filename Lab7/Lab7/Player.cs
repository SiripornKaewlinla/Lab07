using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7
{
    public class Player
    {
        private string Name, Lastname, Game, Mail, Number;

        private int age = 0;



        public Player(string Name, string Lastname, string Game, string Mail, string Number, int Age)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Game = Game;
            this.Mail = Mail;
            this.Number = Number;
            this.age = Age;
        }
    }
}
