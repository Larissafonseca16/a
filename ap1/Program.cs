  bool continuar = true;

        // Loop principal para permitir relatórios múltiplos
    do
        {
            Console.WriteLine("Calculadora de IMC e Idade");
            Console.WriteLine("---------------------------");

            // Pergunte o nome da pessoa
            Console.Write("Nome da pessoa: ");
            string? nome = Console.ReadLine();

            // Pergunte a idade
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine()?? "");

            // Pergunte a altura em centímetros
            Console.Write("Altura (centímetros): ");
            double alturaCm = double.Parse(Console.ReadLine()?? "");

            // Converta a altura para metros
            double altura = alturaCm / 100.0;

            // Pergunte o peso em quilogramas
            Console.Write("Peso (quilogramas): ");
            double peso = double.Parse(Console.ReadLine()?? "");

            // Calcule o IMC
            double imc = peso / (altura * altura);

            // Determine a categoria de IMC
            string categoriaIMC;
            if (imc < 18.5)
            {
                categoriaIMC = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                categoriaIMC = "Normal";
            }
            else if (imc < 29.9)
            {
                categoriaIMC = "Sobrepeso";
            }
            else
            {
                categoriaIMC = "Obeso";
            }

            // Determine a faixa etária
            string faixaEtaria;
            if (idade < 13)
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 20)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            // Gere o relatório
            Console.WriteLine("\nRelatório");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})");
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

            // Pergunte se o usuário deseja gerar outro relatório
            Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
            string resposta = Console.ReadLine()?? "".ToUpper();

            // Verifique a resposta para decidir se continuamos ou encerramos o programa
            if (resposta != "S")
            {
                continuar = false;
            }

        } while (continuar);

        Console.WriteLine("Programa encerrado.");