namespace HeroAcademyBattleSimulator;

public class App
{
    public void Start()
    {
        // 1. 캐릭터 생성
        // [명명된 인수 사용]
        // 매개변수 이름(name:, hp:)을 명시하면 순서를 헷갈릴 일이 없고,
        // 파일을 열어보지 않아도 어떤 값이 들어가는지 바로 알 수 있습니다.
        Wizard myWizard = new Wizard(
            name: "둘리", 
            hp: 100, 
            stats: new Stat(10, 10, 40));

        Knight myKnight = new Knight(
            name: "아라곤", 
            hp: 200, 
            stats: new Stat(50, 20, 10));

        // 2. 델리게이트 연결 (구독)
        // "캐릭터들에게 무슨 일이 생기면 WriteLog 함수를 실행해라"
        myWizard.OnBattleEvent += WriteLog;
        myKnight.OnBattleEvent += WriteLog;

        // 3. 파티 구성 (다형성 활용)
        // 각각 따로 관리하지 않고, 부모 타입인 Student로 한 번에 관리합니다.
        Party<Student> heroParty = new Party<Student>();
        heroParty.AddMember(myWizard);
        heroParty.AddMember(myKnight);

        // 파티원 목록 확인 (기능 확장 예제)
        heroParty.ShowPartyInfo();

        // 4. 시뮬레이션 실행 (테스트)
        Console.WriteLine("\n--- 전투 시뮬레이션 시작 ---\n");
        
        myKnight.Attack();           // 기사 공격
        myWizard.UseSkill(myKnight); // 마법사가 기사에게 스킬 사용
        myKnight.TakeDamage(20);     // 기사가 피해를 입음 (로그 출력됨)
    }

    // 델리게이트가 호출할 함수 (이벤트 핸들러)
    private void WriteLog(string message)
    {
        Console.WriteLine($"[전투 알림] {message}");
    }

    // [제약 조건 추가] T는 반드시 Student 클래스이거나 이를 상속받아야 한다.
    public class Party<T> where T : Student
    {
        private List<T> _party = new List<T>();

        public void AddMember(T member)
        {
            _party.Add(member);
            // 제약 조건(where) 덕분에 .Name 속성을 사용할 수 있습니다.
            Console.WriteLine($"{member.Name}이(가) 파티에 합류했습니다.");
        }

        // [기능 추가] 현재 파티원 목록을 출력하는 메서드
        public void ShowPartyInfo()
        {
            Console.WriteLine("\n[현재 파티원 목록]");
            foreach (var member in _party)
            {
                Console.WriteLine($"- {member.Name}");
            }
        }
    }
}