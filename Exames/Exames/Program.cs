using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ExameMedico
{
    class Program

    {
        public static void Main(string[] args)
        {
            Exame exame = new Exame();
            exame.escolherExame();
            
            
        }
    }

}
