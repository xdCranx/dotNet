package org.example;

import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {

    @Test
    void oneReturnsOneTest () {
        Item validItem = new Item(1, 1, 1);
        Item nonValidItem = new Item(2, 15, 1);

        Problem problem = new Problem(List.of(validItem, nonValidItem));

        Result result = problem.Solve(10);

        assertEquals(10, result.amount);
        assertEquals(10, result.totalValue);
        assertEquals(10, result.totalWeight);

    }

    @Test
    void noneReturnZeroTest () {
        Item nonValidItem1 = new Item(1, 15, 1);
        Item nonValidItem2 = new Item(2, 23, 15);
        Problem problem = new Problem(List.of(nonValidItem1, nonValidItem2));
        Result result = problem.Solve(1);

        assertEquals(0, result.amount);
        assertEquals(0, result.totalValue);
        assertEquals(0, result.totalWeight);
        assertNotSame(result.items, List.of(nonValidItem1, nonValidItem2));
    }

    @Test
    void valueAndLimitTest () {
        int uBound = 10;
        int lBound = 1;
        Problem problem = new Problem(100, 1, uBound, lBound);

        for(Item item : problem.items) {
            if (item.weight < lBound || item.weight > uBound || item.value < lBound || item.value > uBound) {
                fail("Out of bounds");
            }
        }
    }

    @Test
    void solvingTest () {
        Item item1 = new Item(1, 5, 0);
        Item item2 = new Item(2, 6, 6);
        Item item3 = new Item(3, 4, 4);

        Problem problem = new Problem(List.of(item1, item2, item3));
        Result result = problem.Solve(10);

        assertEquals(2, result.amount);
        assertTrue(result.items.contains(item2) && result.items.contains(item3));
        assertEquals(10, result.totalValue);
        assertEquals(10, result.totalWeight);
    }
}