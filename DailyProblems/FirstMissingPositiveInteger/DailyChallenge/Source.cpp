#include <iostream>

using namespace std;

int Result(int arr[], int size) {
	
	
	int min = arr[0];
	
	for (int i = 1; i < size; i++)
	{
		if (arr[i] < 0) continue;
		else if (arr[i] < min) min = arr[i];
	}
	min++; 
	bool test = false;

		do {
			test = false;
			for (int i = 0; i < size; i++) {
				if (min == arr[i])
				{
					min++;
				}
			}
			for (int i = 0; i < size; i++)
			{
				if (min == arr[i]) { test = true; min++; }
			}
		} while (test);
	return min;
}

	//Given an array of integers, find the first missing 
	//positive integer in linear time and constant space.

	int main() {
	int numbers[] = { 3, 4, -1, 1 };
	int size = sizeof(numbers) / sizeof(*numbers);
	cout << Result(numbers, size) << endl;
	system("pause");
}