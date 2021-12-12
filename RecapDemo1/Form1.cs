namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8]; // 8'e 8'lik bir buton Array'i olu�turduk. �imdi �zelliklerini belirleyebiliriz..
            int top = 0; // Buton y�ksekli�inde de�i�iklik yapmak i�in tan�mlad�k.
            int left = 0; // Buton'u sa�a do�ru kayd�rabilmek i�in tan�mlad�k.
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // 8 tane sat�r� olu�turmak i�in.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) // Her bir sat�r�n alt k�sm�na s�tun olu�turmak i�in.
                {
                    buttons[i, j] = new Button(); // Her seferinde yeni bir buton olu�aca�� i�in, new'lememiz gerekiyor.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // �ncelikle ilk butonumuzun yerini sola s�f�rlad�k.
                    buttons[i, j].Top = top; // �lk sat�r i�in y�ksekli�imizi s�f�ra e�itledik.
                    left += 50; // Bir �nceki butona g�re 50 birim sa� tarafa kayd�rmak i�in yazd�k.
                    if ((i+j)%2==0) // renk ayar� vermek i�in i+j nin modunu ald�k.
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]);
                }
                left = 0; // �kinci sat�ra ge�ti�imizde tekrardan sola s�f�rlamak i�in tan�mlad�k.
                top += 50; // Y�ksekli�imizi ayarlamak i�in tan�mlad�k.
               
            }
           
        }
    }
}