package ch13.example;

public class Container<T>{
	
	private T container;
	
	public T get() {
		return container;
	}

	public void set(T container) {
		this.container = container;
	}

}
