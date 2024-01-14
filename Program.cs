int Moscow = 13015126;
int Spb = 5598486;
int inh = Moscow % 1000000 / 1000;
int nih = Spb % 1000000 / 1000;
int finish = nih - inh;
Console.WriteLine($"На {finish} тысяч меньше в Москве");


double rab = 260548.56895;
const double NDFL = 13.0;
double month = rab / 12;
double NDFL13 = month/100*NDFL;
double ZpSNdfl = month - NDFL13;
Console.WriteLine($"Зарплата за месяц: {month:F2}. Зарплата за месяц с вычетом НДФЛ:{ZpSNdfl:F2}.");






