using System;

namespace Sokoban
{
    class Player
    {
        private int x;                // 플레이어 x 좌표
        private int y;                // 플레이어 y 좌표
        private readonly char images; // 플레이어 이미지 문자

        // 플레이어의 초기 좌표와 이미지를 설정하는 생성자.
        public Player(char inImages, int inX, int inY)
        {
            x = inX;
            y = inY;
            images = inImages;
        }

        // 각 값들을 읽기전용으로 제공
        public char Images => images;

        public int X => x;

        public int Y => y;

        // x, y 좌표를 설정하는 메서드.
        public void SetLocation(int inX, int inY)
        {
            x = inX;
            y = inY;
        }

        // 플레이어의 방향에따라 움직여주는 메서드.
        public void Move(ConsoleKeyInfo inKey)
        {
            switch (inKey.Key)
            {
                case ConsoleKey.RightArrow:
                    ++x;
                    break;

                case ConsoleKey.LeftArrow:
                    --x;
                    break;

                case ConsoleKey.UpArrow:
                    --y;
                    break;

                case ConsoleKey.DownArrow:
                    ++y;
                    break;

                default:
                    return;
            }
        }
    }
}
