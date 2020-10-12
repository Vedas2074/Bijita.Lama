class Array //no of collection of same type
{
    void Learn1DArray()
    {
       byte[] array1 = new byte[10];
       array1[0] = 25;
       array1[1] = 10;
       array1[9] = 30;
       

       float[] array2 = new float[] { 1.2f, 2.1f, 35.25f};//if array element is already known
       var x = array2.Length;//:3=no of item

       char[] array3 = {'A','B','C'};
       float[] subarray1 = array2[1..3];

    }
    void LearnMulDArray()
    {
        //2D array
        int[,] numbers = new int [3,4]; 
        numbers[0,0] = 35446;
        numbers[2,2] = -848;

        decimal[,] numbers2 = {{2.3m,34.5m},{56.4m, 12.45m}};

    }
    void LearnJaggedArray()
    {
        short[][] numbers = new short[4][];//Jagged array=holds array of multiple size
        numbers[0] = new short[] { 3, 4, 5 };
        numbers[1] = new short[] { 3,4};
        numbers[2] = new short[] { 3, 5, 6, 12};   
    }

}