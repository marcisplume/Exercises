using System;

namespace Exercises.Level1;

/// <summary>
/// Basic array problems -- can do without loops, but using loops is recomended.
/// Use a[0], a[1], ... to access elements in an array, a.Length is the length of array.
/// Allocate a new array like this: int[] a = new int[10];
/// </summary>
public class Array1
{
    /// <summary>
    /// Given an array of ints, return true if 6 appears as either the first or last element in the
    /// array. The array will be length 1 or more.
    /// 
    /// firstLast6([1, 2, 6]) → true
    /// firstLast6([6, 1, 2, 3]) → true
    /// firstLast6([13, 6, 1, 2, 3]) → false
    /// </summary>
    public bool FirstLast6(int[] nums)
    {
        int first = nums[0];
        int lastindex = nums.Length - 1;
        int last = nums[lastindex];
        return first == 6 || last == 6;


       
    }

    /// <summary>
    /// Given an array of ints, return true if the array is length 1 or more, and the first element
    /// and the last element are equal.
    /// 
    /// sameFirstLast([1, 2, 3]) → false
    /// sameFirstLast([1, 2, 3, 1]) → true
    /// sameFirstLast([1, 2, 1]) → true
    /// </summary>
    public bool SameFirstLast(int[] nums)
    {
        if (nums.Length == 0)
        {
            return false;
        }
        
        int masivaGarums = nums.Length;
        int pirmais = nums[0];
        int noskaidroPedejo = nums.Length-1;
        int pedejais = nums[noskaidroPedejo];

        return masivaGarums >= 1 && pirmais == pedejais;

        
    }

    /// <summary>
    /// Return an int array length 3 containing the first 3 digits of pi, {3, 1, 4}.
    /// 
    /// makePi() → [3, 1, 4]
    /// </summary>
    public int[] MakePi()
    {


        return new int[] { 3, 1, 4 };
        
        
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given 2 arrays of ints, a and b, return true if they have the same first element or they
    /// have the same last element. Both arrays will be length 1 or more.
    /// 
    /// commonEnd([1, 2, 3], [7, 3]) → true
    /// commonEnd([1, 2, 3], [7, 3, 2]) → false
    /// commonEnd([1, 2, 3], [1, 3]) → true
    /// </summary>
    public bool CommonEnd(int[] a, int[] b)
    {
       
        
        //int aPirmais = a[0];
        //int bPirmais = b[0];
        //int aPedejais = a[a.Length - 1];
        //int bPedejais = b[b.Length - 1];

        //return aPedejais == bPedejais || aPirmais == bPirmais;

        // vai iespējams ir šāds vaiants

        return a[0] == b[0] || a[a.Length-1] == b[b.Length-1];

                
         
    }

    /// <summary>
    /// Given an array of ints length 3, return the sum of all the elements.
    /// 
    /// sum3([1, 2, 3]) → 6
    /// sum3([5, 11, 2]) → 18
    /// sum3([7, 0, 0]) → 7
    /// </summary>
    public int Sum3(int[] nums)
    {

        int sum = 0; // šis sākumā jāuzstāda lai piešķirtu vērtību

        foreach (var num in nums) // 
        {

            sum = sum + num; // šo viņš veic vairākos piegājienos līdz beidzāsn num datu masība jeb rindā

            } // tiklīdz beidzās dati iziet un atgriež pedējo summas vērtību
        
        return sum;
        
        
        //return nums[0] + nums[1]+ nums [2];
        
                
    }

    /// <summary>
    /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
    /// 3} yields {2, 3, 1}.
    /// 
    /// rotateLeft3([1, 2, 3]) → [2, 3, 1]
    /// rotateLeft3([5, 11, 9]) → [11, 9, 5]
    /// rotateLeft3([7, 0, 0]) → [0, 0, 7]
    /// </summary>
    public int[] RotateLeft3(int[] nums)
    {
        return new int[] { nums[1], nums[2], nums[0]}; 
        //return ($"{nums[1]}  {nums[2]}  {nums[0]}");

        // izpildīt šo pašu ar ciklu, ja pēkšņi to ierakstu skaits ir piem. 30 gabali,
        // ka visi element maina savu atrašanās vietu par vienu par vienu mazāk
        // katrs cikls parnes elementu -1 

        // bet droši vien atsevisķi jāsaktās uz 0 elementu, jo tas jaaiznest uz otru galu jeb ja
        // mēs noskaidrojam kāds ir masīva garums nums.Length iegūstam nummuru un to pieķiram 0


    }

    /// <summary>
    /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
    /// 3} yields {2, 3, 1}.
    /// 
    /// reverse3([1, 2, 3]) → [3, 2, 1]
    /// reverse3([5, 11, 9]) → [9, 11, 5]
    /// reverse3([7, 0, 0]) → [0, 0, 7]
    /// </summary>
    public int[] Reverse3(int[] nums)
    {
        return new int[] { nums[2], nums[1], nums[0] };
    }

    /// <summary>
    /// Given an array of ints length 3, figure out which is larger, the first or last element in the
    /// array, and set all the other elements to be that value. Return the changed array.
    /// 
    /// maxEnd3([1, 2, 3]) → [3, 3, 3]
    /// maxEnd3([11, 5, 9]) → [11, 11, 11]
    /// maxEnd3([2, 11, 3]) → [3, 3, 3]
    /// </summary>
    public int[] MaxEnd3(int[] nums)
    {

        int Lielakais = Math.Max(nums[0], nums[2]);

        return new int[] { Lielakais, Lielakais, Lielakais};

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] > Lielakais)
        //    {
        //        Lielakais = nums[i];
        //    }
        //    // jāapskata lielākais vai ir pirmais vai beigās elements
        //}

        //return new int[] { Lielakais, Lielakais, Lielakais };

        //nums[0], nums[0], nums[0]

        //return (Lielakais + Lielakais + Lielakais);

        //int max = nums.Max();

        //return ($"{lielakavertiba} {lielakavertiba} {lielakavertiba}");


    }

    /// <summary>
    /// Given an array of ints, return the sum of the first 2 elements in the array. If the array
    /// length is less than 2, just sum up the elements that exist, returning 0 if the array is length
    /// 0.
    /// 
    /// sum2([1, 2, 3]) → 3
    /// sum2([1, 1]) → 2
    /// sum2([1, 1, 1, 1]) → 2
    /// </summary>
    public int Sum2(int[] nums)
    {
        int rindasGarums = nums.Length;

        if (rindasGarums == 0)
        {
            return 0;
        }

        if (rindasGarums == 1)
        {
            return nums[0];

        }
        if (rindasGarums > 1)
        {
            return nums[0] + nums[1];

        }

        
        return 0;
    }

    /// <summary>
    /// Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their
    /// middle elements.
    /// 
    /// middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
    /// middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
    /// middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
    /// </summary>
    public int[] MiddleWay(int[] a, int[] b)
    {
        return new int [] { a[1], b[1]};
    }

    /// <summary>
    /// Given an array of ints, return a new array length 2 containing the first and last elements
    /// from the original array. The original array will be length 1 or more.
    /// 
    /// makeEnds([1, 2, 3]) → [1, 3]
    /// makeEnds([1, 2, 3, 4]) → [1, 4]
    /// makeEnds([7, 4, 6, 2]) → [7, 2]
    /// </summary>
    public int[] MakeEnds(int[] nums)
    {
        
       return new int[] { nums[0], nums[nums.Length-1]};
        
        
    }

    /// <summary>
    /// Given an int array length 2, return true if it contains a 2 or a 3.
    /// 
    /// has23([2, 5]) → true
    /// has23([4, 3]) → true
    /// has23([4, 5]) → false
    /// </summary>
    public bool Has23(int[] nums)
    {
        
        return (nums[0] == 2 || nums[1] == 2 || nums[0] == 3 || nums[1] == 3);
        
        
    }

    /// <summary>
    /// Given an int array length 2, return true if it does not contain a 2 or 3.
    /// 
    /// no23([4, 5]) → true
    /// no23([4, 2]) → false
    /// no23([3, 5]) → false
    /// </summary>
    public bool No23(int[] nums)
    {
        return (nums[0] != 2 && nums[0] != 3 && nums[1] != 2 && nums[1] != 3);
    }

    /// <summary>
    /// Given an int array, return a new array with double the length where its last element is the
    /// same as the original array, and all the other elements are 0. The original array will be
    /// length 1 or more. Note: by default, a new int array contains all 0's.
    /// 
    /// makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
    /// makeLast([1, 2]) → [0, 0, 0, 2]
    /// makeLast([3]) → [0, 3]
    /// </summary>
    public int[] MakeLast(int[] nums)
    {
        int rindasGarums = nums.Length;

        int rindasGarumsReiz2 = rindasGarums * 2;

        int pedCipPoz = nums.Length - 1;

        //int jaunaPedCipPoz = pedCipPoz * 2;

        int[] jaunsMasivs= new int [rindasGarumsReiz2]; // šeit es definēju cik pozīciju kopējo skaitu

       // izveidoju

        jaunsMasivs[jaunsMasivs.Length-1] = nums[rindasGarums - 1];// kreisajā pusē vēršos pie jaunā masīva konkrētās pozicijas  un labajā pusē vecās array konkrētās pozicijas un padaru tās veinādas

        return jaunsMasivs;













        //int num = nums[whileIteratorv];
        //Console.WriteLine($"whileIterator = {whileIteratorv} num ={num}");
        //whileIteratorv++; // Šis nozīme mūžigo ciklu

        
    }

    /// <summary>
    /// Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be
    /// length 0, 1, or 2.
    /// 
    /// double23([2, 2]) → true
    /// double23([3, 3]) → true
    /// double23([2, 3]) → false
    /// </summary>
    public bool Double23(int[] nums)
    {
        int rindasGarums = nums.Length;

        if (rindasGarums < 2)
            return false;

        if ((nums[0] == 2  && nums[0] == nums[1]) || (nums[0] == 3 && nums[0] == nums[1]))
        { 
        return true;
        }

            // ja a =b =c 





        //foreach (int i in nums)
        //{
        //    int numberCount = nums[i];
        //    if (numberCount == 2)
        //    { 
        //    return true;
        //    }
        //}
        
        
        
        
        //// vai datu masīvs satur divus 2  vai divus 3 atgriezt true
        //// ar ciklu saskaitīt cik ir divnieki un cik trīnieki 

        ////int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
        //int count = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    for (int j = i; j < nums.Length - 1; j++)
        //    {

        //        if (nums[j] == nums[j + 1])
        //            count = count + 1;
        //    }
            
        //    return (count == 2 && nums [i] ==2);
            
        //    //Console.WriteLine("\t\n " + nums[i] + "occurse" + count);
        //    //Console.ReadKey();


        //    return false;
        //}


        // ja divnieku skaits ir == ar 2 vai 3 skaits vienāds ar 2 tad true
        // int divskaits = 
        // int trisskaits = 

        // return (divskaits == 2 vai triskaits == 2)

        return false;

    }

    /// <summary>
    /// Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the
    /// 3 element to 0. Return the changed array.
    /// 
    /// fix23([1, 2, 3]) → [1, 2, 0]
    /// fix23([2, 3, 5]) → [2, 0, 5]
    /// fix23([1, 2, 1]) → [1, 2, 1]
    /// </summary>
    public int[] Fix23(int[] nums)
    {


        //int masivaGarums = nums.Length;

        //int [] jaunsMasivs = new int [masivaGarums];

        if (nums[0] == 2 && nums[1] == 3)

          nums[1] = 0;

        if (nums[1] == 2 && nums[2] == 3)
            nums[2] = 0;

        return nums;



        //int[] jaunsMasivs = new int[rindasGarumsReiz2]; // šeit es definēju cik pozīciju kopējo skaitu

        //// izveidoju

        //jaunsMasivs[jaunsMasivs.Length - 1] = nums[rindasGarums - 1];// kreisajā pusē vēršos pie jaunā masīva konkrētās pozicijas  un labajā pusē vecās array konkrētās pozicijas un padaru tās veinādas




        
    }

    /// <summary>
    /// Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as
    /// their first element.
    /// 
    /// start1([1, 2, 3], [1, 3]) → 2
    /// start1([7, 2, 3], [1]) → 1
    /// start1([1, 2], []) → 1
    /// </summary>
    public int Start1(int[] a, int[] b)
    {

        if (a.Length > 0 && a[0] == 1 && b.Length > 0 && b[0] == 1)
            return 2;

        if (a.Length>0 && a[0] == 1)
            return 1;
        if ( b.Length > 0 && b[0] == 1)
            return 1;


        return 0;

        
        
        throw new NotImplementedException();
    }

    /// <summary>
    /// Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each
    /// array. Return the array which has the largest sum. In event of a tie, return a.
    /// 
    /// biggerTwo([1, 2], [3, 4]) → [3, 4]
    /// biggerTwo([3, 4], [1, 2]) → [3, 4]
    /// biggerTwo([1, 1], [1, 2]) → [1, 2]
    /// </summary>
    public int[] BiggerTwo(int[] a, int[] b)
    {
        
        int asumma = a[0] + a[1];
        int bsumma = b[0] + b[1];

        if (bsumma > asumma)
            return b;

        return a;


        
    }

    /// <summary>
    /// Given an array of ints of even length, return a new array length 2 containing the middle
    /// two elements from the original array. The original array will be length 2 or more.
    /// 
    /// makeMiddle([1, 2, 3, 4]) → [2, 3]
    /// makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
    /// makeMiddle([1, 2]) → [1, 2]
    /// </summary>
    public int[] MakeMiddle(int[] nums)
    {

        int videjaisIndeks = nums.Length / 2;

        int videjaisIndeks2 = videjaisIndeks - 1;

        
        int [] a = new int[2];
        a[1] = nums[videjaisIndeks];
        a[0] = nums[videjaisIndeks2];
        
       
                return a;

        // = 


        //int[] jaunsMasivs = new int[rindasGarumsReiz2]; // šeit es definēju cik pozīciju kopējo skaitu

        //// izveidoju

        //jaunsMasivs[jaunsMasivs.Length - 1] = nums[rindasGarums - 1];// kreisajā pusē vēršos pie jaunā masīva konkrētās pozicijas  un labajā pusē vecās array konkrētās pozicijas un padaru tās veinādas

        //return jaunsMasivs;


        //int sakam = nums.Length;

        //int turpinam = sakam / 2;

        //return  nums[nums.Length/-turpinam];


        throw new NotImplementedException();
    }

    /// <summary>
    /// Given 2 int arrays, each length 2, return a new array length 4 containing all their
    /// elements.
    /// 
    /// plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
    /// plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
    /// plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
    /// </summary>
    public int[] PlusTwo(int[] a, int[] b)
    {
        int[] c = new int[4];
        c[0] = a[0];
        c[1] = a[1];
        c[2] = b[0];
        c[3] = b[1];


        return c;

        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an array of ints, swap the first and last elements in the array. Return the modified
    /// array. The array length will be at least 1.
    /// 
    /// swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
    /// swapEnds([1, 2, 3]) → [3, 2, 1]
    /// swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
    /// </summary>
    public int[] SwapEnds(int[] nums)
    {

        int pirmaVieta = nums[0];

        int pedejaVieta = nums[nums.Length-1];
        
        if (nums.Length > 0 )
        {
            nums[0] = pedejaVieta;
            nums[nums.Length-1] = pirmaVieta;
            return nums;
        }
        
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an array of ints of odd length, return a new array length 3 containing the elements
    /// from the middle of the array. The array length will be at least 3.
    /// 
    /// midThree([1, 2, 3, 4, 5]) → [2, 3, 4]
    /// midThree([8, 6, 7, 5, 3, 0, 9]) → [7, 5, 3]
    /// midThree([1, 2, 3]) → [1, 2, 3]
    /// </summary>
    public int[] MidThree(int[] nums)
    {

        int videjaisIndeks = nums.Length / 2;

        int sPalabi = videjaisIndeks +1;

        int paKreisi  = videjaisIndeks -1;


        int[] a = new int[3];
        a[0] = nums[paKreisi];
        a[1] = nums[videjaisIndeks];
        a[2] = nums[sPalabi];


        return a;




        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an array of ints of odd length, look at the first, last, and middle values in the array
    /// and return the largest. The array length will be a least 1.
    /// 
    /// maxTriple([1, 2, 3]) → 3
    /// maxTriple([1, 5, 3]) → 5
    /// maxTriple([5, 2, 3]) → 5
    /// </summary>
    public int MaxTriple(int[] nums)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an int array of any length, return a new array of its first 2 elements. If the array is
    /// smaller than length 2, use whatever elements are present.
    /// 
    /// frontPiece([1, 2, 3]) → [1, 2]
    /// frontPiece([1, 2]) → [1, 2]
    /// frontPiece([1]) → [1]
    /// </summary>
    public int[] FrontPiece(int[] nums)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. Return true if
    /// the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.
    /// 
    /// unlucky1([1, 3, 4, 5]) → true
    /// unlucky1([2, 1, 3, 4, 5]) → true
    /// unlucky1([1, 1, 1]) → false
    /// </summary>
    public bool Unlucky1(int[] nums)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, the
    /// elements from a followed by the elements from b. The arrays may be any length, including
    /// 0, but there will be 2 or more elements available between the 2 arrays.
    /// 
    /// make2([4, 5], [1, 2, 3]) → [4, 5]
    /// make2([4], [1, 2, 3]) → [4, 1]
    /// make2([], [1, 2]) → [1, 2]
    /// </summary>
    public int[] Make2(int[] a, int[] b)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given 2 int arrays, a and b, of any length, return a new array with the first element of
    /// each array. If either array is length 0, ignore that array.
    /// 
    /// front11([1, 2, 3], [7, 9, 8]) → [1, 7]
    /// front11([1], [2]) → [1, 2]
    /// front11([1, 7], []) → [1]
    /// </summary>
    public int[] Front11(int[] a, int[] b)
    {
        throw new NotImplementedException();
    }
}
