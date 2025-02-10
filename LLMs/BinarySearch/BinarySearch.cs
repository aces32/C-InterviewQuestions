namespace LLMs.BinarySearch
{
    internal class BinarySearch
    {
        /*
         * 
        Imagine you have a big book 📖 with 100 pages. 
        You want to find a specific page number, but instead of flipping through one page at a time, 
        you can search faster using a smart trick called Binary Search!

        How Binary Search Works (Step-by-Step)
            1️⃣ Open the book in the middle 📖 (let's say page 50).
            2️⃣ Check if it's the page you want:
            
            If yes, you're done! 🎉
            If the page is too small, go to the right half of the book 📚 (pages 51-100).
            If the page is too big, go to the left half of the book 📚 (pages 1-49). 3️⃣ Repeat the process until you find the correct page.
            Example: Find Page 73 📄
            1️⃣ Open the book in the middle (page 50).
            
            Is it 73? ❌ No!
            73 is bigger, so look at pages 51-100.
            2️⃣ Open the middle of 51-100 (page 75).
            
            Is it 73? ❌ No!
            73 is smaller, so look at pages 51-74.
            3️⃣ Open the middle of 51-74 (page 62).
            
            Is it 73? ❌ No!
            73 is bigger, so look at pages 63-74.
            4️⃣ Open the middle of 63-74 (page 68).
            
            Is it 73? ❌ No!
            73 is bigger, so look at pages 69-74.
            5️⃣ Open the middle of 69-74 (page 72).
            
            Is it 73? ❌ No!
            73 is bigger, so look at pages 73-74.
            6️⃣ Open page 73. 🎉 Found it!
            
            Why is Binary Search Fast? 🚀
            Instead of checking every page one by one 📑 (which takes 100 steps in the worst case),
            Binary search cuts the search space in half each time 🏆
            You only need about 7 steps to find a page in a 100-page book!
         */

        public int BinarySearchImpl(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // 🎉 Found!

                if (arr[mid] < target)
                    left = mid + 1; // 🔍 Search right half
                else
                    right = mid - 1; // 🔍 Search left half
            }

            return -1; // ❌ Not found
        }

    }
}
