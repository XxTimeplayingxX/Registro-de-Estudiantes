namespace Clase_6_11_2023
{
    public partial class MainPage : ContentPage
    {
        public Estudiantes MiEstudiante { get; set; }

        public MainPage()
        {
            InitializeComponent();
            //Creamos el binding
            MiEstudiante = new Estudiantes();
            BindingContext = MiEstudiante;
        }

        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro",
                MiEstudiante.Nombre + " Sus datos se ingresaron correctamente", "Aceptar");
        }
    }
}