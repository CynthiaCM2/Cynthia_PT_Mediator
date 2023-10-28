using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Mediator
{
    //Se crea un usuario admin con sus funcionalidades y los mensajes que enviara//
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {

        }
        public override void Receive(string message)
        {
            Console.WriteLine("Un administrador recibe: "+message);
            Console.WriteLine("Se notifico por email");
        }

    }
}
