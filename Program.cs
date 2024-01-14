int Moscow = 13015126;
int Spb = 5598486;
int inh = Moscow % 1000000 / 1000;
int nih = Spb % 1000000 / 1000;
int finish = nih - inh;
Console.WriteLine($"На {finish} тысяч меньше в Москве");