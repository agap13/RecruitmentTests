
using Diamond;

var character = Console.Read();
var letter = Convert.ToChar(character);

DiamondService diamond = new DiamondService(letter);
diamond.PrintDiamond();