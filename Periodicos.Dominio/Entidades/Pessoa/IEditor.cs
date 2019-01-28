using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Pessoa
//
using Periodicos.Dominio.Entidades.Periodico;
//

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public interface IEditor
        : IPessoa
    {
        IArtigo EncaminharArtigo(IArtigo artigo);
        IEdicao CriarEdicao(IEdicao numero);
    }
}
