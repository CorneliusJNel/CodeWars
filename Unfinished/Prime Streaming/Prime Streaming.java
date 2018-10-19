import java.util.stream.IntStream;
import java.util.*;

public class Primes {
  public static IntStream stream() {
    List<Integer> primes = new ArrayList<>();
    int max = 982451654;
    boolean posPrime = true;
    for (int i = 2; i <= max; i++){
      for (int j = 2; j <= i / 2; j++)
      {
          if (i % j == 0)
          {
              posPrime = false;
              break;
          }
      }
      if (posPrime)
      {
          primes.add(i);
      }
      if(primes.size() == 20000){
        break;
      }
      posPrime = true;
    }
    return primes.stream().mapToInt(Integer::intValue);
  }
}
