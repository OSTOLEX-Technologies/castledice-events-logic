using casltedice_events_logic.ServerToClient;
using castledice_events_logic.ClientToServer;
using castledice_events_logic.ServerToClient;
using castledice_game_data_logic;
using castledice_game_data_logic.ConfigsData;
using castledice_game_data_logic.Content;
using castledice_game_data_logic.Errors;
using castledice_game_data_logic.Moves;
using castledice_game_data_logic.TurnSwitchConditions;
using castledice_game_logic;
using castledice_game_logic.GameObjects;
using castledice_game_logic.TurnsLogic.TurnSwitchConditions;

namespace castledice_events_logic_tests;

public static class ObjectCreationUtility
{
    public static ServerErrorDTO GetServerErrorDTO()
    {
        return new ServerErrorDTO(new ErrorData(ErrorType.GameNotSaved, "some message"));
    }
    
    public static CancelGameDTO GetCancelGameDTO()
    {
        return new CancelGameDTO("somekey");
    }

    public static MoveFromClientDTO GetMoveFromClientDTO()
    {
        return new MoveFromClientDTO(new PlaceMoveData(1, (1, 1), PlacementType.Knight), "somekey");
    }

    public static RequestGameDTO GetRequestGameDTO()
    {
        return new RequestGameDTO("somekey");
    }

    public static PlayerReadyDTO GetPlayerReadyDTO()
    {
        return new PlayerReadyDTO("somekey");
    }

    public static ApproveMoveDTO GetApproveMoveDTO()
    {
        return new ApproveMoveDTO(true); 
    }

    public static CancelGameResultDTO GetCancelGameResultDTO()
    {
        return new CancelGameResultDTO(true, 1);
    }

    public static CreateGameDTO GetCreateGameDTO()
    {
        return new CreateGameDTO(GetGameStartData());
    }

    public static GiveActionPointsDTO GetGiveActionPointsDTO()
    {
        return new GiveActionPointsDTO(1, 3);
    }

    public static MatchFoundDTO GetMatchFoundDTO()
    {
        return new MatchFoundDTO(new List<int>{1, 3});
    }

    public static MoveFromServerDTO GetMoveFromServerDTO()
    {
        return new MoveFromServerDTO(new PlaceMoveData(1, (1, 1), PlacementType.Knight));
    }

    public static InitializePlayerDTO GetInitilizePlayerDTO()
    {
        return new InitializePlayerDTO("somekey");
    }
    
    public static GameStartData GetGameStartData()
    {
        var version = "1.0.0";
        var playerIds = new List<int>() { 1, 2 };
        var boardConfigData = GetBoardData();
        var placeablesConfigs = new PlaceablesConfigData(GetKnightConfigData());
        var playerDecks = new List<PlayerDeckData>()
        {
            new(playerIds[0], new List<PlacementType> { PlacementType.Knight }),
            new (playerIds[1], new List<PlacementType> { PlacementType.Knight })
        };
        var tscConfigData = new TscConfigData(new List<TscType> { TscType.SwitchByActionPoints });
        var data = new GameStartData(version, boardConfigData, placeablesConfigs, tscConfigData, playerIds, playerDecks);
        return data;
    }

    public static BoardData GetBoardData()
    {
        var boardLength = 10;
        var boardWidth = 10;
        var cellType = CellType.Square;
        var cellsPresence = GetNByNTrueBoolMatrix(10);
        var firstCastle = new CastleData((0, 0), 1, 1, 3, 3, 1);
        var secondCastle = new CastleData((9, 9), 1, 1, 3, 3, 2);
        var generatedContent = new List<ContentData>
        {
            firstCastle, 
            secondCastle
        };
        return new BoardData(boardLength, boardWidth, cellType, cellsPresence, generatedContent);
    }
    
    public static KnightConfigData GetKnightConfigData()
    {
        return new KnightConfigData(1, 2);
    }

    public static bool[,] GetNByNTrueBoolMatrix(int size)
    {
        var matrix = new bool[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = true;
            }
        }

        return matrix;
    }
}