using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        long temp=0;
        long prodotto=1;
        //digits ="92";
        //span =2;
        
        char[] vet=digits.ToCharArray();
        int len=vet.Length;
        if (span>len || span<0)
        {
            throw new ArgumentException();
        }
        if( span==0)
        {
            return 1;
        }
        
        for(int i=0; i<len;i++)
        {
            if(!char.IsDigit(vet[i]))
            {
               throw new ArgumentException();
            }
        }
        /*
        if (span==len)
        {
        
            for(int j=0;j<span;j++)
            {
                prodotto=prodotto* Convert.ToInt64( Char.GetNumericValue(vet[j]));
        //Char.GetNumericValue(Character)
        //Console.WriteLine (prodotto);
            }
           return prodotto;
        }
    
           */ 
        
        for(int i=0; i<=vet.Length-span;i++)
        {
            prodotto=1;
            for(int j=i;j<i+span;j++)
            {
                prodotto=prodotto* Convert.ToInt64(Char.GetNumericValue(vet[j]));
            }
            if(prodotto>temp)
            {
                temp=prodotto;
            }
        }
        return temp;  
    }

}