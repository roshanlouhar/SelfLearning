import java.lang.System;

class HelloWorld {
    // Your program begins with a call to main().
    // Prints "Hello, World" to the terminal window.
    public static void main(String args[]) {
        // int[] array = new int[10];
        // for (int i =0; i< 10 ; i++)
        // {
        // array[i]=i;
        // }

        // for(int n :array )
        // {
        // System.out.println(n);
        // }
        ThreadSafeSingleton obj = ThreadSafeSingleton.getInstance();
        obj.TestMethod();

    }
}

class ThreadSafeSingleton {
    // initialize the instance as null.
    private static ThreadSafeSingleton instance = null;

    // private constructor, so it cannot be instantiated outside this class.
    private ThreadSafeSingleton() {
    }

    // check if the instance is null, within a synchronized block. If so, create the
    // object
    public static ThreadSafeSingleton getInstance() {
        synchronized (ThreadSafeSingleton.class) {
            if (instance == null) {
                instance = new ThreadSafeSingleton();
            }
        }
        return instance;
    }

    public int TestMethod() 
    {
        System.out.println("from the function");
        return 10;
    }
}
