string cad_usuario, cad_senha;
string form_usuario, form_senha;
int tentativas = 3, menu;

cad_usuario = "";
cad_senha = "";

Console.WriteLine("para cadastro digite 1");
Console.WriteLine("para logar digite 2");
menu = int.Parse(Console.ReadLine());

switch (menu)
{
    case 1:
        Console.Clear();
        Console.WriteLine("escolha um nome:");
        cad_usuario = Console.ReadLine();
        Console.WriteLine("Qual a senha para este usuario:");
        cad_senha = Console.ReadLine();
        Console.Clear();
        break;

    case 2:
        while(tentativas > 0)
        {
            Console.Clear();
            Console.WriteLine("usuario");
            form_usuario = Console.ReadLine();
            Console.WriteLine("senha");
            form_senha = Console.ReadLine();  

            if (cad_usuario == form_usuario && cad_senha == form_senha)
            {
                Console.WriteLine("Usuario logado");
                tentativas = 0;
            }
            else
            {
                Console.WriteLine("tentativa incorreta!");
                tentativas--;
            }
        }
        break;

    default:
        break;
}