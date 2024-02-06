# SWIG_Example

This example demonstrate how to wrap the following item by Swig.

* Customization struct with string, int, double data format
* Functions in the static Class
* Functions in the class
* Functions return a customization struct
* Functions return a array of customization struct using std::vector in C++
* Functions have customization struct arguments.

## SWIG Commands
Swig use .idl file to generate the discription file(.cxx) of entry point in C++ dll. 
Therefore, using the following Swig command to generate .cxx file before compile the C++ dll.
```
swig.exe -c++ -csharp -namespace <your namespace> -outdir <output directory of cs files> -I <path of .idl file>
```


> ***Notice:***
>
> ***Swig compiler will not check correctness of content in the .idl file.***

## TO DO
* Create python wrapper