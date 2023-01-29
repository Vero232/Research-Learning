using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Factory
    {
        public static IPerson CreatePerson() {

            return new Person();

        }

        public static IChore CreateChore()
        {

            return new Chore(Createlogger(), CreateMessageSender());

        }

        public static ILogger Createlogger()
        {

            return new Logger();

        }

        public static IMessageSender CreateMessageSender()
        {

            return new Emailer();

        }
    }
}
