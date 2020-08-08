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

---
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

public class AdvSimdMethods
{{
{0}

public static unsafe void Main(string[] args)
{{
  string apiResult;
{1}
{2}
}}
}}";
        private static string varInitializer =
@"

var Vector64short_0 = Vector64.Create((short)11, 12, 13, 14);
var Vector64double_0 = Vector64.Create((double)11.5);
var Vector64float_0 = Vector64.Create((float)11.5f, 12.5f);
var Vector64float_1 = Vector64.Create((float)21.5f, 22.5f);
var Vector64byte_0 = Vector64.Create((byte)11, 12, 13, 14, 15, 16, 17, 18);
var Vector64byte_1 = Vector64.Create((byte)21, 22, 23, 24, 25, 26, 27, 28);
var Vector64byte_2 = Vector64.Create((byte)31, 32, 33, 34, 35, 36, 37, 38);
var Vector128ushort_0 = Vector128.Create((ushort)11, 12, 13, 14, 15, 16, 17, 18);
var Vector128byte_0 = Vector128.Create((byte)11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);
var Vector128byte_1 = Vector128.Create((byte)21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36);
var Vector128ushort_1 = Vector128.Create((ushort)11, 12, 13, 14, 15, 16, 17, 18);
var Vector64ushort_0 = Vector64.Create((ushort)11, 12, 13, 14);
var Vector64long_0 = Vector64.Create((long)11);
var Vector64int_0 = Vector64.Create((int)11, 12);
var Vector64long_1 = Vector64.Create((long)11);
var Vector64double_1 = Vector64.Create((double)11.5);
byte byte_0 = 0;
var Vector128short_0 = Vector128.Create((short)11, 12, 13, 14, 15, 16, 17, 18);
var Vector64float_2 = Vector64.Create((float)11.5f, 12.5f);
var Vector64double_2 = Vector64.Create((double)11);
byte byte_1 = 1;
var Vector128double_0 = Vector128.Create((double)11.5, 12.5);
var Vector64short_1 = Vector64.Create((short)21, 22, 23, 24);
var Vector64short_2 = Vector64.Create((short)31, 32, 33, 34);
var Vector128int_0 = Vector128.Create((int)11, 12, 13, 14);
var Vector128short_1 = Vector128.Create((short)21, 22, 23, 24, 25, 26, 27, 28);
var Vector64sbyte_0 = Vector64.Create((sbyte)11, 12, 13, 14, 15, 16, 17, 18);
var Vector128float_0 = Vector128.Create((float)11.5f, 12.5f, 13.5f, 14.5f);
var Vector64int_1 = Vector64.Create((int)21, 22);

int[] intArray = new int[] {11, 12};
byte[] byteArray = new byte[] {11, 12, 13, 14, 15, 16, 17, 18};

";
        private static string methodAttribute = "[MethodImpl(MethodImplOptions.NoInlining)]";
        private static string argValuePrintTemplate = "// {0} = {1}";
        private static string methodDefPrintTemplate =
@"Console.WriteLine(
@""
{9}

### {4}. {5}

`{6}`

Performs '{5}' operation.

```csharp
private {1}
{{{{
  {0};
}}}}
{2}
```

{7}

See MSDN reference {8}.

Assembly generated:

```
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
        private static string sectionSep =
@"```
------------------------------------------------";
        private static string advSimdRefTemplate = "https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.{0}?view=net-5.0";
        private static string arm64RefTemplate = "https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.{0}?view=net-5.0";
        private static int count = 1;
        private static int sectionCount = 1;
        #endregion

    }
}
