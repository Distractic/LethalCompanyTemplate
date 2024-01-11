# How to get assembly files

Run the following command to get the assembly files:

> [!NOTE]  
> `PROGRA~1` is the short path for `C:\Program Files`
> 
> `PROGRA~2` is the short path for `C:\Program Files (x86)`
> 
> Adapt the disk name. For example, if you have Steam installed on `D:\`, then the path would start with `D:...`

```bash
copy "C:\PROGRA~2\Steam\steamapps\common\Lethal Company\Lethal Company_Data\Managed\*.dll" "."
```
