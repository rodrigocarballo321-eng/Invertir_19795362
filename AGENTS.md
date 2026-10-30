# AGENTS.md — Ejercicio1_19795362

Guía para cualquier agente de IA (Claude Code, Copilot, Cursor, etc.) que trabaje en este repositorio.

## Contexto del proyecto
- App **.NET MAUI** (`net10.0`) con una sola pantalla: `MainPage`.
- Funcionalidad: el usuario ingresa 4 enteros (A, B, C, D) y la app los muestra en orden inverso (D, C, B, A).
- Si algún campo no es un entero válido, se muestra un mensaje de error en rojo.
- Un botón en el encabezado (`ThemeButton`) alterna entre tema claro y oscuro (spec 002) y recuerda la elección.

## Estructura
| Ruta | Rol |
|------|-----|
| `Ejercicio1_19795362/MainPage.xaml` | Diseño de la UI |
| `Ejercicio1_19795362/MainPage.xaml.cs` | Lógica (`OnInvertirClicked`) |
| `Ejercicio1_19795362/Resources/Styles/` | Colores y estilos globales |
| `docs/specs/` | Especificaciones (fuente de verdad) |
| `docs/diagrams/` | Diagramas `.excalidraw` |

## Flujo de trabajo (AI-Driven / Spec-Driven Development)
1. **Spec primero**: toda funcionalidad nueva o cambio parte de `docs/specs/NNN-nombre/spec.md`.
2. **Plan** (`plan.md`) y **tareas** (`tasks.md`) antes de escribir código.
3. **Diagrama**: actualizar o crear el `.excalidraw` correspondiente (usar el MCP de Excalidraw, ver abajo).
4. **Implementar** tarea por tarea, cambios pequeños.
5. **Verificar** contra los criterios de aceptación de la spec.

## Reglas
- No cambiar la lógica de `OnInvertirClicked` sin actualizar antes la spec.
- Mantener los `x:Name` (`EntryA`–`EntryD`, `ResultadoLabel`, `ThemeButton`) y los handlers `OnInvertirClicked` y `OnCambiarTemaClicked`; el code-behind depende de ellos.
- Cambios de diseño solo en XAML y `Resources/Styles`. Soportar tema claro y oscuro (`AppThemeBinding`).
- Textos de UI en español.

## MCP Excalidraw
Configurado en `.mcp.json` (Claude Code) y `.vscode/mcp.json` (VS Code). Requiere Node.js.
Úsalo para crear/editar diagramas y guárdalos en `docs/diagrams/`.
Los archivos `.excalidraw` también se abren en https://excalidraw.com
