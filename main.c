#include <stdio.h>
#include <ctype.h>

int main() {
    //задание 0
    /*
    printf("введи станцию(A-E):");
    char a;
    scanf(" %c", &a);
    a = tolower(a);
    switch (a)
    {
        case 'a':
            printf("время: 1\n");
            break;
        case 'b':
            printf("время: 2\n");
            break;
        case 'c':
            printf("время: 3\n");
            break;
        case 'd':
            printf("время: 4\n");
            break;
        case 'e':
            printf("время: 5\n");
            break;
        default:
            printf("такой станции нет лох\n");
            break;
    }

    printf("введи те размер массива: ");
    int s = scanf(" %d", &s), j = 0;
     */
    //задание 1
    /*
    int a[5], j = 0;
    for(int i = 0; i < 5; i++)
    {
        printf("a[%i] = ", i);
        scanf("%i", &a[i]);
        if(a[i] != 0) j++;
    }
    printf("ненулевых чисел: %i\n", j);
*/
    //задание 2
    /*
    const int n = 3;
    int a[n], min = 0;
    printf("введите %i целых чисел :\n", n);
    for(int i = 0; i < n; i++)
    {
        printf("a[%i] = ", i);
        scanf("%i", &a[i]);
        //printf("a[%i] = %i", i, a[i]);
    }
    min = a[0];
    for(int i = 1;i < n; i++)
    {
        if(min > a[i]) min = a[i];
    }
    printf("Минимальное значение из введеных чисел: %i.",min);
     */
    //задание 3
    /*
    const int n = 10;
    int a[n], j = 0, sum = 0; // j - подсчет ненулевых значений
    double avg = 0;
    printf("Введите %i чисел:\n", n);
    for(int i = 0; i < n; i++)
    {
        printf("a[%i] = ", i);
        scanf("%i", &a[i]);
        if(a[i] != 0)
        {
            sum += a[i];
            j++;
        }
    }
    avg = sum / j;
    printf("кол-во не-нулевых значений: %i\n", j);
    printf("сумма не-нулевых значений: %i\n", sum);
    printf("среднее арифметическое не-нулевых значений: %f\n", avg);
     */
    //задание 4
    int n;
    printf("Введите размер массива не меньше 3:\n");
    while(1)
    {
        scanf("%i", &n);
        if(n < 3) printf("сука я тебе сказал введи не меньше 3 даун, попробуй еще раз\n");
        else break;
    }
    //printf("%i", n);
    const int N = n;
    int a[N], sum = 0;

    for(int i = 0; i < N; i++)
    {
        printf("a[%i] = ", i);
        scanf("%i", &a[i]);
    }

    for(int i = 0; i < N; i++)
    {
        switch(i)
        {
            case 0:
                if(a[i] < a[i+1]) sum += a[i];
                break;
            case (N-1):
                if(a[i] < a[i-1]) sum += a[i];
                break;
            default:
        }
    }
    printf("%i", sum);
    return 0;
}
