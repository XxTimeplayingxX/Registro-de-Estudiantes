using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_11_2023
{
    public class Estudiantes : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string materia;

        public string Nombre
        {
            get => nombre; set
            {
                nombre = value;
                this.OnPropertyChanged(nameof(Nombre));
            }
        }
        public string Apellido
        {
            get => apellido; set
            {
                apellido = value;
                this.OnPropertyChanged(nameof(Apellido));
            }
        }
        public string Materia
        {
            get => materia; set
            {
                materia = value;
                this.OnPropertyChanged(nameof(Materia));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
