string[] mass = {"hello", "2", "world", ":-)"};

List<string> CreateNewMass(string[] mass){
    List<string> mass2 = new List<string>();

    for(int i=0; i<mass.Length; i++){
        if(mass[i].Length<=3){
            mass2.Add(mass[i]);
        }
    }
    return mass2;
}

void ShowArray(string[] mass){
    List<string> mass2 = CreateNewMass(mass);
    string[] NewArr = mass2.ToArray();

    for(int i=0; i<NewArr.Length; i++){
        Console.Write(NewArr[i] + " ");
    }
}

ShowArray(mass);