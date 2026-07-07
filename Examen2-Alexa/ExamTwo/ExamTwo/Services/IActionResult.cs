namespace ExamTwo.Services
{
    public class IActionResults
    {  
        public EmptyOrder<string> BuyCoffee(OrderRequest request) {  } 
        public NotEnoughMoney<string> BuyCoffee( OrderRequest request) {  } 
        public MachineWithoutMoney<string> BuyCoffee(OrderRequest request) {  } 
        public MachineWithoutCoffe<string> BuyCoffee( OrderRequest request) {  } 
        public Exchange<string> BuyCoffee(OrderRequest request) {  }  
    } 
 }