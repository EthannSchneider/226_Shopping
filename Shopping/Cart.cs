namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public void Remove(List<Article>? articles = null)
        {
            if (articles == null)
            {
                _articles = new List<Article>();
            }
            else
            {
                foreach (var article in articles)
                {
                    _articles.Remove(article);
                }
            }
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }
        #endregion public methods
    }
}
