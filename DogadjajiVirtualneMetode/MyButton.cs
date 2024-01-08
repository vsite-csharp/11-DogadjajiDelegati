namespace Vsite.CSharp.DogađajiDelegati
{
    internal class MyButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("U overrideanoj metodi");
            //base.OnClick(e);
        }
    }
}
