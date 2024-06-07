package org.example;
public class Main {
    public static void main(String[] args) {
        Problem problem = new Problem(10,1,10,1);
        System.out.println(problem.toString());

        problem.Solve(10);
        System.out.println(problem.toString());
    }
}