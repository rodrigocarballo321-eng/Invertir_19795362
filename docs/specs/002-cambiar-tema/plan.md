# Plan 002 — Cambiar tema

- **UI:** `MainPage.xaml`: `Button x:Name="ThemeButton"` como primer hijo del encabezado (`HorizontalOptions="End"`), fondo `#33FFFFFF`, `CornerRadius` 20, `Clicked="OnCambiarTemaClicked"`.
- **Lógica:** `MainPage.xaml.cs`:
  - `OnCambiarTemaClicked`: alterna `Application.Current.UserAppTheme` entre `Light` y `Dark`, guarda en `Preferences` y actualiza el texto.
  - `AplicarTemaGuardado()`: al construir la página, aplica la preferencia guardada si existe.
  - `ActualizarBotonTema(AppTheme)`: texto del botón según el tema.
  - Suscripción a `Application.RequestedThemeChanged` para mantener el texto sincronizado.
- **Sin cambios** en `OnInvertirClicked`, en `Resources/Styles` ni en los `x:Name` existentes.
- **Diagrama:** `docs/diagrams/flujo-tema.excalidraw`.
