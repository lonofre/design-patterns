
using DesignPatterns.ChainOfResponsibility;

namespace DesignPatternsTests;

public class ChainOfResponsibilityTest
{
    [TestCase("Hello! This is a test!", 
        "fbc78a3d4f6abeceb2b7bae6a0017a2b4f74de9b8f8183ab5a83197e9f9f6a91", 
        true)]
    [TestCase("This is a test!", 
        "54ba1fdce5a89e0d3eee6e4c587497833bc38c3586ff02057dd6451fd2d6b640", 
        false)]
    [TestCase("Hello, this hash is fishy", 
        "54ba1fdce5a89a0d3eee6e5c587497832bc38c3586ff02057dd6451fd2d6b640", 
        false)]
    [TestCase("Hello, this should be a larger message than the other ones", 
        "951376a686c4dfc5ad13bdae1397e970f27d6d63fe4f15fcb808bfc8bfce21bd", 
        false)]
    public void CompleteWorkflow(string content, string hash, bool expectedResult)
    {
        var handler1 = new IntegrityChecker();
        var handler2 = new GreetingChecker();
        var handler3 = new LengthChecker(40);
        handler1.SetHandler(handler2);
        handler2.SetHandler(handler3);
        var message = new Message(content, hash);
        
        var isValid = handler1.Handle(message);
        
        Assert.That(isValid, Is.EqualTo(expectedResult)); 
    }
    
     [TestCase("Hello, this should be a larger message than the other ones", 
         "4fe34985bb08aedfdc317483fa9a55cd9386f4b89740e9d4ac10218dd8e66516", 
         false)]   
     [TestCase("This is a test!", 
             "54ba1fdce5a89e0d3eee6e4c587497833bc38c3586ff02057dd6451fd2d6b640", 
             true)]
    public void DifferentWorkflow(string content, string hash, bool expectedResult)
     {
         // We actually can change the order of the handlers
         // and choose to not use one!
         var handler1 = new LengthChecker(40);
         var handler2 = new IntegrityChecker();
         handler1.SetHandler(handler2);
         var message = new Message(content, hash);
         
         var isValid = handler1.Handle(message);
         
         Assert.That(isValid, Is.EqualTo(expectedResult)); 
     }   
    
}