using System;
using satis_core.enums;

namespace satis_backend
{
    public class MyAuth: Attribute
    {
        public MyAuth(
            Ranks rank
            )
        {

        }
    }
}
