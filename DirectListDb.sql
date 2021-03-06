USE [DirectList]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [CreatedDate], [Discriminator], [FullName], [Image]) VALUES (N'bb4211e2-9cff-4dea-bc71-b3dd28bfaf33', N'tosu@gmail.com', N'TOSU@GMAIL.COM', N'tosu@gmail.com', N'TOSU@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMWPpcuiJe5Gy5wF5B2MiXQ3KA2gv8S0TpZ1BPfZO4LrW+i7Ogn9d5iYBAe2oGn/qg==', N'RWOR6TOSI7Z3SZANMFSOU2R2B2K2CZFA', N'd97e6bf1-912d-4d95-90d2-1439c3838985', NULL, 0, 0, NULL, 1, 0, CAST(N'2022-01-04T20:40:46.9189304' AS DateTime2), N'UserAdmin', N'Tosu Zenglanski', N'cb7752a2-5dac-419d-a0f8-a79355e2dc74-202201042040SS-thumb-4.jpg')
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CretedDate]) VALUES (1, N'3e14a281-8291-4576-a7de-d75946cf7e15-20220103173132-dp-1.jpg', N'Take a Look at Hotels for All Budgets', N'Sed sed tristique nibh iam porta volutpat finibus. Donec in aliquet urneget mattis lorem. Pellentesque pellentesque', CAST(N'2000-12-21T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CretedDate]) VALUES (2, N'76a8abdc-a3f8-41b1-9d65-131b30465c31-20220103184210-dp-4.jpg', N'At vero eos et accusamus et iusto odio ', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud ', CAST(N'2000-01-20T17:32:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CretedDate]) VALUES (3, N'8b0ee976-5627-4940-a1bb-30e8b1a7a52c-20220103183502-dp-5.jpg', N'Take a Look at Hotels for All Budgets', N'Sed sed tristique nibh iam porta volutpat finibus. Donec in aliquet urneget mattis lorem. Pellentesque pellentesque', CAST(N'2021-01-11T18:34:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CretedDate], [BlogId]) VALUES (2, N'Hilda Oatman', N'hilda@gmail.com', N'fsaegwsegsgsdgRgzg', N'Proin rhoncus nulla dictum, volutpat sem sed, aliquam nisi. Sed lorem turpis, viverra eu lacinia id, pellentesque et mi. Quisque vitae tortor dui. Nullam ac eros tempus erat vulputate ultrices ac sed dui. Quisque malesuada lacus non est fringilla, vitae finibus magna rutrum. Sako', CAST(N'2021-11-19T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CretedDate], [BlogId]) VALUES (4, N'Hilda Oatman', N'hilda@gmail.com', N'asfffg', N'Sed porta ante tortor, a pulvinar mi facilisis nec. Proin finibus dolor ac convallis congue', CAST(N'2022-01-03T19:16:02.7499166' AS DateTime2), 3)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Name]) VALUES (5, N'SWIMMING POOL')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (6, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (7, N'FREE PARKING')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (8, N'SWIMMINGPOOL OUTDOOR')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (9, N'FAMILY ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (10, N'NON SMOKING ROOMS')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [Adress], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [Location], [LocationText]) VALUES (4, N'Dingloy Place', N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!

Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2021-12-11T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-19T00:00:00.0000000' AS DateTime2), N'Location', N'zsgggggggggggg')
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToFetaures] ON 

INSERT [dbo].[RestaurantToFetaures] ([Id], [RestaurantId], [FetaureId]) VALUES (1, 4, 7)
SET IDENTITY_INSERT [dbo].[RestaurantToFetaures] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (1, N'Classic Burger', N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (2, N'Cheddar Burger', N'Cheddar Burger')
INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (3, N'Veggie Burger', N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (4, N'Chicken Burger', N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToMenus] ON 

INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [MenuId], [RestaurantId]) VALUES (1, CAST(3.00 AS Decimal(18, 2)), 1, 4)
SET IDENTITY_INSERT [dbo].[RestaurantToMenus] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantImages] ON 

INSERT [dbo].[RestaurantImages] ([Id], [Name], [RestaurantId]) VALUES (1, N'most-img-1.jpg', 4)
SET IDENTITY_INSERT [dbo].[RestaurantImages] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantReviews] ON 

INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (1, N'Tosu', N'jfghjlk;jhgjfcvjbjnlkjjm', CAST(N'2022-01-05T01:12:18.4116344' AS DateTime2), 4)
SET IDENTITY_INSERT [dbo].[RestaurantReviews] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'DINNER')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'HOTEL')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'SEA FOOD')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToTags] ON 

INSERT [dbo].[RestaurantToTags] ([Id], [TagId], [RestaurantId]) VALUES (1, 1, 4)
SET IDENTITY_INSERT [dbo].[RestaurantToTags] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Image], [Title], [SubTitle]) VALUES (4, N'cee74229-fe0d-4e2a-aa1a-bbd4b20f81bc-20220104003113-about-image.jpg', N'Our Goal', N'<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel consectetur, ipsa autem vitae quos ea laborum expedita</p>')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (1, N'title-bar.jpg', N'Blogs', N'Explore New Places', N'Blogs')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (2, N'title-bar.jpg', N'Blog Detail', N'Explore your search places', N'Detail')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (3, N'title-bar.jpg', N'About', N'Explore your search places', N'About')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (4, N'title-bar.jpg', N'Contact Us', N'Explore your search places', N'Contact')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (5, N'title-bar.jpg', N'Restaurant', N'Explore your search places', N'Restaurant')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (6, N'title-bar.jpg', N'Restaurant Detail', N'Explore your search places', N'RestaurantDetail')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CretedDate]) VALUES (6, N'Zahid', N'Akbarov', N'zahid.ekberov87@gmail.com', N'Reklam meqsedli Email', N'Agilli ol', CAST(N'2022-01-04T19:30:15.4161328' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomUsers] ON 

INSERT [dbo].[CustomUsers] ([Id], [Name], [Title], [Image]) VALUES (2, N'Ethan Moore', N'Nullam ultricies, velit ut varius molestie, ante metus condimentum nisi, dignissim facilisis turpis ex in libero. Sed porta ante tortor, a pulvinar mi facilisis nec. Proin finibus dolor ac convallis congue.', N'6c1734e0-4762-4f9c-ab72-19fb78b4f3b5-20220103190429-thumb-4.jpg')
SET IDENTITY_INSERT [dbo].[CustomUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [ContactAdress], [ContactEmail], [ContactPhone], [Adress], [Email], [Phone], [About], [DreamTitle], [DreamSubTitle]) VALUES (1, N'59741b2d-7bac-43ba-9ee9-5eb39ea3e67f-20220104004039-logo-dark.png', N'423B, Roadd Wordwide Country, USA', N'htinfotech78@gmail.com', N'+01-1234-567-8901', N'12345 Little Lonsdale St, Melbourne', N'(123) 123-456', N'office@example.com', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem sapiente, fugiat commodi reprehenderit expedita nam nemo</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!sa</p>', N'Plan The Vacation of Your Dreams', N'Explore some of the best tips from around the world from our partners and friends. Discover some of the most popular listings in Sydney.')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (1, N'fab fa-twitter', N'Twitter', N'twitter.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (2, N'fab fa-facebook-square', N'Facebook', N'facebook.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (4, N'fab fa-dribbble', N'Dribbble', N'dribbble.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (5, N'fab fa-github-square', N'Github', N'github.com')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
