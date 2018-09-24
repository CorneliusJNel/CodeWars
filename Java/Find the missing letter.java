public class Kata
{
  public static char findMissingLetter(char[] array)
  {
    String alpha = "abcdefghijklmnopqrstuvwxyz";
    String alphaCap = alpha.toUpperCase();
    char letter = ' ';
    
    if(Character.isUpperCase(array[0])){
      int aCStart = alphaCap.indexOf(array[0]);
      for (int i = 0; i<= array.length;i++){
        if(alphaCap.charAt(aCStart + i) != array[i]){
          letter = alphaCap.charAt(aCStart + i);
          break;
        }
      }
    }
    else{
      int aStart = alpha.indexOf(array[0]);
      for (int i = 0; i<= array.length;i++){
        if(alpha.charAt(aStart + i) != array[i]){
          letter = alpha.charAt(aStart + i);
          break;
        }
      }
    }
    return letter;
  }
}