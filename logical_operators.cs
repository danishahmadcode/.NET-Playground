namespace logical{
    public class LogicalOperations{
        public bool andOperator(bool cond1, bool cond2){
            return cond1 && cond2;
        }
        public bool orOperator(bool cond1, bool cond2){
            return cond1 || cond2;
        }
        public bool notOperator(bool cond){
            return !cond;
        }
    }
}