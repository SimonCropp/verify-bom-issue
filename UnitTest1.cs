namespace verify_bom_issue;

[UsesVerify]
public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        await Verify("test");
    }
}
