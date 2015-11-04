﻿namespace Disruptor
{
    /// <summary>
    /// Implementations translate another data representations into events claimed from the {@link RingBuffer}
    /// </summary>
    public interface IEventTranslatorOneArg<T, A>
    {
        /// <summary>
        /// Translate a data representation into fields set in given event
        /// </summary>
        /// <param name="event">into which the data should be translated.</param>
        /// <param name="sequence"> that is assigned to event.</param>
        /// <param name="arg0">The first user specified argument to the translator</param>
        void TranslateTo(T @event, long sequence, A arg0);
    }
}