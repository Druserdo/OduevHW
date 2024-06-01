using System.Text;

namespace FileManager_Oduew_POB2312
{
    internal class Program
    {
        private  const int WINDOW_WiDTH = 120;
        private const int WINDOW_HEIGHT = 40;
        private static string _currentDir=Directory.GetCurrentDirectory();


        public static void Main(string[] args)
        {
            Console.SetWindowSize(WINDOW_WiDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WiDTH, WINDOW_HEIGHT);

            DirectoryInfo dir = new DirectoryInfo(_currentDir);
            _currentDir = dir.Root.FullName;

            DrawConsole(0, 0, WINDOW_WiDTH, 25);
            DrawConsole(0, 25, WINDOW_WiDTH, 8);

           UpdateConsole();
        }
        public static void UpdateConsole()
        {
            DrawInputCommandFiled(_currentDir, 0, 33, WINDOW_WiDTH, 3);

            CommandInputProcess();
        }
        public static void CommandParser(string command)
        {
            string[] commandParts = command.Split(" ");

            switch (commandParts[0])
            {
                case "cd":
                    if(commandParts.Length == 1)  
                    {
                        _currentDir = new DirectoryInfo(_currentDir).Root.FullName;
                    }
                    else if(commandParts.Length==2)
                    {
                        if (commandParts[1] == "..")
                        {
                            _currentDir = new DirectoryInfo(_currentDir).Parent.FullName;
                        }
                        else if (commandParts[1].Contains('\\'))
                        {
                            if (Directory.Exists(commandParts[1]))
                            {
                                _currentDir = commandParts[1];
                            }
                        }
                        else if (Directory.Exists(_currentDir + commandParts[1]))
                            {
                                _currentDir += commandParts[1];
                            }
                        
                    }
                    
                    break;
                    
            }

            UpdateConsole();
        }
        public static void CommandInputProcess()
        {
            StringBuilder command = new StringBuilder();

            char pressedKey;
            int savedLeftPosition= Console.CursorLeft;

            do
            {
                pressedKey= Console.ReadKey().KeyChar;

                ConsoleKey key = (ConsoleKey)pressedKey;

                int left = Console.CursorLeft;
                int top = Console.CursorTop;


                if (key == ConsoleKey.Backspace)
                {


                    if (left < savedLeftPosition)
                    {
                        Console.Write("$");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(left, top);

                        command.Remove(command.Length - 1, 1);
                    }
                }
                else if (left == WINDOW_WiDTH - 2)
                {
                    Console.SetCursorPosition(left - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(left - 1, top);
                }
                else
                {

                    command.Append(pressedKey);
                }
            }
            while ((ConsoleKey)pressedKey != ConsoleKey.Enter);

            command.Remove(command.Length - 1, 1);

            CommandParser(command.ToString());
        }
        public static void DrawInputCommandFiled(string currentDir,int left, int top, int widht, int height)
        {
            DrawConsole(left, top, widht, height);
            Console.SetCursorPosition(1, 34);
            Console.Write($"{currentDir}$");
        }
        public static void DrawConsole(int left, int top, int widht, int height)
        {
            Console.SetCursorPosition(left, top);

            Console.Write("┌");
            for (int j = 0; j < widht - 2; j++)
            {
                Console.Write("─");
            }
            Console.Write("┐");

            for (int i = 0; i < height-2; i++)
            {
                Console.Write("│");
                for (int j = 0; j < widht - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("│");
            }
            Console.Write("└");
            for (int j = 0; j < widht - 2; j++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
        }

    }
}
