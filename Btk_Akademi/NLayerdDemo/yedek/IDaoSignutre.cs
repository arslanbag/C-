using System;

public class IDaoSignutre
{
	public interface DaoSignutre()
	{
        List<T> GetAll();
        T Get(T Entity);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
