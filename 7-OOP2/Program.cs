//Создать класс игрока, у которого есть поля с его положением в x, y.
//Создать класс отрисовщик, с методом, который отрисует игрока.
//Попрактиковаться в работе со свойствами.
using System;

namespace _7_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new(10, 10);
            Renderer renderer = new();
            
            renderer.DrawCharacter(player.HorizontalCoordinatesCharacter, player.VerticalCoordinatesCharacter);
        }
    }

    public class Player
    {
        public int VerticalCoordinatesCharacter { get; private set; }

        public int HorizontalCoordinatesCharacter { get; private set; }

        public Player(int verticalCoordinatesCharacter, int horizontalCoordinatesCharacter)
        {
            VerticalCoordinatesCharacter = verticalCoordinatesCharacter;
            HorizontalCoordinatesCharacter = horizontalCoordinatesCharacter;
        }       
    }

    public class Renderer
    {
        public void DrawCharacter(int verticalCoordinatesCharacter, int horizontalCoordinatesCharacter, char sign = '@')
        {
            Console.SetCursorPosition(verticalCoordinatesCharacter, horizontalCoordinatesCharacter);
            Console.Write(sign);
        }
    }
}
