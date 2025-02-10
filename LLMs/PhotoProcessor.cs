namespace LLMs
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFIlterHandler(Photo photo);

        public void Process(string path, Action<Photo> photoFIlterHandler)
        {
            var photo = Photo.Load(path);

            photoFIlterHandler(photo);

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            //photo
        }
    }
}
