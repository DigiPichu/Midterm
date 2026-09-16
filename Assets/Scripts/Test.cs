using UnityEngine;

public class Test : MonoBehaviour
{
    void Main()
    {
        int numberOfDisks = 4;
        towerOfHanoi(numberOfDisks, 'A', 'C', 'B');
    }
    void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
    {
        if (n == 1)
        {
            Debug.Log($"move disk 1 from {from_rod} -> {to_rod}");
            return;
        }
        towerOfHanoi(n-1, from_rod, to_rod, aux_rod);
        Debug.Log($"move disk {n} from {from_rod} -> {to_rod}");
        towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
    }
}
