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
title: Hardware Intrinsics APIs for ARM64 - Part {0}
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

{1},[...](Part{0}.md)


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
@""
{9}

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

```armasm
"", {3});";
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
