# CSharp-Ventas-UNI-Prog_I #2
[![My Skills](https://skillicons.dev/icons?i=cs)](https://skillicons.dev)

<h2>Sistema de Ventas con Concurrencia y Procesamiento Paralelo en C#</h2>

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms (.NET 6.0) que permite cargar y procesar ventas aplicando programación asíncrona, procesamiento paralelo (PLINQ) y el patrón Repository para separar la lógica del sistema.

El objetivo es implementar una solución que procese información sin bloquear la interfaz, manteniendo una estructura organizada del código.

<h2>🎥 Vista previa del sistema</h2>

<p align="center">
  <img src="https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExb3QyaTl2ZHM5dnNsdWZnZGQyNnUyeTJhMnM1amd3Nm80N2RzOGEzMyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/i2rNOf3b7vJgk/giphy.gif" alt="Preview App" width="20%">
</p>

<p align="center">
  <sub>.</sub>
</p>

---
## Funcionalidades ## 

<b>Carga de ventas asíncrona:</b> Obtiene datos sin bloquear la interfaz del usuario.<br>

<p><b>Procesamiento paralelo:</b> Uso de <code>AsParallel()</code> para optimizar cálculos.</p> 

<b>Cálculo de estadísticas:</b><br> 
- Total vendido <br> 
- Promedio de ventas<br> 
- Venta con mayor valor<br> 
- Agrupación por categoría<br>

<b>Interfaz dinámica:</b> 
- Visualización en <code>DataGridView</code><br> 
- Indicadores de estado y progreso<br> 
- Arquitectura desacoplada mediante patrón Repository<br>

<h2> Herramientas Tecnológicas</h2>

<!-- Badges -->
<p align="center">
  <img src="https://img.shields.io/badge/C%23-Programming-blue?style=for-the-badge&logo=csharp&logoColor=white">
  <img src="https://img.shields.io/badge/.NET-6.0-purple?style=for-the-badge&logo=dotnet&logoColor=white">
  <img src="https://img.shields.io/badge/WinForms-UI-blueviolet?style=for-the-badge&logo=windows&logoColor=white">
  <img src="https://img.shields.io/badge/Async-Await-success?style=for-the-badge">
  <img src="https://img.shields.io/badge/PLINQ-Parallel-orange?style=for-the-badge">
  <img src="https://img.shields.io/badge/JSON-Serialization-lightgrey?style=for-the-badge&logo=json&logoColor=black">
</p>

<br>

<!-- Accordion -->
<details>
  <summary><strong>🔍 Ver detalle de tecnologías</h4></strong></summary>
  <br>
  <ul>
    <li>
      <strong> Lenguaje</strong><br>
      <sub>C# — Lenguaje principal orientado a objetos.</sub>
    </li>
    <br>
    <li>
      <strong> Framework</strong><br>
      <sub>.NET 6.0 o superior para desarrollo moderno.</sub>
    </li>
    <br>
    <li>
      <strong> Interfaz</strong><br>
      <sub>Windows Forms (WinForms) para aplicaciones de escritorio.</sub>
    </li>
    <br>
    <li>
      <strong> Concurrencia</strong><br>
      <sub>Uso de Task y async/await para operaciones no bloqueantes.</sub>
    </li>
    <br>
    <li>
      <strong> Paralelismo</strong><br>
      <sub>PLINQ (AsParallel) para procesamiento eficiente.</sub>
    </li>
    <br>
    <li>
      <strong> Serialización</strong><br>
      <sub>System.Text.Json (opcional) para manejo de datos.</sub>
    </li>
  </ul>

</details>

<h2>Documentación del Proyecto</h2>
Para comprender el desarrollo y los conceptos aplicados en esta práctica, puedes consultar la guía base utilizada:
<p align="left">
  <a href="https://github.com/xOfho/CSharp-FileSystem-UNI-Prog_I1/raw/main/docs/Guia_Practica_Prog_II.pdf">
    <img src="https://img.shields.io/badge/Descargar%20Guía%20PDF-32CD32?style=for-the-badge&logo=adobe-acrobat-reader&logoColor=white" alt="Download PDF" />
  </a>
</p>

<h2> Estructura del Código</h2>

<table>
  <thead>
    <tr>
      <th>Archivo</th>
      <th>Descripción</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><code>Venta.cs</code></td>
      <td>Define la entidad principal con las propiedades de cada venta.</td>
    </tr>
    <tr>
      <td><code>IVentaRepository.cs</code></td>
      <td>Establece el contrato para la obtención de datos de ventas.</td>
    </tr>
    <tr>
      <td><code>VentaRepository.cs</code></td>
      <td>Simula la carga de datos de manera asíncrona.</td>
    </tr>
    <tr>
      <td><code>VentaService.cs</code></td>
      <td>Implementa la lógica de procesamiento paralelo de ventas.</td>
    </tr>
    <tr>
      <td><code>Form1.cs</code></td>
      <td>Gestiona la interacción del usuario y los eventos de la interfaz.</td>
    </tr>
  </tbody>
</table>

<h3>Pasos a seguir:</h3>
1.  Abrir Visual Studio 2022.<br>
2.  Crear nuevo proyecto Windows Forms App (.NET).<br>
3.  Asegurarse de seleccionar .NET 6.0 o superior.<br>

# Contribuidores
<a href="https://github.com/ThePhilos/CSharp-Ventas-UNI-Prog_I2/graphs/contributors">
<table align="center">
  <tr>
    <td align="center">
      <a href="https://github.com/ThePhilos">
        <img src="https://github.com/ThePhilos.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>ThePhilos</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/maurijrbs">
        <img src="https://github.com/maurijrbs.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>maurijrbs</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/xOfho">
        <img src="https://github.com/xOfho.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>xOfho</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/joletteolivas">
        <img src="https://github.com/joletteolivas.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>joletteolivas</b></sub>
      </a>
    </td>
  </tr>
</table>
