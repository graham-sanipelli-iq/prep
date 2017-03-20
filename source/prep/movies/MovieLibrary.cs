using System;
using System.Collections.Generic;
using code.utility;
using code.utility.matching;

namespace code.prep.movies
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;

    }

    public IEnumerable<Movie> all()
    {
      return movies.one_at_a_time();
    }

    public void add(Movie movie)
    {
      if (movies.Contains(movie)) return;

      movies.Add(movie);
    }


    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      foreach (var movie in movies)
      {
        if (movie.production_studio == ProductionStudio.Pixar)
        {
          yield return movie;
        }
      }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
        return movies.filter_using(Movie.published_by(ProductionStudio.Pixar).or(Movie.published_by(ProductionStudio.Disney)));
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
        return movies.filter_using(Movie.published_by(ProductionStudio.Pixar).not());
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
        return movies.filter_using(Movie.published_between(year, int.MaxValue));
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
        return movies.filter_using(Movie.published_between(startingYear, endingYear));
    }

    public IEnumerable<Movie> all_kid_movies()
    {
        return movies.filter_using(Movie.in_genre(Genre.kids));
    }

    public IEnumerable<Movie> all_action_movies()
    {
        return movies.filter_using(Movie.in_genre(Genre.action));
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
