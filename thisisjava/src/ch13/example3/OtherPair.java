package ch13.example3;

public class OtherPair<K, V> {
	private K key;
	private V value;
	

	public OtherPair(K key, V value) {
		this.key = key;
		this.value = value;
	}
	
	public K getKey() {
		return key;
	}
	 
	public V getvalue() {
		return value;
	}
}
