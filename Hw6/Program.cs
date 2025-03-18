using Hw6;

// Task 1
MethodCreatedForStagePlayDestructorToWork();
GC.Collect();
GC.WaitForPendingFinalizers();

var stagePlay2 = new StagePlay("Hamlet", "William Shakespeare", "Tragedy", 1600);
stagePlay2.DisplayInfo();
stagePlay2.Dispose();

{
    using var stagePlay3 = new StagePlay("The Importance of Being Earnest", "Oscar Wilde", "Comedy", 1895);
    stagePlay3.DisplayInfo();
}

// Task 2
MethodCreatedForShopDestructorToWork();
GC.Collect();
GC.WaitForPendingFinalizers();

var shop2 = new Shop("Bookstore", "123 Main St", "Retail");
shop2.DisplayInfo();
shop2.Dispose();

using var shop3 = new Shop("Grocery Store", "456 Elm St", "Grocery");
shop3.DisplayInfo();

void MethodCreatedForStagePlayDestructorToWork()
{
    var stagePlay1 = new StagePlay("The Phantom of the Opera", "Andrew Lloyd Webber", "Musical", 1986);
    stagePlay1.DisplayInfo();
}

void MethodCreatedForShopDestructorToWork()
{
    var shop1 = new Shop("Hardware Store", "789 Oak St", "Hardware");
    shop1.DisplayInfo();
}