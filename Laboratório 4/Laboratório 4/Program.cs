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
        static void Main(string[] args)
        {
            //construção naves
            NaveDeGuerra NavePlayer = new NaveDeGuerra("Bob Nelson",40,30,1,10,10,false);
            NaveDeTransporte NavePlayerCena2 = new NaveDeTransporte("Bob Nelson",130,30,1,3,15, 2);
            NaveDeGuerra NaveInimigo1 = new NaveDeGuerra("inimigoTeste1",100,1,1,15,20,true);
            NaveDeGuerra NaveInimigo2 = new NaveDeGuerra("inimigoTeste2", 100, 1, 1, 10, 20,true);
            NaveDeGuerra NaveInimigo3 = new NaveDeGuerra("inimigoTeste3", 100, 1, 1, 5, 20,true);
            NaveDeGuerra NaveInimigo4 = new NaveDeGuerra("inimigoTeste4", 100, 1, 1, 20, 20, true);
            NaveDeGuerra NaveInimigo5 = new NaveDeGuerra("inimigoTeste5", 100, 1, 1, 19, 20, true);
            NaveDeGuerra[] NavesCena1 = new NaveDeGuerra[] { NavePlayer,NaveInimigo1, NaveInimigo2, NaveInimigo3 };
            Nave[] NavesCena2Inimigos = new NaveDeGuerra[] {NaveInimigo4, NaveInimigo5};
            int cena = 1;
            int delayTiro = 1;
            int delayAsteroide = 1;
            bool verificarDanos = false;
            bool atirou = false;
            int ação = 0;
            List<Projétil> ListaTiros = new List<Projétil>();
            List<Asteroide> ListaAsteroides = new List<Asteroide>();
            ListaAsteroides.Add(new Asteroide(10, 0, NavePlayer.Posição[1] - 1));
            string[,] Campo;
            Campo = new string[20, 20];

            // cena 1
            while (NavePlayer.Energia > 0 && cena == 1)
            {
                // delimita a tela
                DelimitarEspaço();
                if (atirou)
                {
                    AtirarPlayer();
                    atirou = false;
                }
                Colisoes();
                DeterminarEspaçosCena1();
                DesenharEspaço();
                FimDeJogo();
                if(cena == 1)
                {
                    // movimentação projetil e meteoro
                    foreach (Projétil elemento in ListaTiros)
                    {
                        elemento.MovimentaçãoProjétil();
                    }
                    foreach (Asteroide elementoAsteroide in ListaAsteroides)
                    {
                        elementoAsteroide.Posição[0] += 1;
                    }
                    //ações do player
                    ação = int.Parse(Console.ReadLine());
                    switch (ação)
                    {
                        case 1:
                            if (cena == 1)
                                atirou = true;
                            break;
                        case 2:
                            verificarDanos = true;
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
                    // depois da ação do player, tem as ações gerais
                    AtirarInimigo();
                    CriarMeteoros();
                }
                Console.Clear();
                NavePlayer.GastarCombustivel();
                Console.WriteLine($"COMBUSTÍVEL : {NavePlayer.NivelCombustivel}");

            }

            // cena 2
            while (NavePlayer.Energia > 0 && cena == 2)
            {
                DelimitarEspaço();
                Colisoes();
                DeterminarEspaçosCena2();
                DesenharEspaço();
                FimDeJogo();
                if (cena == 2)
                {
                    // movimentação projetil e meteoro
                    foreach (Projétil elemento in ListaTiros)
                    {
                        elemento.MovimentaçãoProjétil();
                    }
                    foreach (Asteroide elementoAsteroide in ListaAsteroides)
                    {
                        elementoAsteroide.Posição[0] += 1;
                    }
                    //ações do player
                    ação = int.Parse(Console.ReadLine());
                    switch (ação)
                    {
                        case 2:
                            verificarDanos = true;
                            break;
                        case 3:
                            NavePlayerCena2.MoverCima();
                            NavePlayerCena2.LimitarEspaço();
                            break;
                        case 4:
                            NavePlayerCena2.MoverBaixo();
                            NavePlayerCena2.LimitarEspaço();
                            break;
                        case 5:
                            NavePlayerCena2.MoverDireita();
                            NavePlayerCena2.LimitarEspaço();
                            break;
                        case 6:
                            NavePlayerCena2.MoverEsquerda();
                            NavePlayerCena2.LimitarEspaço();
                            break;
                    }
                    // depois da ação do player, tem as ações gerais
                    AtirarInimigo();
                    CriarMeteoros();
                }
                Console.Clear();
                NavePlayerCena2.GastarCombustivel();
                Console.WriteLine($"COMBUSTÍVEL : {NavePlayerCena2.NivelCombustivel}");
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
                if (cena == 1)
                {
                    if (verificarDanos == true)
                    {
                        Console.WriteLine($"{NavePlayer.VerificarDanos()}\n(1)ATACAR\n(2)VER DANOS\n(3)MOVER PARA CIMA\n(4)MOVER PARA BAIXO\n" +
                            "(5)MOVER PARA DIREITA\n(6)MOVER PARA ESQUERDA\n\n@-METEOROS\n< >-TIRO LASER\nB-BOB NELSON\nP-PIRATA ESPACIAL");
                        verificarDanos = false;
                    }
                    else
                        Console.WriteLine("\n(1)ATACAR\n(2)VER DANOS\n(3)MOVER PARA CIMA\n(4)MOVER PARA BAIXO\n" +
                            "(5)MOVER PARA DIREITA\n(6)MOVER PARA ESQUERDA\n\n@-METEOROS\n< >-TIRO LASER\nB-BOB NELSON\nP-PIRATA ESPACIAL");
                }
                else
                {
                    if (verificarDanos == true)
                    {
                        Console.WriteLine($"{NavePlayerCena2.VerificarDanos()}\n(2)VER DANOS\n(3)MOVER PARA CIMA\n(4)MOVER PARA BAIXO\n" +
                            "(5)MOVER PARA DIREITA\n(6)MOVER PARA ESQUERDA\n\n@-METEOROS\n< >-TIRO LASER\nB-BOB NELSON\nP-PIRATA ESPACIAL\nD-DESTINO");
                        verificarDanos = false;
                    }
                    else
                        Console.WriteLine("\n(2)VER DANOS\n(3)MOVER PARA CIMA\n(4)MOVER PARA BAIXO\n" +
                            "(5)MOVER PARA DIREITA\n(6)MOVER PARA ESQUERDA\n\n@-METEOROS\n< >-TIRO LASER\nB-BOB NELSON\nP-PIRATA ESPACIAL\nD-DESTINO");
                }


            }
            void DelimitarEspaço()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Campo[i, j] = "    ";
                    }
                }
            }
            void DeterminarEspaçosCena1()
            {
                foreach (NaveDeGuerra Naves in NavesCena1)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (Naves.Posição[0] == i + 1 && Naves.Posição[1] == j + 1)
                            {
                                if (Naves.EInimigo == true && Naves.Vivo == true)
                                {
                                    Campo[i, j] = "P   ";
                                }
                                else if(Naves.EInimigo == false && Naves.Vivo == true)
                                {
                                    Campo[i, j] = "B   ";
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
                                        if (elemento.VelocidadeTiro > 0)
                                        {
                                            Campo[i, j] = ">   ";
                                        }
                                        else
                                        {
                                            Campo[i, j] = "<   ";
                                        }
                                    }
                                }
                            }
                            if (ListaAsteroides.Count > 0)
                            {
                                foreach (Asteroide elementoAsteroide in ListaAsteroides)
                                {
                                    if (elementoAsteroide.Posição[0] == i && elementoAsteroide.Posição[1] == j)
                                    {
                                        Campo[i, j] = "@   ";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            void DeterminarEspaçosCena2()
            {
                foreach (NaveDeGuerra Naves in NavesCena2Inimigos)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (Naves.Posição[0] == i + 1 && Naves.Posição[1] == j + 1)
                            {
                                if (Naves.EInimigo == true && Naves.Vivo == true)
                                {
                                    Campo[i, j] = "P   ";
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
                                        if (elemento.VelocidadeTiro > 0)
                                        {
                                            Campo[i, j] = ">   ";
                                        }
                                        else
                                        {
                                            Campo[i, j] = "<   ";
                                        }
                                    }
                                }
                            }
                            if (ListaAsteroides.Count > 0)
                            {
                                foreach (Asteroide elementoAsteroide in ListaAsteroides)
                                {
                                    if (elementoAsteroide.Posição[0] == i && elementoAsteroide.Posição[1] == j)
                                    {
                                        Campo[i, j] = "@   ";
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (NavePlayerCena2.Posição[0] == i + 1 && NavePlayerCena2.Posição[1] == j + 1)
                        {
                            Campo[i, j] = "B   ";
                        }
                        if (i == 20 - 1 && j == 1 - 1)
                        {
                            Campo[i, j] = "D   ";
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
            void AtirarInimigo()
            {
                if (cena == 1)
                {
                    foreach (Nave elementoNave in NavesCena1)
                    {
                        if (elementoNave.EInimigo && elementoNave.Vivo && delayTiro >= 5)
                        {
                            ListaTiros.Add(new Projétil(10, -1, elementoNave.Posição[0] - 1, elementoNave.Posição[1] - 2));
                            delayTiro = 0;
                        }
                        delayTiro += 1;
                    }
                }
                else
                {
                    foreach (Nave elementoNave in NavesCena2Inimigos)
                    {
                        if (elementoNave.EInimigo && elementoNave.Vivo && delayTiro >= 5)
                        {
                            ListaTiros.Add(new Projétil(10, -1, elementoNave.Posição[0] - 1, elementoNave.Posição[1] - 2));
                            delayTiro = 0;
                        }
                        delayTiro += 1;
                    }
                }
            }
            void Colisoes()
            {
                if (cena == 1)
                {
                    foreach (Projétil elementoTiro in ListaTiros)
                    {
                        foreach (Nave elementoNave in NavesCena1)
                            // se bala acerta alvo
                            if (elementoTiro.Posição[0] + 1 == elementoNave.Posição[0] && elementoTiro.Posição[1] + 1 == elementoNave.Posição[1])
                            {
                                elementoNave.LevarDano(elementoTiro.PotenciaTiro);
                            }
                    }
                    foreach (Asteroide elementoAsteroide in ListaAsteroides)
                    {
                        if (elementoAsteroide.Posição[0] + 1 == NavePlayer.Posição[0] && elementoAsteroide.Posição[1] + 1 == NavePlayer.Posição[1])
                        {
                            NavePlayer.LevarDano(elementoAsteroide.Dano);
                        }
                    }
                }
                else
                {
                    foreach (Projétil elementoTiro in ListaTiros)
                    {
                            // se bala acerta alvo
                            if (elementoTiro.Posição[0] + 1 == NavePlayerCena2.Posição[0] && elementoTiro.Posição[1] + 1 == NavePlayerCena2.Posição[1])
                            {
                            NavePlayerCena2.LevarDano(elementoTiro.PotenciaTiro);
                            }
                    }
                    foreach (Asteroide elementoAsteroide in ListaAsteroides)
                    {
                        if (elementoAsteroide.Posição[0] + 1 == NavePlayerCena2.Posição[0] && elementoAsteroide.Posição[1] + 1 == NavePlayerCena2.Posição[1])
                        {
                            NavePlayerCena2.LevarDano(elementoAsteroide.Dano);
                        }
                    }
                }

            }
            void FimDeJogo()
            {
                if (cena == 1)
                {
                    if (NavePlayer.Vivo == false || NavePlayer.NivelCombustivel <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Bob Nelson foi capturado pelos piratas do espaço :(");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (NaveInimigo1.Vivo == false &&
                        NaveInimigo2.Vivo == false &&
                        NaveInimigo3.Vivo == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Bob Nelson derrotou o piratas do espaço e pegou a carga especial, porém, Bob ainda precisa escapar com a carga especial.\nCHEGUE NO DESTINO COM A NAVE DE BOB NELSON" +
                            "\n\nclique enter para ir para a próxima fase");
                        Console.ReadLine();
                        cena = 2;
                    }
                    else
                    {
                        return;
                    }
                }
                if (cena == 2)
                {
                    if (NavePlayerCena2.Vivo == false || NavePlayerCena2.NivelCombustivel <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Bob Nelson foi capturado pelos piratas do espaço :(");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (NavePlayerCena2.Posição[0] == 20 && NavePlayerCena2.Posição[1] == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Bob Nelson chegou ao seu destino com a carga intacta, parabéns :)");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        return;
                    }
                }

            }
            void CriarMeteoros()
            {
                if (cena == 1)
                {
                    if (delayAsteroide >= 5)
                    {
                        ListaAsteroides.Add(new Asteroide(10, 0, NavePlayer.Posição[1] - 1));
                        delayAsteroide = 0;
                    }
                    else
                    {
                        delayAsteroide += 1;
                    }
                }
                else
                {
                    if (delayAsteroide >= 5)
                    {
                        ListaAsteroides.Add(new Asteroide(10, 0, NavePlayerCena2.Posição[1] - 1));
                        delayAsteroide = 0;
                    }
                    else
                    {
                        delayAsteroide += 1;
                    }
                }

            }
        }

    }
}
