/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
*/

public class Solution {
    public string Convert(string s, int numRows) {
        int currentRow = 0;
        bool up = true;
        string[] rows = new string[numRows];
        //1. find number of columns
        //colNum = s.Length 
        //create a list. one entry for each row you're going to need

        if (numRows == 1){
            return s;
        }

        for (int i = 0; i < s.Length; i++){
            rows[currentRow] += s[i];

            if (currentRow == 0){
                up = true;
                //Console.WriteLine($"currentRows = {currentRow}. Going up.");
            } else if (currentRow == numRows-1){
                up = false;
                //Console.WriteLine($"currentRows = {currentRow}. Going down.");
            }

            currentRow = up ? currentRow+1 : currentRow-1;
        }

        //Console.WriteLine($"ans : {ans}");

        return string.Join("",rows);
    }
}