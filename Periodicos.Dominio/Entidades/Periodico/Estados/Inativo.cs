﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Periodicos.Dominio.Entidades.Periodico.Estados
{
    public class Inativo
        : IEstado
    {
        //Inicializa o construtor da classe abstrata
        public Inativo(IArtigo artigo)
            : base(artigo){}

        /// <summary>
        /// Metodo nao deve ser utilizado, pois Aceito é um estado final
        /// </summary>
        public override void ProximoEstado()
        {
            throw new Exception("Aceito é um estado final!");
        }
    }
}
