using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacerCSV
{
    class CatCollection
    {
        public Indicator[] Indicators { get; set; }
    }

    class Language
    {
        public string language { get;set; }
    }

    class Indicator
    {
        public string id { get; set; }
        public string name { get; set; }
        public CategoryIdEn category_ids { get; set; }
    }

    class CategoryIdRu
    {
        public string BLR { get; set; }
        public string TUR { get; set; }
        public string MDA { get; set; }
        public string KAZ { get; set; }
        public string UKR { get; set; }
        public string GBR { get; set; }
        public string USA { get; set; }
        public string CAN { get; set; }
    }

    class CategoryIdEn
    {
        public string GBR { get; set; }
        public string USA { get; set; }
        public string CAN { get; set; }
    }
}
