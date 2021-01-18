using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"Diretorio";//colocar caminho do diretório
            var nomeArquivos = Directory.EnumerateFiles(diretorio, "*", SearchOption.AllDirectories);
            foreach (string nomeArquivo in nomeArquivos)
            {
                if (nomeArquivo.EndsWith("(1).jpg"))//detalhamento do arquivo
                {
                    var arquivo = new FileInfo(nomeArquivo);
                    arquivo.Delete();
                }
            }
        }
    }
}
