#include <iostream>

using namespace std;

int BinarySearch (int a[], int Left, int Right, int Target)
{

    if (Left <= Right) {
        int Mid = (Left + Right)/2;
        if (Target < a[Mid]) return BinarySearch (a, Left, Mid - 1, Target);
        if (Target > a[Mid]) return BinarySearch (a, Mid + 1, Right, Target);
        return Mid;
    }
    return -1;
}

void QuickSort (int a[], int Left, int Right)
{
    int i = Left, j = Right, Mid = (Left + Right)/2;
    if (Left <= Right) {
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
    int n,m;
    cin >> n;
    int *a = new int [n];
    for (int i = 0; i < n; i++) {
        a[i] = rand()%100 + 1;
    }
    for (int i = 0; i < n; i++) {
        cout << a[i] << " " ;
    }
    QuickSort(a, 0, n-1);
    cout << "Find: ";
    cin >> m;
    if (BinarySearch(a, 0, n-1, m) == -1) cout << "No match";
        else {
            cout << "Matching!";
            cout << "\n" << m << " is in position "<< BinarySearch(a, 0, n-1, m);
        }
    return 0;
}
