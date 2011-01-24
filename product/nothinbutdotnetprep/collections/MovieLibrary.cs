using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    using System.Linq;

    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return movies;
        }

        public void add(Movie movie)
        {
            movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
           var listOfMovies = new List<Movie>(movies);
            listOfMovies.Sort((movie1, movie2) => movie2.title.CompareTo(movie1.title));
            return listOfMovies;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {

            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.production_studio.Equals(ProductionStudio.Pixar)).ToList();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.production_studio.Equals(ProductionStudio.Pixar) || m.production_studio.Equals(ProductionStudio.Disney)).ToList();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
             //var listOfMovies = new List<Movie>(movies);
            //listOfMovies.Sort((movie1, movie2) => movie1.title.CompareTo(movie2.title));
            //return listOfMovies;
            throw new NotImplementedException();

        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            var listOfMovies = new List<Movie>(movies);
            listOfMovies.Sort(new MovieStudioYearComparator());
            return listOfMovies;
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => !m.production_studio.Equals(ProductionStudio.Pixar)).ToList();
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.date_published.Year > year).ToList();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.date_published.Year>= startingYear && m.date_published.Year <= endingYear).ToList();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.genre.Equals(Genre.kids)).ToList();
        }

        public IEnumerable<Movie> all_action_movies()
        {
            var listofmovies = new List<Movie>(movies);
            return listofmovies.Where(m => m.genre.Equals(Genre.action)).ToList();
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

    public class MovieStudioYearComparator : IComparer<Movie>
    {

        public int Compare(Movie movie1, Movie movie2)
        {
            if (movie1.production_studio.Name.CompareTo(movie2.production_studio.Name) == 0)
            {
                return (movie1.title.CompareTo(movie2.title));
            }
            return movie1.production_studio.Name.CompareTo(movie2.production_studio.Name);
        }
    }

}