using System;
using System.Collections.Generic;
namespace OOP_in_C_ {
    class Program {
        static void Main(string[] args) { 
            List<PDF> PDF_Format = new List<PDF>();
            Console.Clear();
            PDF_Format.Add(new PDF());
            PDF_Format[0].Name = "Эффективный Spark (2019)";
            PDF_Format[0].Author = "Холден Карау, Рейчел Уоррен";
            PDF_Format[0].Theme = "Data Science";
            PDF_Format[0].Keywords = new string[] { "Data Science" };
            PDF_Format[0].Path = "https://revall.info/effektivnyj-spark-2019.html";
            PDF_Format[0].DateOfCreation = "2019";
            PDF_Format[0].DateOfChange = "";
            PDF_Format[0].Password = "";
            PDF_Format[0].Size = "6 Mb";
            PDF_Format[0].PrintValues();

            PDF_Format.Add(new PDF());
            PDF_Format[1].Name = "Ubuntu Linux с нуля";
            PDF_Format[1].Author = "Сергей Волох";
            PDF_Format[1].Theme = "Linux";
            PDF_Format[1].Keywords = new string[] { "Linux" };
            PDF_Format[1].Path = "https://revall.info/ubuntu-linux-s-nulya-2-e-izd.html";
            PDF_Format[1].DateOfCreation = "2021";
            PDF_Format[1].DateOfChange = "";
            PDF_Format[1].Password = "";
            PDF_Format[1].Size = "44 Mb";
            PDF_Format[1].PrintValues();

            PDF_Format.Add(new PDF());
            PDF_Format[2].Name = "MySQL по максимуму";
            PDF_Format[2].Author = "Шварц Б., Зайцев П., Ткаченко В.";
            PDF_Format[2].Theme = "MySQL";
            PDF_Format[2].Keywords = new string[] { "MySQL" };
            PDF_Format[2].Path = "https://revall.info/mysql-po-maksimumu-2018.html";
            PDF_Format[2].DateOfCreation = "2018";
            PDF_Format[2].DateOfChange = "";
            PDF_Format[2].Password = "";
            PDF_Format[2].Size = "18 Mb";
            PDF_Format[2].PrintValues();
            PDF_Format.Add(new PDF());

            PDF_Format[3].Name = "Raspberry Pi для секретных агентов";
            PDF_Format[3].Author = "Стефан Шогелид";
            PDF_Format[3].Theme = "Raspberry Pi";
            PDF_Format[3].Keywords = new string[] { "Raspberry Pi" };
            PDF_Format[3].Path = "https://revall.info/raspberry-pi-dlya-sekretnyh-agentov.html";
            PDF_Format[3].DateOfCreation = "2015";
            PDF_Format[3].DateOfChange = "";
            PDF_Format[3].Password = "";
            PDF_Format[3].Size = "12 Mb";
            PDF_Format[3].PrintValues();
            Console.ReadKey();
        }
    }
}