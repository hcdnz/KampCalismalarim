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
            Button[,] buttons = new Button[8,8]; // 8'e 8'lik bir buton Array'i oluþturduk. Þimdi özelliklerini belirleyebiliriz..
            int top = 0; // Buton yüksekliðinde deðiþiklik yapmak için tanýmladýk.
            int left = 0; // Buton'u saða doðru kaydýrabilmek için tanýmladýk.
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // 8 tane satýrý oluþturmak için.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) // Her bir satýrýn alt kýsmýna sütun oluþturmak için.
                {
                    buttons[i, j] = new Button(); // Her seferinde yeni bir buton oluþacaðý için, new'lememiz gerekiyor.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // Öncelikle ilk butonumuzun yerini sola sýfýrladýk.
                    buttons[i, j].Top = top; // Ýlk satýr için yüksekliðimizi sýfýra eþitledik.
                    left += 50; // Bir önceki butona göre 50 birim sað tarafa kaydýrmak için yazdýk.
                    if ((i+j)%2==0) // renk ayarý vermek için i+j nin modunu aldýk.
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]);
                }
                left = 0; // Ýkinci satýra geçtiðimizde tekrardan sola sýfýrlamak için tanýmladýk.
                top += 50; // Yüksekliðimizi ayarlamak için tanýmladýk.
               
            }
           
        }
    }
}