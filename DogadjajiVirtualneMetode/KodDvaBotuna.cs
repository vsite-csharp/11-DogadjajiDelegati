namespace Vsite.CSharp.DogađajiDelegati
{
    public partial class KodDvaBotuna : Form
    {
        public KodDvaBotuna()
        {
            InitializeComponent();
            // TODO:080 Pokrenuti program i pogledati formu i kontrole na njoj.

            // TODO:081 Pridružiti donja dva rukovatelja događajima Click tipki button i buttonMy.

        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Botun obični");
        }

        private void ButtonMy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj botun");
        }

        // TODO:082 Napraviti klasu MyButton koja će biti izvedena iz klase Button, u njoj nadglasati virtualnu metodu OnClick te unutar metode dodati prikaz kontrole MessageBox.

        // TODO:083 Promijeniti objekt buttonMy u formi tako da bude tipa MyButton, pokrenuti kod i provjeriti ponašanje tipke.

        // TODO:084 U metodi OnClick klase MyButton zakomentirati poziv base.OnClick te provjeriti ponašanje tipke nakon toga.
    }
}
