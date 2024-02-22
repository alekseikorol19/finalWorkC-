void ReversedArray(int[] array, int j) {
    if (j == 0) {
        Console.Write(array[j]);
        return;
    } else {
        Console.Write(array[j] + " ");
        ReversedArray(array,j-1);
    }
}
ReversedArray([1,2,3,4,5,6],5);