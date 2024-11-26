using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;
using MySecondApp.Contracts.Services;
using MySecondApp.Models;

namespace MySecondApp.Services;
public class SessionService : ISessionService
{

    private Member? _member;


    public bool IsAuthenticated => _member != null;

    public void SetSessionUser(Member member)
    {
        _member = member;
    }

    public Member GetSessioUser() 
    {
        if (!IsAuthenticated) throw new AccessViolationException("세션에 사용자가 존재하지 않습니다.");
        return _member;
    }
}
