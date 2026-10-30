namespace Ejercicio1_19795362
{
    public partial class MainPage : ContentPage
    {
        
            private const string TemaKey = "tema_preferido";

            public MainPage()
            {
                InitializeComponent();

                AplicarTemaGuardado();
                ActualizarBotonTema(TemaActual);

                if (Application.Current is not null)
                {
                    // Si el sistema cambia de tema mientras la app está abierta, refrescar el texto del botón
                    Application.Current.RequestedThemeChanged += (_, _) =>
                        MainThread.BeginInvokeOnMainThread(() => ActualizarBotonTema(TemaActual));
                }
            }

            private static AppTheme TemaActual =>
                Application.Current?.RequestedTheme ?? AppTheme.Light;

            // Aplica el tema que el usuario eligió en una ejecución anterior (si existe)
            private static void AplicarTemaGuardado()
            {
                if (Application.Current is null) return;

                var guardado = Preferences.Default.Get(TemaKey, string.Empty);
                if (Enum.TryParse<AppTheme>(guardado, out var tema) && tema != AppTheme.Unspecified)
                {
                    Application.Current.UserAppTheme = tema;
                }
            }

            private void ActualizarBotonTema(AppTheme tema)
            {
                // El texto indica la acción siguiente
                ThemeButton.Text = tema == AppTheme.Dark ? "☀️ Modo claro" : "🌙 Modo oscuro";
            }

            private void OnCambiarTemaClicked(object sender, EventArgs e)
            {
                if (Application.Current is null) return;

                var nuevoTema = TemaActual == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;

                Application.Current.UserAppTheme = nuevoTema;
                Preferences.Default.Set(TemaKey, nuevoTema.ToString());
                ActualizarBotonTema(nuevoTema);
            }

            private void OnInvertirClicked(object sender, EventArgs e)
            {
                // Intentar convertir los valores ingresados a enteros
                bool isAValid = int.TryParse(EntryA.Text, out int a);
                bool isBValid = int.TryParse(EntryB.Text, out int b);
                bool isCValid = int.TryParse(EntryC.Text, out int c);
                bool isDValid = int.TryParse(EntryD.Text, out int d);

                // Validar que todos los campos contengan números enteros válidos
                if (isAValid && isBValid && isCValid && isDValid)
                {
                    // El orden inverso de A, B, C, D es: D, C, B, A
                    ResultadoLabel.TextColor = Colors.Green;
                    ResultadoLabel.Text = $"Resultado inverso:\n{d}, {c}, {b}, {a}";
                }
                else
                {
                    ResultadoLabel.TextColor = Colors.Red;
                    ResultadoLabel.Text = "Por favor, ingrese números enteros válidos en todos los campos.";
                }
            
        }
    }
}
