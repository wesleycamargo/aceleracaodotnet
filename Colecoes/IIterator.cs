using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Colecoes
{
    public interface IIterator
    {
        #region Metodos

        object Proximo();
        Boolean ContemProximo();
        
        #endregion    
    }
}
