using System;
using System.Collections.Generic;

namespace Enterprise.OA.Framework.Injecting
{
    /// <summary>
    /// The generic Container Facade interface. This interface is used
    /// to retrieve services (instances identified by type and optional
    /// name) from a container.
    /// </summary>
    public interface IContainerFacade : IServiceProvider, IDisposable
    {

        /// <summary>
        /// Get an instance of the given <paramref name="serviceType"/>.
        /// </summary>
        /// <param name="serviceType">Type of object requested.</param>
        /// <exception cref="ActivationException">if there is an error resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        object Resolve(Type serviceType);

        /// <summary>
        /// Get an instance of the given named <paramref name="serviceType"/>.
        /// </summary>
        /// <param name="serviceType">Type of object requested.</param>
        /// <param name="key">Name the object was registered with.</param>
        /// <exception cref="ActivationException">if there is an error resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        object Resolve(Type serviceType, string key);

        /// <summary>
        /// Get all instances of the given <typeparamref name="TService"/> currently
        /// registered in the container.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>A sequence of instances of the requested <typeparamref name="TService"/>.</returns>
        IEnumerable<TService> ResolveAll<TService>();

        /// <summary>
        /// Get all instances of the given <paramref name="serviceType"/> currently
        /// registered in the container.
        /// </summary>
        /// <param name="serviceType">Type of object requested.</param>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>A sequence of instances of the requested <paramref name="serviceType"/>.</returns>
        IEnumerable<object> ResolveAll(Type serviceType);

        /// <summary>
        /// Get an instance of the given <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        TService Resolve<TService>();

        /// <summary>
        /// Get an instance of the given named <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <param name="key">Name the object was registered with.</param>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        TService Resolve<TService>(string key);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        bool TryResolve(Type serviceType, out object instance);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        bool TryResolve(Type serviceType, string key, out object instance);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="key"></param>
        /// <param name="instances"></param>
        /// <returns></returns>
        bool TryResolveAll(Type serviceType, out IEnumerable<object> instances);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="instance"></param>
        /// <returns></returns>
        bool TryResolve<TService>(out TService instance);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        bool TryResolve<TService>(string key, out TService instance);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="instances"></param>
        /// <returns></returns>
        bool TryResolveAll<TService>(out IEnumerable<TService> instances);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        void Release(object instance);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IContainerFacade CreateChild();
    }
}
