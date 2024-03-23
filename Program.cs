// 1. Vaqt kalkulyatori:----------
Console.Write("Daqiqanini kiriting: ");
int daqiqa = Convert.ToInt32(Console.ReadLine());
int m = daqiqa / 60;
int s = daqiqa % 60;
System.Console.WriteLine($"{m}:{s}");

// 2. Yosh toifasini aniqlash:------------
Console.Write("Yosh: ");
int yosh = Convert.ToInt32(Console.ReadLine());
string result = "";
if(yosh > 0 && yosh <= 12)
{
    result = "bola";
}
else if(yosh >= 13 && yosh <= 19)
{
    result = "o'smir";
}
else if(yosh >= 20 && yosh <= 59)
{
    result = "kattalar";
}
else if(yosh >= 60)
{
    result = "katta";
}
System.Console.WriteLine(result);

// 3. O'rtacha ballni hisoblash:--------------------
Console.Write("matematika(ball): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("fizika(ball): ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("english(ball): ");
int c = Convert.ToInt32(Console.ReadLine());
string matematika = 
    (a >= 80 && a <= 100)
        ? "A'lo"
        : (a >= 60 && a <= 79)
            ? "Yaxshi"
            : (a >= 40 && a <= 59)
                ? "Qoniqarli"
                : (a < 40)
                    ? "Qoniqarsiz"
                    : "ballni xato kiritdingiz";
string fizika = 
    (b >= 80 && b <= 100)
        ? "A'lo"
        : (b >= 60 && b <= 79)
            ? "Yaxshi"
            : (b >= 40 && b <= 59)
                ? "Qoniqarli"
                : (b < 40)
                    ? "Qoniqarsiz"
                    : "ballni xato kiritdingiz";
string english = 
    (c >= 80 && c <= 100)
        ? "A'lo"
        : (c >= 60 && c <= 79)
            ? "Yaxshi"
            : (c >= 40 && c <= 59)
                ? "Qoniqarli"
                : (c < 40)
                    ? "Qoniqarsiz"
                    : "ballni xato kiritdingiz";
        
System.Console.WriteLine($"matematika: {matematika}");
System.Console.WriteLine($"fizika: {fizika}");
System.Console.WriteLine($"english: {english}");


// 4. "Raqamni toping" o'yini:------------------
Random r = new Random();
int num = r.Next(100);
bool t = true;
string txt = "son kiriting: ";
string natija = "";
while(t)
{
    Console.Write(txt);
    int son = Convert.ToInt32(Console.ReadLine());
    natija = 
        (son > num)
            ? txt = "siz kiritgan son katta\nkichikroq son kiriting: "
            : (son < num)
                ? txt = "siz kiritgan son kichik\nkattaroq son kiriting: "
                : "to'g'ri topdingiz✅";
    if(natija[natija.Length-1] == '✅')
    {
        break;
    }
}
Console.WriteLine($"bu son {num} edi {natija}");
