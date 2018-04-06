
DIgitPredicate predicated = new DIgitPredicate(7);
Predicate<int> predicate = predicate.IsMatch;
predicate = IsEven;//predicate = null;
predicate.Invoke(237).Dump();  //predicate?.Invoke(237).Dump(); элвис - крутая штука, с ним налреференсэксепшн не упадет

public static bool IsEven(int item) => item%2==0;

public delegate bool Predicate<T>(T item);

return sourse.Filter(predicate.IsMatch);






!!!!!!!!!!!yield
//если есть yeild, метод возвращ 4 интерфейса, метод превращает в класс, который реализует интерфейс(заданный)

пусть
public static IEnumerator<int> GetNumbers()
{

    //...............
    yield return 7;
    //................
    yield return 32
}

IEnumeratot<int> iterator = GetNumbers();// создается обьект класса, созданный комплятором