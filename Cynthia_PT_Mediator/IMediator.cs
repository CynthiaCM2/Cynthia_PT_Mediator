using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Mediator
{
    //Se crea la interfaz de las clases//
    public interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}
