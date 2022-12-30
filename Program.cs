int ArrayQuantity(string[] array, int elemLength) // метод поиска количества элементов в массиве, подходящих по условию
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elemLength) quantity++;
    }
    return quantity;
}
void ArrayTransferringElements(string[] array, string[] arrayTransfer, int elemLength) // метод для переноса значений подходящих по условию задачи в новый массив
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elemLength)
        {
            arrayTransfer[j] = array[i];
            j++;
        }
    }
}
int requiredLengthElement = 3;
System.Console.WriteLine("Введите элементы массива через точку с запятой\n Пример => sdf;12;sinple;gotolag;-2");
string[] arrayString = Array.ConvertAll<string, string>(Console.ReadLine().Split(';'), elem => { return System.Convert.ToString(elem); });
int quantityElems = ArrayQuantity(arrayString, requiredLengthElement);
string[] arraySelectedValues = new string[quantityElems];
ArrayTransferringElements(arrayString, arraySelectedValues, requiredLengthElement);
System.Console.WriteLine(string.Join(" ; ", arraySelectedValues));

