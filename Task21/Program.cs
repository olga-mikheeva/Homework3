// напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double PointDistance(int AX, int AY, int AZ, int BX, int BY, int BZ)
{
    double dist = 0;
    dist = Math.Sqrt(Math.Pow(AX - BX, 2) + Math.Pow(AY - BY, 2) + Math.Pow(AZ - BZ, 2));
    return dist;
}

int AX = InputNum("Введите значение оси координат x для точки A: ");
int AY = InputNum("Введите значение оси координат y для точки A: ");
int AZ = InputNum("Введите значение оси координат z для точки A: ");
int BX = InputNum("Введите значение оси координат x для точки B: ");
int BY = InputNum("Введите значение оси координат y для точки B: ");
int BZ = InputNum("Введите значение оси координат z для точки B: ");
System.Console.WriteLine(PointDistance(AX, AY, AZ, BX, BY, BZ));

