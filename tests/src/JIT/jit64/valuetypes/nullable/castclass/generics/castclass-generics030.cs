// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of NotEmptyStructConstrainedGenQ<int> using cast expr
// </Description> 
// <RelatedBugs> </RelatedBugs>  
//<Expects Status=success></Expects>
// <Code> 


using System.Runtime.InteropServices;
using System;

internal class NullableTest
{
    private static bool BoxUnboxToNQ<T>(T o)
    {
        return Helper.Compare((NotEmptyStructConstrainedGenQ<int>)(ValueType)(object)o, Helper.Create(default(NotEmptyStructConstrainedGenQ<int>)));
    }

    private static bool BoxUnboxToQ<T>(T o)
    {
        return Helper.Compare((NotEmptyStructConstrainedGenQ<int>?)(ValueType)(object)o, Helper.Create(default(NotEmptyStructConstrainedGenQ<int>)));
    }

    private static int Main()
    {
        NotEmptyStructConstrainedGenQ<int>? s = Helper.Create(default(NotEmptyStructConstrainedGenQ<int>));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


