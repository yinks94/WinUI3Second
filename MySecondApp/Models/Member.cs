using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondApp.Models;

public class Member
{
    public Member()
    {
    }

    public Member(string userName)
    {
        UserName = userName;
    }

    public string UserName
    {
        get;
        set;
    }
}
