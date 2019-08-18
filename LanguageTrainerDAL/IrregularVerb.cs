using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainerDAL
{
    public class IrregularVerb
    {
        private int id;
        private string verbBaseForm;
        private string bulgarianVerb;
        private string verbPastSimple;
        private string verbPastParticiple;
        public IrregularVerb()
        {
        }

        public IrregularVerb(int id, string verbBaseForm, string bulgarianVerb,
            string verbPastSimple, string verbPastParticiple)
        {
            Id = id;
            VerbBaseForm = verbBaseForm;
            BulgarianVerb = bulgarianVerb;
            VerbPastSimple = verbPastSimple;
            VerbPastParticiple = verbPastParticiple;
        }

        public int Id { get => id; set => id = value; }
        public string VerbBaseForm { get => verbBaseForm; set => verbBaseForm = value; }
        public string VerbPastSimple { get => verbPastSimple; set => verbPastSimple = value; }
        public string BulgarianVerb { get => bulgarianVerb; set => bulgarianVerb = value; }
        public string VerbPastParticiple { get => verbPastParticiple; set => verbPastParticiple = value; }
    }
}
