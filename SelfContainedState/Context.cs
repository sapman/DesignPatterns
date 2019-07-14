namespace SelfContainedState
{
    public class Context
    {
        private ILoginState curState;

        public Context()
        {
            setState(new NewLogin(this));
        }

        public void setState(ILoginState newState)
        {
            curState = newState;
        }

        public void Login(string password)
        {
            curState.Login(this, password);
        }

        public void Restart()
        {
            curState.Restart(this);
        }
    }
}