using AbstractFactoryPattern;

ITransactionFactory CardtransactionFactory = new CardTransactionFactory();
ITransactionFactory CashtransactionFactory = new CashTransactionFactory();

var Sellingbill = CardtransactionFactory.CreateBill();
var CardPaymentMethod = CardtransactionFactory.CreatePaymentMethod();

var Purchasebill = CashtransactionFactory.CreateBill();
var PaymentMethod = CashtransactionFactory.CreatePaymentMethod();