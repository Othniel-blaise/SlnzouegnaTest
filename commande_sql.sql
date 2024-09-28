CREATE PROCEDURE SPX_ZouegnaProduit_Insert
(
    @ZmProdID VARCHAR(255),
    @ZmDesignation VARCHAR(255),
    @ZmQteStock VARCHAR(255),
    @ZmDateIvent VARCHAR(255),
    @ZmImage VARCHAR(255)
)
AS
BEGIN
    INSERT INTO ZouegnaProduit (ZmProdID, ZmDesignation, ZmQteStock, ZmDateIvent, ZmImage)
    VALUES (@ZmProdID, @ZmDesignation, @ZmQteStock, @ZmDateIvent, @ZmImage)
END
GO
CREATE PROCEDURE SPX_ZouegnaProduit_Update
(
    @ZmProdID VARCHAR(255),
    @ZmDesignation VARCHAR(255),
    @ZmQteStock VARCHAR(255),
    @ZmDateIvent VARCHAR(255),
    @ZmImage VARCHAR(255)
)
AS
BEGIN
    UPDATE ZouegnaProduit
    SET ZmDesignation = @ZmDesignation,
        ZmQteStock = @ZmQteStock,
        ZmDateIvent = @ZmDateIvent,
        ZmImage = @ZmImage
    WHERE ZmProdID = @ZmProdID
END
GO
CREATE PROCEDURE SPX_ZouegnaProduit_SelectAll(@ZmDesignation varchar(255))
AS
BEGIN
    SELECT ZouegnaProduit. * FROM ZouegnaProduit
    where(ZmDesignation like @ZmDesignation +'%' )
END
GO
CREATE PROCEDURE SPX_ZouegnaProduit_Get
(
    @ZmProdID VARCHAR(255)
)
AS
BEGIN
    SELECT ZouegnaProduit. * FROM ZouegnaProduit
    WHERE ZmProdID = @ZmProdID
END
GO
CREATE PROCEDURE SPX_ZouegnaProduit_Delete
(
    @ZmProdID VARCHAR(255)
)
AS
BEGIN
    DELETE FROM ZouegnaProduit
    WHERE ZmProdID = @ZmProdID
END
GO



