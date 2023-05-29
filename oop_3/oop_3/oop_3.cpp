#include <stdio.h>
#include <stdlib.h>
#include <time.h>

class Main_Object {
private:

public:
	Main_Object()
	{
		printf("Main_Object()\n");
	}
	virtual ~Main_Object()
	{
		printf("~Main_Object\n");
	}
	virtual void someMethod()
	{
		printf("someMethod_Main_Obj");
	}
};
class Container {
private:
	Main_Object** _container;//Указатель на массив указателей 
	int size = 0;//размер массива
	int capacity = 0;//Запол-сть 
	int numOut;
public:
	Container() {
		printf("Container()\n");
		printf("Input size mass.->");
		scanf_s("%d", &size);
		_container = new Main_Object * [size];//Создание динамического массива указателей
		for (int c = 0; c < size; c++)
		{
			_container[c] = nullptr;
		}
		printf("%d\n", size);
	}
	~Container() {
		printf("~Container()\n\n");

		for (int i = 0; i < getCount(); i++)
		{
			if (getObject(i) != nullptr)
			{
				numOut += 1;
			}
			delete _container[i];
		}
		delete[]_container;
		printf("Delete obj (%d/%d)", numOut, size);
		numOut = 0;
	}
	void delObj(int i)
	{

		if (size != 0 && capacity != 0)
		{
			if (getObject(i) != nullptr)
			{
				delete _container[i];
				_container[i] = nullptr;
				for (int p = i; p < capacity - 1; p++)
				{
					_container[p] = _container[p + 1];
				}
				_container[capacity - 1] = nullptr;
				capacity--;
			}
		}
		for (int i = 0; i < getCount(); i++)
		{
			if (getObject(i) != nullptr)
			{
				numOut += 1;
			}
		}
		printf("cap.mass ->(%d/%d)\n", numOut, size);
		numOut = 0;
	}
	void PushBack(Main_Object* obj) //Добавление в конец массива
	{
		if (capacity == size)
		{
			ExpMass();
		}
		_container[capacity] = obj;
		capacity++;
	}
	void SetObject(int i, Main_Object* obj)//Заполняем массив
	{
		if (size != 0)
		{
			if (getObject(i) == nullptr)//Проверка на затерание данных, если так то capacity не увеличиваем.
			{
				_container[i] = obj;
				capacity++;
			}
			else
			{
				_container[i] = obj;
			}
		}
	}

	int getCount()//Получение размера массива
	{
		return this->size;
	}
	void ExpMass()//Увеличение массива
	{
		int old_size = size;
		if (size == 0)
		{
			size += 1;
		}
		size = 2 * (size);
		Main_Object** tmp = new Main_Object * [size];
		for (int c = 0; c < size; c++)
		{
			tmp[c] = nullptr;
		}
		if (old_size != 0)
		{
			for (int i = 0; i < old_size; i++)
				tmp[i] = _container[i];
		}
		delete[] _container;
		_container = tmp;
	}
	Main_Object* getObject(int i)
	{
		if (size != 0)
		{
			return _container[i];
		}
	}
	void PushFront(Main_Object* obj)//Добавление в начало массива  
	{
		if (capacity == size)
		{
			ExpMass();
		}
		for (int i = capacity - 1; i >= 0; i--)
		{
			_container[i + 1] = _container[i];
		}

		_container[0] = obj;
		capacity++;
	}
	void PushMiddle(Main_Object* obj)//Добавление в центр
	{
		int tmp;
		if (capacity == size)
		{
			ExpMass();
		}
		tmp = capacity / 2;
		for (int i = capacity - 1; i >= tmp; i--)
		{
			_container[i + 1] = _container[i];
		}
		_container[tmp] = obj;
		capacity++;
	}
	int getCap()
	{
		return capacity;
	}
};
class ObjCh1 : public Main_Object {
private:

public:
	ObjCh1()
	{
		printf("ObjCh1()\n");

	}
	~ObjCh1() override
	{
		printf("~ObjCh1\n");
	}
	void someMethod() override {
		printf("someMethod_ObjCh1\n");
	}
};
class ObjCh2 : public Main_Object {
private:

public:
	ObjCh2()
	{
		printf("ObjCh2()\n");
	}
	~ObjCh2() override
	{
		printf("~ObjCh2()\n");
	}
	void someMethod() override {
		printf("someMethod_ObjCh2 \n");
	}
};

int main()
{
	{
		// создаем контейнер
		Container storadge;
		// добавляем в него объекты
		for (int i = 0; i < storadge.getCount(); i++) {
			switch (rand() % 2)
			{
			case 0:
				storadge.SetObject(i, new ObjCh2()); break;
			case 1:
				storadge.SetObject(i, new ObjCh1()); break;
			default:
				break;
			}
		}
		//обращаемся поочередно ко всем
		for (int i = 0; i < storadge.getCount(); i++)
			storadge.getObject(i)->someMethod();
		storadge.PushFront(new ObjCh1);//добавляем вперед
		storadge.PushMiddle(new ObjCh2);//Добавляем в центр
		storadge.delObj(0);
	}
	{
		Container storadge;
		clock_t start = clock();
		for (int i = 0; i < 1000; i++)
		{
			int tmp = rand() % (storadge.getCap() + 1);
			if (tmp == storadge.getCap() && tmp > 0)
			{
				tmp--;
			}
			int ran = rand() % 4;
			if (ran == 0)
			{
				storadge.SetObject(tmp, new ObjCh1());
			}
			else if (ran == 1 && storadge.getCap() != 0)
			{
				storadge.delObj(tmp);
			}
			else if (ran == 2 && storadge.getCap() != 0)
			{
				storadge.getObject(tmp)->someMethod();
			}
			if (ran == 3)
			{
				storadge.SetObject(tmp, new ObjCh2());
			}
			else
			{
				storadge.PushBack(new ObjCh2);
			}
		}
		clock_t end = clock();
		double seconds = (double)(end - start) / CLOCKS_PER_SEC;
		printf("Time : %f\n", seconds);
	}
	system("pause");
	return 0;
}