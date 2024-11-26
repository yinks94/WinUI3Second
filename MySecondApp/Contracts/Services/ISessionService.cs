using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySecondApp.Models;

namespace MySecondApp.Contracts.Services;


public interface ISessionService
{
    bool IsAuthenticated { get; }

    void SetSessionUser(Member member);

    Member GetSessioUser();
}
