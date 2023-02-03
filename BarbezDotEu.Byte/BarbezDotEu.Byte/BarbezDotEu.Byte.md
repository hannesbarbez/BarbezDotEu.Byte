<a name='assembly'></a>
# BarbezDotEu.Byte

## Contents

- [ByteHelper](#T-BarbezDotEu-Byte-ByteHelper 'BarbezDotEu.Byte.ByteHelper')
  - [ByteArrayToString(hash)](#M-BarbezDotEu-Byte-ByteHelper-ByteArrayToString-System-Byte[]- 'BarbezDotEu.Byte.ByteHelper.ByteArrayToString(System.Byte[])')
  - [StringToByteArray(hex)](#M-BarbezDotEu-Byte-ByteHelper-StringToByteArray-System-String- 'BarbezDotEu.Byte.ByteHelper.StringToByteArray(System.String)')
  - [ToByteArray()](#M-BarbezDotEu-Byte-ByteHelper-ToByteArray-System-String,System-Text-Encoding- 'BarbezDotEu.Byte.ByteHelper.ToByteArray(System.String,System.Text.Encoding)')
- [CSharpJavaByteConverter](#T-BarbezDotEu-Byte-CSharpJavaByteConverter 'BarbezDotEu.Byte.CSharpJavaByteConverter')
  - [ConvertCSharpByteArrayToJavaByteArray(cSharpByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpByteArrayToJavaByteArray-System-String- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertCSharpByteArrayToJavaByteArray(System.String)')
  - [ConvertCSharpStringArrayToJavaByteArray(cSharpByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpStringArrayToJavaByteArray-System-String[]- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertCSharpStringArrayToJavaByteArray(System.String[])')
  - [ConvertJavaByteArrayToCSharpByteArray(javaByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaByteArrayToCSharpByteArray-System-String- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertJavaByteArrayToCSharpByteArray(System.String)')
  - [ConvertJavaStringArrayToCSharpByteArray(javaByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaStringArrayToCSharpByteArray-System-String[]- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertJavaStringArrayToCSharpByteArray(System.String[])')
- [CryptoHelper](#T-BarbezDotEu-Byte-CryptoHelper 'BarbezDotEu.Byte.CryptoHelper')
  - [GetTsqlLikeHashBytes(toHash)](#M-BarbezDotEu-Byte-CryptoHelper-GetTsqlLikeHashBytes-System-String- 'BarbezDotEu.Byte.CryptoHelper.GetTsqlLikeHashBytes(System.String)')

<a name='T-BarbezDotEu-Byte-ByteHelper'></a>
## ByteHelper `type`

##### Namespace

BarbezDotEu.Byte

##### Summary

Helper class containing diverse static methods that can be used in any type of context.

<a name='M-BarbezDotEu-Byte-ByteHelper-ByteArrayToString-System-Byte[]-'></a>
### ByteArrayToString(hash) `method`

##### Summary

Generates a string representation of a byte array.

##### Returns

A string representation of the hash.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hash | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The hash to write as string. |

<a name='M-BarbezDotEu-Byte-ByteHelper-StringToByteArray-System-String-'></a>
### StringToByteArray(hex) `method`

##### Summary

Converts a "written" byte-array to an actual byte array.
e.g. input string: 69CC766AEFAE05F6BE92A529E27D6AC50A0DC73EFB3631534B5E41A9311D56AB.

##### Returns

The actual byte-array representation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The "written" byte-array to convert. |

##### Remarks

Based on https://stackoverflow.com/a/321404/8669939

<a name='M-BarbezDotEu-Byte-ByteHelper-ToByteArray-System-String,System-Text-Encoding-'></a>
### ToByteArray() `method`

##### Summary

Creates a byte array from the string, using the 
System.Text.Encoding.Default encoding unless another is specified.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Byte-CSharpJavaByteConverter'></a>
## CSharpJavaByteConverter `type`

##### Namespace

BarbezDotEu.Byte

##### Summary

Byte array converter allowing for a fast enough and accurate conversion between Java and C# byte arrays.

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpByteArrayToJavaByteArray-System-String-'></a>
### ConvertCSharpByteArrayToJavaByteArray(cSharpByteArray) `method`

##### Summary

Converts a C# byte array (represented as string) into a Java byte array (returned as its string representation).

##### Returns

The string representation of a Java byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpByteArray | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string representation of a C# byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpStringArrayToJavaByteArray-System-String[]-'></a>
### ConvertCSharpStringArrayToJavaByteArray(cSharpByteArray) `method`

##### Summary

Converts a C# byte array (represented as string) into a Java byte array (returned as its int representation because Java byte arrays can contain negative values).

##### Returns

The Java byte array as integer array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpByteArray | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The string[] representation of a C# byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaByteArrayToCSharpByteArray-System-String-'></a>
### ConvertJavaByteArrayToCSharpByteArray(javaByteArray) `method`

##### Summary

Converts a Java byte array (represented as string) into a C# byte array (returned as its string representation).

##### Returns

The string representation of a C# byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| javaByteArray | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string representation of a Java byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaStringArrayToCSharpByteArray-System-String[]-'></a>
### ConvertJavaStringArrayToCSharpByteArray(javaByteArray) `method`

##### Summary

Converts a Java byte array (represented as string) into a C# byte array (returned as its int representation for consistency).

##### Returns

The C# byte array as integer array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| javaByteArray | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The string[] representation of a Java byte array. |

<a name='T-BarbezDotEu-Byte-CryptoHelper'></a>
## CryptoHelper `type`

##### Namespace

BarbezDotEu.Byte

##### Summary

Helpers for cryptography.

<a name='M-BarbezDotEu-Byte-CryptoHelper-GetTsqlLikeHashBytes-System-String-'></a>
### GetTsqlLikeHashBytes(toHash) `method`

##### Summary

Equivalent of T-SQL's HASHBYTES('SHA2_256', <toHash>)".

##### Returns

The result of the hash.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| toHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to hash. |
