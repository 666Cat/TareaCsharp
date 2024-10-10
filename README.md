# Guía para Configurar un Proyecto en C# con Visual Studio Code

## 1. Instalar Visual Studio Code
- Descarga e instala [Visual Studio Code](https://code.visualstudio.com/).

## 2. Instalar .NET SDK
- Descarga e instala el [.NET SDK](https://dotnet.microsoft.com/download) adecuado para tu sistema operativo. Esto incluye las herramientas necesarias para compilar y ejecutar aplicaciones en C#.

## 3. Instalar la extensión de C#
- Abre Visual Studio Code.
- Ve a la pestaña de extensiones (icono de cuadrado en la barra lateral izquierda o presiona `Ctrl+Shift+X`).
- Busca "C#" y selecciona la extensión de Microsoft (normalmente la primera en la lista).
- Haz clic en "Instalar".

## 4. Crear un nuevo proyecto
- Abre una terminal dentro de Visual Studio Code (`Ctrl+``).
- Navega a la carpeta donde quieres crear tu proyecto usando el comando `cd`.
- Ejecuta el siguiente comando para crear un nuevo proyecto de consola:

    ```bash
    dotnet new console -n NombreDelProyecto
    ```

- Cambia a la carpeta del proyecto:

    ```bash
    cd NombreDelProyecto
    ```

## 5. Abrir el proyecto en Visual Studio Code
- Puedes abrir el proyecto en Visual Studio Code usando:

    ```bash
    code .
    ```

## 6. Ejecutar el proyecto
- En la terminal, asegúrate de estar en la carpeta del proyecto y ejecuta:

    ```bash
    dotnet run
    ```

## 7. Configurar el depurador (opcional)
- Si deseas depurar tu código, puedes presionar `F5` para iniciar la depuración. Visual Studio Code generará automáticamente un archivo de configuración de depuración si es necesario.

## 8. Editar y desarrollar
- Comienza a editar tu archivo `Program.cs` o añade más archivos según lo necesites.

## 9. Agregar dependencias (opcional)
- Si necesitas añadir librerías adicionales, puedes usar:

    ```bash
    dotnet add package NombreDelPaquete
    ```
