using DesignPatterns.Observer;
using NUnit.Framework.Interfaces;

namespace DesignPatternsTests;

[TestFixture]
public class ObserverTest
{

    [Test]
    public void SubscribersChangeTheirState()
    {
        var socrates = new SocratesSubscriber();
        var dummy = new DummySubscriber();
        var publisher = new Publisher();
        publisher.Subscribe(socrates);
        publisher.Subscribe(dummy);
        
        publisher.Notify("There's an a letter");
        
        Assert.Multiple(() =>
        {
            Assert.That(socrates.State, Is.EqualTo("There's an a letter?"));
            Assert.That(dummy.State, Is.EqualTo("There's on o letter"));
        });
    }

    [Test]
    public void SubscribeAndUnsubscribe()
    {
        var socrates = new SocratesSubscriber();
        var superSocrates = new SocratesSubscriber();
        var publisher = new Publisher();
        publisher.Subscribe(socrates);
        publisher.Subscribe(superSocrates);
        
       publisher.Notify("I know that I know nothing"); 
       publisher.Unsubscribe(socrates);
       publisher.Notify("What's going on?");
        
       Assert.Multiple(() =>
       {
            Assert.That(socrates.State, Is.EqualTo("I know that I know nothing?"));
            Assert.That(superSocrates.State, Is.EqualTo("What's going on??"));
       }); 
    }

    [Test]
    public void NobodySubscribesToObserver()
    {
        var socrates = new SocratesSubscriber();
        var dummy = new DummySubscriber();
        var publisher = new Publisher();
        
        publisher.Notify("You won");
        
        Assert.Multiple(() =>
        {
            Assert.That(socrates.State, Is.EqualTo(""));
            Assert.That(dummy.State, Is.EqualTo(""));
        });
    }
    
}