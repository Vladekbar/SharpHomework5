// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] NewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue);
    return array;
}

int NotEvenSearchAndSum(int[] array)
{   
    int sumOfNotEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOfNotEven = sumOfNotEven + array[i];
        }
    }
    return sumOfNotEven;
}

int[] array = NewRandomArray(4, -9, 9);
Console.WriteLine("[" + string.Join(", ", array) + "]" + " -> " + NotEvenSearchAndSum(array));