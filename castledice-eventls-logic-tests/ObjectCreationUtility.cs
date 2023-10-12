using System.Net.Http.Headers;
using casltedice_events_logic.ClientToServer;
using casltedice_events_logic.ServerToClient;
using castledice_game_data_logic;
using castledice_game_data_logic.Content;
using castledice_game_data_logic.Content.Generated;
using castledice_game_data_logic.Content.Placeable;
using castledice_game_data_logic.Moves;
using castledice_game_logic;
using castledice_game_logic.GameObjects;

namespace castledice_eventls_logic_tests;

public static class ObjectCreationUtility
{
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

    public static ApproveMoveDTO GetApproveMoveDTO()
    {
        return new ApproveMoveDTO(true); 
    }

    public static CancelGameResultDTO GetCancelGameResultDTO()
    {
        return new CancelGameResultDTO(true);
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
        var boardLength = 10;
        var boardWidth = 10;
        var cellType = CellType.Square;
        var cellsPresence = GetNByNTrueBoolMatrix(10);
        var playerIds = new List<int>() { 1, 2 };
        var firstCastle = new CastleData((0, 0), 1, 1, 3, 3, playerIds[0]);
        var secondCastle = new CastleData((9, 9), 1, 1, 3, 3, playerIds[1]);
        var generatedContent = new List<GeneratedContentData>() { firstCastle, secondCastle };
        var placeablesConfigs = new List<PlaceableContentData>
        {
            new KnightData(1, 2)
        };
        var playerDecks = new List<PlayerDeckData>()
        {
            new(playerIds[0], new List<PlacementType> { PlacementType.Knight }),
            new (playerIds[1], new List<PlacementType> { PlacementType.Knight })
        };
        var data = new GameStartData(boardLength, boardWidth, cellType, cellsPresence, generatedContent, placeablesConfigs, playerIds, playerDecks);
        return data;
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