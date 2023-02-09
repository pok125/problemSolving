// See https://aka.ms/new-console-template for more information
// 상하좌우 문제
// 공간의 크기 N*N

int N = 0;
int x = 1;
int y = 1;
string input1 = Console.ReadLine();
int.TryParse(input1, out N);

input1 = Console.ReadLine();
string[] moveWord = input1.Split(' ');

for (int i = 0; i < moveWord.Length; i++)
{
    switch (moveWord[i])
    {
        case "L":
            if (y - 1 >= 1)
                y--;
            break;
        case "R":
            if (y + 1 <= N)
                y++;
            break;
        case "U":
            if (x - 1 >= 1)
                x--;
            break;
        case "D":
            if (x + 1 <= N)
                x++;
            break;
    }
}

Console.WriteLine("{0} {1}",x,y);
