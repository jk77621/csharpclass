using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class02
{
    class Food
    {
        public string name = "";
        protected float price = 0;
        private string camefrom = "Seoul";

        public virtual void HowMuchIsIt()
        {
            WriteLine(price);
        }

        protected void ThisFoodNameisThis()
        {
            WriteLine(name);
        }
    }
}

/*
 * Virtual, Override
 * 부모에서 virtual를 선언하면 나중에 재정의될 수 있다.
 * 자식에서 override를 선언하고 재정의한다.
 */

/* 
 * Abstract
 * 자식이 선언할거라고 미리 알려주는 선언문
 */

/* 
 * Interface
 * 클래스와 비슷하지만, 직접 구현하지않고 정의만 한다.
 * abstract와 interface의 차이는 정말 많지만 그 중 가장 큰 차이점은 interface는 다중 상속이 가능하다는 것.
 * interface는 인스턴스 필드가 포함될 수 없다는 것.
 * 사용할 것 이다라는 것만 가능하다.
 * 
 * abstract이 좀 더 확장하는 느낌.
 *
 * 예시 - 게임 - (여기서부터 interface) 몬스터, 재화, 무기, 캐릭터 - 이 후 확장 
 */
