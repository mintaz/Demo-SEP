using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace BLL.Tests
{
    public partial class ScheduleBLLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ScheduleBLLTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void AddScheTest01()
{
    ScheduleBLL scheduleBLL;
    bool b;
    scheduleBLL = new ScheduleBLL();
    b = this.AddScheTest(scheduleBLL, (string)null, default(DateTime), 0, 
                         (string)null, (string)null, (string)null, false);
}
    }
}
