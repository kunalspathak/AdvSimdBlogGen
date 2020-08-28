using System;
using System.Collections.Generic;
using System.Text;

namespace AdvSimdBlogGen
{
    public partial class AdvSimdBlogGen
    {

        #region Templates
        private static string header =
@"Console.WriteLine(
@""```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part {0}
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part {0} of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

{1}

<p/>
"");";

        private static string classTemplate =
@"
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;

public partial class AdvSimdMethods
{{
{0}

public static unsafe void Run()
{{
{1}
}}
}}";
        private static string methodAttribute = "[MethodImpl(MethodImplOptions.NoInlining)]";
        private static string argValuePrintTemplate = "// {0} = {1}";
        private static string methodDefPrintTemplate =
@"Console.WriteLine(
@""{9}

### {4}. {5}

`{6}`

{{0}}

```csharp
private {1}
{{{{
  {0};
}}}}
{2}
```

{7}

See Microsoft docs {8}{10}.

Assembly generated:

```armasm"", {3});";
        private static string methodCallTemplate =
@"
try {{
{0}Test({1});
{2}
}} catch (Exception) {{
   apiResult = ""TODO"";
}}
";
        private static string methodDefinitionTemplate =
@"
private static {2} {1}
{{
  {0};
}}
";
        private static string LogInCsvTemplate = "LogInCsv({0});";
        private static string sectionSep =
@"```
------------------------------------------------";
        private static string microsoftAdvSimdRefTemplate = "https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.{0}?view=net-5.0";
        private static string microsoftArm64RefTemplate = "https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.{0}?view=net-5.0";
        private static string armRefTemplate = "https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search={0}";
        private static int count = 1;
        private static int sectionCount = 1;
        #endregion

    }
}
