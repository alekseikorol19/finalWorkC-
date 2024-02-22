void ShowNumbers (int start, int end) {
    if (start == end) {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1,end);
    
}
ShowNumbers(1,5);