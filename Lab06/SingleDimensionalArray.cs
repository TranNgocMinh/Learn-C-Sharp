 static void Main(string[] args)
        {
            // nhập số phần tử mảng
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine()); 
            // khai báo mảng
            int[] array = new int[n];
            // nhập giá trị cho mảng
            Array_Input(array, n);
            //Hiển thị các phần tử của mảng
            Console.Write("Cac phan tu cua mang: ");
            Array_Output(array, n);
            Console.WriteLine();
            // tổng các phần tử của mảng
            int sum = Sum(array);
            Console.Write("Tong cac phan tu la: " + sum.ToString());
            // Đảo ngược các phần tử của mảng
            Array.Reverse(array);
            //Hiển thị các phần tử của mảng sau khi đảo
            Console.WriteLine();
            Console.Write("Cac phan tu cua mang sau khi dao: ");
            Array_Output(array, n);
            // Sắp xếp các phần tử của mảng theo thứ tự tăng dần
            Sort(array,n,true);
            Console.WriteLine();
            Console.Write("Cac phan tu cua mang sau khi sap xep: ");
            Array_Output(array, n);
            Console.ReadKey();
            
        }
        public static void Array_Input(int[] array,  int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1).ToString());
                array[i] = int.Parse(Console.ReadLine()); 
            } 
        }
        public static void Array_Output(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
        }
        public static int Sum(params int[] numbers)
        {
            int s = 0;
            foreach (int num in numbers)
                s = s + num;
            return s;
        }
        public static void Sort(int[] array, int n, bool ASC)
        {
           
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ASC)
                    {
                        if (array[i] > array[j])
                            Swap(ref array[i], ref array[j]);
                    }
                    else
                    {
                        if (array[i] < array[j])
                            Swap(ref array[i], ref array[j]);
                    }
                    
                }
            }

        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
