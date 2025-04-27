namespace jramirez_T2.View;

public partial class princiapal : ContentPage
{
	public princiapal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
         string dato= estudiantePicker.Items[estudiantePicker.SelectedIndex].ToString();

         string FechaPicker = DateTime.Now.ToLongDateString();

        double.TryParse(seguimiento1Entry.Text, out double seguimiento1);
        double.TryParse(examen1Entry.Text, out double examen1);
        double.TryParse(seguimiento2Entry.Text, out double seguimiento2);
        double.TryParse(examen2Entry.Text, out double examen2);

        double parcial1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
        double parcial2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
        double notaFinal = parcial1 + parcial2;

        string estado = notaFinal >= 6.0 ? "Aprobado " : "Reprobado ";

        string mensaje = $"Nombre: {dato}\n" +
                    $"Fehca:{FechaPicker:F2}\n"+
                    $"Nota Parcial 1: {parcial1:F2}\n" +
                    $"Nota Parcial 2: {parcial2:F2}\n" +
                    $"Nota Final: {notaFinal:F2}\n" +
                    $"Estado: {estado}";

        // Mostrar alerta
        DisplayAlert("Resultado Final", mensaje, "OK");
    }
}
