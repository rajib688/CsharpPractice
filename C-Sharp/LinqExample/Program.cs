


int[] ages = new int[] { 5, 9, 3, 34, 23, 40 };

int[] v = (from age in ages where age < 10 select age).ToArray();

int[] v2 = ages.Where(x => x < 10).ToArray();


/* 
Sqlexample
select from ages where ages<10 

 */