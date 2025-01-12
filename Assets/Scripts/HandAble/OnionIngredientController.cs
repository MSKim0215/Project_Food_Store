namespace MSKim.HandAble
{
    public class OnionIngredientController : IngredientController
    {
        public override float CurrentCookTime
        {
            get => currentCookTime;
            set
            {
                currentCookTime = value;

                if (currentCookTime >= maximumCookTime)
                {
                    ChangeCookStateObject(Utils.CookState.OverCook);
                }
                else if (currentCookTime > 0 && currentCookTime < maximumCookTime)
                {
                    ChangeCookStateObject(Utils.CookState.Cook);
                }
                else
                {
                    ChangeCookStateObject(Utils.CookState.UnCook);
                }
            }
        }

        protected override void InitializeCookState()
        {
            maximumCookTime = Utils.CUTTING_ONION_COOK_TIME;

            base.InitializeCookState();
        }
    }
}