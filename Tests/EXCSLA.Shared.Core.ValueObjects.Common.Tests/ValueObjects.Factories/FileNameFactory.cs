
using EXCSLA.Shared.Core.ValueObjects.Common;

namespace EXCSLA.Shared.Tests.Core.Factories
{
    public class FileNameFactory
    {
        public static string DefaultName = "test";
        public static string DefaultExtension = "pdf";
        private FileName _fileName;

        public FileName Build(string fileName)
        {
            this._fileName = new FileName(fileName);

            return this._fileName;
        }

        public static FileName DefaultFileName()
        {
            var defaultFileName = new FileNameFactory();

            return defaultFileName.Build(DefaultName + "." + DefaultExtension);
        }
    }
}