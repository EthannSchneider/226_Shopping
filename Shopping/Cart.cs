using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(List<Article>? articles = null)
        {
            List<Article> tempArticle = new List<Article>();
            tempArticle.AddRange(_articles);
            if (articles == null)
            {
                _articles.Clear();
            }
            else
            {
                foreach (var article in articles)
                {
                    _articles.Remove(article);
                }
            }
            return tempArticle;
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
