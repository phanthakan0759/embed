#include <16F886.h>
#device ADC=10 *=16

#include <math.h>

#FUSES NOWDT                    //No Watch Dog Timer
#FUSES PUT                      //Power Up Timer
#FUSES NOMCLR                   //Master Clear pin not enabled
#FUSES NOPROTECT                //Code not protected from reading
#FUSES NOCPD                    //No EE protection
#FUSES BROWNOUT                 //Brownout reset
#FUSES IESO                     //Internal External Switch Over mode enabled
#FUSES FCMEN                    //Fail-safe clock monitor enabled
#FUSES NOLVP                    //No low voltage prgming, B3(PIC16) or B5(PIC18) used for I/O
#FUSES NODEBUG                  //No Debug mode for ICD
#FUSES NOWRT                    //Program memory not write protected
#FUSES BORV40                   //Brownout reset at 4.0V
#FUSES RESERVED                 //Used to set the reserved FUSE bits
#FUSES INTRC_IO 

#use delay(clock=8M)

#use rs232(baud=9600,parity=N,xmit=PIN_C6,rcv=PIN_C7,bits=8)

int duty_car_1=0;
int duty_cout_car_1=0;
int pri_car_1=100;
int duty_car_2=0;
int duty_cout_car_2=0;
int pri_car_2=100;
int mode = 0;
char data1_1='0';
char data1_2='0';
char data1_3='0';
char data2_1='0';
char data2_2='0';
char data2_3='0';

int get_pwm_car1(float v)
{
   int y = 29539390 + (19.05195 - 29539390)/(1 + pow((v/106.2777),5.124435));
   return y;
}

int get_pwm_car2(float v)
{
   int y = 11721610 + (18.51114 - 11721610)/(1 + pow((v/107.9008),4.602841));
   return y;
}
 
#INT_TIMER1
void timer1_isr()
{
   set_timer1(63536);
   
   if(duty_cout_car_1==0)
   {
      output_high(PIN_A0);
   }
   if(duty_cout_car_1==duty_car_1)
   {
     
      output_low(PIN_A0);
   }
   if(duty_cout_car_1==pri_car_1)
   {
      duty_cout_car_1=0;
   }
   else
   {
      duty_cout_car_1++;
   }
   
   if(duty_cout_car_2==0)
   {
      output_high(PIN_B5);
   }
   if(duty_cout_car_2==duty_car_2)
   {
      output_low(PIN_B5);
   }
   if(duty_cout_car_2==pri_car_2)
   {
      duty_cout_car_2=0;
   }
   else
   {
      duty_cout_car_2++;
   }
}


void main()
{
   delay_ms(3000);
   //v1=[4.2 <-> 8.5
   setup_timer_1(T1_INTERNAL | T1_DIV_BY_1);
   set_timer1(63536);
   //enable_interrupts(INT_TIMER1);
   //enable_interrupts(GLOBAL);
   
   while(1)
   {
      if(mode==0)
      {
         data1_1 = getch();
         data1_2 = getch();
         data1_3 = getch();
         data2_1 = getch();
         data2_2 = getch();
         data2_3 = getch();
         
         mode=1;
         
         enable_interrupts(INT_TIMER1);
         enable_interrupts(GLOBAL);
      }
      else if(mode==1)
      {
         float v1 = (((int)data1_2-48)*1)+(((int)data1_3-48)*0.1);
         int s = 78;
         int d = (((int)data2_1-48)*100)+(((int)data2_2-48)*10)+(((int)data2_3-48));
         float v2 = (s-d)*(v1/d);
         duty_car_1 =  get_pwm_car1(v1);
         duty_car_2 =  get_pwm_car2(v2);
         //printf("%c %c %c %c %c %c\n",data1_1,data1_2,data1_3,data2_1,data2_2,data2_3);
         //printf("%f %d\n",v1,d);
         //printf("%d %d\n",duty_car_1,duty_car_2);
         if(input(PIN_B2)==0)
         {
            duty_car_1 = 0;
            duty_car_2 = 0;
            delay_ms(500);
            disable_interrupts(INT_TIMER1);
            disable_interrupts(GLOBAL);
            mode = 0;
         }
      }
   }
}

