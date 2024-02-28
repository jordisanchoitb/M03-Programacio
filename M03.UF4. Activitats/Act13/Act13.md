- 13. Tenint en compte la següent classe:
```
public class Cat: Animal, Pet 
{
   public Cat(float weight, string name): base(weight, name) 
	{
        	this. Weight weight;
		this.Name = name;
	}
   public double Move(int step) 
	{
		return step * 2;
	}
}
```
- Per què dóna error en instanciar el gat "michi"?
```
public static void Main()
{
	Cat michi = new Cat();
}
```

Dona error ja que no esta instancian la clase amb el seu constructor prefinit i aixo fa que es borri el contructor per defecta i per poder fer una instancia en aquesta classe haura de passar el weight i el nom del gat per poder fer la instancia
