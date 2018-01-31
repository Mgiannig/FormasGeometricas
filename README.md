Comentarios generales sobre la producción

Patrón utilizado: MVC + Business Layer. 

Consideré adecuado no imprimir código HTML directamente desde la clase FiguraGeometrica, como estaba originalmente en la prueba, debido a lo difícil que suele ser darle mantenimiento a esos casos. 

Para solucionar esto, utilicé vistas Razor (cshtml) que toman valores seteados en el model From.cs.
Las propiedades de la figura geométrica se encuentran en el modelo FormaEdit.cs

Utilicé la clase FormaGeometrica para albergar los métodos de cálculo del área y perímetro de las figuras ingresadas por el usuario. La clase TipoForma se utiliza para dar referencia entre los nobmres y los tipos de id de las formas. Un cambio principal que le hice a los métodos de cálculo fue hacer que solo tengan un return, en lugar de uno por caso.

Utilizando una interfaz dinámica, el usuario puede elegir la cantidad y tipos de figuras que desea reportar. Los campos de texto disponibles varían según la figura elegida por el usuario (por ejemplo, para trapecio aparecen más campos de texto). Para lograr esto, utilicé Jquery.

Solo las figuras creadas por el usuario en el momento pasarán al reporte, por lo que este puede optar por eliminarlas con el botón. Las figuras con datos vacíos no serán tomadas en cuenta en el reporte.

El reporte se genera en una tabla de HTML según lo que el usuario elija. Si bien las tablas ya no son tan utilizadas, consideré que serían adecuadas para mostrar información sencilla en este caso. 
En lugar de declarar acumuladores, utilicé LINQ para mostrar la cantidad y tipo de figuras reportadas. 

Consideré que es muy poco mantenible repetir todos los párrafos en diferente idioma. Por lo que se me ocurrió dejar la base para la implementación de un método llamado GetLang. De esta manera podemos encerrar todos los string de la solución en este método. Por ejemplo GetLang("Bienvenido") para que se traduzcan automáticamente. 

No me ha tocado trabajar con Unit testing aun. Sin embargo, estuve investigando sobre estos. Creo que debido a los cambios realizados los unit testing existentes no son del todo válido. Podrían confexionarse nuevos tests sobre los métodos de calculo de área y perímetro.

Sobre el desafio en general: Me agradó la libertad que se le da al aplicante para realizar el challenge. Quizás al principio me limitaba un poco la existencia de los tests.


