using BLL.Services;
using DAL;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            fStream.Close();
            br.Close();
            return data;
        }




        List<Food> foods = new List<Food>() {
                new Food {  Name = "Antrikot", Calorie = 1.21, Image = ReadFile("Resources/antrikot.png") },
                new Food {  Name = "Bonfile", Calorie = 1.38, Image = ReadFile("Resources/bonfile.png") },
                new Food {  Name = "Biftek", Calorie = 2.42, Image = ReadFile("Resources/biftek.png") },
                new Food {  Name = "Dana Kıyma", Calorie = 2.46, Image = ReadFile("Resources/dana kıyma.png") } ,
                new Food {  Name = "Hindi Budu", Calorie = 2.08, Image = ReadFile("Resources/hindi budu.png") },
                new Food {  Name = "Hindi Göğsü", Calorie = 1.35, Image = ReadFile("Resources/hindi göğüs.png") } ,
                new Food {  Name = "Sığır Filetosu", Calorie = 2.18, Image = ReadFile("Resources/sığır filetosu.png") },
                new Food {  Name = "Sığır Kaburgası", Calorie = 2.38, Image = ReadFile("Resources/sığır kaburgası.png") },
                new Food {  Name = "Tavuk But", Calorie = 1.74, Image = ReadFile("Resources/tavuk but.png") },
                new Food {  Name = "Tavuk Ciğeri", Calorie = 1.67, Image = ReadFile("Resources/tavuk ciğer.png") },
                new Food {  Name = "Tavuk Göğsü", Calorie = 1.72, Image = ReadFile("Resources/tavuk göğsü.png") },
                new Food {  Name = "Tavuk Kanadı", Calorie = 2.66, Image = ReadFile("Resources/tavuk kanat.png") },
                new Food {  Name = "Tavuk Taşlığı", Calorie = 1.46, Image = ReadFile("Resources/tavuk taşlık.png") },
                new Food {  Name = "Tavuk Yağı", Calorie = 8.98, Image = ReadFile("Resources/tavuk yağı.png") },
                new Food {  Name = "Ördek", Calorie = 3.37, Image = ReadFile("Resources/ördek.png") },
                new Food {  Name = "Şinitzel", Calorie = 1.56, Image = ReadFile("Resources/şinitzel.png") },
                new Food {  Name = "Alabalık", Calorie = 1.90, Image = ReadFile("Resources/alabalık.png") },
                new Food {  Name = "Havyar", Calorie = 2.64, Image = ReadFile("Resources/havyar.png") },
                new Food {  Name = "Lüfer", Calorie = 1.59, Image = ReadFile("Resources/lüfer.png") },
                new Food {  Name = "Mezgit", Calorie = 0.90, Image = ReadFile("Resources/mezgit.png") },
                new Food {  Name = "Midye", Calorie = 1.72, Image = ReadFile("Resources/midye.png") },
                new Food {  Name = "Ton Balığı", Calorie = 1.32, Image = ReadFile("Resources/ton balığı.png") },
                new Food {  Name = "Uskumru", Calorie = 2.62, Image = ReadFile("Resources/uskumru.png") },
                new Food {  Name = "Çipura", Calorie = 1.35, Image = ReadFile("Resources/çipura.png") },
                new Food {  Name = "Somon", Calorie = 2.06, Image = ReadFile("Resources/somon.png") },
                new Food {  Name = "Kalkan Balığı", Calorie = 1.22, Image = ReadFile("Resources/kalkan balığı.png") },
                new Food {  Name = "Cheddar Peyniri ", Calorie = 4.03, Image = ReadFile("Resources/cheddar peyniri.png") },
                new Food {  Name = "Hellim", Calorie = 3.21, Image = ReadFile("Resources/hellim.png") },
                new Food {  Name = "Kaşar Peyniri", Calorie = 3.37, Image = ReadFile("Resources/kaşar peynir.png") },
                new Food {  Name = "Tulum Peyniri", Calorie = 3.63, Image = ReadFile("Resources/tulum peynir.png") },
                new Food {  Name = "Yumuşak Peynir", Calorie = 2.68, Image = ReadFile("Resources/yumuşak peynir.png") },
                new Food {  Name = "Bazlama", Calorie = 2.40, Image = ReadFile("Resources/bazlama.png") },
                new Food {  Name = "Beyaz Ekmek", Calorie = 2.38, Image = ReadFile("Resources/beyaz ekmek.png") },
                new Food {  Name = "Esmer Ekmek", Calorie = 2.50, Image = ReadFile("Resources/esmer ekmek.png") },
                new Food {  Name = "Hamburger Ekmeği", Calorie = 1.78, Image = ReadFile("Resources/hamburger ekmeği.png") },
                new Food {  Name = "Lavaş", Calorie = 2.64, Image = ReadFile("Resources/lavaş.png") },
                new Food {  Name = "Mısır Ekmeği", Calorie = 1.79, Image = ReadFile("Resources/mısır ekmeği.png") },
                new Food {  Name = "Tam Buğday Ekmek", Calorie = 2.47, Image = ReadFile("Resources/tam buğday ekmek.png") },
                new Food { Name = "Zeytin Yağı", Calorie = 8.84, Image = ReadFile("Resources/zeytin yağı.png") },
                new Food {  Name = "Yeşil Zeytin", Calorie = 1.15, Image = ReadFile("Resources/yeşil zeytin.png") },
                new Food {  Name = "Siyah Zeytin", Calorie = 1.15, Image = ReadFile("Resources/siyah zeytin.png") },
                new Food {  Name = "Bal", Calorie = 3.04, Image = ReadFile("Resources/bal.png") },
                new Food {  Name = "Erik Reçeli", Calorie = 2.50, Image = ReadFile("Resources/erik reçeli.png") },
                new Food {  Name = "Fıstık Ezmesi", Calorie = 5.89, Image = ReadFile("Resources/fıstık ezmesi.png") },
                new Food {  Name = "Kayısı Reçeli", Calorie = 2.50, Image = ReadFile("Resources/kayısı reçeli.png") },
                new Food {  Name = "Yumurta", Calorie = 0.97, Image = ReadFile("Resources/yumurta.png") },
                new Food {  Name = "Bamya ", Calorie = 0.33, Image = ReadFile("Resources/bamya.png") },
                new Food {  Name = "Bezelye", Calorie = 0.81, Image = ReadFile("Resources/bezelye.png") },
                new Food {  Name = "Biber", Calorie = 0.27, Image = ReadFile("Resources/biber.png") },
                new Food {  Name = "Domates", Calorie = 0.18, Image = ReadFile("Resources/domates.png") },
                new Food {  Name = "Havuç", Calorie = 0.41, Image = ReadFile("Resources/havuç.png") },
                new Food {  Name = "Kırmızı Biber", Calorie = 0.26, Image = ReadFile("Resources/kırmızı biber.png") },
                new Food {  Name = "Kabak", Calorie = 0.26, Image = ReadFile("Resources/kabak.png") },
                new Food {  Name = "Lahana", Calorie = 0.25, Image = ReadFile("Resources/lahana.png") },
                new Food {  Name = "Mantar", Calorie = 0.22, Image = ReadFile("Resources/mantar.png") },
                new Food {  Name = "Mısır", Calorie = 3.65, Image = ReadFile("Resources/mısır.png") },
                new Food {  Name = "Patates", Calorie = 0.77, Image = ReadFile("Resources/patates.png") },
                new Food {  Name = "Patlıcan", Calorie = 0.25, Image = ReadFile("Resources/patlıcan.png") },
                new Food {  Name = "Pırasa", Calorie = 0.61, Image = ReadFile("Resources/pırasa.png") },
                new Food {  Name = "Salatalık", Calorie = 1.49, Image = ReadFile("Resources/salatalık.png") },
                new Food {  Name = "Soğan", Calorie = 0.40, Image = ReadFile("Resources/soğan.png") },
                new Food {  Name = "Sarımsak", Calorie = 1.49, Image = ReadFile("Resources/sarımsak.png") },
                new Food {  Name = "Turp", Calorie = 0.28, Image = ReadFile("Resources/turp.png") },
                new Food {  Name = "Marul", Calorie = 0.22, Image = ReadFile("Resources/marul.png") },
                new Food {  Name = "Roka", Calorie = 0.25, Image = ReadFile("Resources/roka.png") },
                new Food {  Name = "Kara Lahana", Calorie = 0.32, Image = ReadFile("Resources/kara lahana.png") },
                new Food {  Name = "Armut", Calorie = 0.57, Image = ReadFile("Resources/armut.png") },
                new Food {  Name = "Ayva", Calorie = 0.57, Image = ReadFile("Resources/ayva.png") },
                new Food {  Name = "Elma", Calorie = 0.52, Image = ReadFile("Resources/elma.png") },
                new Food {  Name = "Erik", Calorie = 0.46, Image = ReadFile("Resources/erik.png") },
                new Food {  Name = "Hurma", Calorie = 2.82, Image = ReadFile("Resources/hurma.png") },
                new Food {  Name = "İncir", Calorie = 0.74, Image = ReadFile("Resources/incir.png") },
                new Food {  Name = "Muz", Calorie = 0.89, Image = ReadFile("Resources/muz.png") },
                new Food {  Name = "Karpuz", Calorie = 0.30, Image = ReadFile("Resources/karpuz.png") },
                new Food {  Name = "Kayısı", Calorie = 0.48, Image = ReadFile("Resources/kayısı.png") },
                new Food {  Name = "Kiraz", Calorie = 0.50, Image = ReadFile("Resources/kiraz.png") },
                new Food {  Name = "Kivi", Calorie = 0.61, Image = ReadFile("Resources/kivi.png") },
                new Food {  Name = "Nar", Calorie = 0.83, Image = ReadFile("Resources/nar.png") },
                new Food {  Name = "Portakal", Calorie = 0.47, Image = ReadFile("Resources/portakal.png") },
                new Food {  Name = "Çilek", Calorie = 0.32, Image = ReadFile("Resources/çilek.png") },
                new Food {  Name = "Üzüm", Calorie = 0.69, Image = ReadFile("Resources/üzüm.png") },
                new Food {  Name = "Şeftali", Calorie = 0.39, Image = ReadFile("Resources/şeftali.png") },
                new Food {  Name = "Bulgur Pilavı", Calorie = 2.15, Image = ReadFile("Resources/bulgur pilavı.png") },
                new Food {  Name = "Bezelye Çorbası", Calorie = 0.75, Image = ReadFile("Resources/bezelye çorbası.png") },
                new Food {  Name = "Karnıyarık", Calorie = 1.34, Image = ReadFile("Resources/karnıyarık.png") },
                new Food {  Name = "Kıymalı/Etli Pide", Calorie = 2.97, Image = ReadFile("Resources/kıymalı etli pide.png") },
                new Food {  Name = "Patates Püresi", Calorie = 0.83, Image = ReadFile("Resources/patates püresi.png") },
                new Food {  Name = "Pirinç Pilav", Calorie = 3.52, Image = ReadFile("Resources/pirinç pilavı.png") },
                new Food {  Name = "Pizza", Calorie = 2.67, Image = ReadFile("Resources/pizza.png") },
                new Food {  Name = "Yaprak Sarması", Calorie = 1.41, Image = ReadFile("Resources/yaprak sarma.png") },
                new Food {  Name = "Peynirli Makarna", Calorie = 3.70, Image = ReadFile("Resources/peynirli makarna.png") },
                new Food {  Name = "Kurufasulye", Calorie = 0.94, Image = ReadFile("Resources/kuru fasulye.png") },
                new Food {  Name = "Hünkar Beğendi", Calorie = 1.74, Image = ReadFile("Resources/hunkar begendi.jpg") },
                new Food {  Name = "Kebap", Calorie = 2.15, Image = ReadFile("Resources/kebap.png") }};

        Console.WriteLine(foods.Count);
        Context context = new Context();
        foreach (var item in foods)
        {
            FoodService foodService = new FoodService(context);
            foodService.Add(item);
            Console.WriteLine("process...");
        }
        Console.WriteLine("DONE");
        Console.ReadKey();
    }

}