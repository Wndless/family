using System.Data;

namespace Family.ModelProperty
{
    public class FamilyData
    {
        // 메뉴 한글명
        public string menu_const_name { get; set; } = string.Empty;

        // 메뉴 컨트롤러명
        public string menu_name { get; set; } = string.Empty;

        // 라벨명 (실명)
        public string label_name { get; set; } = string.Empty;

        // 메뉴 활성화 여부
        public bool IsActive { get; set; } = false;
    }
}