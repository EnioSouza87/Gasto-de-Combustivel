using System;

namespace trabalho_g1_parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============PROGRAMA DE CÁLCULO DE COMBUSTÍVEL GASTO======");
            Console.WriteLine("BEM VINDO");
            Console.WriteLine(" ");
            Console.Write("INFORME QUANTOS KM O SEU CARRO FAZ POR LITRO: ");
            double quilometros_litros = Convert.ToDouble(Console.ReadLine());

            Console.Write("INFORME O TEMPO GASTO NA VIAGEM: ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("INFORME A VELOCIDADE: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("INFORME AGORA O PREÇO DA GASOLINA COMUM: ");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("INFORME O PREÇO DA GASOLINA ADITIVADA: ");
            double gasolinaAditivada = Convert.ToDouble(Console.ReadLine());


            double litros_usados;
            double distancia;
            double gastoComum;
            double gastoAditivada;


            distancia = tempo * velocidade;
            litros_usados = distancia / quilometros_litros;
            gastoComum = litros_usados * gasolina;
            gastoAditivada = litros_usados * gasolinaAditivada;
            Console.WriteLine("========================================");

            Console.WriteLine("RELATORIO DE DESPESA ");



            Console.WriteLine("=========================================   ");
            Console.WriteLine("        ");
            Console.WriteLine("velocidade média: " + velocidade + " km");
            Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
            Console.WriteLine("distância percorrida: " + distancia + " quilometros");
            Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
            Console.WriteLine("Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
            Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");

            Console.WriteLine("=========================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("POSSIBILIDADE DE REVISÃO");
            Console.WriteLine("CARROS DA CLASSE: A, C , F , H: MELHORIA MÁXIMA ALCANÇADA: 10%");
            Console.WriteLine("CARROS DA CLASSE: B, D, E, I, J, T: MELHORIA MÁXIMA ALCANÇADA: 15%");
            Console.WriteLine("CARROS DA CLASSE: K,R: MELHORIA MÁXIMA ALCANÇADA: 25%");
            Console.WriteLine("CARROS DA CLASSE: L, M, N, O, P, Q, S: MELHORIA MÁXIMA ALCANÇADA: 35%");
            Console.WriteLine("CARROS DA CLASSE: U,V,X,Y,W,Z: MELHORIA MÁXIMA ALCANÇADA: 50%");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("DEFINA O TIPO DO SEU CARRO: ");
            string tipoCarro = Console.ReadLine();

            if (tipoCarro == "a" || tipoCarro == "c" || tipoCarro == "f" || tipoCarro == "h")
            {

                double revisao = 0.10 * quilometros_litros;
                double novakm = revisao + quilometros_litros;
                distancia = tempo * velocidade;
                litros_usados = distancia / novakm;
                gastoComum = litros_usados * gasolina;
                gastoAditivada = litros_usados * gasolinaAditivada;


                Console.WriteLine("======================================");
                Console.WriteLine("RESUMO FINAL APÓS A REVISÃO");
                Console.WriteLine("===================================");
                Console.WriteLine("    ");
                Console.WriteLine("nova quilometragem por litro após a revisão: " + novakm + " km");
                Console.WriteLine("velocidade média: " + velocidade + " km");
                Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
                Console.WriteLine("distância percorrida: " + distancia + " quilometros");
                Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
                Console.WriteLine("Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
                Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");

            }else if (tipoCarro=="b" || tipoCarro=="d" || tipoCarro == "e" || tipoCarro =="i" || tipoCarro=="j" ||
                tipoCarro == "t")

            {
                double revisao = 0.15 * quilometros_litros;
                double novakm = revisao + quilometros_litros;
                distancia = tempo * velocidade;
                litros_usados = distancia / novakm;
                gastoComum = litros_usados * gasolina;
                gastoAditivada = litros_usados * gasolinaAditivada;


                Console.WriteLine("======================================");
                Console.WriteLine("RESUMO FINAL APÓS A REVISÃO");
                Console.WriteLine("===================================");
                Console.WriteLine("    ");
                Console.WriteLine("nova quilometragem por litro após a revisão: " + novakm + " km");
                Console.WriteLine("velocidade média: " + velocidade + " km");
                Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
                Console.WriteLine("distância percorrida: " + distancia + " quilometros");
                Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
                Console.WriteLine("Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
                Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");

            }else if(tipoCarro=="k" || tipoCarro == "r")


            {
                double revisao = 0.25 * quilometros_litros;
                double novakm = revisao + quilometros_litros;
                distancia = tempo * velocidade;
                litros_usados = distancia / novakm;
                gastoComum = litros_usados * gasolina;
                gastoAditivada = litros_usados * gasolinaAditivada;


                Console.WriteLine("======================================");
                Console.WriteLine("RESUMO FINAL APÓS A REVISÃO");
                Console.WriteLine("===================================");
                Console.WriteLine("    ");
                Console.WriteLine("nova quilometragem por litro após a revisão: " + novakm + " km");
                Console.WriteLine("velocidade média: " + velocidade + " km");
                Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
                Console.WriteLine("distância percorrida: " + distancia + " quilometros");
                Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
                Console.WriteLine("Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
                Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");

            }else if(tipoCarro=="l" || tipoCarro=="m" || tipoCarro=="n" || tipoCarro=="o" ||tipoCarro=="p" || 
             tipoCarro=="q" || tipoCarro == "s")

            {
                double revisao = 0.35 * quilometros_litros;
                double novakm = revisao + quilometros_litros;
                distancia = tempo * velocidade;
                litros_usados = distancia / novakm;
                gastoComum = litros_usados * gasolina;
                gastoAditivada = litros_usados * gasolinaAditivada;


                Console.WriteLine("======================================");
                Console.WriteLine("RESUMO FINAL APÓS A REVISÃO");
                Console.WriteLine("===================================");
                Console.WriteLine("    ");
                Console.WriteLine("nova quilometragem por litro após a revisão: " + novakm + " km");
                Console.WriteLine("velocidade média: " + velocidade + " km");
                Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
                Console.WriteLine("distância percorrida: " + distancia + " quilometros");
                Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
                Console.WriteLine("Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
                Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");

            }else if(tipoCarro=="u" || tipoCarro=="v" || tipoCarro=="x" || tipoCarro=="y" || tipoCarro=="w"
            || tipoCarro == "z")

            {
                double revisao = 0.50 * quilometros_litros;
                double novakm = revisao + quilometros_litros;
                distancia = tempo * velocidade;
                litros_usados = distancia / novakm;
                gastoComum = litros_usados * gasolina;
                gastoAditivada = litros_usados * gasolinaAditivada;


                Console.WriteLine("======================================");
                Console.WriteLine("RESUMO FINAL APÓS A REVISÃO");
                Console.WriteLine("===================================");
                Console.WriteLine("    ");
                Console.WriteLine("nova quilometragem por litro após a revisão: " + novakm + " km");
                Console.WriteLine("velocidade média: " + velocidade + " km");
                Console.WriteLine("tempo gasto na viagem: " + tempo + " horas");
                Console.WriteLine("distância percorrida: " + distancia + " quilometros");
                Console.WriteLine("Litros usados na viagem: " + Math.Round(litros_usados) + " litros");
                Console.WriteLine($"Custo total usando gasolina comum: " + Math.Round(gastoComum) + " reais");
                Console.WriteLine("custo total usando gasolina aditivada: " + Math.Round(gastoAditivada) + " reais");
            }
            
         }
    }
}
