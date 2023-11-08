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
        private bool IsValid()
        {
            if(string.IsNullOrEmpty(MiEstudiante.Nombre))
            {
                DisplayAlert("Registro Fallido", "Debe de ingresar un Nombre", "ok..");
                return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.Apellido))
            {
                DisplayAlert("Registro Fallido", "Debe de ingresar un Apellido", "ok..");
                return false;
            }
            if (string.IsNullOrEmpty(MiEstudiante.Materia))
            {
                DisplayAlert("Registro Fallido", "Debe ingresar el nombre de la materia", "ok..");
                return false;
            }
            return true;
        }
        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            if(IsValid() == true)
            {
                var mensaje = $"{MiEstudiante.Nombre} sus datos se ingresaron correctamente";
                string titulo = "Registro";
                DisplayAlert(titulo, mensaje, "ok");
            }


        }
    }
}