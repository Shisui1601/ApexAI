# 📚 ApexAI
*ApexAI* es un aplicativo de tecnología desarrollado con ASP.NET MVC que utiliza una base de datos SQL Server. El sistema está diseñado para gestionar información detallada sobre autores, categorías, libros y ventas, proporcionando una solución integral y eficiente para la gestión de datos.

## 🔗 Características
- *Tecnologías Utilizadas*:
  - **ASP.NET MVC**: Framework principal para el desarrollo de la aplicación web.
  - **C#**: Lenguaje de programación utilizado para la lógica del servidor.
  - **SQL Server**: Sistema de gestión de bases de datos para almacenar y recuperar información.
  - **HTML/CSS/JavaScript**: Tecnologías web para el diseño y funcionalidad de la interfaz de usuario.

## ♟ Estructura del Proyecto
- *Carpeta Principal*: ApexAI
- *Subcarpetas y Archivos Clave*:
  - **Controllers/** - Controladores de la aplicación.
  - **Models/** - Modelos de datos y clases de entidad.
  - **Views/** - Vistas de la aplicación para la presentación de datos.
  - **Scripts/** - Archivos y librerías JavaScript.
  - **Styles/** - Archivos CSS para el diseño y estilo.
  - **.gitignore** - Archivo de configuración para ignorar archivos no deseados en Git.
  - **LICENSE** - Archivo de licencia del proyecto.
  - **README.md** - Documento con información del proyecto.

## 📊 Estructura de la Base de Datos

El proyecto cuenta con las siguientes tablas:

### Autores
- **ID**: Identificador único del autor.
- **Nombre**: Nombre del autor.
- **Apellido**: Apellido del autor.
- **Biografía**: Información biográfica del autor.

### Categorías
- **ID**: Identificador único de la categoría.
- **Nombre**: Nombre de la categoría.
- **Descripción**: Descripción de la categoría.

### Libros
- **ID**: Identificador único del libro.
- **Título**: Título del libro.
- **ISBN**: Número ISBN del libro.
- **AutorID**: Identificador del autor (clave foránea).
- **CategoríaID**: Identificador de la categoría (clave foránea).
- **Precio**: Precio del libro.
- **FechaPublicación**: Fecha de publicación del libro.

### Ventas
- **ID**: Identificador único de la venta.
- **LibroID**: Identificador del libro (clave foránea).
- **Cantidad**: Cantidad de libros vendidos.
- **FechaVenta**: Fecha de la venta.
- **PrecioTotal**: Precio total de la venta.

## 🐱‍👤 Instalación
1. Clona el repositorio:
    ```bash
    git clone https://github.com/Shisui1601/ApexAI.git
    ```
2. Navega a la carpeta del proyecto:
    ```bash
    cd ApexAI
    ```
3. Abre el proyecto en Visual Studio o tu IDE preferido.
4. Restaura las dependencias del proyecto y configura la base de datos.
5. Configura el archivo `appsettings.json` con los detalles de conexión de tu SQL Server.
6. Ejecuta la aplicación y verifica que se despliega correctamente en tu entorno local.

## 📔 Licencia
Este proyecto está licenciado bajo la [Licencia MIT](./LICENSE).

## 💎 Contribuciones
Las contribuciones son bienvenidas. Si deseas contribuir al proyecto, sigue estos pasos:
1. Haz un fork del repositorio.
2. Crea una rama para tu funcionalidad o corrección de errores (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -am 'Añadir nueva funcionalidad'`).
4. Empuja tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un pull request en GitHub.
