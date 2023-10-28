using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Mediator
{
    //La clase de mediador servirá para crear la conexión entre los usuariso que se insertaran e intercambiaran mensajes//
    class Mediator : IMediator
    {
        private List<IColleague> colleagues;

        public Mediator()
        {
            colleagues = new List<IColleague>();
        }
        
        public void Add(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }


        public void Send(string message, IColleague colleague)
        {
            foreach (var c in this.colleagues)
            {
                if (colleague != c)
                {
                    c.Receive(message);
                }

            }
        }
    }
}
