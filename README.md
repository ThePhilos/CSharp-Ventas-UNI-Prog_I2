# CSharp-Ventas-UNI-Prog_I #2
[![My Skills](https://skillicons.dev/icons?i=cs)](https://skillicons.dev)

<h2>Sistema de Ventas con Concurrencia y Procesamiento Paralelo en C#</h2>

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms (.NET 6.0) que permite cargar y procesar ventas aplicando programación asíncrona, procesamiento paralelo (PLINQ) y el patrón Repository para separar la lógica del sistema.

El objetivo es implementar una solución que procese información sin bloquear la interfaz, manteniendo una estructura organizada del código.

<h2>Funcionalidades</h2>
<b>Carga de ventas asíncrona:</b> Obtiene datos sin bloquear la interfaz del usuario.<br>
<p><b>Procesamiento paralelo:</b> Uso de AsParallel() para optimizar cálculos.</p>
<b>Cálculo de estadísticas:</b><br>
-Total vendido<br>
-Promedio de ventas
-Venta con mayor valor<br>
<p>-Agrupación por categoría</p>
<b>Interfaz dinámica:</b> Herramientas tecnológicas
-Visualización en DataGridView<br>
-Indicadores de estado y progreso<br>
-Arquitectura desacoplada mediante patrón Repository<br>

<h2>Herramientas tecnológicas</h2>
Lenguaje: C#<br>
Framework: .NET 6.0 o superior<br>
Interfaz de Usuario: Windows Forms (WinForms)<br>
Concurrencia: Task, async/await<br>
Paralelismo: PLINQ (AsParallel)<br>
Serialización (opcional): System.Text.Json<br>

<h2>Documentación del Proyecto</h2>
Para comprender el desarrollo y los conceptos aplicados en esta práctica, puedes consultar la guía base utilizada:
<p align="left">
  <a href="https://github.com/xOfho/CSharp-FileSystem-UNI-Prog_I1/raw/main/docs/Guia_Practica_Prog_II.pdf">
    <img src="https://img.shields.io/badge/Descargar%20Guía%20PDF-32CD32?style=for-the-badge&logo=adobe-acrobat-reader&logoColor=white" alt="Download PDF" />
  </a>
</p>

<h2>Estructura del Código</h2>
<b>Venta.cs:</b> Define la entidad principal con las propiedades de cada venta.<br>
<b>IVentaRepository.cs:</b> Define el contrato para obtener datos de ventas.<br>
<b>VentaRepository.cs:</b> Simula la carga de datos de forma asíncrona.<br>
<b>VentaService.cs:</b> Contiene la lógica de procesamiento paralelo de ventas.<br>
<b>Form1.cs:</b> Maneja la interacción del usuario y eventos de la interfaz.

<h3>Pasos a seguir:</h3>

## Pasos con Capturas de Pantallas

> *Pasos a seguir:*

1.  [cite_start]Abrir Visual Studio 2022[cite: 4].
2.  [cite_start]Crear nuevo proyecto Windows Forms App (.NET)[cite: 5].
3.  [cite_start]Asegúrese de que el Framework seleccionado sea .NET 6.0 o superior[cite: 6].

4.  [cite_start]En la solución, haga clic derecho al Proyecto y cree 3 carpetas con los nombres de: Entidades, Repositorio y Servicio[cite: 70, 71].
5.  [cite_start]Agregue las clases e interfaces correspondientes en cada carpeta (Venta.cs, IVentaRepository.cs, etc.) [cite: 144-152].
6.  [cite_start]Crear la interfaz gráfica agregando el DataGridView, botones y la barra de progreso [cite: 16-32].

7.  [cite_start]Luego en el Formulario se agrega un Label (lblEstado) para mostrar el estado de la carga[cite: 28, 29].
8.  [cite_start]Se agregan los botones para las acciones: Cargar ventas, Procesar ventas y Limpiar [cite: 19-27].
9.  [cite_start]Hacemos clic en cada control y, en la ventana de propiedades, cambiamos el (Name) para identificarlos en el código[cite: 18, 20, 23, 26, 32].


# Contribuidores
<a href="https://github.com/ThePhilos/CSharp-Ventas-UNI-Prog_I2/graphs/contributors">
<p align="center">
  <a href="https://github.com/ThePhilos">
    <img src="https://github.com/ThePhilos.png" width="100px;" style="border-radius:50%"/>
  </a>
  <a href="https://github.com/maurijrbs">
    <img src="https://github.com/maurijrbs.png" width="100px;" style="border-radius:50%"/>
  </a>
  <a href="https://github.com/xOfho">
    <img src="https://github.com/xOfho.png" width="100px;" style="border-radius:50%"/>
  </a>
  <a href="https://github.com/joletteolivas">
    <img src="https://github.com/joletteolivas.png" width="100px;" style="border-radius:50%"/>
  </a>
</p>

<p align="center">
  <sub>
    <a href="https://github.com/ThePhilos">ThePhilos</a> •
    <a href="https://github.com/maurijrbs">maurijrbs</a> •
    <a href="https://github.com/xOfho">xOfho</a> •
    <a href="https://github.com/joletteolivas">joletteolivas</a>
  </sub>
</p>
