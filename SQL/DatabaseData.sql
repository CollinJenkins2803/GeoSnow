USE GeoSnowDB_;
GO
-- Insert mock data into the RESORT table
INSERT INTO [dbo].[RESORT] ([Address], [Zipcode], [City], [State], [Country], [Name], [Phone], [ResortType], [email], [latitude], [longitude])
VALUES
('123 Snowy Lane', '12345', 'Snowtown', 'Snowstate', 'Snowland', 'Snowy Peaks Resort', '555-1234', 'Ski', 'info@snowypeaks.com', 40.123456, -120.123456),
('456 Icy Road', '67890', 'Icetown', 'Icetate', 'Iceland', 'Icy Slopes Resort', '555-5678', 'Snowboard', 'contact@icyslopes.com', 41.654321, -121.654321),
('789 Frosty Blvd', '13579', 'Frostville', 'Froststate', 'Frostland', 'Frosty Pines Resort', '555-9012', 'Ski and Snowboard', 'support@frostypines.com', 42.987654, -122.987654),
('101 Ice Street', '24680', 'Glacierville', 'Glacierstate', 'Glacierland', 'Glacier Peaks Resort', '555-3456', 'Ski', 'info@glacierpeaks.com', 43.876543, -123.876543),
('202 Snowflake Ave', '97531', 'Snowflake City', 'Snowflakestate', 'Snowflakeland', 'Snowflake Valley Resort', '555-7890', 'Snowboard', 'contact@snowflakevalley.com', 44.765432, -124.765432);

-- Insert mock data into the ROOM table
INSERT INTO [dbo].[ROOM] ([ResortID], [NumBeds], [RoomType], [numberNum], [floor])
VALUES
(16, 2, 'Double', 101, 1),
(17, 4, 'Suite', 102, 1),
(18, 2, 'Double', 201, 2),
(19, 1, 'Single', 202, 2),
(20, 3, 'Triple', 301, 3);

-- Insert mock data into the RoomAvailability table
INSERT INTO [dbo].[RoomAvailability] ([RoomID], [AvDate], [Price])
VALUES
(9, '2024-02-25', 150.00),
(10, '2024-02-26', 250.00),
(11, '2024-02-27', 200.00),
(12, '2024-02-28', 100.00),
(13, '2024-02-29', 180.00);

-- Insert mock data into the ResortRatings table
INSERT INTO ResortRatings ([ResortID], [rating], [userID], [comments])
VALUES
(16, 5, 'A1B2C3D4E5F6', 'Amazing experience!'),
(17, 4, 'F6E5D4C3B2A1', 'Great slopes, but the food could be better.'),
(18, 5, '1234567890AB', 'Perfect for families!'),
(19, 3, 'B1A2C3D4E5F6', 'Decent, but a bit crowded.'),
(20, 4, 'C3D4E5F6A1B2', 'Lovely scenery and great facilities.');

-- Insert mock data into the CART table
INSERT INTO CART ([userID], [guestID])
VALUES
('A1B2C3D4E5F6', 'G1H2I3J4K5L6'),
('F6E5D4C3B2A1', 'L6K5J4I3H2G1'),
('1234567890AB', 'M1N2O3P4Q5R6'),
('B1A2C3D4E5F6', 'R6Q5P4O3N2M1'),
('C3D4E5F6A1B2', 'S1T2U3V4W5X6');

-- Insert mock data into the CartLines table
DECLARE @CartID1 UNIQUEIDENTIFIER = (SELECT CartID FROM CART WHERE userID = 'A1B2C3D4E5F6');
DECLARE @CartID2 UNIQUEIDENTIFIER = (SELECT CartID FROM CART WHERE userID = 'F6E5D4C3B2A1');
DECLARE @CartID3 UNIQUEIDENTIFIER = (SELECT CartID FROM CART WHERE userID = '1234567890AB');
DECLARE @CartID4 UNIQUEIDENTIFIER = (SELECT CartID FROM CART WHERE userID = 'B1A2C3D4E5F6');
DECLARE @CartID5 UNIQUEIDENTIFIER = (SELECT CartID FROM CART WHERE userID = 'C3D4E5F6A1B2');

-- Insert mock data into the CartLines table
INSERT INTO CartLines ([CartID], [RoomAvailabilityID], [price], [adults], [children])
SELECT CartID, 11, 150.00, 2, 1 FROM CART WHERE userID = 'A1B2C3D4E5F6';

INSERT INTO CartLines ([CartID], [RoomAvailabilityID], [price], [adults], [children])
SELECT CartID, 12, 250.00, 2, 0 FROM CART WHERE userID = 'F6E5D4C3B2A1';

INSERT INTO CartLines ([CartID], [RoomAvailabilityID], [price], [adults], [children])
SELECT CartID, 13, 200.00, 3, 2 FROM CART WHERE userID = '1234567890AB';

INSERT INTO CartLines ([CartID], [RoomAvailabilityID], [price], [adults], [children])
SELECT CartID, 14, 100.00, 1, 0 FROM CART WHERE userID = 'B1A2C3D4E5F6';

INSERT INTO CartLines ([CartID], [RoomAvailabilityID], [price], [adults], [children])
SELECT CartID, 15, 180.00, 2, 2 FROM CART WHERE userID = 'C3D4E5F6A1B2';


-- Insert mock data into the RESERVATION table
INSERT INTO RESERVATION ([userID], [guestID], [notes], [subtotal], [tax], [fees], [total])
VALUES
('A1B2C3D4E5F6', 'G1H2I3J4K5L6', 'Early check-in requested', 450.00, 45.00, 20.00, 515.00),
('F6E5D4C3B2A1', 'L6K5J4I3H2G1', 'Late checkout requested', 750.00, 75.00, 30.00, 855.00),
('1234567890AB', 'M1N2O3P4Q5R6', 'Additional pillows requested', 600.00, 60.00, 25.00, 685.00),
('B1A2C3D4E5F6', 'R6Q5P4O3N2M1', 'Room with a view requested', 300.00, 30.00, 15.00, 345.00),
('C3D4E5F6A1B2', 'S1T2U3V4W5X6', 'Extra towels requested', 540.00, 54.00, 22.00, 616.00);

-- Insert mock data into the ReservationLines table
DECLARE @ReservationID1 UNIQUEIDENTIFIER = (SELECT ReservationID FROM RESERVATION WHERE userID = 'A1B2C3D4E5F6');
DECLARE @ReservationID2 UNIQUEIDENTIFIER = (SELECT ReservationID FROM RESERVATION WHERE userID = 'F6E5D4C3B2A1');
DECLARE @ReservationID3 UNIQUEIDENTIFIER = (SELECT ReservationID FROM RESERVATION WHERE userID = '1234567890AB');
DECLARE @ReservationID4 UNIQUEIDENTIFIER = (SELECT ReservationID FROM RESERVATION WHERE userID = 'B1A2C3D4E5F6');
DECLARE @ReservationID5 UNIQUEIDENTIFIER = (SELECT ReservationID FROM RESERVATION WHERE userID = 'C3D4E5F6A1B2');

-- Insert mock data into the ReservationLines table
INSERT INTO ReservationLines ([ReservationID], [RoomID], [AvDate], [Price], [adults], [children], [notes], [ReservationStatus])
SELECT ReservationID, 9, '2024-02-25', 150.00, 2, 1, 'Early check-in', 'Confirmed' FROM RESERVATION WHERE userID = 'A1B2C3D4E5F6';

INSERT INTO ReservationLines ([ReservationID], [RoomID], [AvDate], [Price], [adults], [children], [notes], [ReservationStatus])
SELECT ReservationID, 10, '2024-02-26', 250.00, 2, 0, 'Late checkout', 'Confirmed' FROM RESERVATION WHERE userID = 'F6E5D4C3B2A1';

INSERT INTO ReservationLines ([ReservationID], [RoomID], [AvDate], [Price], [adults], [children], [notes], [ReservationStatus])
SELECT ReservationID, 11, '2024-02-27', 200.00, 3, 2, 'Additional pillows', 'Confirmed' FROM RESERVATION WHERE userID = '1234567890AB';

INSERT INTO ReservationLines ([ReservationID], [RoomID], [AvDate], [Price], [adults], [children], [notes], [ReservationStatus])
SELECT ReservationID, 12, '2024-02-28', 100.00, 1, 0, 'Room with a view', 'Confirmed' FROM RESERVATION WHERE userID = 'B1A2C3D4E5F6';

INSERT INTO ReservationLines ([ReservationID], [RoomID], [AvDate], [Price], [adults], [children], [notes], [ReservationStatus])
SELECT ReservationID, 13, '2024-02-29', 180.00, 2, 2, 'Extra towels', 'Confirmed' FROM RESERVATION WHERE userID = 'C3D4E5F6A1B2';


-- Insert mock data into the ForumPost table
INSERT INTO [dbo].[ForumPost] ([ResortID], [PosterName], [Title], [Content], [ParentPostID])
VALUES
(16, 'SnowLover', 'Best slopes for beginners?', 'Can anyone recommend the best slopes for beginners at Snowy Peaks Resort?', NULL),
(17, 'IcyAdventurer', 'Night skiing experiences', 'Has anyone tried night skiing at Icy Slopes Resort? How was it?', NULL),
(18, 'FrostyFamily', 'Family-friendly activities', 'Looking for family-friendly activities at Frosty Pines Resort. Any suggestions?', NULL),
(19, 'GlacierGuru', 'Off-piste skiing tips', 'Anyone have tips for off-piste skiing at Glacier Peaks Resort?', NULL),
(20, 'SnowflakeSeeker', 'Snowboarding gear rental', 'Where can I rent good snowboarding gear at Snowflake Valley Resort?', NULL);

