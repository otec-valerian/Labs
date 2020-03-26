#include <iostream>
#include "Trapeze.h.cpp"
#include <cmath>





Trapeze::Trapeze(int x[2], int y[2], int z[2], int f[2]){
  for (int i = 0; i < 2; i++)
  {
    this->a[i] = x[i];
    this->b[i] = y[i];
    this->c[i] = z[i];
    this->d[i] = f[i];    
  }
}


Trapeze::Trapeze(){
  for (int i = 0; i < 2; i++)
  {
    this->a[i] = rand() % (100) + 0;
    this->b[i] = rand() % (100) + 0;
    if (i == 0)
    {
      this->c[i] = rand() % (max(this->a[i],this->b[i])) + min(this->a[i], this->b[i]);
      this->d[i] = rand() % (max(this->a[i],this->b[i])) + min(this->a[i], this->b[i]);    
    }
    else
    {
      this->c[i] = rand() % (100) + 0;
      this->d[i] = ((d[0] - c[0])*(b[1]-a[1]))/(b[0]-a[0]) + b[1];
    }
          
  }
}


Trapeze::Trapeze(string type)
{
  if (type == "sameside")
  {
    for (int i = 0; i < 2; i++)
    {
      this->a[i] = rand() % (100) + 0;
      this->b[i] = rand() % (100) + 0;
      if (i == 0)
      {
        this->c[i] = rand() % (max(this->a[i],this->b[i])) + min(this->a[i], this->b[i]);
        this->d[i] = rand() % (max(this->c[i],this->b[i])) + min(this->c[i], this->b[i]);    
      }
      else
      {
        this->c[i] = rand() % (100) + 0;
        this->d[i] = (b[i] * c[i]) / a[i];
      }
          
    }   
  }
  else
  {
      Trapeze temp;
      for (int i=0;i<2;i++){
        this->a[i] = temp.a[i];
        this->b[i] = temp.b[i];
        this->c[i] = temp.c[i];
        this->d[i] = temp.d[i];
      }
  }
}



Trapeze Trapeze::operator-(int y)
{
  Trapeze temp;
  for (int i = 0; i < 2; i++)
  {
      temp.a[i] = a[i] - y;
      temp.b[i] = b[i] - y;
      temp.c[i] = c[i] - y;
      temp.d[i] = d[i] - y;    
  }
  
  return temp;
}


void Trapeze::PrintCoord()
{
  cout<<a[0]<<", "<<a[1]<<endl;
  cout<<b[0]<<", "<<b[1]<<endl;
  cout<<c[0]<<", "<<c[1]<<endl;
  cout<<d[0]<<", "<<d[1]<<endl;
}


double Trapeze::GetSquare()
{
  double h_s = sqrt((this->c[0] - this->c[1]) ^ 2 + (this->d[0] - this->d[1]) ^ 2);
  double l_s = sqrt((this->a[0] - this->a[1]) ^ 2 + (this->b[0] - this->b[1]) ^ 2);
  double m_l = (h_s + l_s) / 2;
  double h = abs(this->a[1] - this->c[1]);
  return round(m_l * h);
}


Trapeze Trapeze::operator *(Trapeze tr1)
{
  Trapeze temp;
  for (int i=0;i<2;i++){
    temp.a[i] = round(a[i] * tr1.a[i]);
    temp.b[i] = round(b[i] * tr1.b[i]);
    temp.c[i] = round(c[i] * tr1.c[i]);
    temp.d[i] = round(d[i] * tr1.d[i]);
  }
  return temp;
}


Trapeze::operator double()
{
    double res = this->GetSquare();

    return res;
}