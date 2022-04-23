namespace modul8_1302204080
{
    public class Movies
    {
        public string title {get; set; }
        public string director { get; set; }
        public List<string> Stars { get; set; }
        public string description { get; set; }

        public Movies(string judul, string direktor, string star1, string star2, string star3, string star4, string deskripsi)
        {
            this.title = judul;
            this.director = direktor;
            this.Stars = new List<string>();
            this.Stars.Add(star1);
            this.Stars.Add(star2);
            this.Stars.Add(star3);
            this.Stars.Add(star4);
            this.description = deskripsi;
        }

    }
}
