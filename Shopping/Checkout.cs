namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
            UpdateBalance();
        }

        public List<Article> Remove(Boolean empty = false)
        {
            throw new NotImplementedException();
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                for (int i = 0; i < _articles.Count; i++)
                {
                    _balance += _articles[i].Price;
                }
            }
        }
        #endregion private methods
    }
}
