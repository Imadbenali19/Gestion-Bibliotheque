using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.IDoa
{
    
	interface Idoa<T>
    {
		public bool create(T o);

		public bool update(T o);

		public bool delete(T o);

		public T findById(int id);

		public List<T> findAll();
	}
}
