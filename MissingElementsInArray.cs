//Find missing elements from a2 in a1

void Main()
{
	int[] a1 = {1,2,3,4,5,6};
	int[] a2 = {1,8,3,7,5,6};
	int hi = a1.Length;
	int lo = 0;
	
while(lo <hi){
int mid = (lo+hi)/2;
if(a1[mid]==a2[mid])
lo=mid;
else
hi = mid;
Console.WriteLine(a2[hi]);
if(lo==hi-1)
break;

}

}

// You can define other methods, fields, classes and namespaces here
