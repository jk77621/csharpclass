
namespace Sokoban
{
    class SokobanUI
    {
        // 해당 위치에 문자를 쓰는 메서드.
        public void DrawText(char[,] inCharArr, char inChar, int inX, int inY)
        {
            inCharArr[inY, inX] = inChar;
        }

        // 문자열을 문자배열로 만들어 해당 위치에 인덱스마다 쓰는 메서드.
        public void DrawText(char[,] inCharArr, string inStr, int inX, int inY)
        {
            char[] temp = inStr.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                inCharArr[inY, inX + i] = temp[i];
            }
        }

        // 소코반 게임 정보들을 쓰는 메서드.
        public void WriteUI(char[,] inCharArr)
        {
            DrawText(inCharArr, "Stage   : ", 1, 12);
            DrawText(inCharArr, "Move    : ", 1, 13);
            DrawText(inCharArr, "Player  : ", 1, 15);
            DrawText(inCharArr, "Wall    : ", 1, 16);
            DrawText(inCharArr, "Box     : ", 1, 17);
            DrawText(inCharArr, "Goal    : ", 1, 18);
            DrawText(inCharArr, "GoalBox : ", 1, 19);
            DrawText(inCharArr, "Reset : ", 20, 15);
            DrawText(inCharArr, "Quit  : ", 20, 16);
        }
    }
}
