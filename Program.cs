// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

//C# Eğitimi Değişkenler ve Veri Tipleri Ders Uygulaması

byte b = 5;             //1 byte
sbyte c = 5;            //1 byte

short s = 5;            //2 byte
ushort us = 5;          //2 byte

int i = 2;              //4 byte
Int16 i16 = 2;          //2 byte
Int32 i32 = 2;          //4 byte
Int64 i64 = 2;          //8 byte

uint ui = 2;            //4 byte
long l = 2;             //8 byte
ulong ul = 2;           //8 byte

//Reel Sayılar

float f = 5;            //4 byte
double d = 5;           //8 byte
decimal de = 5;         //16 byte

char ch = '2';          //2 byte
string str = "Can";     //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = 'x';
object o2 = "y";
object o3 = 4;
object o4 = 4.3;

//String İfadeler

string str1 = string.Empty;
str1 = "Berat Can Özdemir";
string ad = "Berat Can";
string soyad = "Özdemir";
string adSoyad = ad + " " + soyad;
Console.WriteLine(adSoyad);

//Integer Tanımlama Şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;
Console.WriteLine(integer3);

//Boolean İfadeler

bool bool1 = 10 > 5;
Console.WriteLine(bool1);

bool bool2 = 10 < 5;
Console.WriteLine(bool2);

//Değişken Dönüşümleri

string str20 = "20";
int int23 = 23;
string yeniDeger = str20 + int23.ToString();
Console.WriteLine(yeniDeger);

int int21 = int23 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int23 + int.Parse(str20);
Console.WriteLine(int22);

//DateTime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("hh:mm");
Console.WriteLine(hour);