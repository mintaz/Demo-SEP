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
    public partial class DicBLLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DicBLLTest))]
public void defaultPassTest925()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.defaultPassTest(s0);
    Assert.AreEqual<string>("vanlang", s);
    Assert.IsNotNull((object)s0);
}
    }
}
