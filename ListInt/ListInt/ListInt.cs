namespace ListInt
{
    internal class ListInt
    {
        private int[] _arr;
        public int Length { get { return _arr.Length; } }

        public int this[int index]
        {
            get
            {
                if (index >= _arr.Length || index < 0)
                {
                    return _arr[_arr.Length - 1];
                }
                return _arr[index];
            }
            set
            {
                if (index < _arr.Length && index >= 0)
                {
                    _arr[index] = value;
                }
            }
        }

        public ListInt()
        {
            _arr = new int[0];
        }

        public ListInt(params int[] nums)
        {
            _arr = nums;
        }

        public void Add(int value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }

        public void AddRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = nums[i];
            }
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                sum += _arr[i];
            }
            return sum;
        }

        public void Remove(int num)
        {
            int findIndex = Array.IndexOf(_arr, num);

            if (findIndex != -1)
            {
                Console.WriteLine($"{num} removed from the array.");
                //2 versiya
                //_arr[findIndex] = _arr[_arr.Length - 1];
                //Array.Resize(ref _arr, _arr.Length - 1);
                for (int i = findIndex; i < _arr.Length - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                Array.Resize(ref _arr, _arr.Length - 1);
            }
            else
            {
                Console.WriteLine($"Cant remove {num} because it is not found in the array.");
            }
        }

        public override string ToString()
        {
            string result = string.Join(", ", _arr);
            return result;
        }

        public void RemoveRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int findIndex = Array.IndexOf(_arr, nums[i]);

                if (findIndex != -1)
                {
                    Console.WriteLine($"{nums[i]} removed from the array.");

                    //Aşağıdakı kimi yazanda dəyərlərin yeri dəyişmiş olur.
                    //_arr[findIndex] = _arr[_arr.Length - 1];
                    //Array.Resize(ref _arr, _arr.Length - 1);

                    //Belə dəyişmir
                    for (int j = findIndex; j < _arr.Length - 1; j++)
                    {
                        _arr[j] = _arr[j + 1];
                    }
                    Array.Resize(ref _arr, _arr.Length - 1);
                }
                else
                {
                    Console.WriteLine($"Can't remove {nums[i]} because it is not found in the array.");
                }
            }
        }
    }
}
