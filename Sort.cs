using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public class Sort
    {
        private GenerateArray ga;
        private int[] countArr1;

        public Sort()
        {
            Ga = new GenerateArray();
        }
        
        public GenerateArray Ga { get => ga; set => ga = value; }
        public int[] CountArr1 { get => countArr1; set => countArr1 = value; }

        public int[] Buble(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            arr2 = arr;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int a = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = a;
                    }
                }

            }
            return arr2;

        }

        public int[] ShakeSort(int[] arr)
        {
            int[] arr3 = new int[arr.Length];
            arr3 = arr;
            int r = 0;
            int count2 = 0;
            int count = 1;
            int wcheck = 0;
            bool ans = true;
            foreach (var item in arr3)
            {
                wcheck++;
                int i = count2;
                for (int j = count2 + 1; j < arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        int a;
                        a = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = a;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                count++;
                int l = arr3.Length - (count + 1);
                for (int k = arr3.Length - count; k > 0; k--)
                {
                    if (arr3[k] < arr3[l])
                    {
                        int b;
                        b = arr3[k];
                        arr3[k] = arr3[l];
                        arr3[l] = b;
                        l--;
                    }
                    else
                    {
                        l--;
                    }
                }
                count2++;

                for (int s = r + 1; s < arr3.Length; s++)
                {
                    if (arr3[r] < arr3[s])
                    {
                        r++;
                        ans = true;
                        
                    }
                    else
                    {
                        ans = false;
                        break;
                    }
                    
                }
                if (ans == true)
                {
                    return arr3;
                }
                
            }
            return arr3;

        }

        public int[] SwitchSort(int[] ar)
        {
            int[] arr3 = new int[ar.Length];
            arr3 = ar;
            for (int i = 1; i < arr3.Length; i++)
            {
                int value = arr3[i];
                int index = i;
                while ((index > 0) && (arr3[index-1] > value))
                {
                    arr3[index] = arr3[index - 1];
                    index--;
                }
                arr3[index] = value;
            }
            return arr3;
        }
               
        public int[] CountSort(int[] inputArr)
        {
            
            int[] countArr = new int[inputArr.Length];
            countArr = inputArr;
            int[] newArr = new int[countArr.Max() + 1];
            for (int i = 0; i < newArr.Length-1; i++)
            {
                newArr[countArr[i]]++;
            }
            int[] sortedArr = new int[countArr.Length];
            int indexArr3 = 0;
            for (int i = sortedArr.Length; i >= 0; i--) 
            {
                for (int j = 0;  j < newArr[i];  j++)
                {
                    sortedArr[indexArr3++] = i;
                }
            }
            for (int i = 0; i < countArr.Length; i++)
            {
                countArr[i] = sortedArr[i];
            }

            int[] finalMassiv = new int[countArr.Length];
            int k = 0;
            for (int i = countArr.Length-1; i < countArr.Length && i >= 0; i--)
            {
                finalMassiv[k] = countArr[i];
                k++;
            }

            for (int i = 0; i < countArr.Length; i++)
            {
                countArr[i] = finalMassiv[i];
            }
            CountArr1 = countArr;
            return CountArr1;

        }


        public int[] Extract3(int[] arr)
        {
            int[] nArr = new int[arr.Length];
            nArr = arr;

            List<int> li = new List<int>();
            for (int i = 0; i < nArr.Length; i++)
            {
                li.Add(arr[i]);
            }
            
            List<int> mass = new List<int>();
            for (int i = 0; i < li.Count; )
            {
                int numMax = li.Max();
                if (li[i] == numMax)
                {
                    mass.Add(li[i]);
                    li.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            int[] ar22 = new int[arr.Length];
            for (int i = 0; i < ar22.Length; i++)
            {
                ar22[i] = mass[i];
            }

            int[] ar23 = new int[arr.Length];
            int k = 0;
            for (int i = ar23.Length - 1; i < ar23.Length && i >= 0; i--)
            {
                ar23[k] = ar22[i];
                k++;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ar23[i];
            }



            return arr;
        }








        /*
        public int[] Extract(int[] arr)
        {
            int[] nArr = new int[arr.Length];
            nArr = arr;
            int[] nArr2 = new int[nArr.Length];
            int count = 0;
            int index = 0;
            int numMax = nArr.Max();
            int[] nAr = new int[nArr.Length - 1];
            for (int i = 0; i < nAr.Length; i++)
            {
                nAr[i] = nArr[i];
            }
            for (int i = nAr.Length; i > 0; i--)
            {

                nAr[i] = numMax;
                for (int k = 0; k < nArr.Length; k++)
                {
                    if (nArr[k] != numMax)
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                numMax = nAr.Max();
                Array.Copy(nArr, 0, nAr, 0, (nArr.Length - (nArr.Length - index)));
                Array.Copy(nArr, index + 1, nAr, index, (nArr.Length - index-1));

            }
            while (nAr.Length > 0)
            {


            }


            return arr;
        }

        */


        /*
                public int[] Extract2(int[] arr)
                {
                    int[] nArr = new int[arr.Length];
                    nArr = arr;
                    int k = 0;
                    int numMax = nArr.Max();
                    int count = 1;
                    for (int i = 0; i < nArr.Length; i++)
                    {

                        int[] nArr2 = new int[nArr.Length - count];
                        for (int j = 0; j < nArr2.Length; )
                        {
                            if (nArr[k] == numMax)
                            {
                                k++;
                                continue;
                            }

                            else
                            {
                                nArr2[j] = nArr[k];
                                j++;
                            }

                            k++;

                        }
                        numMax = nArr2.Max();
                        count++;
                    }



                    return arr;
                }


            */


    }

}

