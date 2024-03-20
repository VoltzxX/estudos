using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    class autenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
