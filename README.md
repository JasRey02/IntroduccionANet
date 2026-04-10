# Mi Curso de Aprendizaje

Curso de Aprendizaje de Introduccion a .NET impartido por el profesor Amin Espinoza.
En este curso hemos aprendido lo basico de .NET, arreglos, tipos de datos, clases, clases estaticas, interfaces, condiciones, hemos aprendido a realizar archivos json para depurar en VS Code, tambien aprendidos a publicar y generar un ejecutable.
Puedes revisarlo tiene muy buenos ejemplos que te ayudaran a iniciar en el mundo de .NET.

---

# 📦 Cómo publicar un proyecto C# y generar un ejecutable (.exe)

Este documento explica paso a paso cómo compilar y publicar un proyecto de consola en C# para generar un archivo ejecutable `.exe`, utilizando la terminal en Visual Studio Code, este ejemplo se a realizado para el proyecto denominado Nuget solo para explicar los pasos detallados para publicar y generar un ejecutable.

---

## 📁 1. Ubicarse en la carpeta del proyecto

Tu proyecto está dentro de una carpeta llamada `Nuget`.

En la terminal, navega hacia esa carpeta:

```bash
cd ruta/donde/esta/Nuget
```

Ejemplo en Windows:

```bash
cd C:\Users\TuUsuario\Documents\Nuget
```

---

## 🔨 2. Compilar el proyecto

Antes de publicar, asegúrate de que el proyecto compile correctamente:

```bash
dotnet build
```

Si no hay errores, puedes continuar.

---

## 🔨 3. Ejecutar comando publish

Me permite crear la parte compilada de la aplicacion

```bash
dotnet publish
```

Si no hay errores, puedes continuar.

---

## 🚀 4. Publicar el proyecto (crear ejecutable)

Este es el paso más importante. Aquí generamos el `.exe`.

Ejecuta el siguiente comando:

```bash
dotnet publish -c Release --self-contained -r win-x64
```

---

## 📌 Explicación del comando

* `dotnet publish` → Publica el proyecto
* `-c Release` → Usa configuración de producción (optimizada)
* `--self-contained` → Incluye .NET dentro del ejecutable (no requiere instalación previa)
* `-r win-x64` → Genera ejecutable para Windows 64 bits

---

## 📂 5. Ubicar el archivo ejecutable

Después de publicar, el `.exe` estará en:

```bash
bin/Release/netX.X/win-x64/
```

Ejemplo:

```bash
bin/Release/net10.0/win-x64/
```

Dentro encontrarás:

```bash
Nuget.exe
```

---

## ▶️ 6. Ejecutar el archivo .exe

Desde la terminal:

```bash
cd bin/Release/netX.X/win-x64/
./Nuget.exe
```

---

## 🎯 Resultado final

Obtendrás un archivo ejecutable:

```bash
Nuget.exe
```

Listo para ejecutarse en cualquier computadora (dependiendo del tipo de publicación).

---
