namespace WindowsFormsApp1.Script
{
    public class ConsoleData
    {
        public int index{private set; get;} = 0;
        public string time{private set; get;} = "";
        public string location{private set; get;}= "";
        public string state{private set; get;}= "";
        public string action{private set; get;}= "";
        public string exception{private set; get;}= "";
        public string information{private set; get;}= "";

        public ConsoleData(string time, string location, string state, string action, string exception,
            string information)
        {
            this.time = time;
            this.location = location;
            this.state = state;
            this.action = action;
            this.exception = exception;
            this.information = information;
        }

        public ConsoleData()
        {
            
        }

        public ConsoleData IndexBuilder(int index)
        {
            this.index = index;
            return this;
        }

        public ConsoleData InformationBuilder(string information)
        {
            this.information = information;
            return this;
        }

        public ConsoleData ExceptionBuilder(string exception)
        {
            this.exception = exception;
            return this;
        }

        public ConsoleData ActionBuilder(string action)
        {
            this.action = action;
            return this;
        }

        public ConsoleData StateBuilder(string state)
        {
            this.state = state;
            return this;
        }

        public ConsoleData LocationBuilder(string location)
        {
            this.location = location;
            return this;
        }

        public ConsoleData TimeBuilder(string time)
        {
            this.time = time;
            return this;
        }

    }
}