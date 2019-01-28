using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Colecoes
{
    /// <summary>
    /// Representa um conjunto de objetos 
    /// </summary>
    /// <typeparam name="T">Uma classe do tipo object</typeparam>
    public class Lista<T>
        : ILista<T>
        where T : class
    {
        #region Atributos

        /// <summary>
        /// Um array de tipo generico
        /// </summary>
        private T[] array;

        /// <summary>
        /// Posicao utilizada para percorrer a lista
        /// </summary>
        private int posicao;

        #region Propriedades

        /// <summary>
        /// Retorna a quantidade de posições do array
        /// </summary>
        public int Tamanho { get; internal set; }

        #endregion

        #endregion

        #region Construtores

        /// <summary>
        /// Cria uma instancia de uma lista generica
        /// </summary>
        /// <param name="tamanho">Tamanho inicial da lista</param>
        public Lista(int tamanho)
        {
            Limpar();

            Tamanho = tamanho;
            this.array = new T[this.Tamanho];
            this.posicao = 0;
        }

        /// <summary>
        /// Cria uma instancia de uma lista generica
        /// </summary>
        public Lista()
        {
            Limpar();
        }

        #endregion

        #region Metodos privados

        /// <summary>
        /// Aumenta a quantidade de posições da lista em 1
        /// </summary>
        private int AtualizarTamanho(bool incrementar)
        {
            T[] NovoArray = new T[this.array.Length + 1];

            array = MoverItens(array, NovoArray);

            return this.Tamanho++;
        }

        /// <summary>
        /// Remove os itens nulos da lista
        /// </summary>
        private int AtualizarTamanho()
        {
            int naoNulos = 0;

            //Verifica a quantidade de itens não nulos para criar um novo array
            for (int i = 0; i < array.Length; i++)
                if (array[i] != null)
                    naoNulos++;

            T[] NovoArray = new T[naoNulos];

            array = MoverItens(array, NovoArray);

            //Atualiza a propriedade de tamanho da lista
            return this.Tamanho = array.Length;
        }

        /// <summary>
        /// Move os itens de um  array ao outro
        /// </summary>
        /// <param name="De">Array de origem dos dados</param>
        /// <param name="Para">Array de destino dos dados</param>
        /// <returns>Array 'para' preenchido com os dados</returns>
        private T[] MoverItens(T[] De, T[] Para)
        {
            int posicaoPara = 0;

            for (int posicaoDe = 0; posicaoDe < De.Length; posicaoDe++)
                if (De[posicaoDe] != null)
                {
                    Para[posicaoPara] = De[posicaoDe];
                    posicaoPara++;
                }

            return Para;
        }

        #endregion

        #region Metodos Publicos

        #region ILista

        /// <summary>
        /// Adiciona um novo item na lista
        /// </summary>
        /// <param name="item">Item a ser adicionado</param>
        public void Adicionar(T item)
        {
            if (item == null)
                throw new Exception("A lista não pode receber itens nulos");
            AtualizarTamanho(true);
            this.array[Tamanho - 1] = item;
        }

        /// <summary>
        /// Remove o item informado da lista
        /// </summary>
        /// <param name="item">Item a remover</param>        
        public void Remover(T item)
        {
            int posicao = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(item))
                    posicao = i + 1;

            if (!posicao.Equals(0))
                Remover(posicao);

            else
                throw new Exception(String.Format(
                                                "Não foi possivel remover o item: {0}\nItem não encontrado!"
                                                , item.ToString()));
        }

        /// <summary>
        /// Remove um item da lista com a posição especificada
        /// </summary>
        /// <param name="posicao">Posição que deseja remover</param>
        public void Remover(int posicao)
        {
            if (posicao > Tamanho || posicao < 1)
                throw new Exception(String.Format(
                                                    "Não foi possivel remover o item: {0}\nPosição inexistente!"
                                                    , posicao.ToString()));
            else
                array[posicao - 1] = null;

            AtualizarTamanho();
        }

        /// <summary>
        /// Busca o item na lista com a posição informada
        /// </summary>
        /// <param name="posicao">Posição desejada</param>
        /// <returns>Item da posição informada</returns>
        public T Buscar(int posicao)
        {
            if (posicao < Tamanho)
                return array[posicao];
            else
                return null;
        }

        /// <summary>
        /// Busca na lista o item recebido como parametro
        /// </summary>
        /// <param name="item">Item a ser procurado na lista</param>
        /// <returns>Caso encontre, o item procurado, se não encontrar retorna null</returns>
        public T Buscar(T item)
        {
            T retorno = null;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                    retorno = array[i];
            }

            return retorno;
        }

        public bool Existe(T item)
        {
            T resultado = this.Buscar(item);
            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Limpa os itens do array
        /// </summary>
        public void Limpar()
        {
            this.Tamanho = 0;
            this.array = new T[this.Tamanho];
            this.posicao = 0;
        }

        #endregion

        #region IIterator

        /// <summary>
        /// Retorna a próxima posição da lista
        /// </summary>
        /// <returns>O próximo item não percorrido</returns>
        public object Proximo()
        {
            return array[posicao++];
        }

        /// <summary>
        /// Verifica se existem itens não percorridos na lista
        /// </summary>
        /// <returns>True, caso existam itens; False, caso não existam</returns>
        public bool ContemProximo()
        {
            if (posicao >= array.Length || array[posicao] == null)
            {
                //Quando não encontrar próximos itens, zera o contador que percorre o array
                posicao = 0;
                return false;
            }
            else
                return true;
        }

        #endregion

        #endregion               
    }
}
