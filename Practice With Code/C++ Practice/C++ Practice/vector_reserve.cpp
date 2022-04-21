#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
#include <algorithm>
#include <utility>
#include <cmath>
#include <ctime>
#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <vector>
#include <list>
#include <deque>
#include <set>
#include <map>
#include <unordered_set>
#include <unordered_map>
#include <stack>
#include <queue>

using ll = long long;
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);

    //1-1. initialize default type
    vector<int> v;
    for (int i = 0; i < 10000; i++)
    {
        v.push_back(1);
    }
    cout << "size & capacity : " << v.size() << " " << v.capacity() << "\n"; // 10,000 / 12,128

    //1-2. initialize parameter type
    vector<int> vector_initialize(10000, 1);
    cout << "size & capacity : " << vector_initialize.size() << " " << vector_initialize.capacity() << "\n"; // 10,000 / 10,000
    

    //2. reserve
    vector<int> vector_reserve;
    vector_reserve.reserve(10000);
    cout << "size & capacity : " << vector_reserve.size() << " " << vector_reserve.capacity() << "\n"; // 0 / 10,000
    /*vector_reserve[100] = 123;
    cout << vector_reserve[100];*/ //ERROR CODE

    //3. resize
    vector<int> vector_resize;
    vector_resize.resize(10000);
    cout << "size & capacity : " << vector_resize.size() << " " << vector_resize.capacity() << "\n"; // 10,000 / 10,000
    vector_resize[100] = 123;
    cout << vector_resize[100]; // 123



    return 0;
}