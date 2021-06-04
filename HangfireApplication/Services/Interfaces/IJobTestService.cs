namespace HangfireApplication.Services.Interfaces
{
	public interface IJobTestService
	{
		void FireAndForgetJob();

		void ReccuringJob();

		void DelayedJob();

		void ContinuationJob();

	}
}
