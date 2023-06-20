Imports System

Module Program
    Sub Main()
        Dim q As Queue = New Queue()
        q.Enqueue("S") 'removed value 3 dari atas akan terhapus
        q.Enqueue("Y") 'removed value
        q.Enqueue("A") 'removed value
        Console.WriteLine("current queue: ")
        Dim c As Char

        For Each c In q
            Console.Write(c + "")
        Next c
        Console.WriteLine()

        Console.WriteLine("masukkan 4 value")
        q.Enqueue(Console.ReadLine()) 'menambahkan value di belakang menambahkan value setelah format asli yang di inputkan pertama.
        q.Enqueue(Console.ReadLine()) 'menambahkan value di belakang
        q.Enqueue(Console.ReadLine())
        q.Enqueue(Console.ReadLine())
        Console.WriteLine("current queue: ")

        For Each c In q
            Console.Write(c + "")
        Next c
        Console.WriteLine()
        Console.WriteLine("removing some values ")
        Dim ch As Char
        ch = q.Dequeue()
        Console.WriteLine("removed value: {0}", ch)
        ch = q.Dequeue()
        Console.WriteLine("removed value: {0}", ch)
        ch = q.Dequeue()
        Console.WriteLine("removed value: {0}", ch)
        Console.WriteLine("current queue: ")

        For Each c In q
            Console.Write(c + " ")
        Next c

        Console.ReadKey()
    End Sub
End Module
