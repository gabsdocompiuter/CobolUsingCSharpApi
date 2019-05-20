       identification division.
       PROGRAM-ID.    calculator.
       AUTHOR.        Gabriel Monteiro.
       DATE-COMPILED.
       ENVIRONMENT    DIVISION.
       CONFIGURATION  SECTION.
       special-names.
           call-convention 74 is winapi.

       input-output section.
       file-control.
       data division.
       file section.

       working-storage section.
       01  DLL      PROCEDURE-POINTER VALUE NULL.

       77  var1   pic 9(03).
       77  var2   pic 9(03).
       
       77  var3   pic 9(4) comp-5.
       77  var4   pic 9(4) comp-5.

       linkage section.

       procedure division.

       main section.
           set DLL to entry "dll\Calc.dll".

           move  123   to var1 var2 var3

           call "TwoStringParams"  using var1 var2.
           call "TwoIntParams"     using var3 var4.

           STOP "Program execution ended".
           STOP RUN.

