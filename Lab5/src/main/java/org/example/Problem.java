package org.example;
import java.util.*;


public class Problem {
        private final int n;
        private int seed;

        private int upperBound;
        private int lowerBound;

        final List<Item> items;


        public Problem(int n, int seed, int upperBound, int lowerBound) {
                this.n = n;
                this.seed = seed;

                this.upperBound = upperBound;
                this.lowerBound = lowerBound;

                this.items = new ArrayList<>();

                Random random = new Random(seed);
                for (int i = 0; i < n; i++) {
                        int weight = random.nextInt(upperBound - lowerBound) + lowerBound;
                        int value = random.nextInt(upperBound - lowerBound) + lowerBound;
                        int id = i + 1;
                        items.add(new Item(id,weight, value));
                }
        }

        // do Testow
        public Problem(List<Item> items) {
                this.items = new ArrayList<>(items);
                this.n = items.size();
        }

        public Result Solve(int capacity) {
                Result r = new Result();

                items.sort((o1, o2) -> {
                        float r1 = (float) o1.value / o1.weight;
                        float r2 = (float) o2.value / o2.weight;
                        return Float.compare(r2, r1);
                });

                for (Item item : items) {
                        while (r.totalWeight + item.weight <= capacity) {
                                r.totalWeight += item.weight;
                                r.totalValue += item.value;
                                r.amount++;
                                r.items.add(item);
                        }
                }
                return r;
        }

        @Override
        public String toString() {
                StringBuilder sb = new StringBuilder();
                sb.append("Problem{\n")
                        .append("n=").append(n).append(",\n")
                        .append("seed=").append(seed).append(",\n")
                        .append("upperBound=").append(upperBound).append(",\n")
                        .append("lowerBound=").append(lowerBound).append(",\n")
                        .append("items=\n");
                for (Item item : items) {
                        sb.append(item).append("\n");
                }
                sb.append('}');
                return sb.toString();
        }
}
