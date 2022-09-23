namespace BongDen{
    public class App{
        // Cho một dãy bao gồm N bóng đèn với 1 nút bấm
        // Đèn có 2 trạng thái sáng/tắt
        /*
        Quy tắc như sau với mỗi lần bấm nút
        - Đèn thứ nhất sẽ chuyển trạng thái, Tức là đang sáng, thì tắt và ngược lại
        - Đèn thứ M + 1 (với N > M > 0) sẽ chuyển trạng thái đèn thứ M bị chuyển từ sáng sang tắt
        */

        /*
        Yêu cầu:
        Cho số đèn và số lần bấm nút, hãy biểu diễn trạng thái của các đèn
        1 = sáng,
        0 = tắt
        */

        // numberOfBulbs: số bóng đèn
        // numberOfClicks: số lần bấm bóng đèn
        public static List<int> X(int numberOfBulbs, int numberOfClicks){

            List<int> result = new List<int>(new int[numberOfBulbs]);

            for(int i = 0; i < numberOfClicks; i++){
                result[0] = result[0] == 0 ? 1 : 0;

                for(int j = 0; j < numberOfBulbs - 1; j++){
                    if(result[j] == 0){
                        result[j + 1] = result[j + 1] == 0 ? 1 : 0;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            return result;
        }
        public static List<int> Y(int numberOfBulbs, int numberOfClicks){
            List<int> result = new List<int>(new int[numberOfBulbs]);

            for(int i = 0; i < numberOfBulbs; i++){
                result[i] = numberOfClicks % 2;
                numberOfClicks = numberOfClicks / 2;
            }

            return result;
        }
        public static void Main(string[] args)
        {
            List<int> result = Y(3, 6);
            for(int i = 0; i < result.Count; i++){
                Console.WriteLine(result[i]); 
            }
            
        }
    }
}
