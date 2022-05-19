// See https://aka.ms/new-console-template for more information
Console.WriteLine("1.flip coin\n2.leap year\n3.power of two\n4.harmonic number\n5.Prime Factors\n6.quotient and remainder\n7.Swapp two numbers\n8.even or odd\n9.vowel or consonant\n10.largest number.\n");
Console.WriteLine("Enter Your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        functionalprograms.flipcoin function = new functionalprograms.flipcoin();
        function.Coinflip();
        break;
    case 2:
        functionalprograms.leapyear year = new functionalprograms.leapyear();
        year.leap();
        break;
    case 3:
        functionalprograms.poweroftwo power = new functionalprograms.poweroftwo();
        power.powerOfTwo();
        break;
    case 4:
        functionalprograms.hormonicnumber harmonic = new functionalprograms.hormonicnumber();
        harmonic.main();
        break;
    case 5:
        functionalprograms.Program prime = new functionalprograms.Program();
        prime.primefact();
        break;
    case 6:
        functionalprograms.quotientandremainder cal = new functionalprograms.quotientandremainder();
        cal.main();
        break;
    case 7:
        functionalprograms.swapptwonumbers se = new functionalprograms.swapptwonumbers();
        se.swap();
        break;
    case 8:
        functionalprograms.evenorodd eo = new functionalprograms.evenorodd();
        eo.even();
        break;
    case 9:
        functionalprograms.vowelorconsonent alphabet = new functionalprograms.vowelorconsonent();
        alphabet.Vowel();
        break;
    case 10:
        functionalprograms.largestnumber value = new functionalprograms.largestnumber();
        value.largest();
        break;
    default:
        Console.WriteLine("Enter valid Option.");
        break;
}