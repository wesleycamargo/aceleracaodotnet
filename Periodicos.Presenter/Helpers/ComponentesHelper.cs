using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using Periodicos.Dominio.Entidades;
using Base.Colecoes;
using Periodicos.Dominio.Entidades.Pessoa;

namespace Periodicos.Presenter.Helpers
{
    public class ComponentesHelper
    {
        /// <summary>
        /// Direciona 
        /// </summary>
        /// <param name="botao"></param>
        /// <param name="e"></param>
        public static void ComponenteFocus(Button botao, KeyPressEventArgs e, int teclaAsc)
        {            
            if (e.KeyChar.Equals(teclaAsc))
                botao.PerformClick();
        }

        /// <summary>
        /// Adiciona um lista de pessoas ao ListView
        /// </summary>
        /// <param name="autor">Lista de pessoas</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(Lista<IAutor> autor, ListView listView)
        {
            while (autor.ContemProximo())
            {
                IAutor pessoa = (IAutor)autor.Proximo();
                AdicionaItemListView(pessoa, listView);
            }

            return listView;
        }

        /// <summary>
        /// Adiciona uma pessoa ao listview
        /// </summary>
        /// <param name="pessoa">Pessoa</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(IAutor pessoa, ListView listView)
        {
            AdicionaItemListView(pessoa.Nome, listView);

            return listView;
        }

        /// <summary>
        /// Adiciona uma lista de strings ao listview
        /// </summary>
        /// <param name="lista">Lista de Strings</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(Lista<String> lista, ListView listView)
        {
            while (lista.ContemProximo())
            {
                String value = (String)lista.Proximo();
                AdicionaItemListView(value, listView);
            }

            return listView;
        }

        /// <summary>
        /// Adiciona uma string ao listview
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(String value, ListView listView)
        {
            listView.Items.Add(value);

            return listView;
        }

        /// <summary>
        /// Adiciona um lista de pessoas ao ListView
        /// </summary>
        /// <param name="autor">Lista de pessoas</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(Lista<IAutor> autor, ListView listView, ImageList imgList, int indiceImagem)
        {
            while (autor.ContemProximo())
            {
                IAutor pessoa = (IAutor)autor.Proximo();
                AdicionaItemListView(pessoa, listView);
            }

            return listView;
        }

        /// <summary>
        /// Adiciona uma pessoa ao listview
        /// </summary>
        /// <param name="pessoa">Pessoa</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(IAutor pessoa, ListView listView, ImageList imgList, int indiceImagem)
        {
            AdicionaItemListView(pessoa.Nome, listView);

            return listView;
        }

        /// <summary>
        /// Adiciona uma lista de strings ao listview
        /// </summary>
        /// <param name="lista">Lista de Strings</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(Lista<String> lista, ListView listView, ImageList imgList, int indiceImagem)
        {
            while (lista.ContemProximo())
            {
                String value = (String)lista.Proximo();
                AdicionaItemListView(value, listView);
            }

            return listView;
        }

        /// <summary>
        /// Adiciona uma string ao listview
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="listView">ListView</param>
        public static ListView AdicionaItemListView(String value, ListView listView, int indiceImagem)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new Exception("O valor não poder ser nulo ou em branco");
            }            
            listView.Items.Add(value, indiceImagem);

            return listView;
        }


        /// <summary>
        /// Adiciona um subitem no list view
        /// </summary>
        /// <param name="itemListView">Indice do item que deseja adicionar subitem</param>
        /// <param name="value">Valor do subitem</param>
        /// <param name="listView">ListView</param>
        /// <returns></returns>
        public static ListView AdicionaSubItemListView(int itemListView, String value, ListView listView)
        {
            listView.Items[itemListView].SubItems.Add(value);

            return listView;
        }

        /// <summary>
        /// Adiciona um subitem no list view
        /// </summary>
        /// <param name="key">Item que deseja adicionar subitem</param>
        /// <param name="value">Valor do subitem</param>
        /// <param name="listView">ListView</param>
        /// <returns></returns>
        public static ListView AdicionaSubItemListView(String key, String value, ListView listView)
        {
            listView.Items[key].SubItems.Add(value);

            return listView;
        }

        /// <summary>
        /// Remove os itens selecionados do ListView
        /// </summary>
        /// <param name="listView">ListView</param>
        public static ListView RemoverItemListView(ListView listView)
        {
            if (listView.SelectedItems.Count.Equals(0))
            {
                throw new Exception("Não existem itens selecionados");
            }

            for (int i = 0; i < listView.SelectedItems.Count; i++)
            {
                listView.Items.Remove(listView.SelectedItems[i]);
            }
            
            return listView;
        }

        /// <summary>
        /// Converte os itens de um listview para uma lista de strings
        /// </summary>
        /// <param name="listview">ListView</param>
        /// <returns>Lista de strings</returns>
        public static Lista<String> ListViewToLista(ListView listview)
        {
            Lista<String> retorno = new Lista<String>();

            for (int i = 0; i < listview.Items.Count; i++)
            {
                retorno.Adicionar(listview.Items[i].Text);
            }
            return retorno;
        }
    }
}
