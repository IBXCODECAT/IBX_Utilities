namespace IBX_Utilities.Windows
{
    public enum WindowsInteruptType : long
    {
        APP = 0x00000000L,
        SYSTEM = 0x00001000L,
        TASK = 0x00002000L,
        HELP = 0x00004000L
    };

    public enum WindowsAlertBoxType : long
    {
        ERROR = 0x00000010L,
        QUESTION = 0x00000020L,
        WARNING = 0x00000030L,
        INFORMATION = 0x00000040L 
    };

    public enum WindowsAlertBoxOptions : long
    {
        OK = 0x00000000L,
        OK_CANCEL = 0x00000001L,
        ABORT_RETRY_IGNORE = 0x00000002L,
        YES_NO_CANCEL = 0x00000003L,
        YES_NO = 0x00000004L,
        RETRY_CANCEL = 0x00000005L,
        CANCEL_RETRY_CONTINUE = 0x00000006L
    };

    public enum WindowsAlertResponseCode : int
    {
        NO_RESPONSE = 0,
        OK = 1,
        CANCEL = 2,
        ABORT = 3,
        RETRY = 4,
        IGNORE = 5,
        YES = 6,
        NO = 7,
        TRY_AGAIN = 10,
        CONTINUE = 11
    };
}
