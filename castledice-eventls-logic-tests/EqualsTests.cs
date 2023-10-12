using static castledice_eventls_logic_tests.ObjectCreationUtility;

namespace castledice_eventls_logic_tests;

public class EqualsTests
{
    [Theory]
    [MemberData(nameof(EqualsTestCases))]
    public void Equals_ShouldReturnTrue_IfTwoInstancesAreEqual<T>(Func<T> instanceProviderFunction)
    {
        var instance1 = instanceProviderFunction();
        var instance2 = instanceProviderFunction();
        
        Assert.True(instance1.Equals(instance2));
    }

    public static IEnumerable<object[]> EqualsTestCases()
    {
        yield return new object[]
        {
            () => GetCancelGameDTO()
        };
        yield return new object[]
        {
            () => GetMoveFromClientDTO()
        };
        yield return new object[]
        {
            () => GetRequestGameDTO()
        };
        yield return new object[]
        {
            () => GetApproveMoveDTO()
        };
        yield return new object[]
        {
            () => GetCancelGameResultDTO()
        };
        yield return new object[]
        {
            () => GetCreateGameDTO()
        };
        yield return new object[]
        {
            () => GetGiveActionPointsDTO()
        };
        yield return new object[]
        {
            () => GetMatchFoundDTO()
        };
        yield return new object[]
        {
            () => GetMoveFromServerDTO()
        };
        yield return new object[]
        {
            () => GetInitilizeClientDTO()
        };
    }
}