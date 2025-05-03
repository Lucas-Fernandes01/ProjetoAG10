namespace ProjetoAG10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // String  marca e modelo (?.trim() remove espaços desnecessários nas pontas da string.)
                string marca = txt_marca.Text?.Trim();
                string modelo = txt_modelo.Text?.Trim();

                // verifica se uma string é null(vazia)


                if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                {
                    DisplayAlert("Aviso", "Preencha a marca e o modelo do veículo.", "OK");
                    return;
                }

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg;

                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O Etanol está compensando para o seu carro {marca} {modelo}!";
                }
                else
                {
                    msg = $"A Gasolina está compensando para o seu carro {marca} {modelo}!";
                }

                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", "Verifique os campos digitados. " + ex.Message, "Fechar");
            }
        }
    }
}
