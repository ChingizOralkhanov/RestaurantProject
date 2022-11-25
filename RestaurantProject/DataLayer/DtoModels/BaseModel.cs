namespace RestaurantProject.DataLayer.DtoModels
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public virtual void DeleteRecord()
        {
            IsDeleted = true;
        }
    }
}
