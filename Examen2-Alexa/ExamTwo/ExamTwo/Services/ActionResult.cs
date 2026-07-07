using ExamTwo.Services.IActionResults;

namespace ExamTwo.Services
{
    public class ActionResults : IActionResults
    {  
        public EmptyOrder<string> BuyCoffee([FromBody] OrderRequest request)
        {
            if (request.Order == null || request.Order.Count == 0)
                return BadRequest("Ordem vacia.");
        } 
        public NotEnoughMoney<string> BuyCoffee([FromBody] OrderRequest request)
        {
            var costoTotal = request.Order.Sum(o => _db.keyValues2.First(c => c.Key == o.Key).Value * o.Value);

                if (request.Payment.TotalAmount < costoTotal)
                { 
                    return BadRequest("Dinero insuficiente ");
                }
        } 
        public MachineWithoutMoney<string> BuyCoffee([FromBody] OrderRequest request)
        {
           if (change > 0)
                {
                    return StatusCode(500, "No hay suficiente cambio en la máquina.");
                }

                return Ok(result);
        }
        public MachineWithoutCoffe<string> BuyCoffee([FromBody] OrderRequest request)
        { 
            {
                foreach (var cafe in request.Order)
                {
                    var selected = _db.keyValues.First(c => c.Key == cafe.Key).Key;
                    if (cafe.Value > _db.keyValues[selected])
                    {
                        return $"No hay suficientes {selected} en la máquina.";
                    }
                    _db.keyValues[selected] -= cafe.Value;
                }
            }
        } 
        public Exchange<string> BuyCoffee([FromBody] OrderRequest request)
        {
            foreach (var coin in _db.keyValues3.Keys.OrderByDescending(c => c))
            {
                var count = Math.Min(change / coin, _db.keyValues3[coin]);
                if (count > 0)
                {
                    result +=  $" {count} moneda de {coin},  ";              
                    change -= coin * count;
                }
            }    
        }
    } 
 }


  

