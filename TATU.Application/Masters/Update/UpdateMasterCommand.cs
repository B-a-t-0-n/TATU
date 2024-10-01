using TATU.Application.DTO;

namespace TATU.Application.Masters.Update
{
    public record UpdateMasterCommand(Guid MasterId, MasterDto Master);
}
