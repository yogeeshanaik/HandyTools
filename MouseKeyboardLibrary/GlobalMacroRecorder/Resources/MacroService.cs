using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GlobalMacroRecorder.Resources
{
    public class MacroService
    {
        private List<MacroCollection> _macros;
        public List<MacroCollection> Macros
        {
            get
            {
                if (File.Exists("data.bin"))
                    using (Stream stream = File.Open("data.bin", FileMode.Open))
                    {
                        var bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        var res = bin.Deserialize(stream);
                        _macros = res as List<MacroCollection>;
                    }
                return _macros;
            }
        }

        public void SaveMacro(List<MacroCollection> macros)
        {
            using (Stream stream = File.Open("data.bin", FileMode.Create))
            {
                var bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bin.Serialize(stream, macros);
            }
        }

    }
}
