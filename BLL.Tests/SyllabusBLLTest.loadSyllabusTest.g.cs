using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DAL;
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
    public partial class SyllabusBLLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SyllabusBLLTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void loadSyllabusTest01()
{
    SyllabusBLL syllabusBLL;
    List<Syllabus> list;
    syllabusBLL = new SyllabusBLL();
    list = this.loadSyllabusTest(syllabusBLL, (string)null);
}
    }
}
