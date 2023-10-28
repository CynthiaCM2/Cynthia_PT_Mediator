using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Mediator
{
    //Se crea otro usuario con sus funciones también con su respectivo mensaje//
    class User : IColleague
    {
        public User(IMediator mediator) : base(mediator)
        {
            
        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un usuario recibe: " +message);
        }
    }
}
