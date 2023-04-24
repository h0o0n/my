package ch13.example2;

public class Container<K,V> {
	
	private K key;
	private V value;
	
	
	public K getKey() {
		return key;
	}
	
	public V getValue() {
		return value;
	}
	
	public void setKey(K key) {
		this.key = key;
	}
	
	public void setValue(V value) {
		this.value = value;
	}
	
	public void set(K key,V value) {
		this.setKey(key);
		this.setValue(value);
	}
}
