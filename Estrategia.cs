
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
            string url = arbol.getDatoRaiz().Nombre.Trim();
            return RecorridoSeoPorId(arbol, id, url);
        }

        private string RecorridoSeoPorId(ArbolGeneral<ItemCat> arbol, int id, string url)
        {
            foreach (var x in arbol.getHijos())
            {
                string nuevaUrl = url + "/" + x.getDatoRaiz().Nombre.Trim();

                if (x.getDatoRaiz().Tipo == TipoElemento.Producto)
                {
                    if (x.getDatoRaiz().Id == id)
                    {
                        return nuevaUrl;
                    }
                }
                else
                {
                    string resultado = RecorridoSeoPorId(x, id, nuevaUrl);

                    if (resultado != "")
                    {
                        return resultado;
                    }
                }
            }

            return "";
        }
        

        public List<string> GetURLsSEO(ArbolGeneral<ItemCat> arbol)
		{
			List<string> urls=new List<string>();
			string url=""+arbol.getDatoRaiz().Nombre.Trim();
			if (arbol.esHoja()) {
				return urls;
			}else{
				recorrido(arbol,urls,url);
			}

			return urls;
		}

        public static void recorrido(ArbolGeneral<ItemCat> arbol,List<string> urls,string url)
		{
			foreach (var x in arbol.getHijos()) {
				if (x.getDatoRaiz().Tipo==TipoElemento.Producto ) {
					urls.Add(url+"/"+x.getDatoRaiz().Nombre.Trim());
				}else{
					recorrido(x,urls,url+"/"+x.getDatoRaiz().Nombre.Trim());
				}
			}
		}
        
        public List<List<string>> ConsultaNiveles(ArbolGeneral<ItemCat> arbol)
		{
            return [["Implementar"]];
        }


        public List<ItemCat> Todos(ArbolGeneral<ItemCat> arbol)
        {
            List<ItemCat> productos=new List<ItemCat>();
			if (arbol.esHoja()) {
				return productos;
			}else{
				agruparProd(arbol,productos);
			}
			 
			return productos;
        }

        private void agruparProd(ArbolGeneral<ItemCat> arbol,List<ItemCat> productos)
		{
			foreach (ArbolGeneral<ItemCat> X in arbol.getHijos()) {
				if (X.getDatoRaiz().Tipo== TipoElemento.Producto && X.getDatoRaiz != null) { 
						productos.Add(X.getDatoRaiz());
				}else{
					agruparProd(X,productos);
				}
			}
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
            List<ItemCat> resultados=new List<ItemCat>();
			if (arbol.esHoja()) {
				return resultados;
			}else{
				_busqueda(arbol,elementoABuscar.ToLower().Trim(),resultados);
			}
			 
			return resultados;
		}
        private void _busqueda(ArbolGeneral<ItemCat> arbol,string elemento,List<ItemCat> resultados)
		{
			foreach (ArbolGeneral<ItemCat> X in arbol.getHijos()) {
				if (X.getDatoRaiz().Tipo== TipoElemento.Producto) { 
					if ((X.getDatoRaiz() != null) && (X.getDatoRaiz().Nombre.ToLower().Trim().Contains(elemento))) {
						resultados.Add(X.getDatoRaiz());
					}
				}else{
					_busqueda(X,elemento,resultados);
				}
			}
		}
            
    }
}