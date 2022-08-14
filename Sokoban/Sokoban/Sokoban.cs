using System;
using MyBuffer;
using System.Threading;

namespace Sokoban
{
    class Sokoban
    {
        private int moveCount = 0;    // 플레이어 움직임 횟수
        private int stageNumber = 0;  // 스테이지 번호
        private int goalCount = 0;    // 골 개수

        private enum eDirection { RIGHT, LEFT, UP, DOWN };            // 입력한 방향키에 따라 값을 주기 위함.
        private Player player = new Player('∇', 0, 0);                // 플레이어의 이미지와 초기 위치 초기화
        private Map map = new Map();
        private ConsoleBuffer gameBoard = new ConsoleBuffer(40, 25);  // 게임이 그려질 화면 크기는 40x25
        private SokobanUI UI = new SokobanUI();

        // 각 스테이지마다 플레이어 위치 설정.
        // 스테이지를 받았지만 이전 스테이지의 블럭이 남아있을 수 있기 때문에
        // 게임화면을 비워준 뒤 새로운 스테이지를 받음.
        // 그리고 그 스테이지의 골 개수를 goalCount에 저장.
        private void SetGame(char[,] inBuf)
        {
            switch (stageNumber)
            {
                case 0:
                    player.SetLocation(4, 3);
                    break;
                case 1:
                    player.SetLocation(2, 3);
                    break;
                case 2:
                    player.SetLocation(2, 1);
                    break;
                case 3:
                    player.SetLocation(12, 8);
                    break;
                case 4:
                    player.SetLocation(8, 4);
                    break;
            }
            gameBoard.ClearBuffer();
            map.SetMap(map.stages[stageNumber], inBuf);
            goalCount = map.GetGoalCount(map.stages[stageNumber]);
        }

        // 방향에 따라 값 반환
        private int SetVertical(eDirection direction)
        {
            switch (direction)
            {
                case eDirection.UP:
                    return -1;
                case eDirection.DOWN:
                    return 1;
                default:
                    return 0;
            }
        }

        // 방향에 따라 값 반환
        private int SetHorizontal(eDirection direction)
        {
            switch (direction)
            {
                case eDirection.RIGHT:
                    return 1;
                case eDirection.LEFT:
                    return -1;
                default:
                    return 0;
            }
        }

        // 위의 SetVertical과 SetHorizontal이 필요한 이유.
        // 한 메서드에 tempX와 tempY를 각 방향에 알맞는 메서드를 호출해서 값을 저장한뒤
        // 각 x, y값마다 tempX와 tempY를 더해준다. 만약 플레이어의 오른쪽 값을 얻기 위해서는
        // direction이 RIGHT가 들어와 tempX는 1, tempY는 0 이되어 (x + 1, y + 0)이 되어
        // 플레이어 오른쪽의 값을 얻게된다.

        // 박스를 밀기 위한 메서드
        // 플레이어 다음 위치에 박스가 있을 경우에 박스 다음 위치에 벽, 박스, 골박스가 없으면 아래가 실행이된다.
        // 박스앞에 골이 있으면 박스가 있던 자리는 길로 채우고 다음 자리에는 골박스를 그린다.
        // 아니면 박스가 있던 자리는 길로 채우고 다음 자리에는 박스로 채운다.
        private void PushBox(int inX, int inY, eDirection direction)
        {
            int tempX = SetHorizontal(direction);
            int tempY = SetVertical(direction);

            if (map.IsBox(gameBoard.Buffer, inX + tempX, inY + tempY))
            {
                if (!map.IsWall(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) &&
                    !map.IsBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) &&
                    !map.IsGoalBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2))
                {
                    if (map.IsGoal(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2))
                    {
                        gameBoard.Draw(map.Road, inX + tempX, inY + tempY);
                        gameBoard.Draw(map.GoalBox, inX + tempX * 2, inY + tempY * 2);
                    }
                    else
                    {
                        gameBoard.Draw(map.Road, inX + tempX, inY + tempY);
                        gameBoard.Draw(map.Box, inX + tempX * 2, inY + tempY * 2);
                    }
                }
            }
        }

        // 골박스를 밀기위한 메서드.
        // 플레이어 다음 위치에 골박스가 있을 경우에 골박스가 다음 위치에 벽, 박스, 골박스가 없으면 아래가 실행이된다.
        // 골박스 앞에 골이 있으면 골박스가 있던 자리는 road로 채우고 다음 자리에는 골박스를 그린다.
        // 아니면 골박스가 있던 자리는 길로 채우고 다음 자리에는 박스로 채운다.
        private void PushGoalBox(int inX, int inY, eDirection direction)
        {
            int tempX = SetHorizontal(direction);
            int tempY = SetVertical(direction);

            if (map.IsGoalBox(gameBoard.Buffer, inX + tempX, inY + tempY))
            {
                if (!map.IsWall(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) &&
                    !map.IsBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) &&
                    !map.IsGoalBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2))
                {
                    if (map.IsGoal(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2))
                    {
                        gameBoard.Draw(map.Road, inX + tempX, inY + tempY);
                        gameBoard.Draw(map.GoalBox, inX + tempX * 2, inY + tempY * 2);
                    }
                    else
                    {
                        gameBoard.Draw(map.Road, inX + tempX, inY + tempY);
                        gameBoard.Draw(map.Box, inX + tempX * 2, inY + tempY * 2);
                    }
                }
            }
        }

        // 플레이어의 이동을 위한 메서드.
        // 플레이어 앞에 벽이 없을경우에 아래가 실행이된다.
        // 플레이어 앞에 박스나 골박스가 있을 경우, 그 앞에 벽, 박스, 골박스가 있을경우에는 메서드를 빠져나온다.
        // 그것이 아니라면 움직임 횟수를 증가시키고 플레이어가 있던 자리는 길로 채우고, 플레이어를 이동시킨다.
        // 플레이어가 있던 자리가 골이 그려져 있던 자리라면 골을 다시 그려준다.
        private void Movement(ConsoleKeyInfo inKey, int inX, int inY, eDirection direction)
        {
            int tempX = SetHorizontal(direction);
            int tempY = SetVertical(direction);

            if (!map.IsWall(gameBoard.Buffer, inX + tempX, inY + tempY))
            {
                if (map.IsBox(gameBoard.Buffer, inX + tempX, inY + tempY) ||
                    map.IsGoalBox(gameBoard.Buffer, inX + tempX, inY + tempY))
                {
                    if (map.IsWall(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) ||
                        map.IsBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2) ||
                        map.IsGoalBox(gameBoard.Buffer, inX + tempX * 2, inY + tempY * 2))
                    {
                        return;
                    }
                }
                moveCount++;
                gameBoard.Draw(map.Road, inX, inY);
                player.Move(inKey);
                OnGoal(inX, inY);
            }
        }

        // 스테이지를 가져와 해당 위치에 골문자가 있다면 골을 그려준다.
        private void OnGoal(int inX, int inY)
        {
            if (map.stages[stageNumber][inY, inX] == 3)
            {
                gameBoard.Draw(map.Goal, inX, inY);
            }
        }

        // 키, 좌표, 움직임방향 값을 받아 박스 밀기, 골박스 밀기, 플레이어 움직임 메서드를 호출하는 메서드.
        // 아래 순서대로 호출되어야 정상적으로 그리기가 된다.
        private void Interaction(ConsoleKeyInfo inKey, int inX, int inY, eDirection direction)
        {
            PushBox(player.X, player.Y, direction);
            PushGoalBox(player.X, player.Y, direction);
            Movement(inKey, player.X, player.Y, direction);
        }

        // 값을 입력받아 처리하는 메서드.
        // 키가 눌려져있을때 아래가 실행이된다.
        // 입력된 키는 콘솔창에 표시하지 않게한다.
        // 방향키 값에 알맞게 Interaction메서드로 방향값과 플레이어의 위치값을 보낸다.
        // R은 리셋버튼으로 스테이지를 다시 받아오고 움직임 횟수도 초기화하며 화면을 한 번 깜빡이는 연출을 한다.
        // Q가 눌려진 경우는 프로그램을 종료한다.
        private void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        Interaction(key, player.X, player.Y, eDirection.RIGHT);
                        break;

                    case ConsoleKey.LeftArrow:
                        Interaction(key, player.X, player.Y, eDirection.LEFT);
                        break;

                    case ConsoleKey.UpArrow:
                        Interaction(key, player.X, player.Y, eDirection.UP);
                        break;

                    case ConsoleKey.DownArrow:
                        Interaction(key, player.X, player.Y, eDirection.DOWN);
                        break;

                    case ConsoleKey.R:
                        SetGame(gameBoard.Buffer);
                        moveCount = 0;
                        Console.Clear();
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;

                    default:
                        return;
                }
            }
        }

        // 플레이어 위치를 그려주는 메서드.
        private void PlayerUpdate()
        {
            gameBoard.Draw(player.Images, player.X, player.Y);
        }

        // 해당 스테이지가 클리어 했는지 판단하는 메서드.
        // 해당 스테이지의 스테이지를 가져와 골 개수가 골박스 개수와 같다면 true 아니면 false.
        private bool IsClear(char[,] inStage, int inStageNum, int inCount)
        {
            int temp = 0;
            for (int y = 0; y < map.stages[inStageNum].GetLength(0); y++)
            {
                for (int x = 0; x < map.stages[inStageNum].GetLength(1); x++)
                {
                    if (inStage[y, x] == map.GoalBox)
                    {
                        temp++;
                    }
                }
            }
            return inCount == temp ? true : false;
        }

        // 다음 스테이지로 넘어가기 위한 메서드.
        // 다음으로 넘어가기 위해 스테이지 번호를 증가시키고 플레이어 움직임 횟수를 초기화하며
        // 텍스트 색을 변경 후 클리어 했다는 문구를 띄운다. 그리고 다시 기본 색으로 돌려놓는다.
        // 1초뒤에 화면이 깜빡이고 다음 스테이지를 가져온다.
        // 스테이지가 끝까지 도달했다면 프로그램이 종료된다.
        private void NextStage()
        {
            if (IsClear(gameBoard.Buffer, stageNumber, goalCount) == true)
            {
                stageNumber++;
                moveCount = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                UI.DrawText(gameBoard.Buffer, "Clear!!!", 21, 12);
                gameBoard.Show();
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
                if (map.stages.Count == stageNumber)
                {
                    Environment.Exit(0);
                }
                SetGame(gameBoard.Buffer);
            }
        }

        // 게임 정보란에 맞게 현재 게임 데이터들을 적어주는 메서드.
        private void GameUI()
        {
            UI.WriteUI(gameBoard.Buffer);
            UI.DrawText(gameBoard.Buffer, (stageNumber + 1).ToString() + " / " + map.stages.Count.ToString(), 11, 12);
            UI.DrawText(gameBoard.Buffer, moveCount.ToString(), 11, 13);
            UI.DrawText(gameBoard.Buffer, player.Images, 11, 15);
            UI.DrawText(gameBoard.Buffer, map.Wall, 11, 16);
            UI.DrawText(gameBoard.Buffer, map.Box, 11, 17);
            UI.DrawText(gameBoard.Buffer, map.Goal, 11, 18);
            UI.DrawText(gameBoard.Buffer, map.GoalBox, 11, 19);
            UI.DrawText(gameBoard.Buffer, 'R', 28, 15);
            UI.DrawText(gameBoard.Buffer, 'Q', 28, 16);
        }

        // 게임을 실행하기 위한 메서드.
        // 처음 스테이지을 가져와 세팅을 한 후 각 필요한 사항들을 반복문을 통해 돌려준다.
        // 게임을 출력하는것은 모든 정보를 변경후에 출력한다.
        public void Run()
        {
            SetGame(gameBoard.Buffer);
            while (true)
            {
                NextStage();
                GameUI();
                Input();
                PlayerUpdate();
                gameBoard.Show();
            }
        }

    }
}
