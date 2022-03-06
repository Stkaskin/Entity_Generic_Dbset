 class CRUD
    {
        Context db = new Context();//yourContext
        public void Add<T>(T types)
        {
            db.Entry(types).State = EntityState.Added;
            db.SaveChanges();
        }
        public void Remove<T>(T types)
        {
            db.Entry(types).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public void Update(object types)
        {
            db.Entry(types).State = EntityState.Modified;
            db.SaveChanges();
        }
        public DbSet<T> GetClass<T>(T types) where T : class => db.Set<T>();
    

    }