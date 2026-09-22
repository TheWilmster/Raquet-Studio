using System;
using System.Collections.Generic;
using System.Text;

namespace Raquet_Studio
{
    internal class ClangdManager
    {
        public void UpdateScriptList()
        {

        }
    }

    internal class ClangdCompileJSON
    {

    }

    internal class ClangdCompileCommand
    {
        string directory;
        string[] arguments;
        string file;

        internal ClangdCompileCommand(string directory, string[] arguments, string file) {
            this.directory = directory;
            this.arguments = arguments;
            this.file = file;
        }
    }
}
