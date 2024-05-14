using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa3
{
    internal class clsVehiculo
    {
        public string nombreVehiculo { get; set; } // Almacena el nombre del vehículo
        public string tipoVehiculo { get; set; } // Almacena el tipo de vehículo
        public Image imagenVehiculo { get; set; } // Almacena la imagen del vehículo

        public clsVehiculo() 
        {
            // Constructor vacío para crear vehículos sin inicializar datos
        }

        // Constructor para crear un vehículo con datos inicializados
        public clsVehiculo(string nombre, string tipo, Image imagen)
        {
            nombreVehiculo = nombre;
            tipoVehiculo = tipo;
            imagenVehiculo = imagen;
        }

        // Método para crear un vehículo con datos inicializados
        public void crearVehiculo(string nombre, string tipo, Image imagen)
        {
            this.nombreVehiculo = nombre;
            this.tipoVehiculo = tipo;
            this.imagenVehiculo = imagen;
        }

    }
}
