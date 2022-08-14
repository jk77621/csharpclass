using System;

namespace MyBuffer
{
    class ConsoleBuffer
    {
        private readonly int width;         // 가로 크기
        private readonly int height;        // 세로 크기
        private char[,] backBuffer = null;  // 각 변경사항, 정보들을 입력받는 백버퍼.
        private char[,] frontBuffer = null; // 백버퍼를 받아 보여주기위한 프론트버퍼

        // 가로, 세로 값을 받아 저장하고 백버퍼와 프론트버퍼를 인스턴스화한다.
        // 콘솔창 크기도 버퍼 크기와 맞게 설정한다.
        public ConsoleBuffer(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
            backBuffer = new char[height, width];
            frontBuffer = new char[height, width];
            Console.SetWindowSize(width, height + 1); // 콘솔에 출력된 문자들이 밀리는 현상을 방지하기 위해 height + 1 
            Console.CursorVisible = false;            // 커서 표시를 제한.
        }

        // 백버퍼를 읽기전용으로 제공.
        public char[,] Buffer => backBuffer;

        // 지정한 크기의 범위가 넘쳤는지 판단하는 메서드.
        private bool IsRangeOut(int inX, int inY)
        {
            if ((inX >= width || inY >= height) || (inX < 0 || inY < 0))
                return true;

            return false;
        }

        // 문자를 백버퍼에 쓰는 메서드.
        public void Draw(char inChar, int inX, int inY)
        {
            if (!IsRangeOut(inX, inY))
                backBuffer[inY, inX] = inChar;
        }

        // 문자열을 문자배열로 만들어 해당 위치에 인덱스마다 쓰는 메서드.
        public void Draw(string inStr, int inX, int inY)
        {
            char[] temp = inStr.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!IsRangeOut(inX, inY))
                    backBuffer[inY, inX + i] = temp[i];
            }
        }

        // 백버퍼를 프론트버퍼에 복사하는 메서드.
        // Array.Copy메서드를 통해 같은 타입의 배열이기 때문에
        // boxing이 일어날 걱정없이 복사가 된다.
        private void BufferExtraction()
        {
            Array.Copy(backBuffer, frontBuffer, width * height);
        }

        // 백버퍼를 비우는 메서드.
        public void ClearBuffer()
        {
            Array.Clear(backBuffer, 0, width * height);
        }

        // 프론트버퍼를 출력하는 메서드.
        private void Print()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(frontBuffer[y, x]);
                }
                Console.WriteLine();
            }
        }

        // 화면에 보여주기위한 메서드.
        public void Show()
        {
            BufferExtraction();
            Console.SetCursorPosition(0, 0);
            Print();
        }
    }
}
