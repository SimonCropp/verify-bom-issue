using System.Text;

namespace verify_bom_issue;

[UsesVerify]
public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        var file = CurrentFile.Relative("UnitTest1.Test1.verified.txt");
        var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
        var target = "test";
        await Verify(target);
        var fileBytes = await File.ReadAllBytesAsync(file);
        var expectedBytes = encoding.GetBytes(target);
        Assert.Equal(expectedBytes, fileBytes);
    }
}
