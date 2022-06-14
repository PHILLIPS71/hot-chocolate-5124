namespace hot_chocolate_5124
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class Query
    {
        public async Task<IEnumerable<IFileSystemNode>> DirectoryContents(CancellationToken cancellation)
        {
            return null;
        }
    }
}
