#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    while(1)
    {

        int ans = rand() % 10;
        int tries = 0;
        cout << "Guess a number from 1 - 10\n";

        while(1)
        {
            int guess;
            tries++;

            cin >> guess;
            if(guess == ans)
            {
                cout << "Correct. You took " << tries << " tries\n";
                break;
            }
            else
            {
                cout << "Incorrect. Try again.\n";
            }
        }
    }
    return 0;
}
