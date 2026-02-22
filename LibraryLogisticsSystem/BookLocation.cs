namespace LibraryLogisticsSystem;

public struct BookLocation
{
    private char Section { get; set; }

    private int Row { get; set; }

    private int Column { get; set; }

    public BookLocation(char section, int row, int column)
    {
        Section = section;
        Row = row;
        Column = column;
    }
    public override string ToString()
    {   
        return $"{Section}-{Row}-{Column}";
    }
}