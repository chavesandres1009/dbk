using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model
{
    [Serializable]
    class Const
    {
        public string cedula { get; set; }
        public int cant_mesas { get; set; }
        public float iv { get; set; }
        public float iS { get; set; }
        public float transporte { get; set; }
        public string impresora { get; set; }
        /*public string db_username { get; set; }
        public string db_password { get; set; }
        public string db_name { get; set; }
        public string db_port { get; set; }*/
        public Const()
        {
            load();
        }

        public Const(string cedula, int cant_mesas, float iv, float iS, float transporte)
        {
            this.cant_mesas = cant_mesas;
            this.iv = iv;
            this.iS = iS;
            this.transporte = transporte;
            this.impresora = impresora;
        }

        public void save_changes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Config.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
        }

        public void load()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream("Config.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Const obj = (Const)formatter.Deserialize(stream);
                this.cedula = obj.cedula;
                this.cant_mesas = obj.cant_mesas;
                this.iv = obj.iv;
                this.iS = obj.iS;
                this.transporte = obj.transporte;
                this.impresora = obj.impresora;
                stream.Close();
            }
            catch(FileNotFoundException e)
            {
                this.cant_mesas = 15;
                this.iv = 13;
                this.iS = 5;
                this.transporte = 700;
            }
        }
    }
}
