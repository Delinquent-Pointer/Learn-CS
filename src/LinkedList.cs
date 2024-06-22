/**
 * Comment test
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LinkedList {

  public class Node {
    private Object _data { get; }
    private Node? _next { get; set; }

    public Node(Object data) {
      _data = data;
      _next = null;
    }

    public object data { get { return _data; } }
    public Node? next { get { return _next; } set { _next = value; } }
  }// End of Node Class

  private Node node;
  private Node? _head { get; set; }
  private int size;

  public LinkedList() {
    _head = null;
    size = 0;
  }

  public Node? head { get { return _head; } set { _head = value; } }

  public void print() {
    Node? cur = head;
    while (cur != null) {
      Console.WriteLine(cur.data);
      cur = cur.next;
    }
  }

  public void push(Object data) {
    Node newNode = new Node(data);
    if (head == null) {
      head = newNode;
    } else {
      Node? cur = head;
      while (cur.next != null) {
        cur = cur.next;
      }
      cur.next = newNode;
    }
    size++;
  }

} // End of LinkedList class
