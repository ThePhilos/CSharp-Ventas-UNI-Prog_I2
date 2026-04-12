# CSharp-Ventas-UNI-Prog_I #2
[![My Skills](https://skillicons.dev/icons?i=cs)](https://skillicons.dev)

<h2>Sistema de Ventas con Concurrencia y Procesamiento Paralelo en C#</h2>

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms (.NET 6.0) que permite cargar y procesar ventas aplicando programación asíncrona, procesamiento paralelo (PLINQ) y el patrón Repository para separar la lógica del sistema.

El objetivo es implementar una solución que procese información sin bloquear la interfaz, manteniendo una estructura organizada del código.

<h2>Funcionalidades</h2>
<b>Carga de ventas asíncrona:</b> Obtiene datos sin bloquear la interfaz del usuario.<br>
<b>Procesamiento paralelo:</b> Uso de AsParallel() para optimizar cálculos.
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
<p align="left"> <a href="#"> <img src="https://img.shields.io/badge/Guía%20Unidad%20II-32CD32?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Guía" /> </a> </p>

<h2>Estructura del Código</h2>
<b>Venta.cs:</b> Define la entidad principal con las propiedades de cada venta.<br>
<b>IVentaRepository.cs:</b> Define el contrato para obtener datos de ventas.<br>
<b>VentaRepository.cs:</b> Simula la carga de datos de forma asíncrona.<br>
<b>VentaService.cs:</b> Contiene la lógica de procesamiento paralelo de ventas.<br>
<b>Form1.cs:</b> Maneja la interacción del usuario y eventos de la interfaz.

<h3>Pasos a seguir:</h3>

# Contribuidores
<a href="https://github.com/ThePhilos/CSharp-Ventas-UNI-Prog_I2/graphs/contributors">
