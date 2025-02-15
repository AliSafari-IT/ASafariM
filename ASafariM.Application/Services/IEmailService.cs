using System;

namespace ASafariM.Application.Services;

public interface IEmailService
{
    void SendReactivationEmail(string email, string reason);
}
