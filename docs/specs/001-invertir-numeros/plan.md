# Plan 001 — Orden inverso

- **UI:** `MainPage.xaml` (Border + Grid 2x2 + Button con gradiente), estilos locales en `ContentPage.Resources`.
- **Lógica:** `MainPage.xaml.cs` → `OnInvertirClicked` usa `int.TryParse` por campo y valida los cuatro antes de mostrar.
- **Tema:** `AppThemeBinding` para fondo, tarjetas, campos y bordes.
- **Resultado:** `Border` con `DataTrigger` sobre `ResultadoLabel.Text.Length` para ocultarlo cuando está vacío.
- **Diagramas:** `docs/diagrams/arquitectura.excalidraw`, `docs/diagrams/flujo-invertir.excalidraw`.
