# CSharp-Ventas-UNI-Prog_I #2
[![My Skills](https://skillicons.dev/icons?i=cs)](https://skillicons.dev)

<h2>Sistema de Ventas con Concurrencia y Procesamiento Paralelo en C#</h2>

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms (.NET 6.0) que permite cargar y procesar ventas aplicando programación asíncrona, procesamiento paralelo (PLINQ) y el patrón Repository para separar la lógica del sistema.

El objetivo es implementar una solución que procese información sin bloquear la interfaz, manteniendo una estructura organizada del código.

<h2>🎥 Vista previa del sistema</h2>

<p align="center">
  <img src="https://via.placeholder.com/800x400?text=Demo+App+Ventas" alt="Preview App" width="80%">
</p>

<p align="center">
  <sub>💡 Reemplaza esta imagen por un GIF real de tu aplicación.</sub>
</p>

---

<h2>📊 Dashboard de características</h2>

<p align="center">
  <img src="https://img.shields.io/badge/Estado-Activo-success?style=for-the-badge">
  <img src="https://img.shields.io/badge/Arquitectura-Repository-blue?style=for-the-badge">
  <img src="https://img.shields.io/badge/Performance-Optimized-orange?style=for-the-badge">
  <img src="https://img.shields.io/badge/UI-WinForms-purple?style=for-the-badge">
</p>

---

<h2>🚀 Características principales</h2>

| Funcionalidad | Descripción |
|--------------|------------|
| ⚡ Carga asíncrona | Datos sin bloquear la UI |
| 🚀 Procesamiento paralelo | Uso de PLINQ |
| 📊 Estadísticas | Métricas en tiempo real |
| 🖥️ Interfaz | DataGridView dinámico |

---

<h2>🧪 Ejemplo visual</h2>

<details>
  <summary><strong>📸 Ver captura</strong></summary>

  <br>

  <p align="center">
    <img src="https://via.placeholder.com/700x350?text=Captura+del+Sistema" width="75%">
  </p>

</details>

---

<h2>🧠 Conceptos aplicados</h2>

<p>
  <img src="https://img.shields.io/badge/OOP-Principles-blue?style=flat-square">
  <img src="https://img.shields.io/badge/Async-Await-green?style=flat-square">
  <img src="https://img.shields.io/badge/Parallelism-PLINQ-orange?style=flat-square">
  <img src="https://img.shields.io/badge/Design-Patterns-lightgrey?style=flat-square">
</p>

---

<h2>📌 Notas</h2>

<ul>
  <li>✔️ Proyecto orientado a concurrencia y paralelismo</li>
  <li>✔️ Código limpio y mantenible</li>
  <li>✔️ Fácil de escalar</li>
</ul>

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
