public class Kata {

  public static String pak(final String s) {
    String[] arr = s.split(" ");
    String recon = "";
    if(arr.length <= 1) return recon;
    else{
      int limit = arr.length-1;
      for(int i = 0; i < limit; i++){
        recon += arr[i] + " pak ";
      }
      recon += arr[limit];
      return recon.trim();
    }
  }
  
}