@echo off

rem c#
echo start compile for c# ----------------------------------------------
for /f "delims=" %%a in ('dir /b/a-d/oN *.fbs') do (
echo compiling %%a 
flatc -n -o ../CSharpDatas/ ./%%a
)
echo compile for c# complete ------------------------------------------

rem cpp
echo start compile for cpp ----------------------------------------------
for /f "delims=" %%a in ('dir /b/a-d/oN *.fbs') do @(
echo compiling %%a 
flatc -c -o ../CppDatas/ ./%%a
)
echo compile for cpp complete ------------------------------------------


echo  
pause