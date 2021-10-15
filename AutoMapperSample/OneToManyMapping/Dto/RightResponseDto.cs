namespace AutoMapperSample.OneToManyMapping.Dto
{
    internal record RightResponseDto
    {
        public RightResponseDto()
        {

        }

        public long Id { get; set; }
        public string? Name { get; set; }
    }
}
