using System.Xml.Xsl;

namespace ParsingXML
{
    static class XslTransformer
    {
        public static void Transform(string input, string xsl, string result)
        {
            XslCompiledTransform xslt = new();
            xslt.Load(xsl);
            xslt.Transform(input, result);
        }
    }
}
