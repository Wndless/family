using Family.ModelProperty;

namespace Family.Model
{
    public class FamilyModel
    {
        public static List<FamilyData> GetMenu(string memberName = "")
        {
            List<FamilyData> datas = new List<FamilyData>();

            datas.Add(new FamilyData() { menu_name = "mom", menu_const_name = "엄마", label_name = "옥주" });
            datas.Add(new FamilyData() { menu_name = "dad", menu_const_name = "아빠", label_name = "동훈" });
            datas.Add(new FamilyData() { menu_name = "son", menu_const_name = "아들", label_name = "태건" });
            datas.Add(new FamilyData() { menu_name = "daughter", menu_const_name = "딸", label_name = "태린" });


            if(datas.Any(p=>p.menu_name.Equals(memberName, StringComparison.OrdinalIgnoreCase)))
            {
                datas.Where(p => p.menu_name.Equals(memberName, StringComparison.OrdinalIgnoreCase)).First().IsActive = true;
            }

            return datas;
        }
    }
}