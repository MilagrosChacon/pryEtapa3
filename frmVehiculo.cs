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
    public partial class frmVehiculo : Form
    {
        List<clsVehiculo> listaVehiculos; // Lista para almacenar objetos de tipo clsVehiculo (vehículos)

        public frmVehiculo()
        {
            InitializeComponent();

            // Cargar la lista de vehículos
            listaVehiculos = new List<clsVehiculo>();
            crearVehiculoAuto();
            crearVehiculoAvion();
            crearVehiculoBarco();

            // Asociar el evento Click a todos los botones que comiencen con "btn"
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name.StartsWith("btn"))
                {
                    btn.Click += btn_Click;
                }
            }
        }

        // Manejador del evento Click para los botones
        private void btn_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender; // Obtiene el botón que se presionó
            int indiceVehiculo = obtenerIndiceVehiculo(botonPresionado.Name); // Obtiene el índice del vehículo asociado al botón

            if (indiceVehiculo != -1) // Si el índice del vehículo es válido
            {
                mostrarVehiculo(listaVehiculos[indiceVehiculo]); // Muestra la información del vehículo seleccionado
            }
        }

        // Método para crear un vehículo tipo auto y agregarlo a la lista
        private void crearVehiculoAuto()
        {
            clsVehiculo vehiculoAuto = new clsVehiculo();
            vehiculoAuto.crearVehiculo("Auto", "Terrestre", Properties.Resources.auto); // Crea un objeto clsVehiculo con la información del auto
            listaVehiculos.Add(vehiculoAuto);
        }

        // Método para crear un vehículo tipo avion y agregarlo a la lista
        private void crearVehiculoAvion()
        {
            clsVehiculo vehiculoAvion = new clsVehiculo();
            vehiculoAvion.crearVehiculo("Avión", "Aéreo", Properties.Resources.avion); // Crea un objeto clsVehiculo con la información del avion
            listaVehiculos.Add(vehiculoAvion);
        }

        // Método para crear un vehículo tipo barco y agregarlo a la lista
        private void crearVehiculoBarco()
        {
            clsVehiculo vehiculoBarco = new clsVehiculo();
            vehiculoBarco.crearVehiculo("Barco", "Marítimo", Properties.Resources.barco); // Crea un objeto clsVehiculo con la información del barco
            listaVehiculos.Add(vehiculoBarco);
        }

        // Método para mostrar la información de un vehículo
        private void mostrarVehiculo(clsVehiculo vehiculo) 
        {
            lblNombreVehiculo.Text = vehiculo.nombreVehiculo;
            lblTipoVehiculo.Text = vehiculo.tipoVehiculo;
            pctVehiculo.Image = vehiculo.imagenVehiculo;
        }

        // Método para obtener el índice del vehículo asociado a un botón
        private int obtenerIndiceVehiculo(string nombreBoton) 
        {
            switch (nombreBoton)
            {
                case "btnAuto":
                    return 0;
                case "btnAvion":
                    return 1;
                case "btnBarco":
                    return 2;
                default:
                    return -1;
            }
        }

    }
}
