﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    // LUOKKAMÄÄRITYKSET
    // =================

    // Yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille
    class Device
    {
        // Kentät ja ominaisuudet
        // ----------------------

        // Luodaan kenttä (field) name, esitellään (define) ja annetaan arvo (set initial value)
        string name = "Uusi laite";

        // Luodaan kenttää vastaava ominaisuus (property) Name ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle riville
        public string Name { get { return name; } set { name = value; } }

        string purchaseDate = "1.1.1900";
        public string PurchaseDate { get { return purchaseDate; } set { purchaseDate = value; } }

        // Huomaa jälkiliite d (suffix)
        double price = 0.0d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }


        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM = 0;
        public int AmountRam { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity = 0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        // Konstruktorit
        // -------------

        // Konstruktori eli olionmuodostin (constructor) ilman argumentteja
        public Device()
        {

        }

        // Konstruktori nimi-argumentilla
        public Device(string name)
        {
            this.name = name;
        }

        // Konstruktori kaikilla argumenteilla
        public Device(string name, string purchaseDate, double price, int warranty)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.warranty = warranty;
        }

        // Muut metodit
        // ------------

        // Yliluokan metodit
        public void ShowPurchaseInfo()
        {
            // Luetaan laitteen ostotiedot sen kentistä, huom! this
            Console.WriteLine();
            Console.WriteLine("Laitteen hankintatiedot");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Laitteen nimi: " + this.name);
            Console.WriteLine("Ostopäivä: " + this.purchaseDate);
            Console.WriteLine("Hankinta: " + this.price);
            Console.WriteLine("Takuu: " + this.warranty + " kk");
        }

        // Luetaan laitteen yleiset tekniset tiedot ominaisuuksista, huom iso alkukirjain
        public void ShowBasicTechnicalInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Laitteen tekniset tiedot");
            Console.WriteLine("------------------------");
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti: " + AmountRam);
            Console.WriteLine("Levytila: " + StorageCapacity);


        }

    }

    // Tietokoneiden luokka, perii ominaisuuksia ja metodeja laiteluokasta Device

    class Computer : Device
    {

        // Konstruktorit
        public Computer() : base()
        { }

        public Computer(string name) : base(name)
        { }

        // Muut metodit

    }

    // Tablettien luokka, perii laiteluokan
    class Tablet : Device
    {
        // Kentät ja ominaisuudet
        // ----------------------

        string operatingSystem;
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }
        bool stylusEnabled = false;
        public bool StylusEnabled { get { return stylusEnabled; } set { stylusEnabled = value; } }

        // Konstruktortit
        // --------------

        public Tablet() : base() { }

        public Tablet(string name) : base(name) { }


        // Tablet-luokan erikoismetodit
        // ----------------------------
        public void TabletInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Tabletin erityitiedot");
            Console.WriteLine("---------------------");
            Console.WriteLine("Käyttöjärjestelmä: " + OperatingSystem);
            Console.WriteLine("Kynätuki: " + StylusEnabled);
        }

    }
    // Pääohjelman luokka, josta tulee Program.exe
    // ===========================================
    internal class Program
    {
        // Ohjelman käynnistävä metodi
        // ---------------------------
        static void Main(string[] args)
        {
            // Olioiden luominen ja metodien testaus
            // -------------------------------------

            // Luodaan uusi tietokone, joka perii laiteluokan (Device) ominaisuudet ja metodit

            Computer tietokone1 = new Computer();

            // Asetetaan ensimmäisen tietokoneen ominaisuuksien arvot
            tietokone1.ProcessorType = "Intel I7";
            tietokone1.AmountRam = 16;
            tietokone1.PurchaseDate = "15.2.2024";
            tietokone1.Price = 850.00d;
            tietokone1.Warranty = 36;

            Console.WriteLine("Tietokone 1");
            Console.WriteLine("===========");
            tietokone1.ShowPurchaseInfo();


            // Luodaan uusi nimetty tietokone 
            Computer tietokone2 = new Computer("Mikan läppäri");
            tietokone2.ProcessorType = "Intel Core i7 vPro";
            tietokone2.AmountRam = 32;

            Console.WriteLine("Tietokone 2");
            Console.WriteLine("===========");
            tietokone2.ShowBasicTechnicalInfo();

            // Luodaan testiolio tabletille

            Tablet tabletti1 = new Tablet("Mikan iPad");
            tabletti1.PurchaseDate = "1.10.2022";
            tabletti1.OperatingSystem = "IOS";
            tabletti1.StylusEnabled = true;

            // Näytetään tietoja metodien avulla

            tabletti1.ShowPurchaseInfo();


            tabletti1.ShowBasicTechnicalInfo();

            Console.WriteLine("Tabletti 1");
            Console.WriteLine("==========");
            tabletti1.TabletInfo();


            // Pidetään ikkuna auki, kunnes käyttäjä painaa <enter>
            Console.ReadLine();
        }
    }
}