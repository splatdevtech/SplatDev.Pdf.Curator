using IronPdf;
namespace SplatDev.DigitalBookCurator.Tests
{
    [TestClass]
    public class PdfLibrary_Tests
    {
        [TestMethod]
        public void PdfLibrary_IronPdf()
        {
            try
            {
                var path = Path.Combine(AppContext.BaseDirectory, "Asset", "ASP_NET_Core_Succinctly.pdf");
                var reader = IronPdf.PdfDocument.FromFile(path);
                Assert.IsNotNull(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}