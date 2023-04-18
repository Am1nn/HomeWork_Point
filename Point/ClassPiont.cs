
namespace Point_and_Counter
{
    class Point
    {
        private int _Variable_X;
        private int _Variable_Y;


        // Constructors
        public Point()
        {
            _Variable_X = 777;
            _Variable_Y = 777;
        }
        public Point(int Variable_X_g, int Variable_Y_g)
        {
            // README
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Parametrli Constructurun Qebul Etdiyi Deyerlerin Sonuna g Yazmaqim (get) Menasini Verir Bunu Ozume Bir Qayda Olaraq Yaziram.
            // Bildirmek Isdedim.Meqsed Gelen Deyerleri Rahat Ferqlendirmekdir.
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            _Variable_X = Variable_X_g;
            _Variable_Y = Variable_Y_g;
        }
        // Print Functions
        public void PrintData()
        {
            Console.WriteLine($"\nVariable X->> {_Variable_X}\nVariable Y->> {_Variable_Y}");   
        }
    }

    internal class Counter
    {
        private int _Min;
        private int _Max;
        private int _Current_Count;


        // Constructors
        public Counter()
        {
            // Note !!
            // Default Value for fields
            // variable a=0
            // variable b=100
            // current count=0
            this._Min = 0;
            this._Max = 100;
            this._Current_Count = 0;
        }
        public Counter(int _Min_G, int _Max_G)
        {
            this._Min = _Min_G;
            this._Max = _Max_G;
            this._Current_Count = _Min;
        }
        // Incerement Function
        public void Increment()
        {
            if (_Current_Count  == _Max)
                _Current_Count = _Min;
            else
            _Current_Count++;
        }

        // Decrement Function
        public void Decrement()
        {
            if (_Current_Count== _Min)
                _Current_Count = _Min;
            else
            _Current_Count--;
        }
        // Print
        public void Information()
        {
            Console.WriteLine("\t\tCurrent Value Information\n");
            Console.WriteLine($"Min Value->> {_Min}");
            Console.WriteLine($"Max Value->> {_Max}");
            Console.WriteLine($"Current Value->> {_Current_Count}\t");
        }
    }
}
