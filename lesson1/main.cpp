#include <iostream>
using namespace std;


typedef struct Node 
{
	int m_data;
	Node *m_next;
}Node;

class LinkList
{
public:
	LinkList():m_header(NULL)
	{
	}

	~LinkList()
	{
		Node *node = NULL;
		Node *temp_node = NULL;
		while (node = m_header)
		{
			temp_node = node;
			node = node->m_next;
			delete node;
		}
	}
public:
	void Insert(int data)
	{
		Node *node = CreateNode(data);
		if (NULL == m_header) m_header = node;
		else {
			Node *prevNode = m_header;
			Node *nextNode = m_header->m_next;
			while(nextNode){ 
				prevNode = nextNode;
				nextNode = nextNode->m_next;
			}
			prevNode->m_next  = node;
		}
	}

	void Remove(int data)
	{
	}
	void Display()
	{
		Node *node = m_header;
		while(node) { 
			cout<<"Node => "<<node->m_data<<endl;
			node = node->m_next;
		}
	}

	void Reverse()
	{
		Node *currNode = m_header;
		Node *prevNode = NULL;
		Node *nextNode = NULL;
		while (currNode)
		{
			nextNode = currNode->m_next;
			currNode->m_next = prevNode;
			prevNode = currNode;
			currNode = nextNode;
		}
		m_header = prevNode;
	}

protected:
	Node *CreateNode(int data)
	{
		Node *node = new Node();
		node->m_data = data;
		node->m_next = NULL;
		return node;
	}
private:
	Node *m_header;
};


int main()
{
	cout<<"writing link list after long time....";
	LinkList *list = new LinkList();
	for (int i=10;i>0;i--) list->Insert(i);
	list->Display();

	cout<<"\n\n";
	list->Reverse();
	list->Display();
	return 0;
}