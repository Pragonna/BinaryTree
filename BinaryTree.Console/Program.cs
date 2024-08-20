

using BinaryTree.Console.Helpers;

ICustomBinaryTree binary = new CustomBinaryTree(8);


var node1=binary.Add( 2);
var node2=binary.Add( 6);
binary.Add( 4);
binary.Add( 23);
binary.Add( 12);
binary.Add( 21);
binary.Add( 112);
binary.Add( 45);

// var foundedNode = binary.FindOrDefault(node2.Right.Id);
// binary.Remove(node2.Right.Id);
// var foundRemovedNode = binary.FindOrDefault(node2.Right.Id); // will throw null reference exception

BinaryHelper.ConsolePrint(binary);
// TextDataManager.SaveToTextFile(binary);

Console.WriteLine();

