#define MyFunctions _declspec(dllexport)
extern "C"
{
	MyFunctions int Add(int a, int b)
	{
		return a + b;
	}

	MyFunctions int Subtract(int a, int b)
	{
		return a - b;
	}

	MyFunctions int Multiply(int a, int b)
	{
		return a * b;
	}

	MyFunctions int Dividing(int a, int b)
	{
		return  a / b;
	}
}