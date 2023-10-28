using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Mediator
{
    //Se crea una clase abstracta donde estaran los objetos de comunicacion//
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator
        {
            get;
        }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Comunicate(string message)
        {
            this.mediator.Send(message,this);
        }

        public abstract void Receive(string message);
    }
}
