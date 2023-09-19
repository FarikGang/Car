``public class Cars {
    int model;
    int price;
    int color;

    public Cars( string model, int price, string color) {
        this.model = model;
        this.price = price;
        this.color = color;
    }

    public int firstModel() {
        return model;
    }
    public int firstPrice() {
        return price;
    }
    public int firstColor() {
        return color;
    }
}


public class Car {
    public static void Main() {
        Cars firstHero = new Cars(BMW, 20000, black);
        Console.WriteLine("Марка" + firstModel() +"Цена" + firstPrice() + "Цвет" + firstColor());
    }

}
