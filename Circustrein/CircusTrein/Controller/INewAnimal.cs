using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Scripts
{
    public interface INewAnimal
    {
        void ConvertToAnimal(object name, object sizeSelection, object typeSelection, ITrain train);
    }
}
