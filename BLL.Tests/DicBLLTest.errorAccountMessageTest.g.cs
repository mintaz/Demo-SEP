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
public void errorAccountMessageTest421()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.errorAccountMessageTest(s0, (string)null);
    Assert.AreEqual<string>("No exception", s);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(DicBLLTest))]
public void errorAccountMessageTest844()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.errorAccountMessageTest(s0, "else");
    Assert.AreEqual<string>
        ("Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.", s);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(DicBLLTest))]
public void errorAccountMessageTest185()
{
    string s;
    DicBLL s0 = new DicBLL();
    s = this.errorAccountMessageTest(s0, "sai email");
    Assert.AreEqual<string>("Email không hợp lệ. \n Vui lòng kiểm tra lại", s);
    Assert.IsNotNull((object)s0);
}
    }
}
