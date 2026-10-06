
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using tp1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tpfinal
{

	public class Estrategia
	{
		
		public string GetUrlSeoPorId(ArbolGeneral<ItemCat> arbol, int id)
        {
            return "Implementar";
        }
        

        public List<string> GetURLsSEO(ArbolGeneral<ItemCat> arbol)
		{
			return ["Implementar"];
		}
        

              

        public List<List<string>> ConsultaNiveles(ArbolGeneral<ItemCat> arbol)
		{
            return [["Implementar"]];
        }


        public List<ItemCat> Todos(ArbolGeneral<ItemCat> arbol)
        {
            return  [];
        }

        public void Agregar(ArbolGeneral<ItemCat> arbol, ItemCat dato, string rutaAlPadre)// 
		{
            List<string> ruta = new List<string>(rutaAlPadre.Split('/'));
            ArbolGeneral<ItemCat> actual= arbol;
            int i=0;
            while (i<ruta.Count())
            {
                ArbolGeneral<ItemCat> siguiente=encontrarHijo(actual,ruta[i]);
                if (siguiente== null)
                {
                    break;
                }
                i++;
                actual=siguiente;
            }

            for (int x = i; x < ruta.Count(); x++)
            {
                ItemCat nodo= new ItemCat(ruta[x],TipoElemento.Categoria);
                ArbolGeneral<ItemCat> nuevo= new ArbolGeneral<ItemCat>(nodo);
                actual.agregarHijo(nuevo);
                actual=nuevo;
            }

            actual.agregarHijo(new ArbolGeneral<ItemCat>(dato));
        }
        private ArbolGeneral<ItemCat> encontrarHijo(ArbolGeneral<ItemCat> arbol,string dato)
        {
            foreach (ArbolGeneral<ItemCat> hijo in arbol.getHijos())
            {
                if (hijo.getDatoRaiz().Nombre==dato)
                {
                    return hijo;
                }
            }
            return null;
        }

        public List<ItemCat> Buscar(ArbolGeneral<ItemCat> arbol, string elementoABuscar)
		{
			return [];
		}
            
    }
}