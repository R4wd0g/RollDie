using System.ComponentModel.Design;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace RollDie {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            label7.Text = "Pontuação: " + pontos;
            label5.Text = "Jogadas: " + jogadas;

        }

        private Random randomNumber = new Random();

        int pontos = 0;
        int jogadas = 0;



        async private void button1_Click(object sender, EventArgs e) {

            new SoundPlayer(".\\dados\\som.wav").Play();

            int face, l1, l2, l3, l4;

            label6.Text = "";

            jogadas++;
            label5.Text = "Jogadas: " + jogadas;



            for (int i = 1; i <= 10; i++) {

                Application.DoEvents();

                face = randomNumber.Next(1, 7);
                label1.Image = Image.FromFile(".\\dados\\" + face + ".png");
                l1 = face;
                Thread.Sleep(25);


                face = randomNumber.Next(1, 7);
                label2.Image = Image.FromFile(".\\dados\\" + face + ".png");
                l2 = face;
                Thread.Sleep(25);

                face = randomNumber.Next(1, 7);
                label3.Image = Image.FromFile(".\\dados\\" + face + ".png");
                l3 = face;
                Thread.Sleep(25);

                face = randomNumber.Next(1, 7);
                label4.Image = Image.FromFile(".\\dados\\" + face + ".png");
                l4 = face;
                Thread.Sleep(25);



                if ((l1 == l2) && (l2 == l3) && (l3 == l4)) {


                    switch (face) {
                        case 1:
                            pontos += 1200;
                            label7.Text = "Pontuação: " + pontos;
                            break;
                        case 2:
                            pontos += 2200;
                            label7.Text = "Pontuação: " + pontos;
                            break;
                        case 3:
                            pontos += 3211;
                            label7.Text = "Pontuação: " + pontos;
                            break;
                        case 4:
                            pontos += 4698;
                            label7.Text = "Pontuação: " + pontos;
                            break;
                        case 5:
                            pontos += 5101;
                            label7.Text = "Pontuação: " + pontos;
                            break;
                        case 6:
                            pontos += 6542;
                            label7.Text = "Pontuação: " + pontos;
                            break;


                    }
                    new SoundPlayer(".\\dados\\winner.wav").Play();
                    label6.Text = "Receba!!!";
                    
                    for (i = 1; i <= 4; i++) {

                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        await Task.Delay(100);

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        await Task.Delay(100);

                    }

                        break;
                }



            }




        }



        async Task PausaComTaskDelay() {
            await Task.Delay(2000);
        }















        private void label5_Click(object sender, EventArgs e) {


        }


        //WMPLib.WindowsMediaPlayer player1;
        WMPLib.WindowsMediaPlayer player1;

        private void Form1_Load(object sender, EventArgs e) {
            //new SoundPlayer(".\\dados\\backMusic.wav").Play();
            player1 = new WMPLib.WindowsMediaPlayer();
            player1.URL = @".\dados\backMusic.mp3";
            player1.settings.setMode("loop", true);
            player1.settings.volume = 60;
            player1.controls.play();




        }
    }
}