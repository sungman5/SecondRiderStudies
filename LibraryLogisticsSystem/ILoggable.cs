namespace LibraryLogisticsSystem;

public interface ILoggable
{
    // 인터페이스는 규격만 정의합니다.
    string Name { get; }
    double Weight { get; }
    BookLocation Location { get; }

    string GetInfo();
}