# Unit test practice
*Arturo Zamora Hernández* 

The following repository is the solution to the **Unit test practice**.

## The Hash function
The following code was used to generate the Hash, notice that we're using a 64 bit Integer.

```
Int64 h = 0;
String letters = "";
Int64 i = 0;
Int64 index = 0;
Int64 inc = 0;
h = 7;
letters = "acdegilmnoprstuw";

for (int x = 0; x < str.Length; x++)
{
    inc = h * 37;
    index = letters.IndexOf(str[x]);
    h = inc + index;
}

return h;
```

## The unit test method
We first declare a **Int64** as the result and a **String** for the text. Then we use the method *Assert.AreEqual*. The first parameter is the expected result, and the second one, the result to be tested.

```
Int64 result = 680131659347;
String text = "leepadg";

Assert.AreEqual(result, Program.Hash(text));
```

if everything is fine, then you should see that the test passed. 
