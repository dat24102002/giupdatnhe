namespace WebApp1.Models
{
    public class MayTinh
    {
        public string MaMay { get; set; }
        public string DongMay { get; set; }
        public string GiaBan { get; set; }
        public DateTime NgaySX { get; set; }
        public string HangSX { get; set; }

        public List<MayTinh> KhoiTao()
        {
            List<MayTinh> mayTinhs = new List<MayTinh>();
            mayTinhs.Add(new MayTinh()
            {
                MaMay ="000000000001",
                DongMay ="assuss",
                GiaBan ="24",
                NgaySX = new DateTime(2020,1,1),
                HangSX = "asu"
            });
            mayTinhs.Add(new MayTinh()
            {
                MaMay = "000000000002",
                DongMay = "assuss",
                GiaBan = "23",
                NgaySX = new DateTime(2021, 1, 1),
                HangSX = "asu"
            });
            mayTinhs.Add(new MayTinh()
            {
                MaMay = "000000000003",
                DongMay = "assuss",
                GiaBan = "26",
                NgaySX = new DateTime(2020,12,11),
                HangSX = "asu1"
            });
            mayTinhs.Add(new MayTinh()
            {
                MaMay = "000000000004",
                DongMay = "assuss",
                GiaBan = "27",
                NgaySX = new DateTime(2020, 7, 8),
                HangSX = "asu23"
            });
            return mayTinhs;
        }
    }
}
