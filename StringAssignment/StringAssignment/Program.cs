using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Hi, ";
            string two = "my name is ";
            string three = "grady.";
            Console.WriteLine(one + two + three.ToUpper());
            StringBuilder IF = new StringBuilder("If you can keep your head when all about you\nAre losing theirs and blaming it on you, ");
            IF.Append("If you can trust yourself when all men doubt you,\nBut make allowance for their doubting too; ");
            IF.Append("\nIf you can wait and not be tired by waiting,\nOr being lied about, don't deal in lies,\nOr being hated, don't give way to hating,\nAnd yet don't look too good, nor talk too wise");
            IF.Append("\nIf you can dream - and not make dreams your master;\nIf you can think - and not make thoughts your aim;\nIf you can meet with Triumph and Disaster\nAnd treat those two impostors just the same; ");
            IF.Append("\nIf you can bear to hear the truth you've spoken\nTwisted by knaves to make a trap for fools,\nOr watch the things you gave your life to, broken,\nAnd stoop and build 'em up with worn-out tools");
            IF.Append("\nIf you can make one heap of all your winnings\nAnd risk it on one turn of pitch - and - toss,\nAnd lose, and start again at your beginnings\nAnd never breathe a word about your loss; ");
            IF.Append("\nIf you can force your heart and nerve and sinew\nTo serve your turn long after they are gone,\nAnd so hold on when there is nothing in you\nExcept the will which says to them: 'Hold on!'");
            IF.Append("\nIf you can talk with crowds and keep your virtue,\nOr walk with Kings - nor lose the common touch,\nIf neither foes nor loving friends can hurt you,\nIf all men count with you, but none too much; ");
            IF.Append("\nIf you can fill the unforgiving minute\nWith sixty seconds' worth of distance run,\nYours is the Earth and everything that's in it,\nAnd - which is more - you'll be a Man, my son!”");
            Console.WriteLine(IF);

            Console.ReadLine();
        }
    }
}
