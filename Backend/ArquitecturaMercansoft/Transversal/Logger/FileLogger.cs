using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transversal.Logger
{
    public static class FileLogger
    {
        public static void Logger(Exception e)
        {            
            Log.Error(e, "Error encontrado");
            // Enviar correo informando el logger
            // Conectar un webSocket para notificar un error 
        }
    }
}
