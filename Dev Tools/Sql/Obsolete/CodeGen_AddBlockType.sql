/* 
Creates the code for the RockMigrationHelper methods to insert a block type and its attributes for the provided BlocyTypeId.
*/

-- Set the Block Type ID here:
DECLARE @BlockTypeId INT = 198

DECLARE @crlf VARCHAR(2) = CHAR(13) + CHAR(10)
SELECT 
	'            // Attrib Value for BlockType: '+ ISNULL([Name], 'BlockType??')
	+ @crlf
	+ '            RockMigrationHelper.AddBlockType( '
	+ '"' + CONVERT(NVARCHAR(MAX), [Name]) + '", '
	+ '"' + CONVERT(NVARCHAR(MAX), [Description]) + '", '
	+ '"' + CONVERT(NVARCHAR(MAX), [Path])+ '", ' 
	+ '"' + CONVERT(NVARCHAR(MAX), [Category]) + '", '
	+ '"' + CONVERT(NVARCHAR(50), [Guid]) + '");'
	+ @crlf AS [CodeGen AddBlockType]
FROM [BlockType]
WHERE [Id] = @BlockTypeId

SELECT 
	'            // Attrib Value for BlockType: '+ ISNULL(bt.[Name], 'BlockType??')
	+ @crlf
	+ '            RockMigrationHelper.AddBlockTypeAttribute( '
	+ '"' + CONVERT(NVARCHAR(50), bt.[Guid]) + '", '
	+ ' Rock.SystemGuid.FieldType.'+ CONVERT(NVARCHAR(MAX), REPLACE(REPLACE(UPPER(ft.[Name]),' ', '_'), '-','_'))+ ', '
	+ '"' + CONVERT(NVARCHAR(MAX), a.[Name])+ '", '
	+ '"' + CONVERT(NVARCHAR(MAX), a.[Key])+ '", '
	+ '"", ' 
	+ '@"' + CONVERT(NVARCHAr(MAX), REPLACE(a.[Description],'"','""')) + '", '
	+ CONVERT(NVARCHAR(MAX), a.[Order]) + ', ' 
	+ '@"' + CONVERT(NVARCHAR(MAX), REPLACE(a.[DefaultValue],'"','""'))+ '", '
	+ '"' + CONVERT(NVARCHAR(50), a.[Guid]) + '", '
	+ CONVERT(NVARCHAR(MAX), IIF(a.[IsRequired] = 1, 'true', 'false')) + ');'
	+ @crlf AS [CodeGen AddBlockTypeAttribute]
FROM [Attribute] [a]
JOIN [FieldType] [ft] ON [ft].[Id] = [a].[FieldTypeId]
LEFT JOIN [BlockType] bt ON [bt].[Id] = @BlockTypeId
WHERE EntityTypeQualifierValue = CONVERT(NVARCHAR(MAX), @BlockTypeId) AND EntityTypeQualifierColumn = N'BlockTypeId'
