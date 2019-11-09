namespace StateMachine.Machine
{
    enum Trigger
    {
        CallDialed,
        CallConnected,
        LeftMessage,
        PlacedOnHold,
        TakenOffHold,
        PhoneHurledAgainstWall,
        MuteMicrophone,
        UnmuteMicrophone,
        SetVolume
    }
}