#include <iostream>

#define MAIN int main(void) {
#define ENDMAIN return 0;}
#define DO ){
#define VAR auto 
#define NUM(_x) (int)(_x);
#define FLO32(_x) (float)(_x);
#define FLO64(_x) (double)(_x);
#define CHR(_x) (char)(_x);
#define BOOL(_x) (bool)(_x);
#define OUTPUT(_x) std::cout << _x << std::endl;
#define NEWLINE std::cout << std::endl;
#define TRUE true
#define FALSE false
#define IF if(
#define THEN ){
#define ELSE }else{
#define ENDIF }
#define WHILE while(
#define DOWHILE ){
#define ENDWHILE }
#define FOR for(auto for_index = 
#define TO ; for_index < 
#define DOFOR ; for_index++) {
#define ENDFOR }
#define ADD(_x, _y) _x += _y;
#define SUB(_x, _y) _x -= _y;
#define DIV(_x, _y) _x /= _y;
#define MUL(_x, _y) _x *= _y;

#if 0
// EXAMPLE AQA CODE
MAIN
    IF TRUE THEN
        FOR 0 TO 10 DOFOR
            OUTPUT("Hello, World! (1)")
        ENDFOR
        NEWLINE
        VAR dd = NUM(0)
        WHILE dd < 10 DOWHILE
            OUTPUT("Hello, World! (2)")
            ADD(dd, 1)
        ENDWHILE
    ELSE
        OUTPUT("Bye... World?")
    ENDIF
ENDMAIN
#endif

