// Попробуйте переработать приложение, добавив подтверждение об отправке сообщений как в сервер, так и в клиент.



using SetDz1;

internal class Program
{
    
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Chat.Server();
        }
        else
        {
            Chat.Client(args[0]);
        }
    }
}