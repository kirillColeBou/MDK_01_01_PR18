using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Тепляков.Classes
{
    public class Magazin
    {
        public string FIO { get; set; }
        public string typeOperationText { get; set; }
        public string formatText { get; set; }
        public string side { get; set; }
        public string colorText { get; set; }
        public int count { get; set; }
        public float price { get; set; }
        public string image { get; set; }

        public Magazin(string _fio, string _typeOperationText, string _formatText, string _side, string _colorText, int _count, float _price, string _image)
        {
            this.FIO = _fio;
            this.typeOperationText = _typeOperationText;
            this.formatText = _formatText;
            this.side = _side;
            this.colorText = _colorText;
            this.count = _count;
            this.price = _price;
            this.image = _image;
        }
    }
}
