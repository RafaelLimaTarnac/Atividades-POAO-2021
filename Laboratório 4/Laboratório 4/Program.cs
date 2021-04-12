using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Laboratório_4
{
    class Program
    {
        static void Main(string[] args) // [x,y]
        {
            //construção naves
            NaveDeGuerra NavePlayer = new NaveDeGuerra("nomeTeste",100,100,1,2,2,false);
            NaveDeGuerra NaveInimigo1 = new NaveDeGuerra("inimigoTeste1",100,100,1,20,20,true);
            NaveDeGuerra NaveInimigo2 = new NaveDeGuerra("inimigoTeste2", 100, 100, 1, 10, 20,true);
            NaveDeGuerra NaveInimigo3 = new NaveDeGuerra("inimigoTeste3", 100, 100, 1, 1, 20,true);
            NaveDeGuerra[] NavesEmJogo = new NaveDeGuerra[] { NavePlayer,NaveInimigo1, NaveInimigo2, NaveInimigo3 };
            int ContadorTurnos = 0;
            bool atirou = false;
            int ação = 0;
            List<Projétil> ListaTiros = new List<Projétil>();
            string[,] Campo;
            Campo = new string[20, 20];
            // jogo
            while (NavePlayer.Energia > 0)
            {
                // delimita a tela
                DelimitarEspaço();
                if (atirou)
                {
                    AtirarPlayer();
                    atirou = false;
                }
                Colisoes();
                DeterminarEspaços();
                DesenharEspaço();
                FimDeJogo();
                foreach (Projétil elemento in ListaTiros)
                {
                    elemento.MovimentaçãoProjétil();
                }
                ação = int.Parse(Console.ReadLine());
                //ações do player
                switch (ação)
                {
                    case 1:
                        atirou = true;
                        break;
                    case 2:
                        NavePlayer.VerificarDanos();
                        break;
                    case 3:
                        NavePlayer.MoverCima();
                        NavePlayer.LimitarEspaço();
                        break;
                    case 4:
                        NavePlayer.MoverBaixo();
                        NavePlayer.LimitarEspaço();
                        break;
                    case 5:
                        NavePlayer.MoverDireita();
                        NavePlayer.LimitarEspaço();
                        break;
                    case 6:
                        NavePlayer.MoverEsquerda();
                        NavePlayer.LimitarEspaço();
                        break;
                }
                Console.Clear();
            }
            //desenha o plano
            Console.Read();
            //métodos
            void DesenharEspaço()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Console.Write(Campo[i, j]);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("(1)ATACAR\n(2)VER DANOS\n(3)MOVER PARA CIMA\n(4)MOVER PARA BAIXO\n" +
                    "(5)MOVER PARA DIREITA\n(6)MOVER PARA ESQUERDA\n");
            }
            void DelimitarEspaço()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Campo[i, j] = ".   ";
                    }
                }
            }
            void DeterminarEspaços()
            {
                foreach (NaveDeGuerra Naves in NavesEmJogo)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (Naves.Posição[0] == i + 1 && Naves.Posição[1] == j + 1)
                            {
                                if (Naves.EInimigo == true && Naves.Vivo == true)
                                {
                                    Campo[i, j] = "<-  ";
                                }
                                else if(Naves.EInimigo == false && Naves.Vivo == true)
                                {
                                    Campo[i, j] = "->  ";
                                }
                                else
                                {

                                }
                            }
                            if (ListaTiros.Count > 0)
                            {
                                foreach (Projétil elemento in ListaTiros)
                                {
                                    if (elemento.Posição[0] == i && elemento.Posição[1] == j)
                                    {
                                        Campo[i, j] = "@   ";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            void AtirarPlayer()
            {
                //NavePlayer.Atirar();
                atirou = true;
                ListaTiros.Add( new Projétil(10,1,NavePlayer.Posição[0] - 1, NavePlayer.Posição[1]));
            }
            void Colisoes()
            {
                foreach (Projétil elementoTiro in ListaTiros)
                {
                    foreach (Nave elementoNave in NavesEmJogo)
                        // se bala acerta alvo
                    if (elementoTiro.Posição[0] + 1 == elementoNave.Posição[0] && elementoTiro.Posição[1] + 1 == elementoNave.Posição[1])
                    {
                            elementoNave.Morte();
                    }
                }
            }
            void FimDeJogo()
            {
                if (NavePlayer.Vivo == false || NavePlayer.NivelCombustivel <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Você foi capturado pelos piratas do espaço :(");
                    Console.ReadLine();
                }
                else if (NaveInimigo1.Vivo == false &&
                    NaveInimigo2.Vivo == false &&
                    NaveInimigo3.Vivo == false)
                {
                    Console.Clear();
                    Console.WriteLine("win");
                }
                else
                {
                    return;
                }
            }
        }

    }
}
