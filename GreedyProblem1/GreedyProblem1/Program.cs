// See https://aka.ms/new-console-template for more information

// 문제. 큰 수의 법칙
// 배열의 크기 N, 숫자가 더해지는 횟수 M, 연속해서 더해질 수 있는 횟수 K

int N = 0;
int M = 0;
int K = 0;
int firstMaxNum = 0;
int secondMaxNum = 0;
int result = 0;
List<int> numberList = new List<int>();

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int.TryParse(splitInput[0], out N);
int.TryParse(splitInput[1], out M);
int.TryParse(splitInput[2], out K);

input = Console.ReadLine();
splitInput = input.Split(' ');

int temp = 0;
for (int i = 0; i < splitInput.Length; i++)
{
    int.TryParse(splitInput[i], out temp);
    numberList.Add(temp);
}

var sortNumberList = numberList.OrderByDescending(x => x).ToList();
firstMaxNum = sortNumberList[0];
secondMaxNum = sortNumberList[1];

result = (M / (K + 1) * (firstMaxNum * K + secondMaxNum)) + (M % (K + 1) * firstMaxNum);
Console.WriteLine(result);
