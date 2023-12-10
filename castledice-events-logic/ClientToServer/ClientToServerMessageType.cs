﻿namespace castledice_events_logic.ClientToServer;

public enum ClientToServerMessageType : ushort
{
    RequestGame,
    MakeMove,
    CancelGame,
    InitializePlayer,
    PlayerReady
}