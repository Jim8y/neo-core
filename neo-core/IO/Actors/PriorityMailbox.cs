using Akka.Actor;
using Akka.Configuration;
using Akka.Dispatch;
using Akka.Dispatch.MessageQueues;
using System.Collections;

namespace Neo.IO.Actors
{
    public abstract class PriorityMailbox : MailboxType, IProducesMessageQueue<PriorityMessageQueue>
    {
        public PriorityMailbox(Akka.Actor.Settings settings, Config config)
            : base(settings, config)
        {
        }

        public override IMessageQueue Create(IActorRef owner, ActorSystem system)
        {
            return new PriorityMessageQueue(ShallDrop, IsHighPriority);
        }

        public virtual bool IsHighPriority(object message) => false;
        public virtual bool ShallDrop(object message, IEnumerable queue) => false;
    }
}
