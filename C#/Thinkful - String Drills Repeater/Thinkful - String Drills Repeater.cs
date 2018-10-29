public class Repeater{
  public static String repeat(String string,long n){
    String repeated = "";
    for(int i = 0; i < n; i++){
      repeated += string; 
    }
    return repeated;
  }
}