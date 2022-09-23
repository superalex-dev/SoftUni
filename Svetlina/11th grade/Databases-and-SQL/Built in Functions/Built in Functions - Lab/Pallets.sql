SELECT [Id], [Name], [Quantity], [BoxCapacity], [PalletCapacity],
	CEILING(
		CAST([Quantity] AS float) / [BoxCapacity] / [PalletCapacity]) As NumberOfPallets FROM Products