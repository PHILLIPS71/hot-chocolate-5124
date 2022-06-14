namespace hot_chocolate_5124
{
    /// <summary>
    /// Represents a directory in a file system hierarchy.
    /// </summary>
    public record FileSystemDirectory : IFileSystemNode
    {
        /// <inheritdoc />
        public string Path { get; set; } = null!;

        /// <inheritdoc />
        public string Name { get; set; } = null!;

        /// <inheritdoc />
        public long Length { get; set; }

        /// <inheritdoc />
        public DateTime CreatedAtUtc { get; set; }

        /// <inheritdoc />
        public DateTime ModifiedAtUtc { get; set; }
    }
}
