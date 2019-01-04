namespace BrotShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly ApplicationDbContext _context;

        public FeedbackRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddFeedback(Feedback feedback)
        {
            //_context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }
    }
}
