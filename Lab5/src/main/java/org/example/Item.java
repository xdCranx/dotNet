package org.example;

public class Item {
    final int weight;
    final int value;
    final int id;

    public Item(int id, int weight, int value) {
        this.id = id;
        this.weight = weight;
        this.value = value;
    }

    @Override
    public String toString() {
        return id+ "| Item | " +
                "weight: " + weight +
                " | value: " + value;
    }
}
