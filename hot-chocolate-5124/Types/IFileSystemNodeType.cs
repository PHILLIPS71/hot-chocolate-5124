namespace hot_chocolate_5124
{
    public class IFileSystemNodeType : UnionType
    {
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor.Type<FileSystemFileType>();
            descriptor.Type<FileSystemDirectoryType>();
        }
    }
}
