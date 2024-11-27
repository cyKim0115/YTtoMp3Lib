
// ReSharper disable CheckNamespace
#pragma warning disable CS8618, CS9264
namespace YDLib;

public class FileItem
{
    private readonly float _oneMega = 1048576;
    
    public string filePath { get; set; }
    public string fileName { get; set; }
    public string size { get; set; }
    public string extension { get; set; }

    public FileItem() {}
    
    public FileItem(string fileUri)
    {
        var fileInfo = new FileInfo(fileUri);
        
        filePath = fileInfo.FullName;
        fileName = fileInfo.Name;
        size = (fileInfo.Length / _oneMega).ToString("0.00")+ "MB";
        extension = fileInfo.Extension;
    }
}