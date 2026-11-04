Trabajo Final: Algoritmos y Estructuras de Datos

Este repositorio contiene la resolución del Trabajo Final Práctico (TFP) de la materia Algoritmos y Estructuras de Datos. El proyecto consiste en la implementación de un catálogo de productos para una plataforma de comercio electrónico utilizando Árboles Generales.

📌 Introducción

Los Árboles Generales son fundamentales en el diseño de catálogos (sistemas PIM) para plataformas de comercio electrónico. Permiten representar estructuras jerárquicas dinámicas y asimétricas, donde:

Raíz: Representa el catálogo completo de la tienda.

Nodos internos: Representan categorías y subcategorías (ej. Electrónica, Computadoras).

Hojas: Corresponden a las categorías más específicas o productos finales.

Esta estructura facilita la navegación, la generación de URLs amigables (SEO) y las búsquedas eficientes.

💻 Tarea a Desarrollar

El proyecto parte de una API REST base proporcionada por la cátedra. El objetivo principal es completar la clase Estrategia implementando los siguientes métodos para operar sobre la estructura de datos ArbolGeneral<ItemCat>:

Métodos a Implementar

Agregar

void Agregar(ArbolGeneral<ItemCat> arbol, ItemCat dato, string rutaAlPadre)


Inserta un nuevo elemento en el árbol. Si la rutaAlPadre no existe, el método crea automáticamente los nodos necesarios antes de insertar el nuevo elemento.

Buscar

List<ItemCat> Buscar(ArbolGeneral<ItemCat> arbol, string elementoABuscar)


Retorna todos los elementos del árbol cuyo nombre contenga la cadena de búsqueda (de forma total o parcial).

Todos

List<ItemCat> Todos(ArbolGeneral<ItemCat> arbol)


Retorna una lista con todos los productos almacenados en el árbol.

GetURLsSEO

List<string> GetURLsSEO(ArbolGeneral<ItemCat> arbol)


Retorna todas las URLs amigables generadas desde la raíz hasta cada hoja (ej. tienda.com/electronica/computadoras/laptops/gaming).

GetUrlSeoPorId

string GetUrlSeoPorId(ArbolGeneral<ItemCat> arbol, int id)


Retorna la URL amigable correspondiente al elemento cuyo identificador coincida con el parámetro recibido.

ConsultaNiveles

List<List<string>> ConsultaNiveles(ArbolGeneral<ItemCat> arbol)


Retorna los elementos del árbol agrupados por nivel, comenzando por la raíz.

📅 Entregas y Evaluación

El proyecto se divide en dos instancias de entrega:

Primera Entrega: Versión con alcance limitado. Incluye una breve entrevista con el docente para exponer avances y la posible resolución en vivo de funcionalidades reducidas.

Segunda Entrega: Versión final y completa. Requiere exposición presencial del funcionamiento y, al igual que en la primera, la resolución en vivo de requerimientos adicionales bajo supervisión docente.

[!WARNING]
Condiciones de Aprobación: La imposibilidad de implementar satisfactoriamente las funcionalidades en vivo solicitadas por el docente implicará la desaprobación. El desempeño es individual y la calificación final puede variar entre los miembros del grupo.

📝 Presentación Final

Para la exposición de la segunda entrega, se incluye una presentación con:

Datos de los integrantes.

Código fuente de los métodos (sin comentarios).

Ideas de mejora o propuestas para versiones avanzadas.

Reflexión/conclusión sobre la experiencia del proyecto.

👥 Integrantes del Grupo

Facundo Della Vedova

Eitan Zarate 

Fernando Zarazola
