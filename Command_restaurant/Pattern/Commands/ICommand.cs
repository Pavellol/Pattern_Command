using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern.Commands
{
    // Интерфейс команды
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
