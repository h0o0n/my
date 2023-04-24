package ch18.sec10;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Arrays;

public class ObjectInputOutputStreamExample {

	public static void main(String[] args) throws IOException, ClassNotFoundException {
		//FileOutputStream에 ObjectOutputStream 보조 스트림 연결
		FileOutputStream fos = new FileOutputStream("C:/Temp/object.dat");
		ObjectOutputStream oos = new ObjectOutputStream(fos);
		
		//객체 생성
		Member m1 = new Member("fall", "단풍");
		Product p1 = new Product("노트북", 100000);
		int[] arr1 = {1, 2, 3};
		
		oos.writeObject(m1);
		oos.writeObject(p1);
		oos.writeObject(arr1);
		
		oos.flush(); oos.close(); fos.close();
		
		
		//ObjectInputStrema 보조 스트림 연결
		FileInputStream fis = new FileInputStream("C:/Temp/object.dat");
		ObjectInputStream ois = new ObjectInputStream(fis);
		
		Member m2 = (Member) ois.readObject();
		Product p2 = (Product) ois.readObject();
		int[] arr2 = (int[]) ois.readObject();
		
		ois.close(); fis.close();
		
		System.out.println(m2);
		System.out.println(p2);
		System.out.println(Arrays.toString(arr2));
		
	}

}
