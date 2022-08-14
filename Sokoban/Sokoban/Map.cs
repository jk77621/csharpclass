using System.Collections.Generic;

namespace Sokoban
{
    class Map
    {
        // 스테이지를 보관하는 리스트
        public List<int[,]> stages = new List<int[,]>();

        // 각 스테이지 배치에 필요한 이미지. 여기에서 변경 하면 모두 적용된다.
        private readonly char wall = '■';
        private readonly char box = '○';
        private readonly char goal = '⊙';
        private readonly char road = '　';
        private readonly char goalBox = '●';

        // Map타입의 객체를 인스턴스화하면 스테이지들이 추가된다.
        public Map()
        {
            AddStage();
        }

        // 각 이미지들을 읽기전용으로 제공한다.
        // 단지 읽기 전용으로 제공할 것이라면
        // 중괄호를 이용한 블럭을 만드는것 보다는 람다식이
        // 더 간결해 람다식으로 구현함.
        public char Wall => wall;

        public char Box => box;

        public char Goal => goal;

        public char Road => road;

        public char GoalBox => goalBox;

        // 스테이지 1
        public int[,] stage1 = new int[8, 8]
        {
            { 0,0,1,1,1,0,0,0 },
            { 0,0,1,3,1,0,0,0 },
            { 0,0,1,0,1,1,1,1 },
            { 1,1,1,2,0,2,3,1 },
            { 1,3,0,2,0,1,1,1 },
            { 1,1,1,1,2,1,0,0 },
            { 0,0,0,1,3,1,0,0 },
            { 0,0,0,1,1,1,0,0 },
        };

        // 스테이지 2
        public int[,] stage2 = new int[7, 10]
        {
            { 0,1,1,1,1,1,1,1,0,0 },
            { 0,1,0,0,0,0,0,1,1,1 },
            { 1,1,2,1,1,1,0,0,0,1 },
            { 1,0,0,0,2,0,0,2,0,1 },
            { 1,0,3,3,1,0,2,0,1,1 },
            { 1,1,3,3,1,0,0,0,1,0 },
            { 0,1,1,1,1,1,1,1,1,0 },
        };

        // 스테이지 3
        public int[,] stage3 = new int[8, 8]
        {
            {0,1,1,1,1,1,0,0 },
            {0,1,0,0,1,1,1,0 },
            {0,1,0,2,0,0,1,0 },
            {1,1,1,0,1,0,1,1 },
            {1,3,1,0,1,0,0,1 },
            {1,3,2,0,0,1,0,1 },
            {1,3,0,0,0,2,0,1 },
            {1,1,1,1,1,1,1,1 },
        };

        // 스테이지 4
        public int[,] stage4 = new int[11, 19]
        {
            { 0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,1,2,0,0,1,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,1,1,1,0,0,2,1,1,0,0,0,0,0,0,0,0,0 },
            { 0,0,1,0,0,2,0,2,0,1,0,0,0,0,0,0,0,0,0 },
            { 1,1,1,0,1,0,1,1,0,1,0,0,0,1,1,1,1,1,1 },
            { 1,0,0,0,1,0,1,1,0,1,1,1,1,1,0,0,3,3,1 },
            { 1,0,2,0,0,2,0,0,0,0,0,0,0,0,0,0,3,3,1 },
            { 1,1,1,1,1,0,1,1,1,0,1,0,1,1,0,0,3,3,1 },
            { 0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1 },
            { 0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0 },
        };

        // 스테이지 5
        public int[,] stage5 = new int[10, 14]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
            {1,3,3,0,0,1,0,0,0,0,0,1,1,1 },
            {1,3,3,0,0,1,0,2,0,0,2,0,0,1 },
            {1,3,3,0,0,1,2,1,1,1,1,0,0,1 },
            {1,3,3,0,0,0,0,0,0,1,1,0,0,1 },
            {1,3,3,0,0,1,0,1,0,0,2,0,1,1 },
            {1,1,1,1,1,1,0,1,1,2,0,2,0,1 },
            {0,0,1,0,2,0,0,2,0,2,0,2,0,1 },
            {0,0,1,0,0,0,0,1,0,0,0,0,0,1 },
            {0,0,1,1,1,1,1,1,1,1,1,1,1,1 },
        };

        // int[,]로 된 스테이지를 char[,]로 변환하는 메서드.
        // int[,]로 된 스테이지들은 설정한 버퍼 사이즈와 다를 수 있기 때문에
        // Array.GetLength() 메서드를 이용한다.
        public void SetMap(int[,] inMap, char[,] inBuf)
        {
            for (int y = 0; y < inMap.GetLength(0); y++)
            {
                for (int x = 0; x < inMap.GetLength(1); x++)
                {
                    if (inMap[y, x] == 0)
                    {
                        inBuf[y, x] = road;
                    }
                    else if (inMap[y, x] == 1)
                    {
                        inBuf[y, x] = wall;
                    }
                    else if (inMap[y, x] == 2)
                    {
                        inBuf[y, x] = box;
                    }
                    else if (inMap[y, x] == 3)
                    {
                        inBuf[y, x] = goal;
                    }
                }
            }
        }

        // 만든 스테이지들을 stages에 추가하는 메서드.
        private void AddStage()
        {
            stages.Add(stage1);
            stages.Add(stage2);
            stages.Add(stage3);
            stages.Add(stage4);
            stages.Add(stage5);
        }

        // 해당 스테이지의 goal의 개수를 반환함.
        public int GetGoalCount(int[,] inMap)
        {
            int goalCount = 0;
            for (int y = 0; y < inMap.GetLength(0); y++)
            {
                for (int x = 0; x < inMap.GetLength(1); x++)
                {
                    if (inMap[y, x] == 3)
                    {
                        goalCount++;
                    }
                }
            }
            return goalCount;
        }

        // inMap[inY, inX] wall인지 판단하는 메서드
        public bool IsWall(char[,] inMap, int inX, int inY)
        {
            return GetPoint(inMap, inX, inY) == wall ? true : false;
        }

        // inMap[inY, inX] box인지 판단하는 메서드.
        public bool IsBox(char[,] inMap, int inX, int inY)
        {
            return GetPoint(inMap, inX, inY) == box ? true : false;
        }

        // inMap[inY, inX] linkageBox인지 판단하는 메서드.
        public bool IsGoalBox(char[,] inMap, int inX, int inY)
        {
            return GetPoint(inMap, inX, inY) == goalBox ? true : false;
        }

        // inMap[inY, inX] goal인지 판단하는 메서드.
        public bool IsGoal(char[,] inMap, int inX, int inY)
        {
            return GetPoint(inMap, inX, inY) == goal ? true : false;
        }

        // inMap[inY, inX] 위치의 값을 반환하는 메서드.
        private char GetPoint(char[,] inMap, int inX, int inY)
        {
            return inMap[inY, inX];
        }
    }
}
