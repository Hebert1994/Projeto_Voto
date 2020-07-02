using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOCandidato
    {
        private string idpessoa;
        private string ideleicao;
        private string idempresa;
        private string numero;
        private string slogan;
        private string descricao;
        private byte[] foto;

        public string Idpessoa { get => idpessoa; set => idpessoa = value; }
        public string Ideleicao { get => ideleicao; set => ideleicao = value; }
        public string Idempresa { get => idempresa; set => idempresa = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Slogan { get => slogan; set => slogan = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;

                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                Foto = new byte[Convert.ToInt32(arqImagem.Length)];
                int IBytes = fs.Read(Foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /*Transformar arquivo em Bytes em uma imagem*/
        public Bitmap getImagem()
        {
            MemoryStream mStream = new MemoryStream();
            mStream.Write(Foto, 0, Convert.ToInt32(Foto.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

    }

}
