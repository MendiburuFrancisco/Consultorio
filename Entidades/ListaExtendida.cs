using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaExtendida<T>:List<T>
    {
 
        /// <summary>
        /// Se agregan elementos a la lista
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static ListaExtendida<T> operator +(ListaExtendida<T> left, T right)
        {
            var nuevaLista = new ListaExtendida<T>();

            left.ForEach(elemento => nuevaLista.Add(elemento));
            nuevaLista.Add(right);

            return nuevaLista;
        }

        /// <summary>
        /// Devuelvo los elementos de la lista extendida de manera aleatoria
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public static T devolverElementoAleatorio(ListaExtendida<T> left)
        {

           int cantidadElementos = left.Count();
           int numeroRandom = new Random().Next(0, cantidadElementos);

            return left.ElementAt(numeroRandom);


        }

    }
}
