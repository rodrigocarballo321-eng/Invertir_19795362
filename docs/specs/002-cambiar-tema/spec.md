# Spec 002 — Botón para cambiar entre modo claro y oscuro

**Estado:** Implementada (pendiente de verificación manual, ver T5)

## Objetivo
Permitir al usuario alternar la app entre tema claro y tema oscuro con un botón, sin depender del tema del sistema.

## Requisitos funcionales
- RF1. En el encabezado de `MainPage` hay un botón de tema (`ThemeButton`), alineado a la derecha.
- RF2. Al tocarlo, la app cambia de claro a oscuro, o de oscuro a claro, al instante.
- RF3. El texto del botón indica la acción siguiente: en tema claro muestra "🌙 Modo oscuro"; en tema oscuro muestra "☀️ Modo claro".
- RF4. Si el usuario no ha elegido nada, la app sigue el tema del sistema; el texto del botón debe reflejar el tema que se está usando.
- RF5. La elección se recuerda entre ejecuciones (`Preferences`, clave `tema_preferido`).
- RF6. Si el tema del sistema cambia mientras la app está abierta, el texto del botón se actualiza.

## Requisitos de diseño
- RD1. El botón es una "píldora" translúcida blanca sobre el degradado del encabezado, visible en ambos temas.
- RD2. Textos en español. El botón tiene `SemanticProperties.Description` para accesibilidad.
- RD3. Todos los colores de la pantalla siguen usando `AppThemeBinding` (no se agregan colores fijos dependientes del tema).

## Restricciones
- No se modifica `OnInvertirClicked` ni los `x:Name` de la spec 001.
- Handler nuevo: `OnCambiarTemaClicked`.

## Criterios de aceptación
| Situación inicial | Acción | Resultado esperado |
|---|---|---|
| Tema claro | Tocar botón | Pantalla en oscuro; botón dice "☀️ Modo claro" |
| Tema oscuro | Tocar botón | Pantalla en claro; botón dice "🌙 Modo oscuro" |
| Elegir oscuro y cerrar la app | Abrirla de nuevo | Inicia en oscuro |
| Sistema en oscuro, sin elección previa | Abrir la app | Inicia en oscuro; botón dice "☀️ Modo claro" |
| Cualquier tema | Calcular orden inverso | Resultado verde/rojo sigue funcionando igual |

Diagrama: `docs/diagrams/flujo-tema.excalidraw`
