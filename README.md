# gdal_csharp
gdal csharp libary

1. 以SWIG生成的C#源代码为基础
2. GDAL库C语言接口，参数是字符串，字符串是UTF8 
3. C#中字符串为Unicode编码
4. 修改的位置则为涉及字符串参数的函数接口
5. 使用Utf8BytesToString和StringToUtf8Bytes做参数转换
