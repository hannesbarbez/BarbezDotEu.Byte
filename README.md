# BarbezDotEu.Byte
Generic logic pertaining to byte and byte arrays.

## Contents

- [ByteHelper](#T-BarbezDotEu-Byte-ByteHelper 'BarbezDotEu.Byte.ByteHelper')
  - [ToByteArray()](#M-BarbezDotEu-Byte-ByteHelper-ToByteArray-System-String,System-Text-Encoding- 'BarbezDotEu.Byte.ByteHelper.ToByteArray(System.String,System.Text.Encoding)')
- [CSharpJavaByteConverter](#T-BarbezDotEu-Byte-CSharpJavaByteConverter 'BarbezDotEu.Byte.CSharpJavaByteConverter')
  - [ConvertCSharpByteArrayToJavaByteArray(cSharpByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpByteArrayToJavaByteArray-System-String- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertCSharpByteArrayToJavaByteArray(System.String)')
  - [ConvertCSharpStringArrayToJavaByteArray(cSharpByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpStringArrayToJavaByteArray-System-String[]- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertCSharpStringArrayToJavaByteArray(System.String[])')
  - [ConvertJavaByteArrayToCSharpByteArray(javaByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaByteArrayToCSharpByteArray-System-String- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertJavaByteArrayToCSharpByteArray(System.String)')
  - [ConvertJavaStringArrayToCSharpByteArray(javaByteArray)](#M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaStringArrayToCSharpByteArray-System-String[]- 'BarbezDotEu.Byte.CSharpJavaByteConverter.ConvertJavaStringArrayToCSharpByteArray(System.String[])')

<a name='T-BarbezDotEu-Byte-ByteHelper'></a>
## ByteHelper `type`
Helper class containing diverse static methods that can be used in any type of context.

<a name='M-BarbezDotEu-Byte-ByteHelper-ToByteArray-System-String,System-Text-Encoding-'></a>
### ToByteArray() `method`

Creates a byte array from the string, using the 
System.Text.Encoding.Default encoding unless another is specified.

<a name='T-BarbezDotEu-Byte-CSharpJavaByteConverter'></a>
## CSharpJavaByteConverter `type`
Byte array converter allowing for a fast enough and accurate conversion between Java and C# byte arrays.

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpByteArrayToJavaByteArray-System-String-'></a>
### ConvertCSharpByteArrayToJavaByteArray(cSharpByteArray) `method`

Converts a C# byte array (represented as string) into a Java byte array (returned as its string representation).

##### Returns

The string representation of a Java byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpByteArray | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string representation of a C# byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertCSharpStringArrayToJavaByteArray-System-String[]-'></a>
### ConvertCSharpStringArrayToJavaByteArray(cSharpByteArray) `method`

Converts a C# byte array (represented as string) into a Java byte array (returned as its int representation because Java byte arrays can contain negative values).

##### Returns

The Java byte array as integer array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpByteArray | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The string[] representation of a C# byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaByteArrayToCSharpByteArray-System-String-'></a>
### ConvertJavaByteArrayToCSharpByteArray(javaByteArray) `method`

Converts a Java byte array (represented as string) into a C# byte array (returned as its string representation).

##### Returns

The string representation of a C# byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| javaByteArray | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string representation of a Java byte array. |

<a name='M-BarbezDotEu-Byte-CSharpJavaByteConverter-ConvertJavaStringArrayToCSharpByteArray-System-String[]-'></a>
### ConvertJavaStringArrayToCSharpByteArray(javaByteArray) `method`

Converts a Java byte array (represented as string) into a C# byte array (returned as its int representation for consistency).

##### Returns

The C# byte array as integer array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| javaByteArray | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The string[] representation of a Java byte array. |

## Author
www.barbez.eu
