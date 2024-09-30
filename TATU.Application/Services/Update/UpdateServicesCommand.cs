using TATU.Application.DTO;

namespace TATU.Application.Services.Update
{
    public record UpdateServicesCommand(Guid ServicesId, ServicesDto Services);
}
