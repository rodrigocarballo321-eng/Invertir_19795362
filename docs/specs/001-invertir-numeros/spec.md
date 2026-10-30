# Spec 001 — Mostrar cuatro números en orden inverso

**Estado:** Implementada

## Objetivo
Permitir al usuario ingresar cuatro números enteros (A, B, C, D) y ver el resultado en orden inverso: D, C, B, A.

## Requisitos funcionales
- RF1. La pantalla tiene 4 campos numéricos: A, B, C y D.
- RF2. Un botón "Mostrar en Orden Inverso" procesa los valores.
- RF3. Si los 4 valores son enteros válidos, se muestra `D, C, B, A` en verde.
- RF4. Si alguno no es un entero válido (vacío, decimal, texto), se muestra un mensaje de error en rojo.

## Requisitos de diseño
- RD1. Diseño moderno con encabezado, tarjeta de entrada y tarjeta de resultado.
- RD2. Soporte de tema claro y oscuro.
- RD3. La tarjeta de resultado solo es visible cuando hay texto.

## Criterios de aceptación
| Entrada (A,B,C,D) | Resultado esperado |
|---|---|
| 1, 2, 3, 4 | `4, 3, 2, 1` (verde) |
| -5, 0, 7, 100 | `100, 7, 0, -5` (verde) |
| 1, 2, 3, (vacío) | Mensaje de error (rojo) |
| 1, 2.5, 3, 4 | Mensaje de error (rojo) |
| a, b, c, d | Mensaje de error (rojo) |

Diagrama: `docs/diagrams/flujo-invertir.excalidraw`
