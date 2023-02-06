using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public static byte[] ReadFile(string sPath)
        {
            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);
            fStream.Close();
            br.Close();
            return data;
        }
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Calorie).IsRequired();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.CreatedDate).HasConversion(typeof(DateTime)).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedDate).HasConversion(typeof(DateTime)).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Food { Id = 1,  Name = "Antrikot", Calorie = 1.21, Image = ReadFile("Resources/antrikot.png") },
                new Food { Id = 2,  Name = "Biftek", Calorie = 2.42, Image = ReadFile("Resources/biftek.png") },
                new Food { Id = 3,  Name = "Bonfile", Calorie = 1.38, Image = ReadFile("Resources/bonfile.png") },
                new Food { Id = 4,  Name = "Dana Kıyma", Calorie = 2.46, Image = ReadFile("Resources/dana kıyma.png") },
                new Food { Id = 5,  Name = "Hindi Budu", Calorie = 2.08, Image = ReadFile("Resources/hindi budu.png") },
                new Food { Id = 6,  Name = "Hindi Göğsü", Calorie = 1.35, Image = ReadFile("Resources/hindi göğüs.png") },
                new Food { Id = 7,  Name = "Hindi Kanadı", Calorie = 2.21, Image = ReadFile("Resources/hindi kanat.png") },
                new Food { Id = 8,  Name = "Kuzu Pirzola", Calorie = 2.76, Image = ReadFile("Resources/kuzu pirzola.png") },
                new Food { Id = 9,  Name = "Kuzu İncik", Calorie = 2.01, Image = ReadFile("Resources/kuzu incik.png") },
                new Food { Id = 10,  Name = "Sığır Eti", Calorie = 2.48, Image = ReadFile("Resources/sığır eti.png") },
                new Food { Id = 11,  Name = "Sığır Filetosu", Calorie = 2.18, Image = ReadFile("Resources/sığır filetosu.png") },
                new Food { Id = 12,  Name = "Sığır Kaburgası", Calorie = 2.38, Image = ReadFile("Resources/sığır kaburgası.png") },
                new Food { Id = 13,  Name = "Tavuk But", Calorie = 1.74, Image = ReadFile("Resources/tavuk but.png") },
                new Food { Id = 14,  Name = "Tavuk Ciğeri", Calorie = 1.67, Image = ReadFile("Resources/tavuk ciğer.png") },
                new Food { Id = 15,  Name = "Tavuk Göğsü", Calorie = 1.72, Image = ReadFile("Resources/tavuk göğsü.png") },
                new Food { Id = 16,  Name = "Tavuk Kanadı", Calorie = 2.66, Image = ReadFile("Resources/tavuk kanat.png") },
                new Food { Id = 17,  Name = "Tavuk Taşlığı", Calorie = 1.46, Image = ReadFile("Resources/tavuk taşlık.png") },
                new Food { Id = 18,  Name = "Tavuk Yağı", Calorie = 8.98, Image = ReadFile("Resources/tavuk yağı.png") },
                new Food { Id = 19,  Name = "Ördek", Calorie = 3.37, Image = ReadFile("Resources/ördek.png") },
                new Food { Id = 20,  Name = "Şinitzel", Calorie = 1.56, Image = ReadFile("Resources/şinitzel.png") },
                new Food { Id = 21,  Name = "Alabalık", Calorie = 1.90, Image = ReadFile("Resources/alabalık.png") },
                new Food { Id = 22,  Name = "Havyar", Calorie = 2.64, Image = ReadFile("Resources/havyar.png") },
                new Food { Id = 23,  Name = "Lüfer", Calorie = 1.59, Image = ReadFile("Resources/lüfer.png") },
                new Food { Id = 24,  Name = "Mezgit", Calorie = 0.90, Image = ReadFile("Resources/mezgit.png") },
                new Food { Id = 25,  Name = "Midye", Calorie = 1.72, Image = ReadFile("Resources/midye.png") },
                new Food { Id = 26,  Name = "Ton Balığı", Calorie = 1.32, Image = ReadFile("Resources/ton balığı.png") },
                new Food { Id = 27,  Name = "Uskumru", Calorie = 2.62, Image = ReadFile("Resources/uskumru.png") },
                new Food { Id = 28,  Name = "Çipura", Calorie = 1.35, Image = ReadFile("Resources/çipura.png") },
                new Food { Id = 29,  Name = "Somon", Calorie = 2.06, Image = ReadFile("Resources/somon.png") },
                new Food { Id = 30,  Name = "Kalkan Balığı", Calorie = 1.22, Image = ReadFile("Resources/kalkan balığı.png") },
                new Food { Id = 31,  Name = "Cheddar Peyniri ", Calorie = 4.03, Image = ReadFile("Resources/cheddar peyniri.png") },
                new Food { Id = 32,  Name = "Hellim", Calorie = 3.21, Image = ReadFile("Resources/hellim.png") },
                new Food { Id = 33,  Name = "Kaşar Peyniri", Calorie = 3.37, Image = ReadFile("Resources/kaşar peynir.png") },
                new Food { Id = 34,  Name = "Tulum Peyniri", Calorie = 3.63, Image = ReadFile("Resources/tulum peynir.png") },
                new Food { Id = 35,  Name = "Yumuşak Peynir", Calorie = 2.68, Image = ReadFile("Resources/yumuşak peynir.png") },
                new Food { Id = 36,  Name = "Bazlama", Calorie = 2.40, Image = ReadFile("Resources/bazlama.png") },
                new Food { Id = 37,  Name = "Beyaz Ekmek", Calorie = 2.38, Image = ReadFile("Resources/beyaz ekmek.png") },
                new Food { Id = 38,  Name = "Esmer Ekmek", Calorie = 2.50, Image = ReadFile("Resources/esmer ekmek.png") },
                new Food { Id = 39,  Name = "Hamburger Ekmeği", Calorie = 1.78, Image = ReadFile("Resources/hamburger ekmeği.png") },
                new Food { Id = 40,  Name = "Lavaş", Calorie = 2.64, Image = ReadFile("Resources/lavaş.png") },
                new Food { Id = 41,  Name = "Mısır Ekmeği", Calorie = 1.79, Image = ReadFile("Resources/mısır ekmeği.png") },
                new Food { Id = 42,  Name = "Tam Buğday Ekmek", Calorie = 2.47, Image = ReadFile("Resources/tam buğday ekmek.png") },
                new Food { Id = 43,  Name = "Zeytin Yağı", Calorie = 8.84, Image = ReadFile("Resources/zeytin yağı.png") },
                new Food { Id = 44,  Name = "Yeşil Zeytin", Calorie = 1.15, Image = ReadFile("Resources/yeşil zeytin.png") },
                new Food { Id = 45,  Name = "Siyah Zeytin", Calorie = 1.15, Image = ReadFile("Resources/siyah zeytin.png") },
                new Food { Id = 46,  Name = "Bal", Calorie = 3.04, Image = ReadFile("Resources/bal.png") },
                new Food { Id = 47,  Name = "Erik Reçeli", Calorie = 2.50, Image = ReadFile("Resources/erik reçeli.png") },
                new Food { Id = 48,  Name = "Fıstık Ezmesi", Calorie = 5.89, Image = ReadFile("Resources/fıstık ezmesi.png") },
                new Food { Id = 49,  Name = "Kayısı Reçeli", Calorie = 2.50, Image = ReadFile("Resources/kayısı reçeli.png") },
                new Food { Id = 50,  Name = "Yumurta", Calorie = 0.97, Image = ReadFile("Resources/yumurta.png") },
                new Food { Id = 51,  Name = "Bamya ", Calorie = 0.33, Image = ReadFile("Resources/bamya.png") },
                new Food { Id = 52,  Name = "Bezelye", Calorie = 0.81, Image = ReadFile("Resources/bezelye.png") },
                new Food { Id = 53,  Name = "Biber", Calorie = 0.27, Image = ReadFile("Resources/biber.png") },
                new Food { Id = 54,  Name = "Domates", Calorie = 0.18, Image = ReadFile("Resources/domates.png") },
                new Food { Id = 55,  Name = "Havuç", Calorie = 0.41, Image = ReadFile("Resources/havuç.png") },
                new Food { Id = 56,  Name = "Kırmızı Biber", Calorie = 0.26, Image = ReadFile("Resources/kırmızı biber.png") },
                new Food { Id = 57,  Name = "Kabak", Calorie = 0.26, Image = ReadFile("Resources/kabak.png") },
                new Food { Id = 58,  Name = "Lahana", Calorie = 0.25, Image = ReadFile("Resources/lahana.png") },
                new Food { Id = 59,  Name = "Mantar", Calorie = 0.22, Image = ReadFile("Resources/mantar.png") },
                new Food { Id = 60,  Name = "Mısır", Calorie = 3.65, Image = ReadFile("Resources/mısır.png") },
                new Food { Id = 61,  Name = "Patates", Calorie = 0.77, Image = ReadFile("Resources/patates.png") },
                new Food { Id = 62,  Name = "Patlıcan", Calorie = 0.25, Image = ReadFile("Resources/patlıcan.png") },
                new Food { Id = 63,  Name = "Pırasa", Calorie = 0.61, Image = ReadFile("Resources/pırasa.png") },
                new Food { Id = 64,  Name = "Salatalık", Calorie = 1.49, Image = ReadFile("Resources/salatalık.png") },
                new Food { Id = 65,  Name = "Soğan", Calorie = 0.40, Image = ReadFile("Resources/soğan.png") },
                new Food { Id = 66,  Name = "Sarımsak", Calorie = 1.49, Image = ReadFile("Resources/sarımsak.png") },
                new Food { Id = 67,  Name = "Turp", Calorie = 0.28, Image = ReadFile("Resources/turp.png") },
                new Food { Id = 68,  Name = "Marul", Calorie = 0.22, Image = ReadFile("Resources/marul.png") },
                new Food { Id = 69,  Name = "Roka", Calorie = 0.25, Image = ReadFile("Resources/roka.png") },
                new Food { Id = 70,  Name = "Kara Lahana", Calorie = 0.32, Image = ReadFile("Resources/kara lahana.png") },
                new Food { Id = 71,  Name = "Armut", Calorie = 0.57, Image = ReadFile("Resources/armut.png") },
                new Food { Id = 72,  Name = "Ayva", Calorie = 0.57, Image = ReadFile("Resources/ayva.png") },
                new Food { Id = 73,  Name = "Elma", Calorie = 0.52, Image = ReadFile("Resources/elma.png") },
                new Food { Id = 74,  Name = "Erik", Calorie = 0.46, Image = ReadFile("Resources/erik.png") },
                new Food { Id = 75,  Name = "Hurma", Calorie = 2.82, Image = ReadFile("Resources/hurma.png") },
                new Food { Id = 76,  Name = "İncir", Calorie = 0.74, Image = ReadFile("Resources/incir.png") },
                new Food { Id = 77,  Name = "Muz", Calorie = 0.89, Image = ReadFile("Resources/muz.png") },
                new Food { Id = 78,  Name = "Karpuz", Calorie = 0.30, Image = ReadFile("Resources/karpuz.png") },
                new Food { Id = 79,  Name = "Kayısı", Calorie = 0.48, Image = ReadFile("Resources/kayısı.png") },
                new Food { Id = 80,  Name = "Kiraz", Calorie = 0.50, Image = ReadFile("Resources/kiraz.png") },
                new Food { Id = 81,  Name = "Kivi", Calorie = 0.61, Image = ReadFile("Resources/kivi.png") },
                new Food { Id = 82,  Name = "Nar", Calorie = 0.83, Image = ReadFile("Resources/nar.png") },
                new Food { Id = 83,  Name = "Portakal", Calorie = 0.47, Image = ReadFile("Resources/portakal.png") },
                new Food { Id = 84,  Name = "Çilek", Calorie = 0.32, Image = ReadFile("Resources/çilek.png") },
                new Food { Id = 85,  Name = "Üzüm", Calorie = 0.69, Image = ReadFile("Resources/üzüm.png") },
                new Food { Id = 86,  Name = "Şeftali", Calorie = 0.39, Image = ReadFile("Resources/şeftali.png") },
                new Food { Id = 87,  Name = "Bulgur Pilavı", Calorie = 2.15, Image = ReadFile("Resources/bulgur pilavı") },
                new Food { Id = 88,  Name = "Bezelye Çorbası", Calorie = 0.75, Image = ReadFile("Resources/bezelye çorbası.png") },
                new Food { Id = 89,  Name = "Karnıyarık", Calorie = 1.34, Image = ReadFile("Resources/karnıyarık.png") },
                new Food { Id = 90,  Name = "Kıymalı/Etli Pide", Calorie = 2.97, Image = ReadFile("Resources/kıymalı etli pide.png") },
                new Food { Id = 91,  Name = "Patates Püresi", Calorie = 0.83, Image = ReadFile("Resources/patates püresi.png") },
                new Food { Id = 92,  Name = "Pirinç Pilav", Calorie = 3.52, Image = ReadFile("Resources/pirinç pilavı.png") },
                new Food { Id = 93,  Name = "Pizza", Calorie = 2.67, Image = ReadFile("Resources/pizza.png") },
                new Food { Id = 94,  Name = "Yaprak Sarması", Calorie = 1.41, Image = ReadFile("Resources/yaprak sarma.png") },
                new Food { Id = 95,  Name = "Rulo Köfte", Calorie = 2.54, Image = ReadFile("Resources/rulo köfte.png") },
                new Food { Id = 96,  Name = "Peynirli Makarna", Calorie = 3.70, Image = ReadFile("Resources/peynirli makarna.png") },
                new Food { Id = 97,  Name = "Kurufasulye", Calorie = 0.94, Image = ReadFile("Resources/kuru fasulye.png") },
                new Food { Id = 98,  Name = "Hünkar Beğendi", Calorie = 1.74, Image = ReadFile("Resources/hunkar begendi.png") },
                new Food { Id = 99,  Name = "Kebap", Calorie = 2.15, Image = ReadFile("Resources/kebap.png") }
            );
        }
    }
}
