using AutoMapper.QueryableExtensions;
using AutoMapperSample.OneToOneMapping.Dto;
using AutoMapperSample.OneToOneMapping.ReadModel;

Console.WriteLine("One to one mapping");

var oneToOneLefts = AutoMapperSample.OneToOneMapping.Mocks.LeftEntityMock.GetLefts();
var oneToOneRights = AutoMapperSample.OneToOneMapping.Mocks.RightEntityMock.GetRights();

var oneToOneAutoMapperConfig = AutoMapperSample.OneToOneMapping.Configurations.AutoMapperConfiguration.GetMapperConfiguration();

var lambdaOneToOneResultResponseDto = oneToOneLefts.Join(oneToOneRights, l => l.Id, r => r.LeftId,
    (l, r) => new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(oneToOneAutoMapperConfig).ToList();

var linqOneToOneResultResponeDto =
    (from l in oneToOneLefts
     join r in oneToOneRights on l.Id equals r.LeftId
     // where ..
     select new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(oneToOneAutoMapperConfig).ToList();

Console.WriteLine();
Console.WriteLine("Lambda version");
foreach (var itemDto in lambdaOneToOneResultResponseDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

Console.WriteLine();
Console.WriteLine("Linq version");
foreach (var itemDto in linqOneToOneResultResponeDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

Console.WriteLine();
Console.WriteLine("The end one to one mapping");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
