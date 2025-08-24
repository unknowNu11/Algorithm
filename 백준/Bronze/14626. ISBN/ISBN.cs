using System;

class Program
{
    static void Main() {
        string isbn = Console.ReadLine();
        int sum = 0;
        int star_index = -1;

        for(int i = 0; i < 13; i++) {
            if(isbn[i] == '*') {
                star_index = i;
                continue;
            }

            int digit = int.Parse(isbn[i].ToString());
            if(i % 2 == 0)
                sum += digit;
            else
                sum += 3 * digit;
        }

        for(int i = 0; i < 10; i++) {
            int temp_sum = sum;
            if(star_index % 2 == 0)
                temp_sum += i;
            else
                temp_sum += 3 * i;

            if(temp_sum % 10 == 0)
                Console.WriteLine(i);
        }
    }
}