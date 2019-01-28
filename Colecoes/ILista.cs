using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Colecoes
{
    public interface ILista<T> 
        : IIterator
        where T : class
    {
        #region Propriedades

        int Tamanho { get; }

        #endregion

        #region Metodos

        void Adicionar(T item);
        void Remover(T item);
        void Remover(int posicao);
        T Buscar(T item);
        T Buscar(int posicao);
        bool Existe(T item);
        void Limpar();

        #endregion
    }
}
