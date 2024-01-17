using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YourThunderstoreTeam.service;

public class TemplateServiceBaseTest
{
    protected TemplateService Service;

    [TestInitialize]
    public void OnBefore()
    {
        Service = new TemplateService();
    }
}

[TestClass]
public class TemplateServiceTest : TemplateServiceBaseTest
{
    [TestClass]
    public class ReturnTrue : TemplateServiceBaseTest
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            var result = Service.ReturnTrue();
            Assert.IsTrue(result);
        }
    }

    [TestClass]
    public class ReturnFalse : TemplateServiceBaseTest
    {
        [TestMethod]
        public void ShouldReturnFalse()
        {
            var result = Service.ReturnFalse();
            Assert.IsFalse(result);
        }
    }
}
