using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;


namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnBuscarCEP.Clicked += (sender, e) => {
              
                var isValidCEP = IsValidCEP(txtCEP.Text);

                if (!isValidCEP)
                {
                    DisplayAlert("Erro!", "O CEP informado é inválido", "OK");                  
                }
                else
                {
                    try
                    {
                        Endereco endereco = ViaCEPServico.BuscarEnderecoViaCEP(txtCEP.Text.Trim());
                        if(endereco?.Cep == null)
                        {
                            DisplayAlert("Erro", "Nenhum endereço encontrado para o CEP informado", "OK");
                            lblResultado.Text = string.Empty;
                        }
                        else
                        {
                            lblResultado.Text = endereco.ToString();
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        DisplayAlert("Erro crítico", ex.Message, "OK");
                    }
                }
            };
        }

        public bool IsValidCEP(string cep)
        {
            bool valid = true;

            if (cep.Length != 8)
            {
                valid = false;
            }
            if (!int.TryParse(cep, out _))
            {
                valid = false;
            }

            return valid;
        }
    }
}
