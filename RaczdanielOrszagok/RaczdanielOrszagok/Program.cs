using RaczdanielOrszagok;


        var varosok = File.ReadAllLines(@"../../../src/varosok.csv").Skip(1).Select(line => new Nagyvaros(line)).ToList();


        Console.WriteLine($"Az összes városok száma: {varosok.Count}");
            Console.WriteLine("---------------------------------------");

        // 1) 
        Console.WriteLine("1. feladat");
        var kinaLakossag = varosok.Where(v => v.Orszag == "Kína").Sum(v => v.Nepesseg);
        Console.WriteLine($"Totális populáció: {kinaLakossag:F2} milliókba");
            Console.WriteLine("---------------------------------------");

        // 2)
        Console.WriteLine("2. feladat");
        var avgLakossaIndia = varosok.Where(v => v.Orszag == "India").Average(v => v.Nepesseg);
        Console.WriteLine($"Átéag populáció India városaiban: {avgLakossaIndia:F2} milliókba");
            Console.WriteLine("---------------------------------------");

        // 3)
        Console.WriteLine("3. feladat");
        var legnagyobbVaros = varosok.OrderByDescending(v => v.Nepesseg).FirstOrDefault();
        Console.WriteLine($"Legnépesebb nagy város: {legnagyobbVaros}");
            Console.WriteLine("---------------------------------------");

        // 4)
        Console.WriteLine("4. feladat");
        var nagyVarosok = varosok.Where(v => v.Nepesseg > 20).OrderByDescending(v => v.Nepesseg).ToList();
        Console.WriteLine("20M lakos feletti nagyvárosok:");
        nagyVarosok.ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------------------");

        // 5) 
        Console.WriteLine("5. feladat");
        var tobbszorosNagyvaros = varosok.GroupBy(v => v.Orszag).Count(g => g.Count() > 1);
        Console.WriteLine($"Országok melynek városai többször is szerepelnek a listában: {tobbszorosNagyvaros}");
            Console.WriteLine("---------------------------------------");

        // 6)
        Console.WriteLine("6. feladat");
        var kezdobetuGyak = varosok.GroupBy(v => v.Varos[0]).OrderByDescending(g => g.Count()).FirstOrDefault()?.Key;
            Console.WriteLine($"Leggyakrabba kezdődő betűvel előforduló városok: {kezdobetuGyak}");