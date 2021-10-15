namespace AutoMapperSample.OneToManyMapping.Dto
{
    internal record LeftRightsResponseDto
    {
        public LeftRightsResponseDto()
        {

        }

        public LeftRightsResponseDto(LeftResponseDto left, List<RightResponseDto> rights)
        {
            Left = left;
            Rights = rights;
        }

        public LeftResponseDto? Left { get; set; }
        public List<RightResponseDto>? Rights { get; set; }
    }
}
