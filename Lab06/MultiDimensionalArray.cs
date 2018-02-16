static void Main(string[] args)
        {
            Console.Write("Nhap so hang cua ma tran: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot cua ma tran:  ");
            int cols = int.Parse(Console.ReadLine());

            // khởi tạo mảng hai chiều - ma trận
            int[,] matrix = new int[rows, cols];

            // Nhập giá trị cho các ô của ma trận
            Console.WriteLine("Nhap gia tri cho cac o cua ma tran:");
            Matrix_Input(matrix, rows, cols);
 
            // Hiển thị ma trận
            Matrix_Output(matrix, rows, cols);
            Console.ReadKey();
            
        }
        public static void Matrix_Input(int[,] matrix,  int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void Matrix_Output(int[,] matrix, int rows, int cols)
        {
            // GetLength(0) trả về số hàng, GetLength(1) trả về số cột của ma trận
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
