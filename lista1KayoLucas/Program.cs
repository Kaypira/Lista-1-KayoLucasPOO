// lista 1 POO!
Console.WriteLine("digite qual exercicio voce quer iniciar");
int opcao = int.Parse(Console.ReadLine()); 
switch (opcao)
{
    case 1:
        //ex1
        
        Console.WriteLine("Saiba se C é maior que A e B");
        Console.WriteLine("DIGITE A"); int ex1a = (int.Parse(Console.ReadLine()));
        Console.WriteLine("DIGITE B"); int ex1b = (int.Parse(Console.ReadLine()));
        Console.WriteLine("DIGITE C"); int ex1c = (int.Parse(Console.ReadLine()));
        if (ex1a + ex1b < ex1c)
        {
            Console.WriteLine("C É MAIOR QUE A E B, ELE É POTENTE");
        }
        else
        {
            Console.WriteLine("C É MENOR QUE A + B, ELE É FRACO");
        }

        break;
        case 2:
        //ex 2
        Console.WriteLine("CADASTRO ESTADO CIVIL");
        Console.WriteLine("DIGITE SEU NOME"); string ex2name = (Console.ReadLine());
        Console.WriteLine("DIGITE SEU SEXO EM M OU F "); string ex2sex = (Console.ReadLine().ToUpper());
        Console.WriteLine("DIGITE SEU ESTADO CIVIL"); string ex2c = (Console.ReadLine().ToUpper());
        Console.WriteLine(ex2name);
        Console.WriteLine(ex2sex);
        Console.WriteLine(ex2c);
        if (ex2sex == "F" && ex2c == "CASADA")
        {
            Console.WriteLine("DIGITE QUANTO ANOS DE CASAMENTO"); int tempca = (int.Parse(Console.ReadLine()));
        }
        else
        {
            Console.WriteLine("concluido");
        }



        break;
        case 3:
        //ex 3
        Console.WriteLine("SAIBA SE UM NUMERO É IMPAR OU PAR");
        Console.WriteLine("DIGITE O NUMERO INTEIRO"); int n1 = (int.Parse(Console.ReadLine()));
        Console.WriteLine(n1);
        if (n1 % 2 == 0)
        {
            Console.WriteLine("VOCE DIGITOU UM NUMERO PAR");
        }
        else
        {
            Console.WriteLine("voce digitou um numero impar");
        }

        break;
            
    case 4:
        //ex4
        Console.WriteLine("digite o numero A"); int ex4a = (int.Parse(Console.ReadLine()));
        Console.WriteLine("digite o numero B"); int ex4b = (int.Parse(Console.ReadLine()));

        if (ex4a == ex4b)
        {
            int ex4c = (ex4a + ex4b);
            Console.WriteLine(" Os Valores são iguais e o seu resultado é  " + ex4c);
        }
        else
        {
            int ex4c = (ex4a * ex4b);
            Console.WriteLine(" Os Valores são diferentes e o seu resultado é " + ex4c);
        }
        break;
            
    case 5:
        // ex5
        Console.WriteLine("digite um numero "); int ex5numa = (int.Parse(Console.ReadLine()));
        if (ex5numa >= 0)
        {
            Console.WriteLine("esse numero é positivo e o seu dobro é " + ex5numa * 2);
        }
        else
        {
            Console.WriteLine("esse numero é negativo e o seu triplo é " + ex5numa * 3);
        }
        break;
        case 6:
        // -ex6
        Console.WriteLine("digite um o valor boleano"); bool ex6mofi = bool.Parse(Console.ReadLine());
        Console.WriteLine("digite outro  valor boleano"); bool ex6mofi2 = bool.Parse(Console.ReadLine());
        if (ex6mofi && ex6mofi2)
        {
            Console.WriteLine("os dois sao verdadeiros mofi ");

        }
        else if (!ex6mofi && !ex6mofi2)
        {
            Console.WriteLine("todos são falsos");
        }
        else
        {
            Console.WriteLine("apenas 1 é verdadeiro ");
        }
        break;
        
    case 7:
        //ex7
        Console.WriteLine("digite um numero "); int ex7numa = (int.Parse(Console.ReadLine()));
        if (ex7numa % 2 == 0)
        {
            Console.WriteLine("esse numero é par, ele somado a 5 é: " + (ex7numa + 5));
        }
        else
            Console.WriteLine("esse numero é impar, ele somado a 8 é: " + (ex7numa + 8));


        break;
        case 8:
        //ex8
        Console.WriteLine("digite um numero "); int numa = (int.Parse(Console.ReadLine()));
        Console.WriteLine("digite um numero "); int numb = (int.Parse(Console.ReadLine()));
        Console.WriteLine("digite um numero "); int numc = (int.Parse(Console.ReadLine()));
        int aux = 0;
        if (numa < numb)
        {
            aux = numa;
            numa = numb;
            numb = aux;
        }
        if (numa < numc)
        {
            aux = numa;
            numa = numc;
            numc = aux;
        }
        if (numb < numc)
        {
            aux = numb;
            numb = numc;
            numc = aux;
        }
        Console.WriteLine(" o valor em ordem decrescente é " + numa + ", " + numb + ", " + numc + "!");
        break;

        case 9:
        //ex9
        Console.WriteLine("digite um sua altura "); double altu = (double.Parse(Console.ReadLine()));
        Console.WriteLine("digite o seu sexo M ou F"); string ex9sex = (Console.ReadLine().ToUpper());
        if (ex9sex == "M")
            Console.WriteLine("O SEU PESO IDEAL É " + ((72.7 * altu) - 58));
        else
            Console.WriteLine("O SEU PESO IDEAL É " + ((62.1 * altu) - 44.7));

        break;
        
    case 10:
        //ex10
        Console.WriteLine("digite um sua altura "); decimal ex10altu = (decimal.Parse(Console.ReadLine()));
        Console.WriteLine("digite o seu peso "); decimal pes = (decimal.Parse(Console.ReadLine()));
        decimal imc = (pes / (ex10altu * ex10altu));
        Console.WriteLine("o seu IMC é {0} a sua altura {1} e seu peso {2} ", imc, ex10altu, pes);
        if (imc < decimal.Parse("18.5"))
            Console.WriteLine("seu IMC é {0} voce esta ABAIXO do peso procure um medico ou nutricionista ", imc);
        else if (imc >= decimal.Parse("18.5") && imc < 25)
            Console.WriteLine("seu IMC é {0} voce esta no peso NORMAL continue assim ", imc);
        else if (imc >= 25 && imc < 30)
            Console.WriteLine("seu IMC é {0} voce esta ACIMA do peso procure um medico ou nutricionista ", imc);
        else
            Console.WriteLine("seu IMC é {0} voce esta OBESO procure um medico ou nutricionista ", imc);

        break;
    
    case 11:
        //Ex 11

        Console.WriteLine("digite o valor do seu produto "); int pre = (int.Parse(Console.ReadLine()));
        Console.WriteLine("digite 1 se for À vista em dinheiro ou cheque, recebe 10% de desconto");
        Console.WriteLine("digite 2 se for À vista no cartão de crédito, recebe 15% de desconto ");
        Console.WriteLine("digite 3 se for Em duas vezes, preço normal de etiqueta sem juros ");
        Console.WriteLine("digite 4 se for Em duas vezes, preço normal de etiqueta mais juros de 10% ");
        Console.WriteLine("qual a forma de pagamento"); int pag = (int.Parse(Console.ReadLine()));
        if (pag == 1)
        {
            double pag1 = 0.90 * pre;
            Console.WriteLine("o valor pago será  " + pag1);
        }
        else if (pag == 2)
        {
            double pag2 = (0.85 * pre);
            Console.WriteLine("o valor pago será " + pag2);
        }
        else if (pag == 3)
        {
            double pag3 = pre;
            Console.WriteLine("o valor pago será {0} ", pag3);
        }
        else if (pag == 4)
        {
            double pag4 = 1.10 * pre;
            Console.WriteLine("o valor pago será {0} ", pag4);
        }
        else
            Console.WriteLine("tente novamente");
        break;

        case 12:
        //ex 12


        Console.WriteLine("escreva seu numero de identificaçao "); int ex12num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva a sua 1 nota "); double ex12nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("escreva a sua 2 nota "); double ex12nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("escreva a sua 3 nota "); double ex12nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a media dos exercicios"); double ex12exer = double.Parse(Console.ReadLine());

        double ex12ma = (ex12nota1 + ex12nota2 * 2 + ex12nota3 * 3 + ex12exer) / 7;
        string ex12mofi = " Aluno " + ex12num1 + " suas notas são " + ex12nota1 + " " + ex12nota2 + " " + ex12nota3 + " " + ex12exer + " e sua media de aproveitamento é " + ex12ma;

        if (ex12ma >= 60)
        {
            Console.WriteLine(ex12mofi + " voce esta aprovado");
        }
        else
        {
            Console.WriteLine(ex12mofi + " voce está reprovado ");
        }

        break;
    default:
        Console.WriteLine("exercicio invalido ");
        break;
        



}








