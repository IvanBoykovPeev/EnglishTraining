namespace LanguageTrainerDAL
{
    public class Type
    {
        private int typeId;
        private string typeName;

        public Type()
        {
        }

        public Type(int id, string type)
        {
            typeId = id;
            typeName = type;
        }

        public int TypeId { get => typeId; set => typeId = value; }
        public string TypeName { get => typeName; set => typeName = value; }
    }
}
