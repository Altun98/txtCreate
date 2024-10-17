namespace txtCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sagirdlerin yaradilmasi
            Student s1 = new Student("Abbas", "Abbasov", "Elcin", 12, "Gence");
            Student s2 = new Student("Hesen", "Qasimov", "Arif", 12, "Quba");
            Student s3 = new Student("Elvin", "Memmedov", "Qasim", 12, "Zaqatala");
            Student s4 = new Student("Qalib", "Quluyev", "Qabil", 12, "Cellabad");
            Student s5 = new Student("Huseynov", "Turkan", "Arif", 12, "Baki");
            Student s6 = new Student("Hesenov", "Ruslan", "Etibar", 14, "Sumqayit");
            Student s7 = new Student("Namazov", "Resad", "Oder", 10, "Baki");
            Student s8 = new Student("Esgersoylu", "Ayxan", "Sebuhi", 13, "Naxcivan");
            Student s9 = new Student("Naqiyev", "Nureddin", "Eldeniz", 22, "Berde");
            Student s10 = new Student("Heziyev", "Abdulla", "Emin", 14, "Terter");
            Student s11 = new Student("Sultanov", "MirAbbas", "Vuqar", 14, "Goranboy");
            Student s12 = new Student("Quluyev", "Ekber", "Mahir", 12, "Ismayilli");
            Student s13 = new Student("Memmedova", "Ulker", "Ilkin", 10, "Seki");
            Student s14 = new Student("Eliyeve", "Medine", "Yasar", 11, "Oquz");
            Student s15 = new Student("Poladli", "Esmer", "Bedirxan", 12, "Lenkaran");
            Student s16 = new Student("Ehmedova", "Arzu", "Yusif", 13, "Masalli");
            Student s17 = new Student("Ehmedova", "Suraye", "Cahandar", 9, "Qubadli");
            Student s18 = new Student("Memmedova", "Cahan", "Eflatun", 10, "Tovuz");
            Student s19 = new Student("Nesirova", "Gozel", "Qulu", 11, "Qazax");
            Student s20 = new Student("Abdullayeva", "Aysel", "Salman", 9, "Qax");
            Student s21 = new Student("Dadasov", "Davud", "Elxan", 8, "Baki");
            #endregion
            #region Sagir Arraylarinin hazirlanmasi
            Student[] st1 = { s1, s2, s3, s4, s5 };
            Student[] st2 = { s6, s7, s8, s9, s10 };
            Student[] st3 = { s11, s12, s13, s14, s15 };
            Student[] st4 = { s16, s17, s18, s19, s20, s21 };
            #endregion
            #region Siniflerin Hazirlanmasi
            ClassForm c1 = new ClassForm("9-cu sinif", st1);
            ClassForm c2 = new ClassForm("8-ci sinif", st2);
            ClassForm c3 = new ClassForm("7-ci sinif", st3);
            ClassForm c4 = new ClassForm("10-cu sinif", st4);
            #endregion
            #region Txt Yaratma
            // burada istifade etdiyimiz Path.Combine ifadesi  faylin adi ile fayl
            // olunu firlesdirmek ucun istifade olunur.
            string faylAdi = "test1.txt";
            string faylYolu = @"D:\";
            string hedef_yol = Path.Combine(faylYolu, faylAdi);
            // File.Existx ifadesi yaradilacaq faylin qeyd edilmis yerde movcud
            // olub olmadiqini yoxlayaraq eger varsa geriye bool tipinde true deyer qaytarir
            if (!File.Exists(hedef_yol))
            {
                //File.Create ifadesi  qeyd edilmis yerde qeyd edilmis adda faylin yaradilmasini heyata kecrir.
                File.Create(hedef_yol);
            }
            else
            {
                Console.WriteLine("sistemde hemin fayl movcuddur");
            }

            #endregion

            #region Massivin setir setir  txt yazilmasi

            //string[] satirlar = { "sagir no 123", "Adi:Abbas", "Soyadi:Abdullayev" };
            //File.WriteAllLines(@hedef_yol, satirlar);
            #endregion
            #region Stringin txt yazilmasi

            //string metn = "1),Abdullayev,Abdulla,Hesden,23,Baki";
            //File.WriteAllText(hedef_yol, metn);
            #endregion

            #region Massivin yalnizca mueyyen sahesinin txt yazilmasi

            string[] metn1 = { "Qasimov", "Abbas", "23", "Baki" };
            using (System.IO.StringWriter dosya = new System.IO.StringWriter(@"D:\test1.txt"))
            {
                foreach (var item in metn1)
                {
                    if (item.Contains("Qasim"))
                    {

                    }
                }
            }

            #endregion
            Console.ReadKey();

        }
    }
}
