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
public void errorCreateProgramTest970()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.errorCreateProgramTest(s0, (string)null);
    Assert.AreEqual<string>("No exception", s);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(DicBLLTest))]
public void errorCreateProgramTest198()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.errorCreateProgramTest(s0, "else");
    Assert.AreEqual<string>("Lỗi kết nối.\v Vui lòng kiểm tra lại", s);
    Assert.IsNotNull((object)s0);
}
    }
}
