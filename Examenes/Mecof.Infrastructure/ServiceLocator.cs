using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace Mecof.Infrastructure
{
    /// <summary>
    /// Service locator design pattern implementation
    /// </summary>
    public class ServiceLocator
    {
        private static ServiceLocator instance;
        public static ServiceLocator Instance 
        {
            get
            {
                instance = instance ?? new ServiceLocator();
                return instance;
            }
        }
        private ServiceLocator()
        { 
            this.registeredObjects = new Dictionary<Type, Object>();
            this.registeredTypes = new Dictionary<Type, Type>();
            this.objectsRegisteredByName = new Dictionary<string, Object>();
        }

        //stores instances, so types registered here will work as singletons
        private Dictionary<Type, Object> registeredObjects;

//        /// <summary>
//        /// used as a helper method when attacching a debugger
//        /// </summary>
//        /// <returns></returns>
//        public Dictionary<Type, Object> GetRegisteredObjects()
//        {
//            return this.registeredObjects;
//        }

        //stores Types, a new instance of this Type will be returned when an Object get requested
        private Dictionary<Type, Type> registeredTypes;

        private Dictionary<string, Object> objectsRegisteredByName;
        
        /// <summary>
        /// Registers an instance of type T
        /// so it's like doing that class a Singleton
        /// </summary>
        /// <typeparam name="T">Type of instance</typeparam>
        /// <param name="instance">Instance to register</param>
        public void RegisterObject<T>(T instance)
        {
            this.registeredObjects[typeof (T)] = instance;
        }

        /// <summary>
        /// Register a type T2 as type T1
        /// </summary>
        /// <typeparam name="T1">Key type</typeparam>
        /// <typeparam name="T2">Type to register</typeparam>
        public void RegisterType<T1, T2>()
        {
            this.registeredTypes[typeof(T1)] = typeof(T2);
        }

        /// <summary>
        /// Registers an instance of type T
        /// so it's like doing that class a Singleton
        /// </summary>
        /// <typeparam name="T">Type of instance</typeparam>
        /// <param name="instance">Instance to register</param>
        public void RegisterObjectByName(string name, Object instance)
        {
            this.objectsRegisteredByName[name] = instance;
        }

        /// <summary>
        /// Returns an instace of type T if exists or creates a new one
        /// </summary>
        /// <typeparam name="T">Type of the instance</typeparam>
        /// <returns>An instance of type T</returns>
        public T GetInstance<T>()
        {
            try
            {
                if (this.registeredObjects.ContainsKey(typeof(T)))
                {
                    return (T)(this.registeredObjects[typeof(T)]);
                }
                else
                {
                    Type t2 = this.registeredTypes[typeof(T)];
                    return (T)(Activator.CreateInstance(t2));
                }
            }
            catch(Exception)
            {
            	//this.LogManager.GetLogger("ServiceLocator").Error("ServiceLocator could not resolve type: " + typeof(T).FullName);
                return default(T);
            }
        }

        /// <summary>
        /// Returns an instance by name
        /// </summary>
        public T GetInstance<T>(string name)
        {
            try
            {
                return (T)this.objectsRegisteredByName[name];
            }
            catch (Exception)
            {
                //this.LogManager.GetLogger("ServiceLocator").Error("ServiceLocator could not resolve object by Name: " + name);
                return default(T);
            }
        }

        // Idea discarded:
        /// <summary>
        /// users of this method are aware that there will be an only instance of T in the whole system
        /// so using GetUniqueInstance rather than GetInstance is a way to express this "singleton like" condition
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //public T GetUniqueInstance<T>()
        //{
        //    if (this.registeredObjects.ContainsKey(typeof(T)))
        //    {
        //        return (T)(this.registeredObjects[typeof(T)]);
        //    }
        //    else
        //    {        //       
        //        throw new Exception();
        //    }
        //}

        
       
    }
}
