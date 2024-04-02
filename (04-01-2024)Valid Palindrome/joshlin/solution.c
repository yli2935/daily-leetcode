#include <ctype.h>
#include <string.h>
#include <stdbool.h>

// Literally 'two pointers' :)
bool isPalindrome(char* s) {
    char* l = s;
    char* r = s + strlen(s) - 1;
    while (l < r) {
        while (l < r && !isalnum(*l)) l++;
        while (l < r && !isalnum(*r)) r--;
        if (tolower(*l) != tolower(*r)) return false;
        l++, r--;
    }
    return true;
}