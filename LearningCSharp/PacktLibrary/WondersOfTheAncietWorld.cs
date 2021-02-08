namespace Packt.Shared
{
    [System.Flags]
    public enum WondersOfTheAncietWorld
    {
        Pramit          = 0b_0000_0000,
        Babylon         = 0b_0000_0001,
        Olympia         = 0b_0000_0010,
        Ephesus         = 0b_0000_0100,
        Halicarnasus    = 0b_0000_1000,
        Rhodes          = 0b_0001_0000,
        Alexandria      = 0b_0010_0000
    }
}