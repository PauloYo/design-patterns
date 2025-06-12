namespace StructuralPatterns.Facade
{
    // Facade
    public class HomeTheaterFacade
    {
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly Lights _lights;
        private readonly SoundSystem _soundSystem;

        public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, 
                                Lights lights, SoundSystem soundSystem)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _lights = lights;
            _soundSystem = soundSystem;
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine("Getting ready to play movie...");
            _lights.Dim(10);
            _projector.On();
            _projector.SetInput("DVD");
            _soundSystem.On();
            _soundSystem.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down home theater...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
            _lights.On();
        }
    }
}