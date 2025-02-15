public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; 
        }
        else if (b == 0) {
            return a; 
        }
        else {
            return MyMethod(a - 1, b - 1) + a + b; // Stack Overflow Error if a and b are large
        }
    }
}