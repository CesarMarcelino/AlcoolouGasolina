Console.Clear();

Console.WriteLine("--- Alcool ou Gasolina? ---\n");

Console.Write("Digite o preço do Alcool (R$).....: ");
decimal Alcool = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (AbastecerComGasolina(Alcool, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Alcool";
}

double razao = RazaoAlcoolGasolina(Alcool, gasolina) * 100;

Console.WriteLine($"\nO preço do Alcool corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {recomendacao.ToUpper()}.");

double RazaoAlcoolGasolina(decimal precoAlcool, decimal precoGasolina)
{
    return Convert.ToDouble(precoAlcool / precoGasolina);
}

bool AbastecerComGasolina(decimal precoAlcool, decimal precoGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoAlcoolGasolina(precoAlcool, precoGasolina) >= MinRazaoUsoGasolina;
}