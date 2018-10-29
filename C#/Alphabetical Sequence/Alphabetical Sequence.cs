import java.util.Arrays;
public class Solution {
  public static String alphaSeq(String s) {
      char[] chars = s.toLowerCase().toCharArray();
      Arrays.sort(chars);
      String output = "";
      int l = chars.length;
      for(int i = 0; i < l; i++){
        output += strBuild(chars[i]) + ",";
        if(i == l-2){
          output += strBuild(chars[i+1]);
          break;
        }
      }
      return output;
  }
  public static String strBuild(char c){
    char[] alphabet = "abcdefghijklmnopqrstuvwxyz".toCharArray();
    String repeated = "";
      for(int n = 0; n < alphabet.length; n++){
          if(alphabet[n] == c){
            repeated += Character.toUpperCase(c);
            for(int i = 0; i < n; i++)repeated += c;
            break;
          }
      }
    return repeated;
  }
}