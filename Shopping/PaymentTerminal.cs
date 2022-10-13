namespace Shopping
{
    public class PaymentTerminal
    {
        #region private attributes
        private Checkout _checkout = new Checkout();
        private CreditCard _creditCard = null;
        #endregion private attributes

        #region public methods
        public PaymentTerminal(Checkout checkout)
        {
            _checkout = checkout;
        }

        public CreditCard CreditCard { 
            get
            {
                return _creditCard;
            }
        }

        public void Cash(float balance)
        {
            _checkout.Balance = 0f;
        }

        public void InsertCard(CreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        public void RemoveCard()
        {
            _creditCard = null;
        }
        #endregion public methods
    }
}
