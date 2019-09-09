#include <iostream>

using namespace std;

void QuickSort (int a[], int Left, int Right)
{
    int i = Left, j = Right, Mid = (Left + Right)/2;
    while (i <= j) {
        while (a[i] < a[Mid]) i++;
        while (a[j] > a[Mid]) j--;
        if (i <= j) {
            swap (a[i], a[j]);
            i++;
            j--;
        }
    }
    if (Left <= j) QuickSort (a, Left, j);
    if (Right >= i) QuickSort (a, i, Right);
}

int main()
{
    int n;
    cin >> n;
    int *a = new int [n];
    for (int i = 0; i < n; i++) {
        a[i] = rand()%100 + 1;
    }
    for (int i = 0; i < n; i++) {
        cout << a[i] << " " ;
    }
    cout << "\nAfter Sorted: ";
    QuickSort(a, 0, n-1);
    for (int i = 0; i < n; i++) {
        cout << a[i] << " " ;
    }
    return 0;
}
