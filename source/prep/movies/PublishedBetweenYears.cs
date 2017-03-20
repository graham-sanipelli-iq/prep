using code.utility.matching;

namespace code.prep.movies
{
  public class PublishedBetweenYears : IMatchA<Movie>
  {
        private int startYear;
        private int endYear;


    public PublishedBetweenYears(int startYear, int endYear)
    {
            this.startYear = startYear;
            this.endYear = endYear;
    }

    public bool matches(Movie movie)
    {
      return movie.date_published.Year >= startYear && movie.date_published.Year <= endYear;
    }     
  }
}