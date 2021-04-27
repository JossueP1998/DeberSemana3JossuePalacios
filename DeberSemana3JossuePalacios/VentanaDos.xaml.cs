using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberSemana3JossuePalacios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaDos : ContentPage
    {
        public VentanaDos(string usuario, string contraseña)
        {
            InitializeComponent();
            
        }
        private void btnCalcular1_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);

                double suma = (nota1 * 0.3) + (examen1 * 0.2);
                txtNparcial1.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }

        }

        private void btnCalcular2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);

                double suma2 = (nota2 * 0.3) + (examen2 * 0.2);
                txtNparcial2.Text = suma2.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }

        }

        private void btnCalcular3_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nota3 = Convert.ToDouble(txtNparcial1.Text);
                double nota4 = Convert.ToDouble(txtNparcial2.Text);

                double suma3 = nota3 + nota4;
                txtNfinal.Text = suma3.ToString();

                if (suma3 >= 7)
                {
                    DisplayAlert("Alerta", "Aprobado", "Gracias");

                }
                else
                {
                    DisplayAlert("Alerta", "Reprobado", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}
    
