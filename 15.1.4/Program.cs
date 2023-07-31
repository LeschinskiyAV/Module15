string word = "word";
string word1 = "alfkdjd;lqerqoierwrjf;aslffasdf";
var smth = word.Intersect(word1);
foreach (var word2 in smth)
    Console.WriteLine(word2);
